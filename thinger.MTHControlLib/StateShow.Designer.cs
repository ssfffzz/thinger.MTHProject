namespace thinger.MTHControlLib
{
    partial class StateShow
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Value = new System.Windows.Forms.Label();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.led_Alarm = new SeeSharpTools.JY.GUI.LED();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.80608F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.19392F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Value, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Unit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.led_Alarm, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 41);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Title.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(3, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(182, 41);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "1#站点温度高限";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Title.DoubleClick += new System.EventHandler(this.StateShow_DoubleClick);
            // 
            // lbl_Value
            // 
            this.lbl_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Value.Font = new System.Drawing.Font("Droid Sans Fallback", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Value.ForeColor = System.Drawing.Color.White;
            this.lbl_Value.Location = new System.Drawing.Point(191, 0);
            this.lbl_Value.Name = "lbl_Value";
            this.lbl_Value.Size = new System.Drawing.Size(51, 41);
            this.lbl_Value.TabIndex = 1;
            this.lbl_Value.Text = "0.0";
            this.lbl_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Value.DoubleClick += new System.EventHandler(this.StateShow_DoubleClick);
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Unit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Unit.ForeColor = System.Drawing.Color.White;
            this.lbl_Unit.Location = new System.Drawing.Point(248, 0);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(48, 41);
            this.lbl_Unit.TabIndex = 2;
            this.lbl_Unit.Text = "℃";
            this.lbl_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Unit.DoubleClick += new System.EventHandler(this.StateShow_DoubleClick);
            // 
            // led_Alarm
            // 
            this.led_Alarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.led_Alarm.BlinkColor = System.Drawing.Color.Lime;
            this.led_Alarm.BlinkInterval = 1000;
            this.led_Alarm.BlinkOn = false;
            this.led_Alarm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.led_Alarm.Interacton = SeeSharpTools.JY.GUI.LED.InteractionStyle.Indicator;
            this.led_Alarm.Location = new System.Drawing.Point(309, 5);
            this.led_Alarm.Name = "led_Alarm";
            this.led_Alarm.OffColor = System.Drawing.Color.Lime;
            this.led_Alarm.OnColor = System.Drawing.Color.Red;
            this.led_Alarm.Size = new System.Drawing.Size(30, 30);
            this.led_Alarm.Style = SeeSharpTools.JY.GUI.LED.LedStyle.Circular;
            this.led_Alarm.TabIndex = 3;
            this.led_Alarm.Value = false;
            this.led_Alarm.DoubleClick += new System.EventHandler(this.StateShow_DoubleClick);
            // 
            // StateShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StateShow";
            this.Size = new System.Drawing.Size(350, 41);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Value;
        private System.Windows.Forms.Label lbl_Unit;
        private SeeSharpTools.JY.GUI.LED led_Alarm;
    }
}
