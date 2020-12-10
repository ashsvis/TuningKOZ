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


        public static void FetchSerial(SerialPort sp, int node, int func, int address, int datacount,
            out int regcount, out ushort[] fetchvals, out int errorcode)
        {
            regcount = 0;
            fetchvals = new ushort[regcount];
            var sendBytes = EncodeData((byte)node, (byte)func,
                                       (byte)(address >> 8), (byte)(address & 0xff),
                                       (byte)(datacount >> 8), (byte)(datacount & 0xff), 0, 0);
            sp.ReceivedBytesThreshold = (sendBytes[4] * 256 + sendBytes[5]) * 2 + 5;
            var buff = new List<byte>(sendBytes);
            var crc = BitConverter.GetBytes(Crc(buff.ToArray(), buff.Count - 2));
            sendBytes[sendBytes.Length - 2] = crc[0];
            sendBytes[sendBytes.Length - 1] = crc[1];
            errorcode = 0;
            // Создаём последовательный порт для отправки запроса данных контроллеру
            buff.Clear();
            if (!sp.IsOpen) 
                sp.Open();
            if (sp.IsOpen)
            {
                sp.DiscardInBuffer();
                sp.DiscardOutBuffer();
                sp.Write(sendBytes, 0, sendBytes.Length);
            }
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

        public static void SendToErrorsLog(string content, string sdt = null)
        {
            Console.WriteLine(content);
            //if (_errcontent.Equals(content)) return;
            //_errcontent = content;
            //var dt = DateTime.Now;
            //if (sdt != null) DateTime.TryParse(sdt, out dt);
            //var filename = "errors.log";
            //var list = new[]
            //    {
            //        dt.ToString("yyyy-MM-dd HH:mm:ss.fff"),
            //        content
            //    };
            //ThreadPool.QueueUserWorkItem(arg =>
            //{
            //    var count = 10;
            //    while (count > 0)
            //    {
            //        try
            //        {
            //            lock (Loglocker)
            //            {
            //                using (var stream = new FileStream(filename, FileMode.Append))
            //                {
            //                    using (var writer = new StreamWriter(stream))
            //                    {
            //                        writer.WriteLine(string.Join("\t", list));
            //                        writer.Flush();
            //                    }
            //                }
            //            }
            //            break;
            //        }
            //        catch
            //        {
            //            Thread.Sleep(50);
            //            count--;
            //        }
            //    }
            //});
        }

    }
}
