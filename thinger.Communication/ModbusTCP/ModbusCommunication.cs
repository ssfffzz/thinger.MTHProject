using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thinger.EquipModel;

namespace thinger.Communication
{
    /// <summary>
    /// ModbusTCP通信数据采集类
    /// </summary>
    public class ModbusCommunication
    {
        //任务一：加载通信配置信息（设备Device,通信组Group,变量Variable）
        /// <summary>
        /// 加载所有的通信组和变量集合
        /// </summary>
        /// <param name="groupPath">通信组文件excel路径</param>
        /// <param name="variablePath">变量表文件excel路径</param>
        /// <returns></returns>
        public List<ModbusGroup> LoadGroup(string groupPath, string variablePath)
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


        //任务二：数据采集与对象树变量赋值

    }
}
