using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thinger.DataConvertLib;
using thinger.EquipModel;
using thinger.ModbusLib;

namespace thinger.Communication
{
    /// <summary>
    /// Modbus对象树
    /// 作用：提供完整的【通信对象数】，同时存放一些公用的属性和方法
    /// </summary>
    public class ModbusObjectTree
    {
        /// <summary>
        /// 项目设备对象
        /// </summary>
        public static ModbusDevice Device { get; set; }

        /// <summary>
        /// ModbusTCP通信对象
        /// </summary>
        public static ModbusTCP Tcp { get; set; }

        /// <summary>
        /// 默认数据大小端
        /// </summary>
        public static DataFormat DataFormat { get; set; } = DataFormat.ABCD;
        /// <summary>
        /// 添加委托日志
        /// </summary>
        public static Action<int, string> AddLogAction { get; set; }

        /// <summary>
        /// 通用写入方法
        /// </summary>
        /// <param name="varName">变量名称</param>
        /// <param name="varValue">变量值</param>
        /// <returns></returns>
        public static bool CommonWrite(string varName, string varValue)
        {
            ModbusVariable currentVar = null;
            foreach (var group in Device.GroupList)
            {
                currentVar = group.VariableList.Find(v => v.VarName == varName);
                if (currentVar != null)
                {
                    break;
                }
            }
            if (currentVar == null)
            {
                //AddLogAction?.Invoke(2, $"Modbus写入失败，未找到变量：{varName}");
                return false;
            }
            //根据当前变量对象得到变量类型,dataType是一个枚举类型
            DataType dataType = (DataType)Enum.Parse(typeof(DataType), currentVar.DataType);
            //线性还原（比如把25.6，实际还原成256）
            var result = MigrationLib.SetMigrationValue(varValue, dataType, currentVar.Scale.ToString(), currentVar.Offset.ToString());
            //写入数据,根据变量的数据类型进行不同的处理
            //输入datatype后连续按两下enter键可以生成switch代码框架
            switch (dataType)
            {
                case DataType.Bool:
                    Tcp.WriteSingleCoil(currentVar.Start, Convert.ToBoolean(result.Content));
                    break;
                case DataType.Short:
                    Tcp.WriteSingleRegister(currentVar.Start, Convert.ToInt16(result.Content));
                    break;
                case DataType.UShort:
                    Tcp.WriteSingleRegister(currentVar.Start, Convert.ToUInt16(result.Content));
                    break;
                case DataType.Int:              
                    Tcp.WriteMultiRegisters(currentVar.Start, ByteArrayLib.GetByteArrayFromInt(Convert.ToInt32(result.Content),DataFormat));
                    break;
                case DataType.UInt:
                    Tcp.WriteMultiRegisters(currentVar.Start, ByteArrayLib.GetByteArrayFromUInt(Convert.ToUInt32(result.Content), DataFormat));
                    break;
                case DataType.Float:
                    Tcp.WriteMultiRegisters(currentVar.Start, ByteArrayLib.GetByteArrayFromFloat(Convert.ToSingle(result.Content), DataFormat));
                    break;
                case DataType.Double:
                    Tcp.WriteMultiRegisters(currentVar.Start, ByteArrayLib.GetByteArrayFromDouble(Convert.ToDouble(result.Content), DataFormat));
                    break;
                case DataType.Long:
                    Tcp.WriteMultiRegisters(currentVar.Start, ByteArrayLib.GetByteArrayFromLong(Convert.ToInt64(result.Content), DataFormat));
                    break;
                case DataType.ULong:
                    Tcp.WriteMultiRegisters(currentVar.Start, ByteArrayLib.GetByteArrayFromULong(Convert.ToUInt64(result.Content), DataFormat));
                    break;
                case DataType.String:
                    Tcp.WriteMultiRegisters(currentVar.Start, ByteArrayLib.GetByteArrayFromString(result.Content,Encoding.ASCII));
                    break;
                case DataType.ByteArray:
                    Tcp.WriteMultiRegisters(currentVar.Start, ByteArrayLib.GetByteArrayFromHexString(result.Content));
                    break;
                case DataType.HexString:
                    Tcp.WriteMultiRegisters(currentVar.Start, ByteArrayLib.GetByteArrayFromHexString(result.Content));
                    break;
                default:
                    break;
            }
            return true;
        }
    }
}
