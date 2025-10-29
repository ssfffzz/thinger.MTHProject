using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thinger.MTHControlLib
{
    public partial class CheckBoxEx : CheckBox
    {
        //封装文本布局信息（如对齐方式、方向和制表位）
        private StringFormat stringFormat = new StringFormat();

        public CheckBoxEx() : base()
        {
            stringFormat.Alignment = StringAlignment.Center; //居中： //获取或设置字符串的水平对齐方式
            stringFormat.LineAlignment = StringAlignment.Center;     //获取或设置字符串的垂直对齐方式

            //下面的内容，可以直接F1，查看ControlStyles官方解释
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true); //如果为 true，则控件忽略窗口消息 WM_ERASEBKGND 以减少闪烁
            this.SetStyle(ControlStyles.UserPaint, true);      //如果为 true，则会由控件而不是由操作系统来绘制控件自身。 如果 false，则不会引发 Paint 事件。
            this.SetStyle(ControlStyles.DoubleBuffer, true); //如果为 true，则在缓冲区中进行绘制，并且完成后将结果输出到屏幕。 双缓冲可以防止因重绘控件而引起的闪烁。 如果将 DoubleBuffer 设置为 true，则还应将 UserPaint 和 AllPaintingInWmPaint 设置为 true。
            this.SetStyle(ControlStyles.ResizeRedraw, true);//如果为 true，则控件会在调整大小时进行重绘
            this.SetStyle(ControlStyles.Selectable, true);     //如果为 true，则控件可以接收焦点
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);//如果为 true，则控件接受 alpha 组件数小于 255 个的 BackColor 来模拟透明度
        }

        //控件的基础颜色
        private Color baseColor = Color.FromArgb(3, 25, 66);
        public Color BaseColor
        {
            get { return baseColor; }
            set
            {
                baseColor = value;
                base.Invalidate();//重绘控件
            }
        }
        //复选框控件的宽度
        private int ckbWidth = 20;
        public int CkbWidth
        {
            get { return ckbWidth; }
            set
            {
                ckbWidth = value;
                this.Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //擦掉以前的内容
            base.OnPaint(e);
            base.OnPaintBackground(e);
            Graphics graphics = e.Graphics; //封装一个 GDI+ 绘图图面
            //设置此 Graphics 的呈现质量(平滑度）,  AntiAlias指定抗锯齿的呈现
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            //创建两个矩形对象-----------------------------------------------------------------------------
            int x = 1;
            int y = (this.Height - CkbWidth) / 2;   //Height：控件的基础类中的高度
            int width = CkbWidth;
            int height = CkbWidth;
            Rectangle checkRect = new Rectangle(x, y, width, height);

            x = checkRect.Right + 2;
            y = 0;
            width = this.Width - checkRect.Right - 4;
            height = this.Height;
            Rectangle textRect = new Rectangle(x, y, width, height);

            //定义单色画刷，用来填充颜色-----------------------------------------------------------
            SolidBrush brush = new SolidBrush(Color.Red);//红色画刷
            graphics.FillRectangle(brush, checkRect);//填充矩形颜色
            if (this.CheckState == CheckState.Checked)//如果选中，绘制选中对钩√
            {
                //定义对钩的三个点
                PointF[] points = new PointF[3];
                points[0] = new PointF(checkRect.X + checkRect.Width / 4.5f, checkRect.Y + checkRect.Height / 2.5f);
                points[1] = new PointF(checkRect.X + checkRect.Width / 2.5f, checkRect.Bottom - checkRect.Height / 3f);
                points[2] = new PointF(checkRect.Right - checkRect.Width / 4.0f, checkRect.Y + checkRect.Height / 4.5f);

                Pen cpen = new Pen(Color.White, 3.0F);  //3.0F表示像素,像素越大，对钩越粗
                graphics.DrawLines(cpen, points);
            }
            //定义画笔，用来画文本矩形
            Pen pen = new Pen(Color.LightGray);
            graphics.DrawRectangle(pen, checkRect);
            //写文本内容（Text就是控件的Text属性）
            graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textRect, this.stringFormat);
        }
    }
}
