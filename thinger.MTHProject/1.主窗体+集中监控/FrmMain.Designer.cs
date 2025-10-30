namespace thinger.MTHProject
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.top_Panel = new System.Windows.Forms.Panel();
            this.naviButton6 = new thinger.MTHControlLib.NaviButton();
            this.naviButton5 = new thinger.MTHControlLib.NaviButton();
            this.naviButton3 = new thinger.MTHControlLib.NaviButton();
            this.naviButton4 = new thinger.MTHControlLib.NaviButton();
            this.naviButton2 = new thinger.MTHControlLib.NaviButton();
            this.naviButton1 = new thinger.MTHControlLib.NaviButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRightForm = new System.Windows.Forms.Button();
            this.btnLeftForm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrectForm = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainPenalEx = new thinger.MTHControlLib.PanelEx();
            this.top_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_Panel
            // 
            this.top_Panel.BackColor = System.Drawing.Color.Transparent;
            this.top_Panel.Controls.Add(this.naviButton6);
            this.top_Panel.Controls.Add(this.naviButton5);
            this.top_Panel.Controls.Add(this.naviButton3);
            this.top_Panel.Controls.Add(this.naviButton4);
            this.top_Panel.Controls.Add(this.naviButton2);
            this.top_Panel.Controls.Add(this.naviButton1);
            this.top_Panel.Controls.Add(this.btnExit);
            this.top_Panel.Controls.Add(this.pictureBox1);
            this.top_Panel.Controls.Add(this.label2);
            this.top_Panel.Controls.Add(this.label1);
            this.top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_Panel.Location = new System.Drawing.Point(0, 0);
            this.top_Panel.Name = "top_Panel";
            this.top_Panel.Size = new System.Drawing.Size(1440, 133);
            this.top_Panel.TabIndex = 0;
            this.top_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.top_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // naviButton6
            // 
            this.naviButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton6.BackgroundImage")));
            this.naviButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.naviButton6.IsLeft = false;
            this.naviButton6.IsSelected = false;
            this.naviButton6.Location = new System.Drawing.Point(1233, 74);
            this.naviButton6.Name = "naviButton6";
            this.naviButton6.Size = new System.Drawing.Size(129, 43);
            this.naviButton6.TabIndex = 3;
            this.naviButton6.TitleName = "用户管理";
            this.naviButton6.Click += new System.EventHandler(this.naviButton_Click);
            // 
            // naviButton5
            // 
            this.naviButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton5.BackgroundImage")));
            this.naviButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.naviButton5.IsLeft = false;
            this.naviButton5.IsSelected = false;
            this.naviButton5.Location = new System.Drawing.Point(1098, 74);
            this.naviButton5.Name = "naviButton5";
            this.naviButton5.Size = new System.Drawing.Size(129, 43);
            this.naviButton5.TabIndex = 3;
            this.naviButton5.TitleName = "历史趋势";
            this.naviButton5.Click += new System.EventHandler(this.naviButton_Click);
            // 
            // naviButton3
            // 
            this.naviButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton3.BackgroundImage")));
            this.naviButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.naviButton3.IsLeft = true;
            this.naviButton3.IsSelected = false;
            this.naviButton3.Location = new System.Drawing.Point(348, 74);
            this.naviButton3.Name = "naviButton3";
            this.naviButton3.Size = new System.Drawing.Size(129, 43);
            this.naviButton3.TabIndex = 3;
            this.naviButton3.TitleName = "配方管理";
            this.naviButton3.Click += new System.EventHandler(this.naviButton_Click);
            // 
            // naviButton4
            // 
            this.naviButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton4.BackgroundImage")));
            this.naviButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.naviButton4.IsLeft = false;
            this.naviButton4.IsSelected = false;
            this.naviButton4.Location = new System.Drawing.Point(965, 74);
            this.naviButton4.Name = "naviButton4";
            this.naviButton4.Size = new System.Drawing.Size(129, 43);
            this.naviButton4.TabIndex = 3;
            this.naviButton4.TitleName = "报警追溯";
            this.naviButton4.Click += new System.EventHandler(this.naviButton_Click);
            // 
            // naviButton2
            // 
            this.naviButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton2.BackgroundImage")));
            this.naviButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.naviButton2.IsLeft = true;
            this.naviButton2.IsSelected = false;
            this.naviButton2.Location = new System.Drawing.Point(213, 74);
            this.naviButton2.Name = "naviButton2";
            this.naviButton2.Size = new System.Drawing.Size(129, 43);
            this.naviButton2.TabIndex = 3;
            this.naviButton2.TitleName = "系统配置";
            this.naviButton2.Click += new System.EventHandler(this.naviButton_Click);
            // 
            // naviButton1
            // 
            this.naviButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton1.BackgroundImage")));
            this.naviButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.naviButton1.IsLeft = true;
            this.naviButton1.IsSelected = false;
            this.naviButton1.Location = new System.Drawing.Point(80, 74);
            this.naviButton1.Name = "naviButton1";
            this.naviButton1.Size = new System.Drawing.Size(129, 43);
            this.naviButton1.TabIndex = 3;
            this.naviButton1.TitleName = "集中监控";
            this.naviButton1.Click += new System.EventHandler(this.naviButton_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::thinger.MTHProject.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(1322, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 41);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::thinger.MTHProject.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(33, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(504, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "多温湿度监控采集系统";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(74, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "THINGER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnRightForm);
            this.panel1.Controls.Add(this.btnLeftForm);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblCurrectForm);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 65);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::thinger.MTHProject.Properties.Resources.Alarm;
            this.panel2.Location = new System.Drawing.Point(914, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 43);
            this.panel2.TabIndex = 2;
            // 
            // btnRightForm
            // 
            this.btnRightForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRightForm.FlatAppearance.BorderSize = 0;
            this.btnRightForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRightForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRightForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightForm.Image = global::thinger.MTHProject.Properties.Resources.Right;
            this.btnRightForm.Location = new System.Drawing.Point(820, 16);
            this.btnRightForm.Name = "btnRightForm";
            this.btnRightForm.Size = new System.Drawing.Size(54, 40);
            this.btnRightForm.TabIndex = 1;
            this.btnRightForm.UseVisualStyleBackColor = true;
            this.btnRightForm.Click += new System.EventHandler(this.btnRightForm_Click);
            // 
            // btnLeftForm
            // 
            this.btnLeftForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeftForm.FlatAppearance.BorderSize = 0;
            this.btnLeftForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLeftForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLeftForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftForm.Image = global::thinger.MTHProject.Properties.Resources.Left;
            this.btnLeftForm.Location = new System.Drawing.Point(545, 16);
            this.btnLeftForm.Name = "btnLeftForm";
            this.btnLeftForm.Size = new System.Drawing.Size(53, 40);
            this.btnLeftForm.TabIndex = 1;
            this.btnLeftForm.UseVisualStyleBackColor = true;
            this.btnLeftForm.Click += new System.EventHandler(this.btnLeftForm_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1262, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "通信状态：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(130, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "欢迎登录";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrectForm
            // 
            this.lblCurrectForm.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrectForm.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrectForm.ForeColor = System.Drawing.Color.White;
            this.lblCurrectForm.Image = global::thinger.MTHProject.Properties.Resources.Current;
            this.lblCurrectForm.Location = new System.Drawing.Point(622, 11);
            this.lblCurrectForm.Name = "lblCurrectForm";
            this.lblCurrectForm.Size = new System.Drawing.Size(173, 50);
            this.lblCurrectForm.TabIndex = 0;
            this.lblCurrectForm.Text = "集中监控";
            this.lblCurrectForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(66, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Admin:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Image = global::thinger.MTHProject.Properties.Resources.User;
            this.label3.Location = new System.Drawing.Point(33, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 28);
            this.label3.TabIndex = 0;
            // 
            // mainPenalEx
            // 
            this.mainPenalEx.BackColor = System.Drawing.Color.Transparent;
            this.mainPenalEx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(86)))), ((int)(((byte)(160)))));
            this.mainPenalEx.BorderWidth = 3;
            this.mainPenalEx.BottomGap = 20;
            this.mainPenalEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPenalEx.LeftGap = 20;
            this.mainPenalEx.Location = new System.Drawing.Point(0, 198);
            this.mainPenalEx.Name = "mainPenalEx";
            this.mainPenalEx.Padding = new System.Windows.Forms.Padding(23);
            this.mainPenalEx.RightGap = 20;
            this.mainPenalEx.Size = new System.Drawing.Size(1440, 762);
            this.mainPenalEx.TabIndex = 2;
            this.mainPenalEx.TopGap = 20;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::thinger.MTHProject.Properties.Resources.Main;
            this.ClientSize = new System.Drawing.Size(1440, 960);
            this.Controls.Add(this.mainPenalEx);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MTH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.top_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_Panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLeftForm;
        private System.Windows.Forms.Button btnRightForm;
        private System.Windows.Forms.Label lblCurrectForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private MTHControlLib.NaviButton naviButton1;
        private MTHControlLib.NaviButton naviButton6;
        private MTHControlLib.NaviButton naviButton5;
        private MTHControlLib.NaviButton naviButton3;
        private MTHControlLib.NaviButton naviButton4;
        private MTHControlLib.NaviButton naviButton2;
        private MTHControlLib.PanelEx mainPenalEx;
    }
}

