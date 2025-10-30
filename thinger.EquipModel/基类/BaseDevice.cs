using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinger.EquipModel
{
    public class BaseDevice
    {
        /// <summary>
        /// 设备连接状态, true已连接，false未连接，通信状态标志位
        /// </summary>
        public bool IsConnected { get; set; }
        /// <summary>
        /// 重连标志位
        /// </summary>
        public bool ReConnectSign { get; set; } = false;
        /// <summary>
        /// 自动重连时间间隔，单位毫秒
        /// </summary>
        public int ReConnectTime { get; set; } = 2000;

        /// <summary>
        /// 设备所有的【变量字典集合】
        /// </summary>
        public Dictionary<string, object> VariableDictionary = new Dictionary<string, object>();

        public void UpdateDicVariable(BaseVariable baseVariable)
        {
            if (VariableDictionary.ContainsKey(baseVariable.VarName))//是否包含变量的名字
            {
                VariableDictionary[baseVariable.VarName] = baseVariable.Varvalue;//包含的话就更新变量值
            }
            else
            {
                VariableDictionary.Add(baseVariable.VarName, baseVariable.Varvalue);//不包含的话就添加进集合
            }

        }
        //使用索引器，方便调用集合
        public object this[string key]
        {
            get
            {
                if (VariableDictionary.ContainsKey(key))
                {
                    return VariableDictionary[key];
                }
                else
                {
                    return null;
                }
            }
     
        }
    }
}
