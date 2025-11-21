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
        }

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

        private void btnGroupConfig_Click(object sender, EventArgs e)
        {
            FrmConfigGroup frmConfigGroup =new FrmConfigGroup();
            frmConfigGroup.ShowDialog();
        }

        private void btnVariableConfig_Click(object sender, EventArgs e)
        {
            new FrmConfigVariable().ShowDialog();
        }

        private void stateShow1_ControlDoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");
        }
    }
}
