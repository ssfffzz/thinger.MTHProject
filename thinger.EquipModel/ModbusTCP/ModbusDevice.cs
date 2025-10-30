using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinger.EquipModel
{
    public class ModbusDevice : BaseDevice
    {
        /// <summary>
        /// Modbus设备IP地址
        /// </summary>
        public string IPAddress { get; set; }
        /// <summary>
        /// Modbus端口号
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// Modbus从站ID
        /// </summary>
        public byte SlaveId { get; set; }

        public List<ModbusGroup> GroupList { get; set; }

        /// <summary>
        /// 当前所应用的配方
        /// </summary>
        public string CurrentRecipe { get; set; }
    }
}
