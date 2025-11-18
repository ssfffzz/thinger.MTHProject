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
using thinger.EquipModel;
using thinger.ToolLib;

namespace thinger.MTHProject
{
    public partial class FrmConfigGroup : Form
    {
        public FrmConfigGroup()
        {
            InitializeComponent();
            //初始化存储区下拉框
            this.cmb_StoreArea.DataSource = new string[] { "输入线圈", "输出线圈", "输入寄存器", "输出寄存器" };
            //设置dgv不自动生成列
            this.dgv_GroupList.AutoGenerateColumns = false;
            //读取所有的通信组
            this.totalGroups = GetAllGroups();
            //刷新通信组的显示
            RefreshGroups();
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
        private void FrmConfigGroup_FormClosing(object sender, FormClosingEventArgs e)
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

        #region 显示现有的通信组列表       
        private List<ModbusGroup> totalGroups = null;
        private string gPath = null;
        private List<ModbusGroup> GetAllGroups()
        {
            gPath = Application.StartupPath + ConfigurationManager.AppSettings["groupPath"].ToString();
            try
            {
                return MiniExcel.Query<ModbusGroup>(gPath).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("加载通信组失败，错误原因：" + ex.Message, "错误提示");
                return new List<ModbusGroup>();
            }
        }
        private void RefreshGroups()
        {
            this.dgv_GroupList.DataSource = null;
            this.dgv_GroupList.DataSource = totalGroups;
        }

        private void dgv_GroupList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewHelper.DgvRowPostPaint((DataGridView)sender, e);
        }
        //如果某一个单元格没有内容，则显示为“——”
        private void dgv_GroupList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                object value = this.dgv_GroupList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value == null || value?.ToString().Length == 0)
                {
                    e.Value = "——";
                }
            }
        }
        #endregion

        private void dgv_GroupList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 声明ModbusGroup对象变量
            ModbusGroup modbusGroup = null;
            if (this.dgv_GroupList.CurrentRow != null)// 确保有选中的行
            {
                // 1. 获取当前选中行的GroupName列的值,获取当前选中行中"GroupName"列的值，并转换为字符串
                string groupName = this.dgv_GroupList.CurrentRow.Cells["GroupName"].Value.ToString();
                // 2. 在totalGroups集合中查找匹配的ModbusGroup对象
                modbusGroup = totalGroups.Find(c => c.GroupName == groupName);
                // 3. 如果找到了对应的ModbusGroup对象，则将其属性值显示在文本框和下拉框中
                if (modbusGroup != null)
                {
                    this.txt_GroupName.Text = modbusGroup.GroupName;
                    this.cmb_StoreArea.Text = modbusGroup.StoreArea;
                    this.num_Start.Text = modbusGroup.Start.ToString();
                    this.num_Length.Text = modbusGroup.Length.ToString();
                    this.txt_Remark.Text = modbusGroup.Remark;
                }
            }
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            if (this.dgv_GroupList.RowCount == 0)
            {
                MessageBox.Show("当前没有要修改的通信组", "修改提示");
                return;
            }
            if (!IsGroupNameExists(this.txt_GroupName.Text.Trim()))
            {
                MessageBox.Show("通信组名称不存在，请检查", "修改提示");
                return;
            }
            //找到当前通信组对象，并更新属性
            ModbusGroup modbusGroup = totalGroups.Find(c => c.GroupName == this.txt_GroupName.Text.Trim());
            modbusGroup.StoreArea = this.cmb_StoreArea.Text;
            modbusGroup.Start = (ushort)this.num_Start.Value;
            modbusGroup.Length = (ushort)this.num_Length.Value;
            modbusGroup.Remark = this.txt_Remark.Text.Trim();
            modbusGroup.GroupName = this.txt_GroupName.Text.Trim();
            //保存到Excel文件
            MiniExcel.SaveAs(gPath, totalGroups,overwriteFile:true);
            //刷新列表
            this.dgv_GroupList.Refresh();
        }

        private bool IsGroupNameExists(string groupName)
        {
            return totalGroups.FindAll(c => c.GroupName == groupName).Count > 0;
        }
    }
}
