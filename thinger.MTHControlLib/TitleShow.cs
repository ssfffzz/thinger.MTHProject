using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thinger.MTHControlLib
{
    public partial class TitleShow : UserControl
    {
        public TitleShow()
        {
            InitializeComponent();
        }

        //导航标题
        private string title = "标题名称";
        [Category("自定义控件")]
        [Description("获取或显示标题名称的文本")]
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                this.lblTitle.Text = title;
            }
        }

    }
}
