using System;
using System.Windows.Forms;

namespace TuningKOZ
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            timerFetch.Enabled = true;
        }

        private void timerFetch_Tick(object sender, EventArgs e)
        {
            var error = Data.FetchSerial(comport: 5, baudrate: 9600, parityCode: "N", node: 247, func: 3, address: 0, datacount: 61, 
                             sendTimeout: 5000, receiveTimeout: 5000,
                             regcount: out int regcount, fetchvals: out ushort[] fetchvals, errorcode: out int errorcode);
            if (error) return;
            riserTuningLink.UpdateData(fetchvals, false);
            riserTuningPlc.UpdateData(fetchvals, false);
            riserTuningAdc.UpdateData(fetchvals, false);
            riserTuningAlarmLevel.UpdateData(fetchvals, false);
            riserTuningAnalogLevel.UpdateData(fetchvals, false);
            riserStatus.UpdateData(fetchvals, false);
        }
    }
}
