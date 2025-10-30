using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinger.EquipModel
{
    public class BaseGroup
    {
        /// <summary>
        /// 通讯组名称
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// 读取长度
        /// </summary>
        public ushort Length { get; set; }
        /// <summary>
        /// 备注说明
        /// </summary>
        public string Remark { get; set; }
    }
}
