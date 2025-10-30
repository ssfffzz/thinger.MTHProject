using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace thinger.ModbusLib
{
    public class ModbusTCP
    {        
        private Socket socket = null;      
        private SimpleHybirdLockTCP lockTCP = new SimpleHybirdLockTCP();

        #region 通信相关的属性

        public int SendTimeOut { get; set; } = 2000;      
        public int ReceiveTimeOut { get; set; } = 2000;   
        public int SleepTime { get; set; } = 50;     
        public int MaxWaitTimes { get; set; } = 20;
        public byte SlaveId { get; set; } = 0x01;

        #endregion

        #region 建立Socket连接与断开连接

        /// <summary>
        /// 建立Socket连接
        /// </summary>
        /// <param name="ip">IP地址</param>
        /// <param name="port">端口号</param>
        public bool Connect(string ip, int port)
        {           
            this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.socket.SendTimeout = SendTimeOut;
            this.socket.ReceiveTimeout = ReceiveTimeOut;
            try
            {               
                if (IPAddress.TryParse(ip, out IPAddress ipAddress))
                {                  
                    this.socket.Connect(ipAddress, port);
                }
                else
                {                  
                    this.socket.Connect(ip, port);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("打开连接错误，请检查IP地址和端口号。具体错误：" + ex.Message);
            }
        }
        /// <summary>
        /// 断开连接
        /// </summary>
        public void DisConnect()
        {
            if (this.socket != null)
            {
                this.socket.Close();
            }
        }

        #endregion

        #region 【01H】读取输出线圈 

        /// <summary>
        /// 01H读取输出线圈
        /// </summary>
        /// <param name="start">起始线圈地址</param>
        /// <param name="count">线圈长度</param>
        /// <returns>返回数据</returns>
        public byte[] ReadOutputCoils(ushort start, ushort count)
        {
            List<byte> sendBytes = new List<byte>
            {               
                0x00, 0x00,
                0x00, 0x00,
                0x00, 0x06,
                SlaveId,
                0x01,
                (byte)(start / 256),  (byte)(start %256),
                (byte) (count/256), (byte) (count%256)
            };
            try
            {              
                byte[] receiveBytes = SendAndReceive(sendBytes.ToArray());             
                int byteLength = count % 8 == 0 ? count / 8 : count / 8 + 1;
                if (receiveBytes.Length == 9 + byteLength
                    && receiveBytes[6] == SlaveId
                    && receiveBytes[7] == 0x01
                    && receiveBytes[8] == byteLength)
                {
                    byte[] result = new byte[byteLength];
                    Array.Copy(receiveBytes, 9, result, 0, byteLength);
                    return result;
                }
                else
                {
                    throw new Exception("ReadOutputCoils方法返回数据异常！请断点调试返回的数据，以便发现问题");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ReadOutputCoils方法执行发生异常：" + ex.Message);
            }
        }
        #endregion

        #region 【02H】读取输入线圈 

        /// <summary>
        /// 02H读取输入线圈 
        /// </summary>
        /// <param name="start">起始线圈地址</param>
        /// <param name="count">线圈长度</param>
        /// <returns>返回数据</returns>
        public byte[] ReadInputCoils(ushort start, ushort count)
        {
            List<byte> sendBytes = new List<byte>
            {
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x06,
                SlaveId,
                0x02,
                (byte)(start / 256),  (byte)(start % 256),
                (byte) (count/256), (byte) (count%256)
            };
            try
            {
                byte[] receiveBytes = SendAndReceive(sendBytes.ToArray());
                int byteLength = count % 8 == 0 ? count / 8 : count / 8 + 1;
                if (receiveBytes.Length == 9 + byteLength
                    && receiveBytes[6] == SlaveId
                    && receiveBytes[7] == 0x02
                    && receiveBytes[8] == byteLength)
                {
                    byte[] result = new byte[byteLength];
                    Array.Copy(receiveBytes, 9, result, 0, byteLength);
                    return result;
                }
                else
                {
                    throw new Exception("ReadInputCoils方法返回数据异常！请断点调试返回的数据，以便发现问题");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ReadInputCoils方法执行发生异常：" + ex.Message);
            }
        }
        #endregion

        #region 【03H】读取输出寄存器

        /// <summary>
        /// 03H读取输出寄存器
        /// </summary>
        /// <param name="start">起始寄存器地址</param>
        /// <param name="length">寄存器长度</param>
        /// <returns>返回字节数组</returns>
        public byte[] ReadOutputRegisters(ushort start, ushort count)
        {
            List<byte> sendBytes = new List<byte>
            {
                0x00,0x00,
                0x00,0x00,
                0x00,0x06,
                SlaveId,
                0x03,
                (byte)(start / 256),  (byte)(start %256),
                (byte) (count/256), (byte) (count%256)
            };
            try
            {
                byte[] receiveBytes = SendAndReceive(sendBytes.ToArray());
                int byteLength = count * 2;
                if (receiveBytes.Length == 9 + byteLength
                    && receiveBytes[6] == SlaveId
                    && receiveBytes[7] == 0x03
                    && receiveBytes[8] == byteLength)
                {
                    byte[] result = new byte[byteLength];
                    Array.Copy(receiveBytes, 9, result, 0, byteLength);
                    return result;
                }
                else
                {
                    throw new Exception("ReadOutputRegisters方法返回数据异常！请断点调试返回的数据，以便发现问题");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ReadOutputRegisters方法执行发生异常：" + ex.Message);
            }
        }

        #endregion

        #region 【04H】读取输入寄存器

        /// <summary>
        /// 读取输入寄存器
        /// </summary>
        /// <param name="start">起始寄存器地址</param>
        /// <param name="count">寄存器长度</param>
        /// <returns>返回字节数组</returns>
        public byte[] ReadInputRegisters(ushort start, ushort count)
        {
            List<byte> sendBytes = new List<byte>
            {
                0x00,0x00,
                0x00,0x00,
                0x00,0x06,
                SlaveId,
                0x04,
                (byte)(start / 256),  (byte)(start %256),
                (byte) (count/256), (byte) (count%256)
            };
            try
            {
                byte[] receiveBytes = SendAndReceive(sendBytes.ToArray());
                int byteLength = count * 2;
                if (receiveBytes.Length == 9 + byteLength
                    && receiveBytes[6] == SlaveId
                    && receiveBytes[7] == 0x04
                    && receiveBytes[8] == byteLength)
                {
                    byte[] result = new byte[byteLength];
                    Array.Copy(receiveBytes, 9, result, 0, byteLength);
                    return result;
                }
                else
                {
                    throw new Exception("ReadInputRegisters方法返回数据异常！请断点调试返回的数据，以便发现问题");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ReadInputRegisters方法执行发生异常：" + ex.Message);
            }
        }

        #endregion

        #region 【05H】写入单线圈

        /// <summary>
        /// 05H写入单线圈
        /// </summary>
        /// <param name="start">线圈地址</param>
        /// <param name="value">线圈值</param>
        /// <returns>返回结果</returns>
        public void WriteSingleCoil(ushort start, bool value)
        {
            List<byte> sendBytes = new List<byte>
            {
                0x00,0x00,
                0x00,0x00,
                0x00,0x06,
                SlaveId,
                0x05,
                (byte)(start / 256),  (byte)(start %256),
                value ? (byte)0xFF : (byte)0x00, 0x00
            };
            try
            {
                byte[] receiveBytes = SendAndReceive(sendBytes.ToArray());
                if (receiveBytes.Length == 12)
                {
                    bool b = ByteArrayEquals(sendBytes.ToArray(), receiveBytes);
                    if (!b)
                    {
                        throw new Exception("WriteSingleCoil方法返回异常：收发报文不一致！");
                    }
                }
                else
                {
                    throw new Exception("WriteSingleCoil方法返回数据异常！请断点调试返回的数据，以便发现问题");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("WriteSingleCoil方法执行发生异常：" + ex.Message);
            }
        }

        #endregion

        #region 【06H】写入单寄存器

        /// <summary>
        /// 06H写入单寄存器
        /// </summary>
        /// <param name="start">寄存器地址</param>
        /// <param name="value">寄存器值</param>
        /// <returns>返回结果</returns>
        public void WriteSingleRegister(ushort start, byte[] value)
        {
            List<byte> sendBytes = new List<byte>
            {
                0x00,0x00,
                0x00,0x00,
                0x00,0x06,
                SlaveId,
                0x06,
                (byte)(start / 256),  (byte)(start %256)
            };
            sendBytes.AddRange(value);
            try
            {
                byte[] receiveBytes = SendAndReceive(sendBytes.ToArray());
                if (receiveBytes.Length == 12)
                {
                    bool b = ByteArrayEquals(sendBytes.ToArray(), receiveBytes);
                    if (!b)
                    {
                        throw new Exception("WriteSingleRegister方法返回异常：收发报文不一致！");
                    }
                }
                else
                {
                    throw new Exception("WriteSingleRegister方法返回数据异常！请断点调试返回的数据，以便发现问题");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("WriteSingleRegister方法执行发生异常：" + ex.Message);
            }
        }

        /// <summary>
        /// 写入单寄存器
        /// </summary>
        /// <param name="start">寄存器地址</param>
        /// <param name="value">Short类型</param>
        /// <returns>返回结果</returns>
        public void WriteSingleRegister(ushort start, short value)
        {
            WriteSingleRegister(start, BitConverter.GetBytes(value).Reverse().ToArray());
        }

        /// <summary>
        /// 写入单寄存器
        /// </summary>
        /// <param name="start">寄存器地址</param>
        /// <param name="value">UShort类型</param>
        /// <returns>返回结果</returns>
        public void WriteSingleRegister(ushort start, ushort value)
        {
            WriteSingleRegister(start, BitConverter.GetBytes(value).Reverse().ToArray());
        }

        #endregion

        #region 【0FH】写入多线圈

        /// <summary>
        /// 0FH写入多线圈
        /// </summary>
        /// <param name="start">起始线圈地址</param>
        /// <param name="value">写入值</param>
        /// <returns>返回结果</returns>
        public void WriteMultiCoils(ushort start, bool[] value)
        {
            byte[] byteArray = GetByteArrayFromBoolArray(value);
            List<byte> sendBytes = new List<byte>
            {
                0x00,0x00,
                0x00,0x00,
                (byte) ((7 + byteArray.Length)/256),
                (byte) ((7 + byteArray.Length)%256),
                SlaveId,
                0x0F,
                (byte) (start/256), (byte) (start%256),
                (byte) (value.Length/256), (byte) (value.Length%256),
                (byte)byteArray.Length
            };
            sendBytes.AddRange(byteArray);
            try
            {
                byte[] receiveBytes = SendAndReceive(sendBytes.ToArray());
                byte[] send = new byte[12];
                Array.Copy(sendBytes.ToArray(), 0, send, 0, 12);
                send[4] = 0x00;
                send[5] = 0x06;
                if (!ByteArrayEquals(send, receiveBytes))
                {
                    throw new Exception("WriteMultiCoils方法返回异常：接收报文不符合要求。");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("WriteMultiCoils方法执行发生异常：" + ex.Message);
            }
        }
        #endregion

        #region 【10H】写入多寄存器

        /// <summary>
        /// 10H写入多寄存器
        /// </summary>
        /// <param name="start">起始寄存器地址</param>
        /// <param name="value">写入值</param>
        /// <returns>返回结果</returns>
        public void WriteMultiRegisters(ushort start, byte[] values)
        {
            if (values == null || values.Length == 0 || values.Length % 2 == 1)
            {
                throw new Exception("WriteMultiRegister方法返回数据异常：values值不符合要求！");
            }
            List<byte> sendBytes = new List<byte>
            {
                0x00,
                0x00,
                0x00,
                0x00,
                (byte) ((7 + values.Length)/256),
                (byte) ((7 + values.Length)%256),
                SlaveId,
                0x10,
                (byte) (start/256), (byte) (start%256),
                (byte) (values.Length / 2/256),
                (byte) (values.Length / 2%256),
                (byte)values.Length
            };
            sendBytes.AddRange(values);
            try
            {
                byte[] receiveBytes = SendAndReceive(sendBytes.ToArray());
                byte[] send = new byte[12];
                Array.Copy(sendBytes.ToArray(), 0, send, 0, 12);
                send[4] = 0x00;
                send[5] = 0x06;
                if (!ByteArrayEquals(send, receiveBytes))
                {
                    throw new Exception("WriteMultiRegisters方法返回异常：接收报文不符合要求。");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("WriteMultiRegisters方法执行发生异常：" + ex.Message);
            }
        }
        #endregion

        #region 通用发送并接收方法

        /// <summary>
        /// 发送并接收方法
        /// </summary>
        /// <param name="sendBytes">发送报文</param>  
        /// <returns>返回结果</returns>
        private byte[] SendAndReceive(byte[] sendBytes)
        {
            lockTCP.Enter();
            byte[] buffer = new byte[1024];
            MemoryStream stream = new MemoryStream();
            try
            {
                socket.Send(sendBytes, sendBytes.Length, SocketFlags.None);
                int timer = 0;
                while (true)
                {
                    Thread.Sleep(SleepTime);
                    if (socket.Available > 0) 
                    {
                        int count = socket.Receive(buffer, SocketFlags.None);
                        stream.Write(buffer, 0, count);
                    }
                    else
                    {
                        timer++;
                        if (stream.Length > 0)
                        {
                            break;
                        }
                        else if (timer > MaxWaitTimes)
                        {
                            throw new Exception("未读取到数据，超过最大读取时间！");
                        }
                    }
                }
                return stream.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception("发送或接收数据错误，原因：" + ex.Message);
            }
            finally
            {
                lockTCP.Leave();
            }
        }

        #endregion

        #region 数组比较方法

        /// <summary>
        /// 数组比较方法    0x01 0x02   01-02
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <returns></returns>
        private bool ByteArrayEquals(byte[] b1, byte[] b2)
        {
            return BitConverter.ToString(b1) == BitConverter.ToString(b2);
        }

        #endregion

        #region 将布尔数组转换成字节数组

        private byte[] GetByteArrayFromBoolArray(bool[] value)
        {
            int byteLength = value.Length % 8 == 0 ? value.Length / 8 : value.Length / 8 + 1;

            byte[] result = new byte[byteLength];

            for (int i = 0; i < result.Length; i++)
            {
                int total = value.Length < 8 * (i + 1) ? value.Length - 8 * i : 8;
                for (int j = 0; j < total; j++)
                {
                    result[i] = SetBitValue(result[i], j, value[8 * i + j]);
                }
            }
            return result;
        }

        /// <summary>
        /// 将某个字节某个位置位或复位
        /// </summary>
        /// <param name="src"></param>
        /// <param name="bit"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private byte SetBitValue(byte src, int bit, bool value)
        {
            return value ? (byte)(src | (byte)Math.Pow(2, bit)) : (byte)(src & ~(byte)Math.Pow(2, bit));
        }
        #endregion
    }

    #region 简单的混合锁

    public sealed class SimpleHybirdLockTCP : IDisposable
    {

        #region IDisposable Support
        private bool disposedValue = false; // 要检测冗余调用

        void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)。
                }

                // TODO: 释放未托管的资源(未托管的对象)并在以下内容中替代终结器。
                // TODO: 将大型字段设置为 null。
                m_waiterLock.Close();

                disposedValue = true;
            }
        }

        // TODO: 仅当以上 Dispose(bool disposing) 拥有用于释放未托管资源的代码时才替代终结器。
        // ~SimpleHybirdLock() {
        //   // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
        //   Dispose(false);
        // }

        // 添加此代码以正确实现可处置模式。
        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
            Dispose(true);
            // TODO: 如果在以上内容中替代了终结器，则取消注释以下行。
            // GC.SuppressFinalize(this);
        }
        #endregion

        private Int32 m_waiters = 0;
     
        private AutoResetEvent m_waiterLock = new AutoResetEvent(false);

        public void Enter()
        {
            if (Interlocked.Increment(ref m_waiters) == 1) return;
            m_waiterLock.WaitOne();
        }
        public void Leave()
        {
            if (Interlocked.Decrement(ref m_waiters) == 0) return;
            m_waiterLock.Set();
        }

        public bool IsWaitting => m_waiters == 0;
    }
    #endregion
}
