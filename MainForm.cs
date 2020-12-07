using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var result = Data.FetchSerial(comport: 5, baudrate: 9600, parityCode: "N", node: 247, func: 3, address: 0, datacount: 60, 
                             sendTimeout: 5000, receiveTimeout: 5000,
                             regcount: out int regcount, fetchvals: out ushort[] fetchvals, errorcode: out int errorcode);

        }
    }
}
