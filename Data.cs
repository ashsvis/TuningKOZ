using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace TuningKOZ
{
    public static class Data
    {
        private static readonly object Loglocker = new object();

        public static bool FetchSerial(int comport, int baudrate, string parityCode,
                                    int node, int func, int address, int datacount,
                                    int sendTimeout, int receiveTimeout,
                                    out int regcount, out ushort[] fetchvals, out int errorcode)
        {
            regcount = 0;
            fetchvals = new ushort[regcount];
            bool fetchError = true;
            var sendBytes = EncodeData((byte)node, (byte)(func),
                                       (byte)(address >> 8), (byte)(address & 0xff),
                                       (byte)(datacount >> 8), (byte)(datacount & 0xff), 0, 0);
            var buff = new List<byte>(sendBytes);
            var crc = BitConverter.GetBytes(Crc(buff.ToArray(), buff.Count - 2));
            sendBytes[sendBytes.Length - 2] = crc[0];
            sendBytes[sendBytes.Length - 1] = crc[1];
            errorcode = 0;
            var portname = "COM" + comport;
            var parity = Parity.None;
            switch (parityCode)
            {
                case "N": parity = Parity.None; break;
                case "E": parity = Parity.Even; break;
                case "O": parity = Parity.Odd; break;
                case "M": parity = Parity.Mark; break;
                case "S": parity = Parity.Space; break;
            }
            // Создаём последовательный порт для отправки запроса данных контроллеру
            buff.Clear();
            using (var sp = new SerialPort(portname, baudrate, parity, 8, StopBits.One))
            {
                try
                {
                    sp.WriteTimeout = sendTimeout * 1000;
                    sp.ReadTimeout = receiveTimeout * 1000;
                    sp.Open();
                    if (sp.IsOpen)
                    {
                        sp.DiscardInBuffer();
                        sp.DiscardOutBuffer();
                        sp.Write(sendBytes, 0, sendBytes.Length);
                        var len = (sendBytes[4] * 256 + sendBytes[5]) * 2 + 5;
                        while (true)
                        {
                            try
                            {
                                var onebyte = sp.ReadByte();
                                if (onebyte < 0) break; // буфер приёма пуст, ошибка
                                buff.Add((byte)onebyte);
                                if (buff.Count == len)
                                {
                                    // конец приёма блока данных
                                    break;
                                }
                            }
                            catch (TimeoutException ex)
                            {
                                // устройство не ответило вовремя, ошибка
                                fetchError = true;
                                errorcode = -2;
                                SendToErrorsLog(string.Format("Ошибка порта для [COM{0}]: {1}", comport, ex.Message));
                                buff.Clear();
                                break;
                            }
                        }
                        if (buff.Count > 0)
                        {
                            var crcCalc = Crc(buff.ToArray(), buff.Count - 2);
                            var crcBuff = BitConverter.ToUInt16(buff.ToArray(), buff.Count - 2);
                            if (crcCalc == crcBuff)
                            {
                                // данные получены правильно
                                fetchError = false;
                                errorcode = 0;
                                regcount = buff[2] / 2;
                                fetchvals = new ushort[regcount];
                                var n = 3;
                                for (var i = 0; i < regcount; i++)
                                {
                                    var raw = new byte[2];
                                    raw[0] = buff[n + 1];
                                    raw[1] = buff[n];
                                    fetchvals[i] = BitConverter.ToUInt16(raw, 0);
                                    n += 2;
                                }
                            }
                            else
                            {
                                // ошибка контрольной суммы
                                fetchError = true;
                                errorcode = -3;
                                SendToErrorsLog(string.Format("Ошибка контрольной суммы для [COM{0}] от устройства {1}", comport, node));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    fetchError = true;
                    errorcode = -1;
                    var mess = string.Format("Ошибка конфигурирования канала для [COM{0}]: {1}", comport, ex.Message);
                    SendToErrorsLog(mess);
                }
            } // end of using            

            return fetchError;
        }

        private static byte[] EncodeData(params byte[] list)
        {
            var result = new byte[list.Length];
            for (var i = 0; i < list.Length; i++) result[i] = list[i];
            return result;
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

        private static string _errcontent = "";

        public static void SendToErrorsLog(string content, string sdt = null)
        {
            if (_errcontent.Equals(content)) return;
            _errcontent = content;
            var dt = DateTime.Now;
            if (sdt != null) DateTime.TryParse(sdt, out dt);
            var filename = "errors.log";
            var list = new[]
                {
                    dt.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                    content
                };
            ThreadPool.QueueUserWorkItem(arg =>
            {
                var count = 10;
                while (count > 0)
                {
                    try
                    {
                        lock (Loglocker)
                        {
                            using (var stream = new FileStream(filename, FileMode.Append))
                            {
                                using (var writer = new StreamWriter(stream))
                                {
                                    writer.WriteLine(string.Join("\t", list));
                                    writer.Flush();
                                }
                            }
                        }
                        break;
                    }
                    catch
                    {
                        Thread.Sleep(50);
                        count--;
                    }
                }
            });
        }

    }
}
