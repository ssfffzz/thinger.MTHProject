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
            SeeSharpTools.JY.GUI.StripChartXSeries stripChartXSeries3 = new SeeSharpTools.JY.GUI.StripChartXSeries();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelEnhanced1 = new thinger.MTHControlLib.PanelEnhanced();
            this.chartX = new SeeSharpTools.JY.GUI.StripChartX();
            this.lst_info = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dialPlateControl2 = new thinger.MTHControlLib.DialPlateControl();
            this.cbe_Humidity2 = new thinger.MTHControlLib.CheckBoxEx();
            this.dialPlateControl1 = new thinger.MTHControlLib.DialPlateControl();
            this.cbe_Temp2 = new thinger.MTHControlLib.CheckBoxEx();
            this.dialPlateControl3 = new thinger.MTHControlLib.DialPlateControl();
            this.cbe_Humidity1 = new thinger.MTHControlLib.CheckBoxEx();
            this.dialPlateControl4 = new thinger.MTHControlLib.DialPlateControl();
            this.cbe_Temp1 = new thinger.MTHControlLib.CheckBoxEx();
            this.dialPlateControl5 = new thinger.MTHControlLib.DialPlateControl();
            this.cbe_Humidity4 = new thinger.MTHControlLib.CheckBoxEx();
            this.dialPlateControl6 = new thinger.MTHControlLib.DialPlateControl();
            this.cbe_Temp4 = new thinger.MTHControlLib.CheckBoxEx();
            this.titleShow1 = new thinger.MTHControlLib.TitleShow();
            this.cbe_Humidity3 = new thinger.MTHControlLib.CheckBoxEx();
            this.titleShow2 = new thinger.MTHControlLib.TitleShow();
            this.cbe_Temp3 = new thinger.MTHControlLib.CheckBoxEx();
            this.cbe_Temp5 = new thinger.MTHControlLib.CheckBoxEx();
            this.cbe_Humidity5 = new thinger.MTHControlLib.CheckBoxEx();
            this.cbe_Humidity6 = new thinger.MTHControlLib.CheckBoxEx();
            this.cbe_Temp6 = new thinger.MTHControlLib.CheckBoxEx();
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
            this.panelEnhanced1.Controls.Add(this.chartX);
            this.panelEnhanced1.Controls.Add(this.lst_info);
            this.panelEnhanced1.Controls.Add(this.dialPlateControl2);
            this.panelEnhanced1.Controls.Add(this.cbe_Humidity2);
            this.panelEnhanced1.Controls.Add(this.dialPlateControl1);
            this.panelEnhanced1.Controls.Add(this.cbe_Temp2);
            this.panelEnhanced1.Controls.Add(this.dialPlateControl3);
            this.panelEnhanced1.Controls.Add(this.cbe_Humidity1);
            this.panelEnhanced1.Controls.Add(this.dialPlateControl4);
            this.panelEnhanced1.Controls.Add(this.cbe_Temp1);
            this.panelEnhanced1.Controls.Add(this.dialPlateControl5);
            this.panelEnhanced1.Controls.Add(this.cbe_Humidity4);
            this.panelEnhanced1.Controls.Add(this.dialPlateControl6);
            this.panelEnhanced1.Controls.Add(this.cbe_Temp4);
            this.panelEnhanced1.Controls.Add(this.titleShow1);
            this.panelEnhanced1.Controls.Add(this.cbe_Humidity3);
            this.panelEnhanced1.Controls.Add(this.titleShow2);
            this.panelEnhanced1.Controls.Add(this.cbe_Temp3);
            this.panelEnhanced1.Controls.Add(this.cbe_Temp5);
            this.panelEnhanced1.Controls.Add(this.cbe_Humidity5);
            this.panelEnhanced1.Controls.Add(this.cbe_Humidity6);
            this.panelEnhanced1.Controls.Add(this.cbe_Temp6);
            this.panelEnhanced1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEnhanced1.Location = new System.Drawing.Point(0, 0);
            this.panelEnhanced1.Name = "panelEnhanced1";
            this.panelEnhanced1.Size = new System.Drawing.Size(1394, 716);
            this.panelEnhanced1.TabIndex = 14;
            // 
            // chartX
            // 
            this.chartX.AxisX.AutoScale = false;
            this.chartX.AxisX.AutoZoomReset = false;
            this.chartX.AxisX.Color = System.Drawing.Color.White;
            this.chartX.AxisX.InitWithScaleView = false;
            this.chartX.AxisX.IsLogarithmic = false;
            this.chartX.AxisX.LabelAngle = 0;
            this.chartX.AxisX.LabelEnabled = true;
            this.chartX.AxisX.LabelFormat = null;
            this.chartX.AxisX.MajorGridColor = System.Drawing.Color.White;
            this.chartX.AxisX.MajorGridCount = 6;
            this.chartX.AxisX.MajorGridEnabled = true;
            this.chartX.AxisX.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chartX.AxisX.Maximum = 1000D;
            this.chartX.AxisX.Minimum = 0D;
            this.chartX.AxisX.MinorGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chartX.AxisX.MinorGridEnabled = false;
            this.chartX.AxisX.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chartX.AxisX.TickWidth = 1F;
            this.chartX.AxisX.Title = "";
            this.chartX.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chartX.AxisX.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chartX.AxisX.ViewMaximum = 1000D;
            this.chartX.AxisX.ViewMinimum = 0D;
            this.chartX.AxisX2.AutoScale = false;
            this.chartX.AxisX2.AutoZoomReset = false;
            this.chartX.AxisX2.Color = System.Drawing.Color.Black;
            this.chartX.AxisX2.InitWithScaleView = false;
            this.chartX.AxisX2.IsLogarithmic = false;
            this.chartX.AxisX2.LabelAngle = 0;
            this.chartX.AxisX2.LabelEnabled = true;
            this.chartX.AxisX2.LabelFormat = null;
            this.chartX.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.chartX.AxisX2.MajorGridCount = 6;
            this.chartX.AxisX2.MajorGridEnabled = true;
            this.chartX.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chartX.AxisX2.Maximum = 1000D;
            this.chartX.AxisX2.Minimum = 0D;
            this.chartX.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.chartX.AxisX2.MinorGridEnabled = false;
            this.chartX.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chartX.AxisX2.TickWidth = 1F;
            this.chartX.AxisX2.Title = "";
            this.chartX.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chartX.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chartX.AxisX2.ViewMaximum = 1000D;
            this.chartX.AxisX2.ViewMinimum = 0D;
            this.chartX.AxisY.AutoScale = true;
            this.chartX.AxisY.AutoZoomReset = false;
            this.chartX.AxisY.Color = System.Drawing.Color.White;
            this.chartX.AxisY.InitWithScaleView = false;
            this.chartX.AxisY.IsLogarithmic = false;
            this.chartX.AxisY.LabelAngle = 0;
            this.chartX.AxisY.LabelEnabled = true;
            this.chartX.AxisY.LabelFormat = null;
            this.chartX.AxisY.MajorGridColor = System.Drawing.Color.White;
            this.chartX.AxisY.MajorGridCount = 6;
            this.chartX.AxisY.MajorGridEnabled = true;
            this.chartX.AxisY.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chartX.AxisY.Maximum = 3.5D;
            this.chartX.AxisY.Minimum = 0.5D;
            this.chartX.AxisY.MinorGridColor = System.Drawing.Color.Black;
            this.chartX.AxisY.MinorGridEnabled = false;
            this.chartX.AxisY.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chartX.AxisY.TickWidth = 1F;
            this.chartX.AxisY.Title = "";
            this.chartX.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chartX.AxisY.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chartX.AxisY.ViewMaximum = 3.5D;
            this.chartX.AxisY.ViewMinimum = 0.5D;
            this.chartX.AxisY2.AutoScale = true;
            this.chartX.AxisY2.AutoZoomReset = false;
            this.chartX.AxisY2.Color = System.Drawing.Color.Black;
            this.chartX.AxisY2.InitWithScaleView = false;
            this.chartX.AxisY2.IsLogarithmic = false;
            this.chartX.AxisY2.LabelAngle = 0;
            this.chartX.AxisY2.LabelEnabled = true;
            this.chartX.AxisY2.LabelFormat = null;
            this.chartX.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.chartX.AxisY2.MajorGridCount = 6;
            this.chartX.AxisY2.MajorGridEnabled = true;
            this.chartX.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chartX.AxisY2.Maximum = 3.5D;
            this.chartX.AxisY2.Minimum = 0.5D;
            this.chartX.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.chartX.AxisY2.MinorGridEnabled = false;
            this.chartX.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chartX.AxisY2.TickWidth = 1F;
            this.chartX.AxisY2.Title = "";
            this.chartX.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chartX.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chartX.AxisY2.ViewMaximum = 3.5D;
            this.chartX.AxisY2.ViewMinimum = 0.5D;
            this.chartX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chartX.ChartAreaBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chartX.Direction = SeeSharpTools.JY.GUI.StripChartX.ScrollDirection.LeftToRight;
            this.chartX.DisplayPoints = 4000;
            this.chartX.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chartX.ForeColor = System.Drawing.Color.White;
            this.chartX.GradientStyle = SeeSharpTools.JY.GUI.StripChartX.ChartGradientStyle.None;
            this.chartX.LegendBackColor = System.Drawing.Color.Transparent;
            this.chartX.LegendFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chartX.LegendForeColor = System.Drawing.Color.White;
            this.chartX.LegendVisible = true;
            stripChartXSeries3.Color = System.Drawing.Color.Red;
            stripChartXSeries3.Marker = SeeSharpTools.JY.GUI.StripChartXSeries.MarkerType.None;
            stripChartXSeries3.Name = "Series1";
            stripChartXSeries3.Type = SeeSharpTools.JY.GUI.StripChartXSeries.LineType.FastLine;
            stripChartXSeries3.Visible = true;
            stripChartXSeries3.Width = SeeSharpTools.JY.GUI.StripChartXSeries.LineWidth.Thin;
            stripChartXSeries3.XPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            stripChartXSeries3.YPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            this.chartX.LineSeries.Add(stripChartXSeries3);
            this.chartX.Location = new System.Drawing.Point(789, 50);
            this.chartX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartX.Miscellaneous.CheckInfinity = false;
            this.chartX.Miscellaneous.CheckNaN = false;
            this.chartX.Miscellaneous.CheckNegtiveOrZero = false;
            this.chartX.Miscellaneous.DirectionChartCount = 3;
            this.chartX.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.StripChartX.FitType.Range;
            this.chartX.Miscellaneous.MaxSeriesCount = 32;
            this.chartX.Miscellaneous.MaxSeriesPointCount = 4000;
            this.chartX.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.chartX.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.StripChartXUtility.LayoutDirection.LeftToRight;
            this.chartX.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.chartX.Miscellaneous.SplitViewAutoLayout = true;
            this.chartX.Name = "chartX";
            this.chartX.NextTimeStamp = new System.DateTime(((long)(0)));
            this.chartX.ScrollType = SeeSharpTools.JY.GUI.StripChartX.StripScrollType.Cumulation;
            this.chartX.SeriesCount = 1;
            this.chartX.Size = new System.Drawing.Size(575, 306);
            this.chartX.SplitView = false;
            this.chartX.StartIndex = 0;
            this.chartX.TabIndex = 14;
            this.chartX.TimeInterval = System.TimeSpan.Parse("00:00:00");
            this.chartX.TimeStampFormat = null;
            this.chartX.XCursor.AutoInterval = true;
            this.chartX.XCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.chartX.XCursor.Interval = 0.001D;
            this.chartX.XCursor.Mode = SeeSharpTools.JY.GUI.StripChartXCursor.CursorMode.Zoom;
            this.chartX.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.chartX.XCursor.Value = double.NaN;
            this.chartX.XDataType = SeeSharpTools.JY.GUI.StripChartX.XAxisDataType.Index;
            this.chartX.YCursor.AutoInterval = true;
            this.chartX.YCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.chartX.YCursor.Interval = 0.001D;
            this.chartX.YCursor.Mode = SeeSharpTools.JY.GUI.StripChartXCursor.CursorMode.Disabled;
            this.chartX.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.chartX.YCursor.Value = double.NaN;
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
            this.columnHeader1.Width = 180;
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
            // cbe_Humidity2
            // 
            this.cbe_Humidity2.BackColor = System.Drawing.Color.Transparent;
            this.cbe_Humidity2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.cbe_Humidity2.CkbWidth = 20;
            this.cbe_Humidity2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbe_Humidity2.ForeColor = System.Drawing.Color.White;
            this.cbe_Humidity2.Location = new System.Drawing.Point(1243, 363);
            this.cbe_Humidity2.Name = "cbe_Humidity2";
            this.cbe_Humidity2.Size = new System.Drawing.Size(119, 29);
            this.cbe_Humidity2.TabIndex = 9;
            this.cbe_Humidity2.Text = "模块2湿度";
            this.cbe_Humidity2.UseVisualStyleBackColor = false;
            this.cbe_Humidity2.CheckedChanged += new System.EventHandler(this.Cbe_TempHum_CheckedChanged);
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
            // cbe_Temp2
            // 
            this.cbe_Temp2.BackColor = System.Drawing.Color.Transparent;
            this.cbe_Temp2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.cbe_Temp2.CkbWidth = 20;
            this.cbe_Temp2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbe_Temp2.ForeColor = System.Drawing.Color.White;
            this.cbe_Temp2.Location = new System.Drawing.Point(1093, 363);
            this.cbe_Temp2.Name = "cbe_Temp2";
            this.cbe_Temp2.Size = new System.Drawing.Size(119, 29);
            this.cbe_Temp2.TabIndex = 10;
            this.cbe_Temp2.Text = "模块2温度";
            this.cbe_Temp2.UseVisualStyleBackColor = false;
            this.cbe_Temp2.CheckedChanged += new System.EventHandler(this.Cbe_TempHum_CheckedChanged);
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
            // cbe_Humidity1
            // 
            this.cbe_Humidity1.BackColor = System.Drawing.Color.Transparent;
            this.cbe_Humidity1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.cbe_Humidity1.CkbWidth = 20;
            this.cbe_Humidity1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbe_Humidity1.ForeColor = System.Drawing.Color.White;
            this.cbe_Humidity1.Location = new System.Drawing.Point(943, 363);
            this.cbe_Humidity1.Name = "cbe_Humidity1";
            this.cbe_Humidity1.Size = new System.Drawing.Size(119, 29);
            this.cbe_Humidity1.TabIndex = 11;
            this.cbe_Humidity1.Text = "模块1湿度";
            this.cbe_Humidity1.UseVisualStyleBackColor = false;
            this.cbe_Humidity1.CheckedChanged += new System.EventHandler(this.Cbe_TempHum_CheckedChanged);
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
            // cbe_Temp1
            // 
            this.cbe_Temp1.BackColor = System.Drawing.Color.Transparent;
            this.cbe_Temp1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.cbe_Temp1.CkbWidth = 20;
            this.cbe_Temp1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbe_Temp1.ForeColor = System.Drawing.Color.White;
            this.cbe_Temp1.Location = new System.Drawing.Point(793, 363);
            this.cbe_Temp1.Name = "cbe_Temp1";
            this.cbe_Temp1.Size = new System.Drawing.Size(119, 29);
            this.cbe_Temp1.TabIndex = 12;
            this.cbe_Temp1.Text = "模块1温度";
            this.cbe_Temp1.UseVisualStyleBackColor = false;
            this.cbe_Temp1.CheckedChanged += new System.EventHandler(this.Cbe_TempHum_CheckedChanged);
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
            // cbe_Humidity4
            // 
            this.cbe_Humidity4.BackColor = System.Drawing.Color.Transparent;
            this.cbe_Humidity4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.cbe_Humidity4.CkbWidth = 20;
            this.cbe_Humidity4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbe_Humidity4.ForeColor = System.Drawing.Color.White;
            this.cbe_Humidity4.Location = new System.Drawing.Point(1243, 408);
            this.cbe_Humidity4.Name = "cbe_Humidity4";
            this.cbe_Humidity4.Size = new System.Drawing.Size(119, 29);
            this.cbe_Humidity4.TabIndex = 5;
            this.cbe_Humidity4.Text = "模块4湿度";
            this.cbe_Humidity4.UseVisualStyleBackColor = false;
            this.cbe_Humidity4.CheckedChanged += new System.EventHandler(this.Cbe_TempHum_CheckedChanged);
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
            // cbe_Temp4
            // 
            this.cbe_Temp4.BackColor = System.Drawing.Color.Transparent;
            this.cbe_Temp4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.cbe_Temp4.CkbWidth = 20;
            this.cbe_Temp4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbe_Temp4.ForeColor = System.Drawing.Color.White;
            this.cbe_Temp4.Location = new System.Drawing.Point(1093, 408);
            this.cbe_Temp4.Name = "cbe_Temp4";
            this.cbe_Temp4.Size = new System.Drawing.Size(119, 29);
            this.cbe_Temp4.TabIndex = 6;
            this.cbe_Temp4.Text = "模块4温度";
            this.cbe_Temp4.UseVisualStyleBackColor = false;
            this.cbe_Temp4.CheckedChanged += new System.EventHandler(this.Cbe_TempHum_CheckedChanged);
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
            // cbe_Humidity3
            // 
            this.cbe_Humidity3.BackColor = System.Drawing.Color.Transparent;
            this.cbe_Humidity3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.cbe_Humidity3.CkbWidth = 20;
            this.cbe_Humidity3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbe_Humidity3.ForeColor = System.Drawing.Color.White;
            this.cbe_Humidity3.Location = new System.Drawing.Point(943, 408);
            this.cbe_Humidity3.Name = "cbe_Humidity3";
            this.cbe_Humidity3.Size = new System.Drawing.Size(119, 29);
            this.cbe_Humidity3.TabIndex = 7;
            this.cbe_Humidity3.Text = "模块3湿度";
            this.cbe_Humidity3.UseVisualStyleBackColor = false;
            this.cbe_Humidity3.CheckedChanged += new System.EventHandler(this.Cbe_TempHum_CheckedChanged);
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
            // cbe_Temp3
            // 
            this.cbe_Temp3.BackColor = System.Drawing.Color.Transparent;
            this.cbe_Temp3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.cbe_Temp3.CkbWidth = 20;
            this.cbe_Temp3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbe_Temp3.ForeColor = System.Drawing.Color.White;
            this.cbe_Temp3.Location = new System.Drawing.Point(793, 408);
            this.cbe_Temp3.Name = "cbe_Temp3";
            this.cbe_Temp3.Size = new System.Drawing.Size(119, 29);
            this.cbe_Temp3.TabIndex = 8;
            this.cbe_Temp3.Text = "模块3温度";
            this.cbe_Temp3.UseVisualStyleBackColor = false;
            this.cbe_Temp3.CheckedChanged += new System.EventHandler(this.Cbe_TempHum_CheckedChanged);
            // 
            // cbe_Temp5
            // 
            this.cbe_Temp5.BackColor = System.Drawing.Color.Transparent;
            this.cbe_Temp5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.cbe_Temp5.CkbWidth = 20;
            this.cbe_Temp5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbe_Temp5.ForeColor = System.Drawing.Color.White;
            this.cbe_Temp5.Location = new System.Drawing.Point(793, 457);
            this.cbe_Temp5.Name = "cbe_Temp5";
            this.cbe_Temp5.Size = new System.Drawing.Size(119, 29);
            this.cbe_Temp5.TabIndex = 3;
            this.cbe_Temp5.Text = "模块5温度";
            this.cbe_Temp5.UseVisualStyleBackColor = false;
            this.cbe_Temp5.CheckedChanged += new System.EventHandler(this.Cbe_TempHum_CheckedChanged);
            // 
            // cbe_Humidity5
            // 
            this.cbe_Humidity5.BackColor = System.Drawing.Color.Transparent;
            this.cbe_Humidity5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.cbe_Humidity5.CkbWidth = 20;
            this.cbe_Humidity5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbe_Humidity5.ForeColor = System.Drawing.Color.White;
            this.cbe_Humidity5.Location = new System.Drawing.Point(943, 457);
            this.cbe_Humidity5.Name = "cbe_Humidity5";
            this.cbe_Humidity5.Size = new System.Drawing.Size(119, 29);
            this.cbe_Humidity5.TabIndex = 3;
            this.cbe_Humidity5.Text = "模块5湿度";
            this.cbe_Humidity5.UseVisualStyleBackColor = false;
            this.cbe_Humidity5.CheckedChanged += new System.EventHandler(this.Cbe_TempHum_CheckedChanged);
            // 
            // cbe_Humidity6
            // 
            this.cbe_Humidity6.BackColor = System.Drawing.Color.Transparent;
            this.cbe_Humidity6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.cbe_Humidity6.CkbWidth = 20;
            this.cbe_Humidity6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbe_Humidity6.ForeColor = System.Drawing.Color.White;
            this.cbe_Humidity6.Location = new System.Drawing.Point(1243, 457);
            this.cbe_Humidity6.Name = "cbe_Humidity6";
            this.cbe_Humidity6.Size = new System.Drawing.Size(119, 29);
            this.cbe_Humidity6.TabIndex = 3;
            this.cbe_Humidity6.Text = "模块6湿度";
            this.cbe_Humidity6.UseVisualStyleBackColor = false;
            this.cbe_Humidity6.CheckedChanged += new System.EventHandler(this.Cbe_TempHum_CheckedChanged);
            // 
            // cbe_Temp6
            // 
            this.cbe_Temp6.BackColor = System.Drawing.Color.Transparent;
            this.cbe_Temp6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.cbe_Temp6.CkbWidth = 20;
            this.cbe_Temp6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbe_Temp6.ForeColor = System.Drawing.Color.White;
            this.cbe_Temp6.Location = new System.Drawing.Point(1093, 457);
            this.cbe_Temp6.Name = "cbe_Temp6";
            this.cbe_Temp6.Size = new System.Drawing.Size(119, 29);
            this.cbe_Temp6.TabIndex = 3;
            this.cbe_Temp6.Text = "模块6温度";
            this.cbe_Temp6.UseVisualStyleBackColor = false;
            this.cbe_Temp6.CheckedChanged += new System.EventHandler(this.Cbe_TempHum_CheckedChanged);
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
        private MTHControlLib.CheckBoxEx cbe_Temp5;
        private MTHControlLib.CheckBoxEx cbe_Humidity5;
        private MTHControlLib.CheckBoxEx cbe_Temp6;
        private MTHControlLib.CheckBoxEx cbe_Humidity6;
        private MTHControlLib.CheckBoxEx cbe_Humidity4;
        private MTHControlLib.CheckBoxEx cbe_Temp4;
        private MTHControlLib.CheckBoxEx cbe_Humidity3;
        private MTHControlLib.CheckBoxEx cbe_Temp3;
        private MTHControlLib.CheckBoxEx cbe_Humidity2;
        private MTHControlLib.CheckBoxEx cbe_Temp2;
        private MTHControlLib.CheckBoxEx cbe_Humidity1;
        private MTHControlLib.CheckBoxEx cbe_Temp1;
        private System.Windows.Forms.ListView lst_info;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList imageList1;
        private MTHControlLib.PanelEnhanced panelEnhanced1;
        private SeeSharpTools.JY.GUI.StripChartX chartX;
    }
}