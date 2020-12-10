using System;
using System.Windows.Forms;

namespace TuningKOZ
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Fetch()
        {
            modbusSerialPort1.Fetch();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Fetch();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fetch();
        }

        private void modbusSerialPort1_ModbusDataReceived(object sender, View.ModbusEventArgs e)
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

        private void modbusSerialPort1_ModbusErrorReceived(object sender, View.ModbusErrorArgs e)
        {
            //
        }
    }
}
