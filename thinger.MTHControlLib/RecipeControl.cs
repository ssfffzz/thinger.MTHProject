using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.DataModels;

namespace thinger.MTHControlLib
{
    public partial class RecipeControl : UserControl
    {
        public RecipeControl()
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
        private string siteName = "1号站点";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("显示或设置站点名称")]
        public string SiteName
        {
            get { return siteName; }
            set
            {
                siteName = value;
                this.siteTitleName.Title = siteName;
                this.stateShowEx1.TitleName = siteName + "温度高限";
                this.stateShowEx2.TitleName = siteName + "温度低限";
                this.stateShowEx3.TitleName = siteName + "湿度高限";
                this.stateShowEx4.TitleName = siteName + "湿度低限";
            }
        }
        public RecipeParam param = null;

        /// <summary>
        /// 配方参数取值和赋值
        /// </summary>
        [Browsable(false)]
        public RecipeParam RecipeParam
        {
            get
            {
                return param = new RecipeParam()
                {
                    TempMax = this.stateShowEx1.CurrentValue,
                    TempMin = this.stateShowEx2.CurrentValue,
                    HumidityMax = this.stateShowEx3.CurrentValue,
                    HumidityMin = this.stateShowEx4.CurrentValue,
                    TempAlarmEnable = this.checkBoxEx1.Checked,
                    HumidityAlarmEnable = this.checkBoxEx2.Checked
                };
            }
            set
            {
                param = value;
                this.stateShowEx1.CurrentValue = param.TempMax;
                this.stateShowEx2.CurrentValue = param.TempMin;
                this.stateShowEx3.CurrentValue = param.HumidityMax;
                this.stateShowEx4.CurrentValue = param.HumidityMin;
                this.checkBoxEx1.Checked = param.TempAlarmEnable;
                this.checkBoxEx2.Checked = param.HumidityAlarmEnable;            
            }
        }
    }
}
