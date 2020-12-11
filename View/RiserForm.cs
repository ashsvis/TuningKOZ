using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuningKOZ.Model;

namespace TuningKOZ.View
{
    public partial class RiserForm : Form
    {
        public RiserForm(WriteData riserTuning_OnWrite)
        {
            InitializeComponent();
            //riserControl.OnWrite += riserTuning_OnWrite;
        }

        public void UpdateData(ushort[] fetchVals, bool remoted)
        {
            riserControl.UpdateData(fetchVals, remoted);
        }

        private void RiserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
