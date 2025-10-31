using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

        //任务二：数据采集与对象树变量赋值
        public void PLCCommunication(ModbusDevice device, Action<ModbusVariable> checkAlarm, CancellationTokenSource cts)
        {
            while (!cts.IsCancellationRequested)
            {
                if (device.IsConnected)//如果设备通信连接成功，则读取数据
                {
                    //基于多线程读取设备数据
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

    }
}
