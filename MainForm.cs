using System;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using TuningKOZ.Model;
using TuningKOZ.View;

namespace TuningKOZ
{
    public partial class MainForm : Form
    {
        private StatusForm statusForm;
        private WorkDiagramForm workDiagramForm;
        // признак нажатого автоматического опроса
        private bool wasChecked;            

        public MainForm()
        {
            InitializeComponent();
            riserTuningLink.OnWrite += RiserTuning_OnWrite;
            riserTuningPlc.OnWrite += RiserTuning_OnWrite;
            riserTuningAdc.OnWrite += RiserTuning_OnWrite;
            riserTuningAlarmLevel.OnWrite += RiserTuning_OnWrite;
            riserTuningAnalogLevel.OnWrite += RiserTuning_OnWrite;
            // временно удаляем будущую фичу
            tcTuningLink.TabPages.Remove(tpEthernetLink);
        }

        /// <summary>
        /// Команда для записи новых параметров
        /// </summary>
        /// <param name="address"></param>
        /// <param name="regcount"></param>
        /// <param name="hregs"></param>
        /// <param name="changelogdata"></param>
        private void RiserTuning_OnWrite(int address, int regcount, ushort[] hregs, string[] changelogdata = null)
        {
            wasChecked = cbFetching.Checked;
            cbFetching.Checked = false;
            modbusSerialPort1.WriteModbusData(address, hregs);
        }

        /// <summary>
        /// Опросить устройство (с параметрами по умолчанию)
        /// </summary>
        private void Fetch()
        {
            modbusSerialPort1.FetchModbusData();
        }

        /// <summary>
        /// Первоначальная настройка контролов настройки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            cbPort.Items.AddRange(SerialPort.GetPortNames());
            cbPort.Text = Properties.Settings.Default.PortName;
            modbusSerialPort1.PortName = $"{cbPort.SelectedItem}";
            var abaud = new object[] { 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600, 76800, 115200, 230400 };
            cbBaudRate.Items.AddRange(abaud);
            cbBaudRate.Text = Properties.Settings.Default.BaudRate;
            if (int.TryParse(cbBaudRate.Text, out int baudrate))
                modbusSerialPort1.BaudRate = baudrate;
            var aparity = Enum.GetNames(typeof(Parity)).Take(3).ToArray();
            cbParity.Items.AddRange(aparity);
            cbParity.Text = Properties.Settings.Default.Parity;
            if (Enum.TryParse(cbParity.Text, out Parity parity))
                modbusSerialPort1.Parity = parity;
            var anodes = Enumerable.Range(1, 247).Select(item => (object)item).ToArray();
            cbSlaveID.Items.AddRange(anodes);
            var slaveID = Properties.Settings.Default.SlaveID;
            cbSlaveID.Text = slaveID.ToString();
            modbusSerialPort1.Node = slaveID;
            Fetch();
        }

        /// <summary>
        /// Переключение вкладок свойств
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbFetching.Checked)
                Fetch();
        }

        /// <summary>
        /// Данные Modbus получены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modbusSerialPort1_ModbusDataReceived(object sender, ModbusEventArgs e)
        {
            UpdateTabs(e.FetchVals);
        }

        /// <summary>
        /// Принимаем и раздаём данные в основном потоке
        /// </summary>
        /// <param name="fetchVals"></param>
        private void UpdateTabs(ushort[] fetchVals)
        {
            var method = new MethodInvoker(() =>
            {
                // раздаем данные по вкладкам
                riserTuningLink.UpdateData(fetchVals, false);
                riserTuningPlc.UpdateData(fetchVals, false);
                riserTuningAdc.UpdateData(fetchVals, false);
                riserTuningAlarmLevel.UpdateData(fetchVals, false);
                riserTuningAnalogLevel.UpdateData(fetchVals, false);
                statusForm?.UpdateData(fetchVals, false);
                workDiagramForm?.UpdateData(fetchVals, false);
            });
            if (InvokeRequired)
                BeginInvoke(method);
            else
                method();
        }

        /// <summary>
        /// Ошибка приема данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modbusSerialPort1_ModbusErrorReceived(object sender, ModbusErrorArgs e)
        {
            var method = new MethodInvoker(() =>
            {
                MessageForm.Show(MousePosition, e.Message, true);
                if (wasChecked)
                    cbFetching.Checked = true;
            });
            if (InvokeRequired)
                BeginInvoke(method);
            else
                method();
        }

        /// <summary>
        /// Команда записи в устройство выполнена успешно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modbusSerialPort1_ModbusCommandOk(object sender, EventArgs e)
        {
            var method = new MethodInvoker(() =>
            {
                Fetch();
                MessageForm.Show(MousePosition, "Выполнено.");
                if (wasChecked)
                    cbFetching.Checked = true;
                else
                    timerPulseFetch.Enabled = true;
            });
            if (InvokeRequired)
                BeginInvoke(method);
            else
                method();
        }

        /// <summary>
        /// Выбор нового значения имени порта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbPort_SelectionChangeCommitted(object sender, EventArgs e)
        {
            modbusSerialPort1.Close();
            Properties.Settings.Default.PortName = cbPort.Text;
            Properties.Settings.Default.Save();
            modbusSerialPort1.PortName = $"{cbPort.SelectedItem}";
            Fetch();
        }

        /// <summary>
        /// Выбор нового значения скорости порта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBaudRate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!int.TryParse(cbBaudRate.Text, out int baudrate)) return;
            Properties.Settings.Default.BaudRate = cbBaudRate.Text;
            Properties.Settings.Default.Save();
            modbusSerialPort1.BaudRate = baudrate;
            Fetch();
        }

        /// <summary>
        /// Выбор нового значения паритета порта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbParity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!Enum.TryParse(cbParity.Text, out Parity parity)) return;
            Properties.Settings.Default.Parity = cbParity.Text;
            Properties.Settings.Default.Save();
            modbusSerialPort1.Parity = parity;
            Fetch();
        }

        /// <summary>
        /// Выбор нового значения ID устройства
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSlaveID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!int.TryParse(cbSlaveID.Text, out int slaveID)) return;
            Properties.Settings.Default.SlaveID = slaveID;
            Properties.Settings.Default.Save();
            modbusSerialPort1.Node = slaveID;
            Fetch();
        }

        /// <summary>
        /// Случится таймаут
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modbusSerialPort1_ModbusTimeout(object sender, EventArgs e)
        {
            UpdateTabs(new ushort[] { });
            if (wasChecked)
                cbFetching.Checked = true;
        }

        /// <summary>
        /// Вызов панели статуса стояка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStatus_Click(object sender, EventArgs e)
        {
            Fetch();
            if (statusForm == null)
                statusForm = new StatusForm();
            statusForm.Show();
            statusForm.UpdateData(modbusSerialPort1.FetchVals, false);
        }

        /// <summary>
        /// Вызов панели диаграммы работы стояка налива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWorkDiagram_Click(object sender, EventArgs e)
        {
            Fetch();
            if (workDiagramForm == null)
                workDiagramForm = new WorkDiagramForm(RiserTuning_OnWrite);
            workDiagramForm.Show();
            workDiagramForm.UpdateData(modbusSerialPort1.FetchVals, false);
        }

        /// <summary>
        /// Включение/выключение автоматического опроса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFetching_CheckedChanged(object sender, EventArgs e)
        {
            timerFetchig.Enabled = cbFetching.Checked;
        }

        /// <summary>
        /// По событию таймера делаем опрос
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFetchig_Tick(object sender, EventArgs e)
        {
            Fetch();
        }

        private void timerPulseFetch_Tick(object sender, EventArgs e)
        {
            timerPulseFetch.Enabled = false;

            if (!cbFetching.Checked)
                Fetch();
        }
    }
}
