using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;

namespace TuningKOZ.View
{
    public partial class ModbusSerialPort : SerialPort
    {
        public ModbusSerialPort()
        {
            InitializeComponent();
            InitializeEvents();
        }

        public ModbusSerialPort(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            DataReceived += ModbusSerialPort_DataReceived;
            ErrorReceived += ModbusSerialPort_ErrorReceived;
        }

        public int Node { get; set; }
        public int Func { get; set; }
        public int Address { get; set; }
        public int DataCount { get; set; }
        public int RegCount { get; private set; }
        public ushort[] FetchVals { get; private set; }
        public int ErrorCode { get; private set; }

        public void FetchModbusData()
        {
            RegCount = 0;
            FetchVals = new ushort[RegCount];
            var sendBytes = EncodeData((byte)Node, (byte)Func,
                                       (byte)(Address >> 8), (byte)(Address & 0xff),
                                       (byte)(DataCount >> 8), (byte)(DataCount & 0xff), 0, 0);
            ReceivedBytesThreshold = (sendBytes[4] * 256 + sendBytes[5]) * 2 + 5;
            var buff = new List<byte>(sendBytes);
            var crc = BitConverter.GetBytes(Crc(buff.ToArray(), buff.Count - 2));
            sendBytes[sendBytes.Length - 2] = crc[0];
            sendBytes[sendBytes.Length - 1] = crc[1];
            ErrorCode = 0;
            buff.Clear();
            try
            {
                if (!IsOpen)
                    Open();
                if (IsOpen)
                {
                    DiscardInBuffer();
                    DiscardOutBuffer();
                    Write(sendBytes, 0, sendBytes.Length);
                }
            }
            catch (Exception)
            {
            }
        }

        public void WriteModbusData(int writeaddress, ushort[] writedata)
        {
            var buff = new List<byte>();
            try
            {
                if (!IsOpen)
                    Open();
                if (IsOpen)
                {
                    var list = new List<byte>();
                    list.AddRange(new[] { (byte)Node, (byte)16 });
                    list.AddRange(BitConverter.GetBytes(Swap((ushort)writeaddress)));
                    var datacount = writedata.Length;
                    list.AddRange(BitConverter.GetBytes(Swap((ushort)datacount)));
                    list.Add((byte)(datacount * 2));
                    foreach (var writeval in writedata)
                        list.AddRange(BitConverter.GetBytes(Swap(writeval)));
                    list.AddRange(new byte[] { 0, 0 }); // место для контрольной суммы
                    var sendBytes = list.ToArray();
                    var crc = BitConverter.GetBytes(Crc(list.ToArray(), list.Count - 2));
                    sendBytes[sendBytes.Length - 2] = crc[0];
                    sendBytes[sendBytes.Length - 1] = crc[1];

                    DiscardInBuffer();
                    DiscardOutBuffer();
                    Write(sendBytes, 0, sendBytes.Length);
                }
            }
            catch (Exception)
            {
            }
        }

        private static ushort Swap(ushort value)
        {
            var bytes = BitConverter.GetBytes(value);
            var buff = bytes[0];
            bytes[0] = bytes[1];
            bytes[1] = buff;
            return BitConverter.ToUInt16(bytes, 0);
        }

        private static byte[] EncodeData(params byte[] list)
        {
            var result = new byte[list.Length];
            for (var i = 0; i < list.Length; i++) result[i] = list[i];
            return result;
        }

        /// <summary>
        /// Контрольная сумма MODBUS RTU
        /// </summary>
        /// <param name="buff"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        private static ushort Crc(IList<byte> buff, int len)
        {   
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

        private void ModbusSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var buff = new List<byte>();
            while (BytesToRead > 0)
            {
                var onebyte = ReadByte();
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
                    RegCount = buff[2] / 2;
                    FetchVals = new ushort[RegCount];
                    var n = 3;
                    for (var i = 0; i < RegCount; i++)
                    {
                        var raw = new byte[2];
                        raw[0] = buff[n + 1];
                        raw[1] = buff[n];
                        FetchVals[i] = BitConverter.ToUInt16(raw, 0);
                        n += 2;
                    }
                    //
                    modbusDataReceived?.Invoke(this, new ModbusEventArgs(FetchVals));
                }
                else
                {
                    // ошибка контрольной суммы
                    modbusErrorReceived?.Invoke(this, new ModbusErrorArgs(-1));
                }
            }
        }

        private void ModbusSerialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private event ModbusEventHandler modbusDataReceived;

        /// <summary>
        /// Событие при получении данных MODBUS
        /// </summary>
        public event ModbusEventHandler ModbusDataReceived
        {
            add { modbusDataReceived += value; }
            remove { modbusDataReceived -= value; }
        }

        private event ModbusErrorHandler modbusErrorReceived;

        /// <summary>
        /// Событие при получении ошибки MODBUS
        /// </summary>
        public event ModbusErrorHandler ModbusErrorReceived
        {
            add { modbusErrorReceived += value; }
            remove { modbusErrorReceived -= value; }
        }

    }

    public class ModbusEventArgs : EventArgs
    {
        public ushort[] FetchVals { get; private set; }

        public ModbusEventArgs(ushort[] fetchVals)
        {
            FetchVals = fetchVals;
        }
    }

    public class ModbusErrorArgs : EventArgs
    {
        public int ErrorCode { get; private set; }

        public ModbusErrorArgs(int errorCode)
        {
            ErrorCode = errorCode;
        }
    }

    public delegate void ModbusEventHandler(object sender, ModbusEventArgs e);
    public delegate void ModbusErrorHandler(object sender, ModbusErrorArgs e);

}
