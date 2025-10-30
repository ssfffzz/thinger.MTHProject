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

    }
}
