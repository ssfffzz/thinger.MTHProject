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
    [DefaultEvent("Click")]//当前控件默认是Click事件
    public partial class NaviButton : UserControl
    {     
        public NaviButton()//初始化
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

        //设置导航按钮是否被选中
        private bool isSelected = false;
        [Category("自定义控件")]
        [Description("获取或设置导航按钮是否被选中")]
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                ChangeImage();
            }
        }

        //设置导航按钮是否被选中
        private bool isLeft = true;
        [Category("自定义控件")]
        [Description("获取或设置导航按钮是左偏还是右偏")]
        public bool IsLeft
        {
            get { return isLeft; }
            set
            {
                isLeft = value;
                ChangeImage();
            }
        }
        public void ChangeImage()
        {
            if (isSelected)//选中
            {
                this.BackgroundImage = isLeft ?
                         Properties.Resources.LeftSelected : Properties.Resources.RightSelected;
            }
            else//没选中
            {
                this.BackgroundImage = isLeft ?
                         Properties.Resources.LeftUnSelected : Properties.Resources.RightUnSelected;
            }
        }

        //设置导航按钮显示文本
        private string titleName = "导航按钮";
        [Category("自定义控件")]
        [Description("获取或设置导航按钮显示文本")]
        public string TitleName
        {
            get { return titleName; }
            set
            {
                titleName = value;
                this.lbl_Title.Text = titleName;
            }
        }

        /// <summary>
        /// 自定义导航按钮单击事件（使用new关键字覆盖原有事件）
        /// </summary>
        public new event EventHandler Click;
        //当用户单机标签的时候，激发导航按钮的单击事件
        private void lbl_Title_Click(object sender, EventArgs e)
        {
            this.Click?.Invoke(this, e);//this代表当前控件，用label的单击事件触发控件的单击事件
        }
    }
}
