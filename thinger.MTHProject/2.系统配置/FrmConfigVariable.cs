using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
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
            if (ModbusObjectTree.Device.GroupList != null)
            {
                this.cmb_GroupName.Items.AddRange(ModbusObjectTree.Device.GroupList.ToArray());
                this.cmb_GroupName.DisplayMember = "GroupName";
                this.cmb_GroupName.ValueMember = "GroupName";
                this.cmb_GroupName.SelectedIndex = 0;
            }
            //刷新变量显示
            RefreshVariables();

            //通信组下拉框选择改变事件
            this.cmb_GroupName.SelectedIndexChanged += new System.EventHandler(this.cmb_GroupName_SelectedIndexChanged);
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

        //通信组下拉框选择改变事件
        private void cmb_GroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshVariables();
        }

        #region 单行选中dgv，并将其属性值显示在文本框和下拉框中
        /// <summary>
        /// 单行选中dgv，并将其属性值显示在文本框和下拉框中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_VariableList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 声明ModbusGroup对象变量
            ModbusVariable modbusVariable = null;
            if (this.dgv_VariableList.CurrentRow != null)// 确保有选中的行
            {
                // 1. 获取当前选中行的GroupName列的值,获取当前选中行中"GroupName"列的值，并转换为字符串
                string vName = this.dgv_VariableList.CurrentRow.Cells["VarName"].Value.ToString();
                // 2. 在totalGroups集合中查找匹配的ModbusGroup对象
                modbusVariable = totalVariables.Find(c => c.VarName == vName);
                // 3. 如果找到了对应的ModbusGroup对象，则将其属性值显示在文本框和下拉框中
                if (modbusVariable != null)
                {
                    this.txt_VariableName.Text = modbusVariable.VarName;
                    this.num_Start.Value = modbusVariable.Start;
                    this.num_OffsetOrLength.Value = modbusVariable.OffsetOrLength;
                    this.num_Scale.Value = (decimal)modbusVariable.Scale;
                    this.cmb_DataType.Text = modbusVariable.DataType;
                    this.num_Offset.Value = (decimal)modbusVariable.Offset;
                    this.chk_PosAlarm.Checked = modbusVariable.PosAlarm;
                    this.chk_NegAlarm.Checked = modbusVariable.NegAlarm;
                    this.txt_Remark.Text = modbusVariable.Remark;
                }
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

        private List<ModbusVariable> GetVariablesByGroupName(string groupName)
        {
            if (groupName == "")
            {
                return totalVariables;
            }
            else
            {
                return totalVariables.FindAll(x => x.GroupName == groupName);
            }

        }

        private void RefreshVariables()
        {
            List<ModbusVariable> list = GetVariablesByGroupName(this.cmb_GroupName.Text);
            this.dgv_VariableList.DataSource = null;
            if (list != null && list.Count > 0)
            {
                this.dgv_VariableList.DataSource = list;
            }

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
                if (e.ColumnIndex == 6 || e.ColumnIndex == 7)
                {
                    if (value != null)
                    {
                        e.Value = value.ToString() == "True" ? "启用" : "禁用";
                    }
                }
            }
        }

        #endregion

        //通信组是唯一标识，不能修改
        #region 修改变量
        private bool IsVariableNameExists(string vName)
        {
            //FindAll方法，该方法会返回所有满足条件的元素（即所有VariableName等于vName的ModbusVariable对象）的列表
            return totalVariables.FindAll(c => c.VarName == vName).Count > 0;
        }
        private void btn_Modify_Click(object sender, EventArgs e)
        {
            if (this.dgv_VariableList.RowCount == 0)
            {
                MessageBox.Show("当前没有要修改的变量", "修改提示");
                return;
            }
            if (!IsVariableNameExists(this.txt_VariableName.Text.Trim()))
            {
                MessageBox.Show("变量名称不存在，请检查", "修改提示");
                return;
            }
            DialogResult result = MessageBox.Show("确认修改变量吗？", "修改确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;

            //找到当前通信组对象，并更新属性
            ModbusVariable modbusVariable = totalVariables.Find(c => c.VarName == this.txt_VariableName.Text.Trim());
            modbusVariable.VarName = this.txt_VariableName.Text.Trim();
            modbusVariable.Start = (ushort)this.num_Start.Value;
            modbusVariable.OffsetOrLength = (ushort)this.num_OffsetOrLength.Value;//bool量的偏移量也是按长度来设置的
            modbusVariable.Scale = Convert.ToSingle(this.num_Scale.Value);
            modbusVariable.DataType = this.cmb_DataType.Text.Trim();
            modbusVariable.Offset = Convert.ToSingle(this.num_Offset.Text.Trim());
            modbusVariable.PosAlarm = this.chk_PosAlarm.Checked;
            modbusVariable.NegAlarm = this.chk_NegAlarm.Checked;
            modbusVariable.Remark = this.txt_Remark.Text.Trim();

            //保存到Excel文件
            MiniExcel.SaveAs(vPath, totalVariables, overwriteFile: true);
            //刷新列表
            this.dgv_VariableList.Refresh();
        }


        #endregion

        #region 删除变量
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (this.dgv_VariableList.RowCount == 0)//判断dgv中是否有数据
            {
                MessageBox.Show("当前没有要删除的变量", "删除提示");
                return;
            }
            //进一步从集合中判断通信是否存在
            string vName = this.dgv_VariableList.CurrentRow.Cells["VarName"].Value.ToString();
            if (!IsVariableNameExists(vName))
            {
                MessageBox.Show("当前变量名称不存在，请检查", "删除提示");
                return;
            }
            DialogResult result = MessageBox.Show("确认删除变量吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel) return;

            int deleteRowIndex = this.dgv_VariableList.CurrentRow.Index;
            //从集合中删除，并保存到excel表中
            this.totalVariables.RemoveAll(c => c.VarName == vName);           
            MiniExcel.SaveAs(vPath, totalVariables, overwriteFile: true);
            //刷新dgv列表
            RefreshVariables();
            if (this.dgv_VariableList.RowCount != 0)
            {
                //这行代码将DataGridView中索引为deleteRowIndex - 1的行设置为选中状态
                this.dgv_VariableList.Rows[deleteRowIndex - 1].Selected = true;
                //这行代码设置DataGridView的垂直滚动条的位置，使得索引为deleteRowIndex - 1的行成为第一个显示的行（即滚动到该行）
                this.dgv_VariableList.FirstDisplayedScrollingRowIndex = deleteRowIndex - 1;
                //这行代码将当前焦点设置到索引为deleteRowIndex - 1的行的第一个单元格（列索引为0）
                this.dgv_VariableList.CurrentCell = this.dgv_VariableList.Rows[deleteRowIndex - 1].Cells[0];
            }
        }
        #endregion

        #region 添加变量
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (IsVariableNameExists(this.txt_VariableName.Text.Trim()))
            {
                MessageBox.Show("当前变量名称已存在，请检查", "新增提示");
                return;
            }
         
            //更新到集合中
            this.totalVariables.Add(new ModbusVariable()
            {
                GroupName = this.cmb_GroupName.Text.Trim(),
                VarName = this.txt_VariableName.Text.Trim(),
                Start = Convert.ToUInt16( this.num_Start.Value),
                OffsetOrLength = Convert.ToInt32(this.num_OffsetOrLength.Value),
                Scale = Convert.ToSingle(this.num_Scale.Value),
                DataType = this.cmb_DataType.Text.Trim(),
                Offset = Convert.ToSingle(this.num_Offset.Value),
                PosAlarm = this.chk_PosAlarm.Checked,
                NegAlarm = this.chk_NegAlarm.Checked,
                Remark = this.txt_Remark.Text.Trim(),

            });
            //从excel表中删除(重新保存)
            MiniExcel.SaveAs(vPath, totalVariables, overwriteFile: true);
            //刷新dgv列表
            RefreshVariables();         
            //选中删除行的上一行
            this.dgv_VariableList.Rows[this.dgv_VariableList.Rows.Count - 1].Selected = true;
            this.dgv_VariableList.FirstDisplayedScrollingRowIndex = this.dgv_VariableList.Rows.Count - 1;
            this.dgv_VariableList.CurrentCell = this.dgv_VariableList.Rows[this.dgv_VariableList.Rows.Count - 1].Cells[0];
        }
        #endregion
    }
}
