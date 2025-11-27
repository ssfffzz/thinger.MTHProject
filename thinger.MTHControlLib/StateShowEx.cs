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
    public partial class StateShowEx : UserControl
    {
        public StateShowEx()
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

        private string titleName = "模块1温度高限";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示变量名称")]
        public string TitleName
        {
            get { return titleName; }
            set
            {
                titleName = value;
                this.lbl_Title.Text = titleName;
            }
        }

        private float currentValue = 0.0f;
        [Category("自定义属性")]
        [Description("设置或显示当前设定的数值")]
        public float CurrentValue
        {
            get
            {
                currentValue = Convert.ToSingle(this.num_Value.Value);
                return currentValue;
            }
            set
            {
                currentValue = value;
                this.num_Value.Value = Convert.ToDecimal(currentValue);
            }
        }
        private string unit = "°C";
        [Category("自定义属性")]
        [Description("设置或显示当前设定的数值")]
        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
                this.lbl_Unit.Text = unit;
            }
        }
    }
}
