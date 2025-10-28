using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thinger.MTHControlLib
{
    public partial class DialPlateControl : UserControl
    {
        public DialPlateControl()
        {
            InitializeComponent();
            //样式相关的设置,防止闪烁
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        //设置组合控件的站点显示
        private string titleName = "1#站点";
        [Browsable(true)]
        [Category("自定义控件")]
        [Description("获取或设置组合控件的站点显示")]
        public string TitleName
        {
            get { return titleName; }
            set
            {
                titleName = value;
                this.lblTitle.Text = titleName;
            }
        }

        //设置组合控件的温度显示
        private float temp = 0.0f;
        [Browsable(true)]
        [Category("自定义控件")]
        [Description("获取或设置组合控件的温度文本")]
        public float Temperature
        {
            get { return temp; }
            set
            {
                if (temp != value)
                {
                    temp = value;
                    string t = temp.ToString();
                    if (t.Length == 2)  //比如是12.0
                    {
                        t += ".";
                        t = t.PadRight(4, '0');//4是字符串的总字符数，根据总长度补充0
                    }
                    this.lblTemp.Text = t;
                    this.dialPlate1.Temp = temp;
                }

            }
        }

        //设置组合控件的湿度显示
        private float humidity = 0.0f;
        [Browsable(true)]
        [Category("自定义控件")]
        [Description("获取或设置组合控件的湿度文本")]
        public float Humidity
        {
            get { return humidity; }
            set
            {
                if (humidity != value)
                {
                    humidity = value;
                    string t = humidity.ToString();
                    if (t.Length == 2)  //比如是12.0
                    {
                        t += ".";
                        t = t.PadRight(4, '0');//4是字符串的总字符数，根据总长度补充0
                    }
                    this.lblHumitity.Text = t;
                    this.dialPlate1.Humidity = humidity;
                }

            }
        }

        //设置组合控件的站点状态
        private bool moduleError = false;
        [Browsable(true)]
        [Category("自定义控件")]
        [Description("获取或设置站点实时状态是否有错误")]
        public bool ModuleError
        {
            get { return moduleError; }
            set
            {
                if (moduleError != value)
                {
                    moduleError = value;
                    this.lblTitle.BackColor = moduleError ? Color.Red : Color.FromArgb(255, 128, 0);
                }
            }
        }

        #region 以下属性是为动态绑定数据做准备
        [Browsable(true)]
        [Category("自定义控件")]
        [Description("获取或设置【温度】绑定的变量")]
        public string TemVarName { get; set; } = string.Empty;

        [Browsable(true)]
        [Category("自定义控件")]
        [Description("获取或设置【湿度】绑定的变量")]
        public string HumitityVarName { get; set; } = string.Empty;

        [Browsable(true)]
        [Category("自定义控件")]
        [Description("获取或设置【站点状态】绑定的变量")]
        public string StateVarName { get; set; } = string.Empty;


        #endregion


    }
}
