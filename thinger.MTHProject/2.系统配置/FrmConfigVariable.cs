using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thinger.MTHProject
{
    public partial class FrmConfigVariable : Form
    {
        public FrmConfigVariable()
        {
            InitializeComponent();
        }

        #region 无边框移动
        private Point mPoint;
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion

        #region 退出确认
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmConfigVariable_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出？", "退出提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                //退出的话，需要做一些其他处理
               
            }
            else
            {
                e.Cancel = true;// 取消退出
            }
        }


        #endregion
    }
}
