using System;
using System.Collections.Generic;
using System.IO.Ports;
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
            Data.FetchSerial(serialPort1, node: 247, func: 3, address: 0, datacount: 61,
                regcount: out int regcount, fetchvals: out ushort[] fetchvals, errorcode: out int errorcode);
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            var method = new MethodInvoker(() =>
            {

                var sp = (SerialPort)sender;
                var buff = new List<byte>();
                while (sp.BytesToRead > 0)
                {
                    var onebyte = sp.ReadByte();
                    if (onebyte < 0) break; // буфер приёма пуст, ошибка
                    buff.Add((byte)onebyte);
                }
                if (buff.Count > 0)
                {
                    var crcCalc = Crc(buff.ToArray(), buff.Count - 2);
                    var crcBuff = BitConverter.ToUInt16(buff.ToArray(), buff.Count - 2);
                    if (crcCalc == crcBuff)
                    {
                        // данные получены правильно
                        var regcount = buff[2] / 2;
                        var fetchvals = new ushort[regcount];
                        var n = 3;
                        for (var i = 0; i < regcount; i++)
                        {
                            var raw = new byte[2];
                            raw[0] = buff[n + 1];
                            raw[1] = buff[n];
                            fetchvals[i] = BitConverter.ToUInt16(raw, 0);
                            n += 2;
                        }
                        //
                        riserTuningLink.UpdateData(fetchvals, false);
                        riserTuningPlc.UpdateData(fetchvals, false);
                        riserTuningAdc.UpdateData(fetchvals, false);
                        riserTuningAlarmLevel.UpdateData(fetchvals, false);
                        riserTuningAnalogLevel.UpdateData(fetchvals, false);
                        //riserStatus.UpdateData(fetchvals, false);
                    }
                    else
                    {
                        // ошибка контрольной суммы
                    }
                }
            });
            if (InvokeRequired)
                BeginInvoke(method);
            else
                method();
        }

        private static ushort Crc(IList<byte> buff, int len)
        {   // контрольная сумма MODBUS RTU
            ushort result = 0xFFFF;
            if (len <= buff.Count)
            {
                for (var i = 0; i < len; i++)
                {
                    result ^= buff[i];
                    for (var j = 0; j < 8; j++)
                    {
                        var flag = (result & 0x0001) > 0;
                        result >>= 1;
                        if (flag) result ^= 0xA001;
                    }
                }
            }
            return result;
        }

        private void serialPort1_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            //
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Fetch();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fetch();
        }
    }
}
