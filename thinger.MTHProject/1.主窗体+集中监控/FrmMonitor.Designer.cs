namespace thinger.MTHProject
{
    partial class FrmMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonitor));
            SeeSharpTools.JY.GUI.StripChartXSeries stripChartXSeries1 = new SeeSharpTools.JY.GUI.StripChartXSeries();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelEnhanced1 = new thinger.MTHControlLib.PanelEnhanced();
            this.lst_info = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dialPlateControl2 = new thinger.MTHControlLib.DialPlateControl();
            this.checkBoxEx9 = new thinger.MTHControlLib.CheckBoxEx();
            this.dialPlateControl1 = new thinger.MTHControlLib.DialPlateControl();
            this.checkBoxEx10 = new thinger.MTHControlLib.CheckBoxEx();
            this.dialPlateControl3 = new thinger.MTHControlLib.DialPlateControl();
            this.checkBoxEx11 = new thinger.MTHControlLib.CheckBoxEx();
            this.dialPlateControl4 = new thinger.MTHControlLib.DialPlateControl();
            this.checkBoxEx12 = new thinger.MTHControlLib.CheckBoxEx();
            this.dialPlateControl5 = new thinger.MTHControlLib.DialPlateControl();
            this.checkBoxEx5 = new thinger.MTHControlLib.CheckBoxEx();
            this.dialPlateControl6 = new thinger.MTHControlLib.DialPlateControl();
            this.checkBoxEx6 = new thinger.MTHControlLib.CheckBoxEx();
            this.titleShow1 = new thinger.MTHControlLib.TitleShow();
            this.checkBoxEx7 = new thinger.MTHControlLib.CheckBoxEx();
            this.titleShow2 = new thinger.MTHControlLib.TitleShow();
            this.checkBoxEx8 = new thinger.MTHControlLib.CheckBoxEx();
            this.checkBoxEx1 = new thinger.MTHControlLib.CheckBoxEx();
            this.checkBoxEx2 = new thinger.MTHControlLib.CheckBoxEx();
            this.checkBoxEx4 = new thinger.MTHControlLib.CheckBoxEx();
            this.checkBoxEx3 = new thinger.MTHControlLib.CheckBoxEx();
            this.stripChartX1 = new SeeSharpTools.JY.GUI.StripChartX();
            this.panelEnhanced1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "info.png");
            this.imageList1.Images.SetKeyName(1, "warning.png");
            this.imageList1.Images.SetKeyName(2, "error.png");
            // 
            // panelEnhanced1
            // 
            this.panelEnhanced1.BackgroundImage = global::thinger.MTHProject.Properties.Resources.BackGround;
            this.panelEnhanced1.Controls.Add(this.stripChartX1);
            this.panelEnhanced1.Controls.Add(this.lst_info);
            this.panelEnhanced1.Controls.Add(this.dialPlateControl2);
            this.panelEnhanced1.Controls.Add(this.checkBoxEx9);
            this.panelEnhanced1.Controls.Add(this.dialPlateControl1);
            this.panelEnhanced1.Controls.Add(this.checkBoxEx10);
            this.panelEnhanced1.Controls.Add(this.dialPlateControl3);
            this.panelEnhanced1.Controls.Add(this.checkBoxEx11);
            this.panelEnhanced1.Controls.Add(this.dialPlateControl4);
            this.panelEnhanced1.Controls.Add(this.checkBoxEx12);
            this.panelEnhanced1.Controls.Add(this.dialPlateControl5);
            this.panelEnhanced1.Controls.Add(this.checkBoxEx5);
            this.panelEnhanced1.Controls.Add(this.dialPlateControl6);
            this.panelEnhanced1.Controls.Add(this.checkBoxEx6);
            this.panelEnhanced1.Controls.Add(this.titleShow1);
            this.panelEnhanced1.Controls.Add(this.checkBoxEx7);
            this.panelEnhanced1.Controls.Add(this.titleShow2);
            this.panelEnhanced1.Controls.Add(this.checkBoxEx8);
            this.panelEnhanced1.Controls.Add(this.checkBoxEx1);
            this.panelEnhanced1.Controls.Add(this.checkBoxEx2);
            this.panelEnhanced1.Controls.Add(this.checkBoxEx4);
            this.panelEnhanced1.Controls.Add(this.checkBoxEx3);
            this.panelEnhanced1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEnhanced1.Location = new System.Drawing.Point(0, 0);
            this.panelEnhanced1.Name = "panelEnhanced1";
            this.panelEnhanced1.Size = new System.Drawing.Size(1394, 716);
            this.panelEnhanced1.TabIndex = 14;
            // 
            // lst_info
            // 
            this.lst_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lst_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lst_info.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lst_info.ForeColor = System.Drawing.Color.White;
            this.lst_info.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lst_info.HideSelection = false;
            this.lst_info.Location = new System.Drawing.Point(789, 540);
            this.lst_info.Name = "lst_info";
            this.lst_info.ShowItemToolTips = true;
            this.lst_info.Size = new System.Drawing.Size(575, 166);
            this.lst_info.SmallImageList = this.imageList1;
            this.lst_info.TabIndex = 13;
            this.lst_info.UseCompatibleStateImageBehavior = false;
            this.lst_info.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "日志时间";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "日志内容";
            this.columnHeader2.Width = 260;
            // 
            // dialPlateControl2
            // 
            this.dialPlateControl2.BackColor = System.Drawing.Color.Transparent;
            this.dialPlateControl2.Humidity = 0F;
            this.dialPlateControl2.HumitityVarName = "模块2湿度";
            this.dialPlateControl2.Location = new System.Drawing.Point(411, 12);
            this.dialPlateControl2.ModuleError = false;
            this.dialPlateControl2.Name = "dialPlateControl2";
            this.dialPlateControl2.Size = new System.Drawing.Size(358, 226);
            this.dialPlateControl2.StateVarName = "";
            this.dialPlateControl2.TabIndex = 1;
            this.dialPlateControl2.Temperature = 0F;
            this.dialPlateControl2.TempVarName = "模块2温度";
            this.dialPlateControl2.TitleName = "2#站点";
            // 
            // checkBoxEx9
            // 
            this.checkBoxEx9.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEx9.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEx9.CkbWidth = 20;
            this.checkBoxEx9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxEx9.ForeColor = System.Drawing.Color.White;
            this.checkBoxEx9.Location = new System.Drawing.Point(1243, 363);
            this.checkBoxEx9.Name = "checkBoxEx9";
            this.checkBoxEx9.Size = new System.Drawing.Size(119, 29);
            this.checkBoxEx9.TabIndex = 9;
            this.checkBoxEx9.Text = "模块2湿度";
            this.checkBoxEx9.UseVisualStyleBackColor = false;
            // 
            // dialPlateControl1
            // 
            this.dialPlateControl1.BackColor = System.Drawing.Color.Transparent;
            this.dialPlateControl1.Humidity = 0F;
            this.dialPlateControl1.HumitityVarName = "模块1湿度";
            this.dialPlateControl1.Location = new System.Drawing.Point(12, 12);
            this.dialPlateControl1.ModuleError = false;
            this.dialPlateControl1.Name = "dialPlateControl1";
            this.dialPlateControl1.Size = new System.Drawing.Size(358, 226);
            this.dialPlateControl1.StateVarName = "";
            this.dialPlateControl1.TabIndex = 1;
            this.dialPlateControl1.Temperature = 0F;
            this.dialPlateControl1.TempVarName = "模块1温度";
            this.dialPlateControl1.TitleName = "1#站点";
            // 
            // checkBoxEx10
            // 
            this.checkBoxEx10.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEx10.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEx10.CkbWidth = 20;
            this.checkBoxEx10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxEx10.ForeColor = System.Drawing.Color.White;
            this.checkBoxEx10.Location = new System.Drawing.Point(1093, 363);
            this.checkBoxEx10.Name = "checkBoxEx10";
            this.checkBoxEx10.Size = new System.Drawing.Size(119, 29);
            this.checkBoxEx10.TabIndex = 10;
            this.checkBoxEx10.Text = "模块2温度";
            this.checkBoxEx10.UseVisualStyleBackColor = false;
            // 
            // dialPlateControl3
            // 
            this.dialPlateControl3.BackColor = System.Drawing.Color.Transparent;
            this.dialPlateControl3.Humidity = 0F;
            this.dialPlateControl3.HumitityVarName = "模块3湿度";
            this.dialPlateControl3.Location = new System.Drawing.Point(12, 245);
            this.dialPlateControl3.ModuleError = false;
            this.dialPlateControl3.Name = "dialPlateControl3";
            this.dialPlateControl3.Size = new System.Drawing.Size(358, 226);
            this.dialPlateControl3.StateVarName = "";
            this.dialPlateControl3.TabIndex = 1;
            this.dialPlateControl3.Temperature = 0F;
            this.dialPlateControl3.TempVarName = "模块3温度";
            this.dialPlateControl3.TitleName = "3#站点";
            // 
            // checkBoxEx11
            // 
            this.checkBoxEx11.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEx11.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEx11.CkbWidth = 20;
            this.checkBoxEx11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxEx11.ForeColor = System.Drawing.Color.White;
            this.checkBoxEx11.Location = new System.Drawing.Point(943, 363);
            this.checkBoxEx11.Name = "checkBoxEx11";
            this.checkBoxEx11.Size = new System.Drawing.Size(119, 29);
            this.checkBoxEx11.TabIndex = 11;
            this.checkBoxEx11.Text = "模块1湿度";
            this.checkBoxEx11.UseVisualStyleBackColor = false;
            // 
            // dialPlateControl4
            // 
            this.dialPlateControl4.BackColor = System.Drawing.Color.Transparent;
            this.dialPlateControl4.Humidity = 0F;
            this.dialPlateControl4.HumitityVarName = "模块4湿度";
            this.dialPlateControl4.Location = new System.Drawing.Point(411, 245);
            this.dialPlateControl4.ModuleError = false;
            this.dialPlateControl4.Name = "dialPlateControl4";
            this.dialPlateControl4.Size = new System.Drawing.Size(358, 226);
            this.dialPlateControl4.StateVarName = "";
            this.dialPlateControl4.TabIndex = 1;
            this.dialPlateControl4.Temperature = 0F;
            this.dialPlateControl4.TempVarName = "模块4温度";
            this.dialPlateControl4.TitleName = "4#站点";
            // 
            // checkBoxEx12
            // 
            this.checkBoxEx12.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEx12.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEx12.CkbWidth = 20;
            this.checkBoxEx12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxEx12.ForeColor = System.Drawing.Color.White;
            this.checkBoxEx12.Location = new System.Drawing.Point(793, 363);
            this.checkBoxEx12.Name = "checkBoxEx12";
            this.checkBoxEx12.Size = new System.Drawing.Size(119, 29);
            this.checkBoxEx12.TabIndex = 12;
            this.checkBoxEx12.Text = "模块1温度";
            this.checkBoxEx12.UseVisualStyleBackColor = false;
            // 
            // dialPlateControl5
            // 
            this.dialPlateControl5.BackColor = System.Drawing.Color.Transparent;
            this.dialPlateControl5.Humidity = 0F;
            this.dialPlateControl5.HumitityVarName = "模块5湿度";
            this.dialPlateControl5.Location = new System.Drawing.Point(12, 480);
            this.dialPlateControl5.ModuleError = false;
            this.dialPlateControl5.Name = "dialPlateControl5";
            this.dialPlateControl5.Size = new System.Drawing.Size(358, 226);
            this.dialPlateControl5.StateVarName = "";
            this.dialPlateControl5.TabIndex = 1;
            this.dialPlateControl5.Temperature = 0F;
            this.dialPlateControl5.TempVarName = "模块5温度";
            this.dialPlateControl5.TitleName = "5#站点";
            // 
            // checkBoxEx5
            // 
            this.checkBoxEx5.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEx5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEx5.CkbWidth = 20;
            this.checkBoxEx5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxEx5.ForeColor = System.Drawing.Color.White;
            this.checkBoxEx5.Location = new System.Drawing.Point(1243, 408);
            this.checkBoxEx5.Name = "checkBoxEx5";
            this.checkBoxEx5.Size = new System.Drawing.Size(119, 29);
            this.checkBoxEx5.TabIndex = 5;
            this.checkBoxEx5.Text = "模块4湿度";
            this.checkBoxEx5.UseVisualStyleBackColor = false;
            // 
            // dialPlateControl6
            // 
            this.dialPlateControl6.BackColor = System.Drawing.Color.Transparent;
            this.dialPlateControl6.Humidity = 0F;
            this.dialPlateControl6.HumitityVarName = "模块6湿度";
            this.dialPlateControl6.Location = new System.Drawing.Point(411, 480);
            this.dialPlateControl6.ModuleError = false;
            this.dialPlateControl6.Name = "dialPlateControl6";
            this.dialPlateControl6.Size = new System.Drawing.Size(358, 226);
            this.dialPlateControl6.StateVarName = "";
            this.dialPlateControl6.TabIndex = 1;
            this.dialPlateControl6.Temperature = 0F;
            this.dialPlateControl6.TempVarName = "模块6温度";
            this.dialPlateControl6.TitleName = "6#站点";
            // 
            // checkBoxEx6
            // 
            this.checkBoxEx6.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEx6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEx6.CkbWidth = 20;
            this.checkBoxEx6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxEx6.ForeColor = System.Drawing.Color.White;
            this.checkBoxEx6.Location = new System.Drawing.Point(1093, 408);
            this.checkBoxEx6.Name = "checkBoxEx6";
            this.checkBoxEx6.Size = new System.Drawing.Size(119, 29);
            this.checkBoxEx6.TabIndex = 6;
            this.checkBoxEx6.Text = "模块4温度";
            this.checkBoxEx6.UseVisualStyleBackColor = false;
            // 
            // titleShow1
            // 
            this.titleShow1.BackColor = System.Drawing.Color.Transparent;
            this.titleShow1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titleShow1.BackgroundImage")));
            this.titleShow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.titleShow1.Location = new System.Drawing.Point(789, 12);
            this.titleShow1.Name = "titleShow1";
            this.titleShow1.Size = new System.Drawing.Size(110, 31);
            this.titleShow1.TabIndex = 2;
            this.titleShow1.Title = "实时趋势";
            // 
            // checkBoxEx7
            // 
            this.checkBoxEx7.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEx7.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEx7.CkbWidth = 20;
            this.checkBoxEx7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxEx7.ForeColor = System.Drawing.Color.White;
            this.checkBoxEx7.Location = new System.Drawing.Point(943, 408);
            this.checkBoxEx7.Name = "checkBoxEx7";
            this.checkBoxEx7.Size = new System.Drawing.Size(119, 29);
            this.checkBoxEx7.TabIndex = 7;
            this.checkBoxEx7.Text = "模块3湿度";
            this.checkBoxEx7.UseVisualStyleBackColor = false;
            // 
            // titleShow2
            // 
            this.titleShow2.BackColor = System.Drawing.Color.Transparent;
            this.titleShow2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titleShow2.BackgroundImage")));
            this.titleShow2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.titleShow2.Location = new System.Drawing.Point(789, 503);
            this.titleShow2.Name = "titleShow2";
            this.titleShow2.Size = new System.Drawing.Size(110, 31);
            this.titleShow2.TabIndex = 2;
            this.titleShow2.Title = "历史监控";
            // 
            // checkBoxEx8
            // 
            this.checkBoxEx8.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEx8.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEx8.CkbWidth = 20;
            this.checkBoxEx8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxEx8.ForeColor = System.Drawing.Color.White;
            this.checkBoxEx8.Location = new System.Drawing.Point(793, 408);
            this.checkBoxEx8.Name = "checkBoxEx8";
            this.checkBoxEx8.Size = new System.Drawing.Size(119, 29);
            this.checkBoxEx8.TabIndex = 8;
            this.checkBoxEx8.Text = "模块3温度";
            this.checkBoxEx8.UseVisualStyleBackColor = false;
            // 
            // checkBoxEx1
            // 
            this.checkBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEx1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEx1.CkbWidth = 20;
            this.checkBoxEx1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxEx1.ForeColor = System.Drawing.Color.White;
            this.checkBoxEx1.Location = new System.Drawing.Point(793, 457);
            this.checkBoxEx1.Name = "checkBoxEx1";
            this.checkBoxEx1.Size = new System.Drawing.Size(119, 29);
            this.checkBoxEx1.TabIndex = 3;
            this.checkBoxEx1.Text = "模块5温度";
            this.checkBoxEx1.UseVisualStyleBackColor = false;
            // 
            // checkBoxEx2
            // 
            this.checkBoxEx2.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEx2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEx2.CkbWidth = 20;
            this.checkBoxEx2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxEx2.ForeColor = System.Drawing.Color.White;
            this.checkBoxEx2.Location = new System.Drawing.Point(943, 457);
            this.checkBoxEx2.Name = "checkBoxEx2";
            this.checkBoxEx2.Size = new System.Drawing.Size(119, 29);
            this.checkBoxEx2.TabIndex = 3;
            this.checkBoxEx2.Text = "模块5湿度";
            this.checkBoxEx2.UseVisualStyleBackColor = false;
            // 
            // checkBoxEx4
            // 
            this.checkBoxEx4.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEx4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEx4.CkbWidth = 20;
            this.checkBoxEx4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxEx4.ForeColor = System.Drawing.Color.White;
            this.checkBoxEx4.Location = new System.Drawing.Point(1243, 457);
            this.checkBoxEx4.Name = "checkBoxEx4";
            this.checkBoxEx4.Size = new System.Drawing.Size(119, 29);
            this.checkBoxEx4.TabIndex = 3;
            this.checkBoxEx4.Text = "模块6湿度";
            this.checkBoxEx4.UseVisualStyleBackColor = false;
            // 
            // checkBoxEx3
            // 
            this.checkBoxEx3.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEx3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEx3.CkbWidth = 20;
            this.checkBoxEx3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxEx3.ForeColor = System.Drawing.Color.White;
            this.checkBoxEx3.Location = new System.Drawing.Point(1093, 457);
            this.checkBoxEx3.Name = "checkBoxEx3";
            this.checkBoxEx3.Size = new System.Drawing.Size(119, 29);
            this.checkBoxEx3.TabIndex = 3;
            this.checkBoxEx3.Text = "模块6温度";
            this.checkBoxEx3.UseVisualStyleBackColor = false;
            // 
            // stripChartX1
            // 
            this.stripChartX1.AxisX.AutoScale = false;
            this.stripChartX1.AxisX.AutoZoomReset = false;
            this.stripChartX1.AxisX.Color = System.Drawing.Color.White;
            this.stripChartX1.AxisX.InitWithScaleView = false;
            this.stripChartX1.AxisX.IsLogarithmic = false;
            this.stripChartX1.AxisX.LabelAngle = 0;
            this.stripChartX1.AxisX.LabelEnabled = true;
            this.stripChartX1.AxisX.LabelFormat = null;
            this.stripChartX1.AxisX.MajorGridColor = System.Drawing.Color.White;
            this.stripChartX1.AxisX.MajorGridCount = 6;
            this.stripChartX1.AxisX.MajorGridEnabled = true;
            this.stripChartX1.AxisX.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.stripChartX1.AxisX.Maximum = 1000D;
            this.stripChartX1.AxisX.Minimum = 0D;
            this.stripChartX1.AxisX.MinorGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stripChartX1.AxisX.MinorGridEnabled = false;
            this.stripChartX1.AxisX.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.stripChartX1.AxisX.TickWidth = 1F;
            this.stripChartX1.AxisX.Title = "";
            this.stripChartX1.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.stripChartX1.AxisX.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.stripChartX1.AxisX.ViewMaximum = 1000D;
            this.stripChartX1.AxisX.ViewMinimum = 0D;
            this.stripChartX1.AxisX2.AutoScale = false;
            this.stripChartX1.AxisX2.AutoZoomReset = false;
            this.stripChartX1.AxisX2.Color = System.Drawing.Color.Black;
            this.stripChartX1.AxisX2.InitWithScaleView = false;
            this.stripChartX1.AxisX2.IsLogarithmic = false;
            this.stripChartX1.AxisX2.LabelAngle = 0;
            this.stripChartX1.AxisX2.LabelEnabled = true;
            this.stripChartX1.AxisX2.LabelFormat = null;
            this.stripChartX1.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.stripChartX1.AxisX2.MajorGridCount = 6;
            this.stripChartX1.AxisX2.MajorGridEnabled = true;
            this.stripChartX1.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.stripChartX1.AxisX2.Maximum = 1000D;
            this.stripChartX1.AxisX2.Minimum = 0D;
            this.stripChartX1.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.stripChartX1.AxisX2.MinorGridEnabled = false;
            this.stripChartX1.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.stripChartX1.AxisX2.TickWidth = 1F;
            this.stripChartX1.AxisX2.Title = "";
            this.stripChartX1.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.stripChartX1.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.stripChartX1.AxisX2.ViewMaximum = 1000D;
            this.stripChartX1.AxisX2.ViewMinimum = 0D;
            this.stripChartX1.AxisY.AutoScale = true;
            this.stripChartX1.AxisY.AutoZoomReset = false;
            this.stripChartX1.AxisY.Color = System.Drawing.Color.White;
            this.stripChartX1.AxisY.InitWithScaleView = false;
            this.stripChartX1.AxisY.IsLogarithmic = false;
            this.stripChartX1.AxisY.LabelAngle = 0;
            this.stripChartX1.AxisY.LabelEnabled = true;
            this.stripChartX1.AxisY.LabelFormat = null;
            this.stripChartX1.AxisY.MajorGridColor = System.Drawing.Color.White;
            this.stripChartX1.AxisY.MajorGridCount = 6;
            this.stripChartX1.AxisY.MajorGridEnabled = true;
            this.stripChartX1.AxisY.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.stripChartX1.AxisY.Maximum = 3.5D;
            this.stripChartX1.AxisY.Minimum = 0.5D;
            this.stripChartX1.AxisY.MinorGridColor = System.Drawing.Color.Black;
            this.stripChartX1.AxisY.MinorGridEnabled = false;
            this.stripChartX1.AxisY.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.stripChartX1.AxisY.TickWidth = 1F;
            this.stripChartX1.AxisY.Title = "";
            this.stripChartX1.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.stripChartX1.AxisY.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.stripChartX1.AxisY.ViewMaximum = 3.5D;
            this.stripChartX1.AxisY.ViewMinimum = 0.5D;
            this.stripChartX1.AxisY2.AutoScale = true;
            this.stripChartX1.AxisY2.AutoZoomReset = false;
            this.stripChartX1.AxisY2.Color = System.Drawing.Color.Black;
            this.stripChartX1.AxisY2.InitWithScaleView = false;
            this.stripChartX1.AxisY2.IsLogarithmic = false;
            this.stripChartX1.AxisY2.LabelAngle = 0;
            this.stripChartX1.AxisY2.LabelEnabled = true;
            this.stripChartX1.AxisY2.LabelFormat = null;
            this.stripChartX1.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.stripChartX1.AxisY2.MajorGridCount = 6;
            this.stripChartX1.AxisY2.MajorGridEnabled = true;
            this.stripChartX1.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.stripChartX1.AxisY2.Maximum = 3.5D;
            this.stripChartX1.AxisY2.Minimum = 0.5D;
            this.stripChartX1.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.stripChartX1.AxisY2.MinorGridEnabled = false;
            this.stripChartX1.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.stripChartX1.AxisY2.TickWidth = 1F;
            this.stripChartX1.AxisY2.Title = "";
            this.stripChartX1.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.stripChartX1.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.stripChartX1.AxisY2.ViewMaximum = 3.5D;
            this.stripChartX1.AxisY2.ViewMinimum = 0.5D;
            this.stripChartX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.stripChartX1.ChartAreaBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.stripChartX1.Direction = SeeSharpTools.JY.GUI.StripChartX.ScrollDirection.LeftToRight;
            this.stripChartX1.DisplayPoints = 4000;
            this.stripChartX1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stripChartX1.ForeColor = System.Drawing.Color.White;
            this.stripChartX1.GradientStyle = SeeSharpTools.JY.GUI.StripChartX.ChartGradientStyle.None;
            this.stripChartX1.LegendBackColor = System.Drawing.Color.Transparent;
            this.stripChartX1.LegendFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stripChartX1.LegendForeColor = System.Drawing.Color.White;
            this.stripChartX1.LegendVisible = true;
            stripChartXSeries1.Color = System.Drawing.Color.Red;
            stripChartXSeries1.Marker = SeeSharpTools.JY.GUI.StripChartXSeries.MarkerType.None;
            stripChartXSeries1.Name = "Series1";
            stripChartXSeries1.Type = SeeSharpTools.JY.GUI.StripChartXSeries.LineType.FastLine;
            stripChartXSeries1.Visible = true;
            stripChartXSeries1.Width = SeeSharpTools.JY.GUI.StripChartXSeries.LineWidth.Thin;
            stripChartXSeries1.XPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            stripChartXSeries1.YPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            this.stripChartX1.LineSeries.Add(stripChartXSeries1);
            this.stripChartX1.Location = new System.Drawing.Point(789, 50);
            this.stripChartX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stripChartX1.Miscellaneous.CheckInfinity = false;
            this.stripChartX1.Miscellaneous.CheckNaN = false;
            this.stripChartX1.Miscellaneous.CheckNegtiveOrZero = false;
            this.stripChartX1.Miscellaneous.DirectionChartCount = 3;
            this.stripChartX1.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.StripChartX.FitType.Range;
            this.stripChartX1.Miscellaneous.MaxSeriesCount = 32;
            this.stripChartX1.Miscellaneous.MaxSeriesPointCount = 4000;
            this.stripChartX1.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.stripChartX1.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.StripChartXUtility.LayoutDirection.LeftToRight;
            this.stripChartX1.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.stripChartX1.Miscellaneous.SplitViewAutoLayout = true;
            this.stripChartX1.Name = "stripChartX1";
            this.stripChartX1.NextTimeStamp = new System.DateTime(((long)(0)));
            this.stripChartX1.ScrollType = SeeSharpTools.JY.GUI.StripChartX.StripScrollType.Cumulation;
            this.stripChartX1.SeriesCount = 1;
            this.stripChartX1.Size = new System.Drawing.Size(575, 306);
            this.stripChartX1.SplitView = false;
            this.stripChartX1.StartIndex = 0;
            this.stripChartX1.TabIndex = 14;
            this.stripChartX1.TimeInterval = System.TimeSpan.Parse("00:00:00");
            this.stripChartX1.TimeStampFormat = null;
            this.stripChartX1.XCursor.AutoInterval = true;
            this.stripChartX1.XCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.stripChartX1.XCursor.Interval = 0.001D;
            this.stripChartX1.XCursor.Mode = SeeSharpTools.JY.GUI.StripChartXCursor.CursorMode.Zoom;
            this.stripChartX1.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.stripChartX1.XCursor.Value = double.NaN;
            this.stripChartX1.XDataType = SeeSharpTools.JY.GUI.StripChartX.XAxisDataType.Index;
            this.stripChartX1.YCursor.AutoInterval = true;
            this.stripChartX1.YCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.stripChartX1.YCursor.Interval = 0.001D;
            this.stripChartX1.YCursor.Mode = SeeSharpTools.JY.GUI.StripChartXCursor.CursorMode.Disabled;
            this.stripChartX1.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.stripChartX1.YCursor.Value = double.NaN;
            // 
            // FrmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1394, 716);
            this.Controls.Add(this.panelEnhanced1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMonitor";
            this.Text = "集中监控";
            this.panelEnhanced1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MTHControlLib.DialPlateControl dialPlateControl1;
        private MTHControlLib.DialPlateControl dialPlateControl2;
        private MTHControlLib.DialPlateControl dialPlateControl3;
        private MTHControlLib.DialPlateControl dialPlateControl4;
        private MTHControlLib.DialPlateControl dialPlateControl5;
        private MTHControlLib.DialPlateControl dialPlateControl6;
        private MTHControlLib.TitleShow titleShow1;
        private MTHControlLib.TitleShow titleShow2;
        private MTHControlLib.CheckBoxEx checkBoxEx1;
        private MTHControlLib.CheckBoxEx checkBoxEx2;
        private MTHControlLib.CheckBoxEx checkBoxEx3;
        private MTHControlLib.CheckBoxEx checkBoxEx4;
        private MTHControlLib.CheckBoxEx checkBoxEx5;
        private MTHControlLib.CheckBoxEx checkBoxEx6;
        private MTHControlLib.CheckBoxEx checkBoxEx7;
        private MTHControlLib.CheckBoxEx checkBoxEx8;
        private MTHControlLib.CheckBoxEx checkBoxEx9;
        private MTHControlLib.CheckBoxEx checkBoxEx10;
        private MTHControlLib.CheckBoxEx checkBoxEx11;
        private MTHControlLib.CheckBoxEx checkBoxEx12;
        private System.Windows.Forms.ListView lst_info;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList imageList1;
        private MTHControlLib.PanelEnhanced panelEnhanced1;
        private SeeSharpTools.JY.GUI.StripChartX stripChartX1;
    }
}