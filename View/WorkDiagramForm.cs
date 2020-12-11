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
    public partial class WorkDiagramForm : Form
    {
        public WorkDiagramForm(WriteData riserTuning_OnWrite)
        {
            InitializeComponent();
            riserWorkDiagram.OnWrite += riserTuning_OnWrite;
        }

        private void WorkDiagramForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        public void UpdateData(ushort[] fetchVals, bool remoted)
        {
            riserWorkDiagram.UpdateData(fetchVals, remoted);
        }
    }
}
