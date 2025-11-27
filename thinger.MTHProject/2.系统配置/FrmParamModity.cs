using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.Communication;

namespace thinger.MTHProject
{
    public partial class FrmParamModity : Form
    {
        /// <summary>
        /// 构造函数传参：传递变量名称和当前值
        /// </summary>
        /// <param name="varName">变量名称</param>
        /// <param name="currentValue">当前值</param>
        public FrmParamModity(string varName, string currentValue)
        {
            InitializeComponent();
            this.lbl_VarName.Text = varName;
            this.lbl_CurrentValue.Text = currentValue;
            this.txt_Value.Select();
        
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

        #region 窗体关闭
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmParamModity_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_Comfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string inputValue = this.txt_Value.Text.Trim();
                if (string.IsNullOrWhiteSpace(inputValue))
                {
                    MessageBox.Show("输入值不能为空", "输入错误");
                    return;
                }

                if (!double.TryParse(inputValue, out double numericValue))
                {
                    MessageBox.Show("请输入有效的数字", "输入错误");
                    return;
                }

                // 根据实际业务需求调整范围
                if (numericValue < 0 || numericValue > 100)

                {
                    MessageBox.Show("请输入0-100范围内的数值", "输入错误");
                    return;
                }
                bool result = ModbusObjectTree.CommonWrite(this.lbl_VarName.Text, inputValue);
                if (result)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"写入参数失败，异常信息：{ex.Message}", "写入失败");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txt_Value_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btn_Comfirm_Click(null,null);
            }
        }

       
    }
}
