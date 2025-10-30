using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniExcelLibs.Attributes;

namespace thinger.EquipModel
{
    public class BaseVariable
    {
        /// <summary>
        /// 变量名称
        /// </summary>
        public string VarName { get; set; }
        /// <summary>
        /// 变量起始地址
        /// </summary>
        public ushort Start { get; set; }
        /// <summary>
        /// 数据类型
        /// </summary>
        public string DataType { get; set; }
        /// <summary>
        /// 变量【偏移量或长度】
        /// </summary>
        public int OffsetOrLength { get; set; }
        /// <summary>
        /// 通信组名称
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// 信息备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 变量【上升沿报警】
        /// </summary>
        public bool PostAlarm { get; set; }
        /// <summary>
        /// 变量【下降沿报警】
        /// </summary>
        public bool NegAlarm { get; set; }
        /// <summary>
        /// 变量线性系数
        /// </summary>
        public float Scale { get; set; } = 1.0f;
        /// <summary>
        /// 变量线性偏移
        /// 比如：y=ax+b
        /// </summary>
        public float Offset { get; set; } = 0.0f;
        /// <summary>
        /// 上升沿报警检测的缓存值
        /// </summary>
        [ExcelIgnore] //读取excel表时忽略此属性
        public bool PostCacheValue { get; set; }
        /// <summary>
        /// 下降沿报警检测的缓存值
        /// </summary>
        [ExcelIgnore]//读取excel表时忽略此属性
        public bool NegCacheValue { get; set; }
        /// <summary>
        /// 变量值
        /// </summary>
        [ExcelIgnore]//读取excel表时忽略此属性
        public object Varvalue { get; set; }

    }
}
