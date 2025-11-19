using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniExcelLibs;
using thinger.Communication;
using thinger.DataConvertLib;
using thinger.EquipModel;
using thinger.ToolLib;

namespace thinger.MTHProject
{
    public partial class FrmConfigVariable : Form
    {
        public FrmConfigVariable()
        {
            InitializeComponent();
            //初始化数据类型下拉框
            this.cmb_DataType.DataSource = Enum.GetValues(typeof(DataType));
            //设置dgv不自动生成列
            this.dgv_VariableList.AutoGenerateColumns = false;
            //赋值变量表
            this.totalVariables = GetAllVariables();
            //刷新变量显示
            RefreshGroups();

            if (ModbusObjectTree.Device.GroupList!=null)
            {
                this.cmb_GroupName.Items.AddRange(ModbusObjectTree.Device.GroupList.ToArray());
            }

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

        #region 显示现有的变量列表       
        private List<ModbusVariable> totalVariables = null;
        private string vPath = null;
        private List<ModbusVariable> GetAllVariables()
        {
            vPath = Application.StartupPath + ConfigurationManager.AppSettings["vPath"].ToString();
            try
            {
                return MiniExcel.Query<ModbusVariable>(vPath).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("加载变量失败，错误原因：" + ex.Message, "错误提示");
                return new List<ModbusVariable>();
            }
        }
        private void RefreshGroups()
        {
            this.dgv_VariableList.DataSource = null;
            this.dgv_VariableList.DataSource = totalVariables;
        }
        //显示单元格行序号
        private void dgv_VariableList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewHelper.DgvRowPostPaint((DataGridView)sender, e);
        }

        //如果某一个单元格没有内容，则显示为“——”
        private void dgv_VariableList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                object value = this.dgv_VariableList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value == null || value?.ToString().Length == 0)
                {
                    e.Value = "——";
                }
            }
        }
        #endregion


    }
}
