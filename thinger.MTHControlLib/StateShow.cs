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
    //默认双击用户控件就产生这个事件
    [DefaultEvent("ControlDoubleClick")]
    public partial class StateShow : UserControl
    {
        public StateShow()
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

        private string titleName = "1号站点温度设置";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示标题名称")]
        public string TitleName
        {
            get { return titleName; }
            set
            {
                titleName = value;
                this.lbl_Title.Text = titleName;
            }
        }

        private string currentValue = "0.0";
        [Category("自定义属性")]
        [Description("设置或显示当前设定的数值")]
        public string CurrentValue
        {
            get { return currentValue; }
            set
            {
                if (value != currentValue)
                {
                    currentValue = value;
                    this.lbl_Value.Text = currentValue;
                }

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
        private bool isAlarm = false;
        [Category("自定义属性")]
        [Description("设置或显示当前指示灯报警状态")]
        public bool IsAlarm
        {
            get { return isAlarm; }
            set
            {
                isAlarm = value;
                this.led_Alarm.Value = isAlarm;
            }
        }
        [Category("自定义属性")]
        [Description("设置或显示绑定的变量名称")]
        public string BindVarName { get; set; } = "1#号站点温度高限";

        [Category("自定义属性")]
        [Description("设置或显示报警绑定的变量名称")]
        public string AlarmVarName { get; set; }

        //用户控件双击事件声明
        public event EventHandler ControlDoubleClick;
        //事件激发（把4个控件都关联上）
        private void StateShow_DoubleClick(object sender, EventArgs e)
        {
            if (ControlDoubleClick != null)
            {
                ControlDoubleClick(this, e);
            }
        }
    }
}
