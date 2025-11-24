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
using thinger.MTHControlLib;
using thinger.ToolLib;

namespace thinger.MTHProject
{
    public partial class FrmParamSet : Form
    {
        public FrmParamSet(string devPath)
        {
            InitializeComponent();
            this.devPath = devPath;
            this.txtIP.Text = ModbusObjectTree.Device.IPAddress;
            this.txtPort.Text = ModbusObjectTree.Device.Port.ToString();
            this.txtSlaveId.Text = ModbusObjectTree.Device.SlaveId.ToString();
            BindEvnrt();
            GetLimitParamValue();
            GetAlarmParam();

            //设置定时器参数，并开启
            this.updateTimer.Interval = 200;
            this.updateTimer.Tick += UpdateTimer_Tick;
            this.updateTimer.Start();

            //窗体关闭时，同时关闭定时器
            this.FormClosing += (sender, e) =>
            {
                this.updateTimer.Stop();
            };
        }

        #region 确认设置按钮实现
        private string devPath = string.Empty;
        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            //写入参数到配置文件
            bool result = IniConfigHelper.WriteIniData("设备参数", "IP地址", this.txtIP.Text.Trim(), this.devPath);
            result &= IniConfigHelper.WriteIniData("设备参数", "端口号", this.txtPort.Text.Trim(), this.devPath);
            result &= IniConfigHelper.WriteIniData("设备参数", "站地址", this.txtSlaveId.Text.Trim(), this.devPath);

            if (result)
            {
                //把当前的通信信息立即更新
                ModbusObjectTree.Device.IPAddress = this.txtIP.Text.Trim();
                ModbusObjectTree.Device.Port = Convert.ToInt32(this.txtPort.Text.Trim());
                ModbusObjectTree.Device.SlaveId = Convert.ToByte(this.txtSlaveId.Text.Trim());
                DialogResult dialogResult = MessageBox.Show("通信参数保存成功，是否立即重连", "重连提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    ModbusObjectTree.Device.IsConnected = false;//标志位设置为false，多线程读取的时候会触发重连
                }
            }
        }
        #endregion

        #region 通信组配置和变量配置窗口显示
        private void btnGroupConfig_Click(object sender, EventArgs e)
        {
            FrmConfigGroup frmConfigGroup = new FrmConfigGroup();
            frmConfigGroup.ShowDialog();
        }

        private void btnVariableConfig_Click(object sender, EventArgs e)
        {
            new FrmConfigVariable().ShowDialog();
        }
        #endregion

        #region 绑定stateshow控件的双击事件和复选框事件
        private void BindEvnrt()
        {
            foreach (var item in this.MainPanel.Controls.OfType<StateShow>())
            {
                if (item.BindVarName != null && item.BindVarName.Length > 0)
                {
                    item.ControlDoubleClick += Common_ControlDoubleClick;
                }
            }
            foreach (var item in this.MainPanel.Controls.OfType<CheckBoxEx>())
            {
                if (item.Tag != null && item.Tag.ToString().Length > 0)
                {
                    item.CheckedChanged += Common_CheckedChanged;
                }
            }
        }

        // this.stateShow1.ControlDoubleClick += new System.EventHandler(this.stateShow1_ControlDoubleClick);
        private void Common_ControlDoubleClick(object sender, EventArgs e)
        {
            //as返回的是对象，is返回的是bool量
            StateShow stateShow = sender as StateShow;
            FrmParamModity frmParamModity = new FrmParamModity(stateShow.BindVarName, stateShow.CurrentValue);
            frmParamModity.ShowDialog();
        }
        //复选框改变，写入报警启用变量值
        private void Common_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBoxEx checkBox)
            {
                if (checkBox.Tag != null && checkBox.Tag.ToString().Length > 0)
                {
                    bool result = false;
                    try
                    {
                        result = ModbusObjectTree.CommonWrite(checkBox.Tag.ToString(), checkBox.Checked ? "1" : "0");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"硬件蜂鸣器报警是否启用状态更改失败: {ex.Message}", "报警提示");
                    }
                    finally
                    {
                        if (result == false)
                        {
                            checkBox.CheckedChanged -= Common_CheckedChanged;
                            checkBox.Checked = !checkBox.Checked;
                            checkBox.CheckedChanged += Common_CheckedChanged;
                        }
                    }
                }
            }
        }
        #endregion

        #region 绑定并设置参数设置值和报警是否启用
        private void GetLimitParamValue()
        {
            if (ModbusObjectTree.Device.IsConnected)
            {
                foreach (var item in this.MainPanel.Controls.OfType<StateShow>())
                {
                    if (item.BindVarName != null && item.BindVarName.Length > 0)
                    {
                        //获取当前要显示的值
                        string cValue = ModbusObjectTree.Device[item.BindVarName]?.ToString();
                        if (cValue?.Length == 2)
                        {
                            cValue += ".";
                            item.CurrentValue = cValue.PadRight(4, '0');
                        }
                        else
                        {
                            item.CurrentValue = cValue;
                        }
                    }
                    if (item.AlarmVarName != null && item.AlarmVarName.Length > 0)
                    {
                        item.IsAlarm = ModbusObjectTree.Device[item.AlarmVarName]?.ToString() == "True";
                    }

                }
            }
        }

        private Timer updateTimer = new Timer();
        // 定时器周期触发事件，用于更新参数值和报警状态
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (ModbusObjectTree.Device.IsConnected)
            {
                GetLimitParamValue();
            }
        }

        private void GetAlarmParam()
        {
            if (ModbusObjectTree.Device.IsConnected)
            {
                foreach (var item in this.MainPanel.Controls.OfType<CheckBoxEx>())
                {
                    if (item.Tag != null && item.Tag.ToString().Length > 0)
                    {
                        item.Checked = ModbusObjectTree.Device[item.Tag.ToString()]?.ToString() == "1";
                    }
                }
            }
        }


        #endregion
    }
}
