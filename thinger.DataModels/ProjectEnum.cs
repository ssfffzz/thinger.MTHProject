using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinger.DataModels
{
    /// <summary>
    /// 所有窗体的枚举，小于临界窗体的为默认不关闭的窗体
    /// </summary>
    public enum FormNames
    {
        集中监控,
        临界窗体,//在临界窗体后面的默认关闭
        系统配置,
        配方管理,
        报警追溯,
        历史趋势,
        用户管理

    }
}
