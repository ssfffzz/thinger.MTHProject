using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using SeeSharpTools.JY.GUI;
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

            //设置listview第二列宽度=总宽度-第一列宽度-25
            this.lst_info.Columns[1].Width = this.lst_info.Width - this.lst_info.Columns[0].Width - 25;

            //定时器设置属性
            this.updateTimer.Interval = 500; //设置时间间隔为1秒
            this.updateTimer.Tick += UpdateTimer_Tick;
            this.updateTimer.Start(); //启动定时器

            SetChartProperties();
        }

        #region 定时器更新UI显示6组温湿度采集数据+日志记录列表
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
                SetYData();
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
                ListViewItem lst = new ListViewItem(" " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), index);
                lst.SubItems.Add(log);
                this.lst_info.Items.Add(lst);
                this.lst_info.Items[this.lst_info.Items.Count - 1].EnsureVisible();
            }
            else
            {
                this.lst_info.Invoke(new Action<int, string>(AddLog), index, log);
            }
        }
        #endregion

        #region 设置和显示实时曲线图
        //设置曲线控件相关属性
        public void SetChartProperties()
        {
            this.chartX.XDataType = StripChartX.XAxisDataType.TimeStamp;//X轴数据类型为时间戳
            this.chartX.TimeStampFormat = "HH:mm:ss";//时间戳格式为时分秒

            this.chartX.LegendVisible = true;//显示图例
            this.chartX.DisplayPoints = 20;//显示点数

            this.chartX.AxisY.Minimum = 0.0f;//X轴最小值
            this.chartX.AxisY.Maximum = 100.0f;//X轴最大值
            this.chartX.AxisY.AutoScale = false;//X轴自动缩放

            this.chartX.Series.Clear();//清除所有数据序列
            this.chartX.SeriesCount = 12;//设置数据序列数量为12
            //设置12条曲线相关属性
            for (int i = 0; i < 12; i++)
            {
                //设置曲线名称
                this.chartX.Series[i].Name = i % 2 == 0 ? $"模块{i / 2 + 1}温度" : $"模块{i / 2 + 1}湿度";
                this.chartX.Series[i].Visible = false;//初始化时设置曲线不可见
                this.chartX.Series[i].Width = StripChartXSeries.LineWidth.Middle;//设置曲线宽度为中等宽度

            }
            //默认选中第一组温湿度
            this.cbe_Temp1.Checked = true;
            this.cbe_Humidity1.Checked = true;
        }

        //复选框是否选中同步对应图像的显示
        private void Cbe_TempHum_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBoxEx cbe)
            {
                if (cbe.Tag != null && cbe.Tag.ToString().Length > 0)
                {
                    int index = Convert.ToInt32(cbe.Tag.ToString());
                    this.chartX.Series[index].Visible = cbe.Checked;//复选框的true或false赋值给曲线的使能
                }
            }
        }

        //设置Y轴数据
        private void SetYData()
        {
            //ModbusObjectTree.Device[item.TempV    arName]
            List<double> yData = new List<double>();
            for (int i = 1; i <= 6; i++)
            {
                yData.Add(Convert.ToDouble(ModbusObjectTree.Device[$"模块{i}温度"]?.ToString()));
                yData.Add(Convert.ToDouble(ModbusObjectTree.Device[$"模块{i}湿度"]?.ToString()));
            }
            if (this.chartX.Disposing)
            {
                this.chartX.PlotSingle(yData.ToArray());//把数据加入到图表
            }

        }

        #endregion


    }
}
