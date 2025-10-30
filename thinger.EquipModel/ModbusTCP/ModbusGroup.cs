using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniExcelLibs.Attributes;

namespace thinger.EquipModel
{
    public class ModbusGroup : BaseGroup
    {
        /// <summary>
        /// 起始地址（在ModbusTCP里，表示寄存器的地址）
        /// </summary>
        public ushort Start { get; set; }
        /// <summary>
        /// 存储区名称（输出线圈，输出寄存器）
        /// </summary>
        public string StoreArea { get; set; }

        /// <summary>
        /// 当前通信组所包含的全部变量集合
        /// </summary>
        [ExcelIgnore]
        public List<ModbusVariable> VariableList { get; set; }
    }
}
