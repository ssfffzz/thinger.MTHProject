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
                temp = value;
                string t = temp.ToString();
                if (t.Length == 2)  //比如是12.0
                {
                    t += "0";
                    t = t.PadRight(4, '0');
                }
                this.lblTemp.Text = t;
                this.dialPlate1.Temp = temp;
            }
        }
    }
}
