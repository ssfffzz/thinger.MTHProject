using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using thinger.DataConvertLib;
using thinger.EquipModel;
using thinger.ModbusLib;
using thinger.ToolLib;

namespace thinger.Communication
{
    /// <summary>
    /// ModbusTCP通信数据采集类
    /// </summary>
    public class ModbusCommunication
    {
        #region 任务一：加载通信配置信息（设备Device,通信组Group,变量Variable）
        /// <summary>
        /// 加载设备Device对象树信息
        /// </summary>
        /// <param name="devicePath">ini配置文件路径</param>
        /// <param name="groupPath">通信组文件excel路径</param>
        /// <param name="variablePath">变量表文件excel路径</param>
        /// <returns></returns>
        public ModbusDevice LoadDevice(string devicePath, string groupPath, string variablePath)
        {
            if (!File.Exists(devicePath))//检查文件是否存在
            {
                ModbusObjectTree.AddLogAction(1, "设备文件不存在");
                return null;
            }
            List<ModbusGroup> groupList = LoadGroup(groupPath, variablePath);//加载通信组和变量集合
            if (groupList != null && groupList.Count > 0)
            {
                try
                {
                    ModbusDevice modbusDevice = new ModbusDevice()
                    {
                        IPAddress = IniConfigHelper.ReadIniData("设备参数", "IP地址", "192.0.0.1", devicePath),
                        Port = int.Parse(IniConfigHelper.ReadIniData("设备参数", "端口号", "502", devicePath)),
                        SlaveId = byte.Parse(IniConfigHelper.ReadIniData("设备参数", "站地址", "15", devicePath)),
                        GroupList = groupList,
                        CurrentRecipe = IniConfigHelper.ReadIniData("设备参数", "当前配方", "", devicePath)
                    };
                    return modbusDevice;
                }
                catch (Exception ex)
                {
                    ModbusObjectTree.AddLogAction(1, "设备信息文件读取失败" + ex.Message);
                    return null;
                }
            }
            else
                return null;
        }

        /// <summary>
        /// 加载所有的通信组和变量集合
        /// </summary>
        /// <param name="groupPath">通信组文件excel路径</param>
        /// <param name="variablePath">变量表文件excel路径</param>
        /// <returns></returns>
        private List<ModbusGroup> LoadGroup(string groupPath, string variablePath)
        {
            if (!File.Exists(groupPath))//检查文件是否存在
            {
                ModbusObjectTree.AddLogAction(1, "通信组文件不存在");
                return null;
            }
            if (!File.Exists(variablePath))
            {
                ModbusObjectTree.AddLogAction(1, "变量表文件不存在");
                return null;
            }
            List<ModbusVariable> varList = null;//加载变量表
            try
            {
                varList = MiniExcel.Query<ModbusVariable>(variablePath).ToList();
            }
            catch (Exception ex)
            {
                ModbusObjectTree.AddLogAction(1, "变量表加载失败！" + ex.Message);
                return null;
            }
            List<ModbusGroup> groupList = null;//加载变量表
            try
            {
                groupList = MiniExcel.Query<ModbusGroup>(groupPath).ToList();
            }
            catch (Exception ex)
            {
                ModbusObjectTree.AddLogAction(1, "通信组加载失败！" + ex.Message);
                return null;
            }
            if (groupList.Count != 0 && varList.Count != 0)
            {
                foreach (var group in groupList)//遍历通信组集合里的每个通信组
                {
                    group.VariableList = varList.FindAll(c => c.GroupName == group.GroupName).ToList();
                }
                return groupList;
            }
            else
            { return null; }
        }
        #endregion

        #region 任务二：数据采集与对象树变量赋值
        public void PLCCommunication(ModbusDevice device, Action<ModbusVariable> checkAlarm, CancellationTokenSource cts)
        {
            while (!cts.IsCancellationRequested)
            {
                if (device.IsConnected)//如果设备通信连接成功，则读取数据
                {
                    //基于多线程读取设备数据
                    foreach (var group in device.GroupList)//遍历通信组
                    {
                        byte[] dataBytes = null;//返回的字节数组
                        int requestByteLength = 0;//请求的字节长度
                        if (group.StoreArea == "输入线圈" || group.StoreArea == "输出线圈")
                        {
                            switch (group.StoreArea)
                            {
                                case "输入线圈":
                                    dataBytes = ModbusObjectTree.Tcp.ReadInputCoils(group.Start, group.Length);
                                    requestByteLength = ShortLib.GetByteLengthFromBoolLength(group.Length);
                                    break;
                                case "输出线圈":
                                    dataBytes = ModbusObjectTree.Tcp.ReadOutputCoils(group.Start, group.Length);
                                    requestByteLength = ShortLib.GetByteLengthFromBoolLength(group.Length);
                                    break;
                                default:
                                    break;
                            }
                            if (dataBytes != null && dataBytes.Length == requestByteLength)
                            {
                                foreach (var variable in group.VariableList) 
                                {
                                    //获取数据变量类型（把变量对象中字符串表示的“数据类型”转换成“实际实际数据类型的枚举”）
                                    DataType dataType = (DataType)Enum.Parse(typeof(DataType), variable.DataType, true);
                                    //得到变量的相对地址
                                    int readStart = (variable.Start - group.Start);
                                    switch (dataType)
                                    {
                                        case DataType.Bool:
                                            variable.Varvalue = BitLib.GetBitFromByteArray(dataBytes, readStart, variable.OffsetOrLength);
                                            break;
                                        default:
                                            break;
                                    }
                                    //更新到设备变量集合中对应的变量值（线圈不要做线性转换）
                                    device.UpdateDicVariable(variable);
                                }
                            }
                        }
                        else//读取寄存器
                        {
                            switch (group.StoreArea)
                            {
                                case "输入寄存器":
                                    dataBytes = ModbusObjectTree.Tcp.ReadInputRegisters(group.Start, group.Length);
                                    requestByteLength = group.Length * 2;
                                    break;
                                case "输出寄存器":
                                    dataBytes = ModbusObjectTree.Tcp.ReadOutputRegisters(group.Start, group.Length);
                                    requestByteLength = group.Length * 2;
                                    break;
                                default:
                                    break;
                            }
                            //把读取的寄存器数据，封装到对象树的【变量】中
                            if (dataBytes != null && dataBytes.Length == requestByteLength)
                            {
                                foreach (var variable in group.VariableList)//遍历通信组中所有变量
                                {
                                    //获取数据变量类型（把变量对象中字符串表示的“数据类型”转换成“实际实际数据类型的枚举”）
                                    DataType dataType = (DataType)Enum.Parse(typeof(DataType), variable.DataType, true);
                                    //得到变量的相对地址
                                    int readStart = (variable.Start - group.Start) * 2;
                                    switch (dataType)
                                    {
                                        case DataType.Bool:
                                            variable.Varvalue = BitLib.GetBitFrom2BytesArray(dataBytes, readStart, variable.OffsetOrLength, ModbusObjectTree.DataFormat == DataFormat.BADC || ModbusObjectTree.DataFormat == DataFormat.DCBA);
                                            //对于bool类型来说只有小端和大端区别，如果是两个字节BADC和DCBA一样都是小端，ABCD是大端
                                            break;
                                        case DataType.Byte:
                                            variable.Varvalue = ByteLib.GetByteFromByteArray(dataBytes, readStart);
                                            break;
                                        case DataType.Short:
                                            variable.Varvalue = ShortLib.GetShortFromByteArray(dataBytes, readStart);
                                            break;
                                        case DataType.UShort:
                                            variable.Varvalue = UShortLib.GetUShortFromByteArray(dataBytes, readStart);
                                            break;
                                        case DataType.Int:
                                            variable.Varvalue = IntLib.GetIntFromByteArray(dataBytes, readStart, ModbusObjectTree.DataFormat);
                                            break;
                                        case DataType.UInt:
                                            variable.Varvalue = UIntLib.GetUIntFromByteArray(dataBytes, readStart, ModbusObjectTree.DataFormat);
                                            break;
                                        case DataType.Float:
                                            variable.Varvalue = FloatLib.GetFloatFromByteArray(dataBytes, readStart, ModbusObjectTree.DataFormat);
                                            break;
                                        case DataType.Double:
                                            variable.Varvalue = DoubleLib.GetDoubleFromByteArray(dataBytes, readStart, ModbusObjectTree.DataFormat);
                                            break;
                                        case DataType.Long:
                                            variable.Varvalue = LongLib.GetLongFromByteArray(dataBytes, readStart, ModbusObjectTree.DataFormat);
                                            break;
                                        case DataType.ULong:
                                            variable.Varvalue = ULongLib.GetULongFromByteArray(dataBytes, readStart, ModbusObjectTree.DataFormat);
                                            break;
                                        case DataType.String:
                                            variable.Varvalue = StringLib.GetStringFromByteArrayByEncoding(dataBytes, readStart, variable.OffsetOrLength * 2, Encoding.ASCII);
                                            break;
                                        case DataType.ByteArray:
                                            variable.Varvalue = ByteArrayLib.GetByteArrayFromByteArray(dataBytes, readStart, variable.OffsetOrLength * 2);
                                            break;

                                    }
                                    //值类型要先做线性转换
                                    if (dataType != DataType.Bool && dataType != DataType.String && dataType != DataType.ByteArray)
                                    {
                                        variable.Varvalue = MigrationLib.GetMigrationValue(variable.Varvalue, variable.Scale.ToString(), variable.Offset.ToString()).Content;
                                    }
                                    //更新到设备对象的【变量字典】集合中
                                    device.UpdateDicVariable(variable);
                                }
                            }
                            else//如果读取数据有问题，则视为连接不成功（下次读取之前重新连接）
                            {
                                device.IsConnected = false;
                            }
                        }
                    }
                    //扫描延时
                    Thread.Sleep(500);
                }
                else//如果设备通信没有连接，则打开连接或者等待重连
                {
                    if (device.ReConnectSign)//如果重连标志为true
                    {
                        ModbusObjectTree.Tcp?.DisConnect();//如果TCP对象不为空，则断开连接
                        ModbusObjectTree.AddLogAction(0, "通信中断，或者未返回数据控制器重新连接中...");
                        Thread.Sleep(device.ReConnectTime);//等待2秒钟后重连
                    }
                    //创建通信对象，并开始连接
                    ModbusObjectTree.Tcp = new ModbusTCP();
                    ModbusObjectTree.Tcp.SlaveId = ModbusObjectTree.Device.SlaveId;
                    try
                    {
                        device.IsConnected = ModbusObjectTree.Tcp.Connect(device.IPAddress, device.Port);
                        //判断是重连还是首次连接
                        if (device.ReConnectSign)
                        {
                            ModbusObjectTree.AddLogAction(device.IsConnected ? 0 : 1, device.IsConnected ? "设备重连成功" : "设备重连失败");
                        }
                        else
                        {
                            ModbusObjectTree.AddLogAction(device.IsConnected ? 0 : 1, device.IsConnected ? "设备首次连接成功" : "设备首次连接失败");
                            device.ReConnectSign = true;//在首次连接后，将重连标志设置为true
                        }
                    }
                    catch (Exception ex)
                    {
                        ModbusObjectTree.AddLogAction(2, "通信失败，异常信息：" + ex.Message);
                    }                  
                }
            }

        }
        #endregion
    }
}
