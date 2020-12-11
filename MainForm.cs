using System;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using TuningKOZ.Model;

namespace TuningKOZ
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            riserTuningLink.OnWrite += RiserTuning_OnWrite;
            riserTuningPlc.OnWrite += RiserTuning_OnWrite;
            riserTuningAdc.OnWrite += RiserTuning_OnWrite;
            riserTuningAlarmLevel.OnWrite += RiserTuning_OnWrite;
            riserTuningAnalogLevel.OnWrite += RiserTuning_OnWrite;
        }

        private void RiserTuning_OnWrite(int address, int regcount, ushort[] hregs, string[] changelogdata = null)
        {
            modbusSerialPort1.WriteModbusData(address, hregs);
        }

        private void Fetch()
        {
            modbusSerialPort1.FetchModbusData();
        }

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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fetch();
        }

        private void modbusSerialPort1_ModbusDataReceived(object sender, ModbusEventArgs e)
        {
            var method = new MethodInvoker(() =>
            {
                riserTuningLink.UpdateData(e.FetchVals, false);
                riserTuningPlc.UpdateData(e.FetchVals, false);
                riserTuningAdc.UpdateData(e.FetchVals, false);
                riserTuningAlarmLevel.UpdateData(e.FetchVals, false);
                riserTuningAnalogLevel.UpdateData(e.FetchVals, false);
                //riserStatus.UpdateData(e.FetchVals, false);
            });
            if (InvokeRequired)
                BeginInvoke(method);
            else
                method();
        }

        private void modbusSerialPort1_ModbusErrorReceived(object sender, ModbusErrorArgs e)
        {
            var method = new MethodInvoker(() =>
            {
                MessageBox.Show(this, e.Message, "Что-то пошло не так...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            });
            if (InvokeRequired)
                BeginInvoke(method);
            else
                method();
        }

        private void modbusSerialPort1_ModbusCommandOk(object sender, EventArgs e)
        {
            var method = new MethodInvoker(() =>
            {
                Fetch();
                MessageBox.Show(this, "Выполнено.", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
            if (InvokeRequired)
                BeginInvoke(method);
            else
                method();
        }

        private void cbPort_SelectionChangeCommitted(object sender, EventArgs e)
        {
            modbusSerialPort1.Close();
            Properties.Settings.Default.PortName = cbPort.Text;
            Properties.Settings.Default.Save();
            modbusSerialPort1.PortName = $"{cbPort.SelectedItem}";
            Fetch();
        }

        private void cbBaudRate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!int.TryParse(cbBaudRate.Text, out int baudrate)) return;
            Properties.Settings.Default.BaudRate = cbBaudRate.Text;
            Properties.Settings.Default.Save();
            modbusSerialPort1.BaudRate = baudrate;
            Fetch();
        }

        private void cbParity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!Enum.TryParse(cbParity.Text, out Parity parity)) return;
            Properties.Settings.Default.Parity = cbParity.Text;
            Properties.Settings.Default.Save();
            modbusSerialPort1.Parity = parity;
            Fetch();
        }

        private void cbSlaveID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!int.TryParse(cbSlaveID.Text, out int slaveID)) return;
            Properties.Settings.Default.SlaveID = slaveID;
            Properties.Settings.Default.Save();
            modbusSerialPort1.Node = slaveID;
            Fetch();
        }

    }
}
