using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.Communication;
using thinger.DataModels;
using thinger.MTHControlLib;

namespace thinger.MTHProject
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //导航按钮添加到集合，方便左右切换使用
            this.naviButtonList.Add(naviButton1);
            this.naviButtonList.Add(naviButton2);
            this.naviButtonList.Add(naviButton3);
            this.naviButtonList.Add(naviButton4);
            this.naviButtonList.Add(naviButton5);
            this.naviButtonList.Add(naviButton6);
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
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出？", "退出提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                //退出的话，需要做一些其他处理q
            }
            else
            {
                e.Cancel = true;// 取消退出
            }
        }


        #endregion

        #region 导航按钮切换界面  
        private void naviButton_Click(object sender, EventArgs e)
        {
            //if (sender is NaviButton)
            //{
            //    NaviButton btn =(NaviButton)sender;
            //}
            if (sender is NaviButton naviButton)//这行代码等同于上面的代码,is是判断不转换类型，as是直接转换成想要的类型
            {
                //根据当前被点击的导航按钮，得到要打开的窗体名称的枚举值
                FormNames formName = (FormNames)Enum.Parse(typeof(FormNames), naviButton.TitleName);//根据按钮的标题(TitleName)获取对应的枚举值，就是转换成枚举类型          
                //MessageBox.Show("要打开的窗体名称是：" + formNames.ToString());
                //根据窗体名称枚举，打开对应的窗体
                OpenForm(formName);
                //设置当前窗体在中间标签中的显示
                this.lblCurrectForm.Text = formName.ToString();
                //设置当前按钮为选中状态
                foreach (var item in this.top_Panel.Controls.OfType<NaviButton>())
                {
                    item.IsSelected = false;
                }
                naviButton.IsSelected = true;
            }
        }

        Form currentForm = null;//当前窗体对象
        public void OpenForm(FormNames formName)
        {
            int closeCount = 0;//关闭窗体的数量
            bool isFind = false;//是否找到当前要打开窗体

            //获取当前Panel容器中所有窗体的数量
            int total = this.mainPenalEx.Controls.Count;
            for (int i = 0; i < total; i++)
            {

                Control control = this.mainPenalEx.Controls[i - closeCount];
                if (control is Form form)
                {
                    //如果当前窗体是我们需要的窗体，显示到最前面即可
                    if (form.Text == formName.ToString())
                    {
                        form.BringToFront();
                        isFind = true;
                        break;
                    }
                    else//如果当前窗体不是我们需要的窗体，就关闭
                    {
                        FormNames name = (FormNames)Enum.Parse(typeof(FormNames), form.Text);
                        if (name > FormNames.临界窗体)
                        {
                            form.Close();
                            closeCount++;
                        }
                    }
                }
            }
            if (isFind == false)//下面打开新的窗体，并嵌入
            {
                switch (formName)
                {
                    case FormNames.集中监控:
                        currentForm = new FrmMonitor();
                        ModbusObjectTree.AddLogAction = ((FrmMonitor)currentForm).AddLog;//关联日志委托
                        break;
                    case FormNames.系统配置:
                        currentForm = new FrmParamSet();
                        break;
                    case FormNames.配方管理:
                        currentForm = new FrmRecipe();
                        break;
                    case FormNames.报警追溯:
                        currentForm = new FrmAlarmQuery();
                        break;
                    case FormNames.历史趋势:
                        currentForm = new FrmHistoryQuery();
                        break;
                    case FormNames.用户管理:
                        currentForm = new FrmUserManage();
                        break;
                    default:
                        break;
                }
                if (currentForm != null)
                {
                    //设置窗体嵌入的相关属性
                    currentForm.FormBorderStyle = FormBorderStyle.None;//无边框
                    currentForm.TopLevel = false;
                    currentForm.Dock = DockStyle.Fill;
                    currentForm.Parent = this.mainPenalEx;
                    currentForm.BringToFront();
                    currentForm.Show();
                }
            }
        }
        #endregion

        #region 导航左右切换按钮      
        //定义导航按钮集合
        public List<NaviButton> naviButtonList = new List<NaviButton>();
        //定义当前导航按钮对应的索引
        private int currentNaviIndex = 0;
        //下一个界面
        private void btnRightForm_Click(object sender, EventArgs e)
        {
            currentNaviIndex++;
            if (currentNaviIndex < naviButtonList.Count)
            {
                naviButton_Click(this.naviButtonList[currentNaviIndex], null);
            }
            else
            {
                currentNaviIndex--;
            }
        }
        //上一个界面
        private void btnLeftForm_Click(object sender, EventArgs e)
        {
            currentNaviIndex--;
            if (currentNaviIndex >= 0)
            {
                naviButton_Click(this.naviButtonList[currentNaviIndex], null);
            }
            else
            {
                currentNaviIndex++;
            }
        }
        #endregion

        #region 减少闪烁
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion

        //设备数据文件路径，通信组文件路径，变量表文件路径
        private string devicePath = Application.StartupPath + "\\Config\\Device.ini";
        private string groupPath = Application.StartupPath + "\\Config\\Group.xlsx";
        private string variablePath = Application.StartupPath + "\\Config\\Variable.xlsx";

        //实例化Modbus通信对象
        private ModbusCommunication mct = new ModbusCommunication();
        //令牌取消对象
        private CancellationTokenSource cts = null;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //默认打开【集中监控】界面
            naviButton_Click(this.naviButtonList[0], null);//naviButton_Click方法里的sender就是触发事件的对象，在这里就是集中监控按钮
            //加载设备对象信息（包括设备信息，通信组和变量表数据）
            try
            {
                ModbusObjectTree.Device = mct.LoadDevice(devicePath, groupPath, variablePath);
                if (ModbusObjectTree.Device != null)
                {
                    ModbusObjectTree.AddLogAction(0, "设备信息加载成功");
                    cts = new CancellationTokenSource();//每次加载都需要重新new一下，所以不能在创建对象的时候直接new
                }
                else
                {
                    ModbusObjectTree.AddLogAction(1, "设备信息加载失败，请检查配置文件");
                    return;
                }
            }
            catch (Exception ex)
            {
                ModbusObjectTree.AddLogAction(2, "对象树加载失败，错误原因" + ex.Message);
                return;
            }
            //开启多线程循环读取数据，并同时存储到变量集合中
            Task.Run(() =>
            {
                mct.PLCCommunication(ModbusObjectTree.Device, null, cts);
            }, cts.Token);



        }
    }
}
