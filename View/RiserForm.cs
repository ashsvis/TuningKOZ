using System;
using System.Drawing;
using System.Windows.Forms;
using TuningKOZ.Model;

namespace TuningKOZ.View
{
    public partial class RiserForm : Form
    {
        private WaggonData waggon;
        private readonly ModbusSerialPort modbusSerialPort1;

        public RiserForm(ModbusSerialPort modbusSerialPort1, WriteData riserTuning_OnWrite)
        {
            InitializeComponent();
            waggon = new WaggonData();
            this.modbusSerialPort1 = modbusSerialPort1;
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

        private void riserControl_DoubleClick(object sender, EventArgs e)
        {
            var frm = new FormTaskDataEditor(waggon.Number, waggon.Ntype, waggon.FactHeight, waggon.Setpoint)
            {
                Text = string.Format("Задание налива [ Стояк {0} ]", 247),
                DeepLevel = 900,
                WorkLevel = 740
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                waggon = frm.GetData;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            modbusSerialPort1.WriteModbusData(0x06, new ushort[]
                                        {
                                            0x01, Convert.ToUInt16(waggon.FactHeight), Convert.ToUInt16(waggon.Setpoint)
                                        });
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            modbusSerialPort1.WriteModbusData(0x06, new ushort[]
                                        {
                                            0x02,
                                        });
        }

        private void RiserForm_Load(object sender, EventArgs e)
        {
            if (Location == Point.Empty)
                CenterToScreen();
        }
    }
}
