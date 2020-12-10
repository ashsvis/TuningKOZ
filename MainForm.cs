using System;
using System.Windows.Forms;

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Fetch();
        }
    }
}
