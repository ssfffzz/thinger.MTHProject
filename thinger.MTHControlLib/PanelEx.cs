using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//Panel在这个命名空间里面

namespace thinger.MTHControlLib
{
    public partial class PanelEx : Panel  //新建组件类的意思是扩展Panel控件，所以继承自Panel，新建用户控件是把原有的控件组合在一起
    {
        public PanelEx()
        {
            InitializeComponent();
            //样式相关的设置,防止闪烁
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private int borderWidth = 2;
        [Category("自定义属性")]
        [Description("获取或设置Panel的边框宽度")]
        public int BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                this.Invalidate();
            }
        }

        private Color borderColor = Color.FromArgb(25,235,255);
        [Category("自定义属性")]
        [Description("获取或设置Panel的边框颜色")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        private int topGap = 1;
        [Category("自定义属性")]
        [Description("获取或设置Panel的顶部间隙")]
        public int TopGap
        {
            get { return topGap; }
            set
            {
                topGap = value;
                this.Invalidate();
            }
        }

        private int bottomGap = 1;
        [Category("自定义属性")]
        [Description("获取或设置Panel的底部间隙")]
        public int BottomGap
        {
            get { return bottomGap; }
            set
            {
                bottomGap = value;
                this.Invalidate();
            }
        }

        private int leftGap = 1;
        [Category("自定义属性")]
        [Description("获取或设置Panel的左侧间隙")]
        public int LeftGap
        {
            get { return leftGap; }
            set
            {
                leftGap = value;
                this.Invalidate();
            }
        }

        private int rightGap = 1;
        [Category("自定义属性")]
        [Description("获取或设置Panel的右侧间隙")]
        public int RightGap
        {
            get { return rightGap; }
            set
            {
                rightGap = value;
                this.Invalidate();
            }
        }




        protected override void OnPaint(PaintEventArgs e) //重载OnPaint这个方法
        {
            base.OnPaint(e);//调用基类的OnPaint方法，确保Panel的其他部分正常绘制
            //【1】定义画布(Graphics)
            Graphics graphics = e.Graphics;
            //【2】定义画笔
            Pen pen = new Pen(borderColor, borderWidth);
            //【3】定义矩形的绘制参数
            float x = leftGap + (borderWidth * 0.5f);
            float y = topGap + (borderWidth * 0.5f);
            float width = this.Width - leftGap - rightGap - (borderWidth * 1.0f);
            float height = this.Height - topGap - bottomGap - (borderWidth * 1.0f);
            //【4】绘制图形
            graphics.DrawRectangle(pen, x, y, width, height);



            //using (Pen pen = new Pen(borderColor, borderWidth))
            //{
            //    Rectangle rect = new Rectangle(
            //        borderWidth / 2 + leftGap,
            //        borderWidth / 2 + topGap,
            //        this.Width - borderWidth - leftGap - rightGap,
            //        this.Height - borderWidth - topGap - bottomGap);
            //    e.Graphics.DrawRectangle(pen, rect);
            //}
        }
    }
}
