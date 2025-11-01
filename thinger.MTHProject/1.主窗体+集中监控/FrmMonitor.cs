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

namespace thinger.MTHProject
{
    public partial class FrmMonitor : Form
    {
        //创建定时器对象
        private Timer updateTimer = new Timer();
        public FrmMonitor()
        {
            InitializeComponent();
            this.updateTimer.Interval = 500; //设置时间间隔为1秒
            this.updateTimer.Tick += UpdateTimer_Tick;
            this.updateTimer.Start(); //启动定时器
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (ModbusObjectTree.Device == null)
            {
                return;
            }
            if (ModbusObjectTree.Device.IsConnected)
            {
                //遍历集中监控窗体里的panelEnhanced1里的所有DialPlateControl控件
                foreach (var item in this.panelEnhanced1.Controls.OfType<DialPlateControl>())
                {
                    if (ModbusObjectTree.Device[item.TempVarName] != null)
                    {
                        item.Temperature = Convert.ToSingle(ModbusObjectTree.Device[item.TempVarName]);
                    }
                    if (ModbusObjectTree.Device[item.HumitityVarName] != null)
                    {
                        item.Humidity = Convert.ToSingle(ModbusObjectTree.Device[item.HumitityVarName]);
                    }
                }
            }
        }

        public void AddLog(int index, string log)
        {
            if (!this.lst_info.InvokeRequired)
            {
                if (this.lst_info.Items.Count == 10)
                {
                    this.lst_info.Items.Clear();
                }
                ListViewItem lst = new ListViewItem(".." + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), index);
                lst.SubItems.Add(log);
                this.lst_info.Items.Add(lst);
                this.lst_info.Items[this.lst_info.Items.Count - 1].EnsureVisible();
            }
            else
            {
                this.lst_info.Invoke(new Action<int, string>(AddLog), index, log);
            }

        }

    }
}
