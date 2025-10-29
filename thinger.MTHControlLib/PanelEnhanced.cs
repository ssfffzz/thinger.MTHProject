﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thinger.MTHControlLib
{
    public partial class PanelEnhanced : Panel
    {
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //重载基类的背景擦除方法，防止闪烁
            //解决窗口加载刷新，图像闪烁的问题

            return;
        }
        /// <summary>
        /// 重绘事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            // 使用双缓冲
            this.DoubleBuffered = true;
            // 背景重绘移动到此
            if (this.BackgroundImage != null)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                e.Graphics.DrawImage(
                    this.BackgroundImage,
                    new System.Drawing.Rectangle(0, 0, this.Width, this.Height),
                    0,
                    0,
                    this.BackgroundImage.Width,
                    this.BackgroundImage.Height,
                    System.Drawing.GraphicsUnit.Pixel);
            }
            base.OnPaint(e);

        }
    }
}
