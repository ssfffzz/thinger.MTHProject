namespace thinger.MTHProject
{
    partial class FrmParamSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParamSet));
            this.panelEnhanced1 = new thinger.MTHControlLib.PanelEnhanced();
            this.btnVariableConfig = new System.Windows.Forms.Button();
            this.btnGroupConfig = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.txtSlaveId = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleShow1 = new thinger.MTHControlLib.TitleShow();
            this.label1 = new System.Windows.Forms.Label();
            this.stateShow1 = new thinger.MTHControlLib.StateShow();
            this.panelEnhanced1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEnhanced1
            // 
            this.panelEnhanced1.BackgroundImage = global::thinger.MTHProject.Properties.Resources.BackGround;
            this.panelEnhanced1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEnhanced1.Controls.Add(this.stateShow1);
            this.panelEnhanced1.Controls.Add(this.btnVariableConfig);
            this.panelEnhanced1.Controls.Add(this.btnGroupConfig);
            this.panelEnhanced1.Controls.Add(this.btnSaveConfig);
            this.panelEnhanced1.Controls.Add(this.txtSlaveId);
            this.panelEnhanced1.Controls.Add(this.txtPort);
            this.panelEnhanced1.Controls.Add(this.txtIP);
            this.panelEnhanced1.Controls.Add(this.label3);
            this.panelEnhanced1.Controls.Add(this.label2);
            this.panelEnhanced1.Controls.Add(this.titleShow1);
            this.panelEnhanced1.Controls.Add(this.label1);
            this.panelEnhanced1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEnhanced1.Location = new System.Drawing.Point(0, 0);
            this.panelEnhanced1.Name = "panelEnhanced1";
            this.panelEnhanced1.Size = new System.Drawing.Size(1394, 716);
            this.panelEnhanced1.TabIndex = 0;
            // 
            // btnVariableConfig
            // 
            this.btnVariableConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVariableConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVariableConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVariableConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVariableConfig.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVariableConfig.ForeColor = System.Drawing.Color.White;
            this.btnVariableConfig.Image = global::thinger.MTHProject.Properties.Resources.变量配置;
            this.btnVariableConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVariableConfig.Location = new System.Drawing.Point(1219, 24);
            this.btnVariableConfig.Name = "btnVariableConfig";
            this.btnVariableConfig.Size = new System.Drawing.Size(127, 44);
            this.btnVariableConfig.TabIndex = 3;
            this.btnVariableConfig.Text = "变量设置";
            this.btnVariableConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVariableConfig.UseVisualStyleBackColor = false;
            this.btnVariableConfig.Click += new System.EventHandler(this.btnVariableConfig_Click);
            // 
            // btnGroupConfig
            // 
            this.btnGroupConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGroupConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroupConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGroupConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupConfig.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGroupConfig.ForeColor = System.Drawing.Color.White;
            this.btnGroupConfig.Image = global::thinger.MTHProject.Properties.Resources.conn;
            this.btnGroupConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroupConfig.Location = new System.Drawing.Point(1072, 24);
            this.btnGroupConfig.Name = "btnGroupConfig";
            this.btnGroupConfig.Size = new System.Drawing.Size(141, 44);
            this.btnGroupConfig.TabIndex = 3;
            this.btnGroupConfig.Text = "通信组设置";
            this.btnGroupConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGroupConfig.UseVisualStyleBackColor = false;
            this.btnGroupConfig.Click += new System.EventHandler(this.btnGroupConfig_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConfig.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveConfig.ForeColor = System.Drawing.Color.White;
            this.btnSaveConfig.Image = global::thinger.MTHProject.Properties.Resources.确定设置;
            this.btnSaveConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveConfig.Location = new System.Drawing.Point(870, 24);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(127, 44);
            this.btnSaveConfig.TabIndex = 3;
            this.btnSaveConfig.Text = "保存设置";
            this.btnSaveConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveConfig.UseVisualStyleBackColor = false;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // txtSlaveId
            // 
            this.txtSlaveId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlaveId.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSlaveId.Location = new System.Drawing.Point(740, 31);
            this.txtSlaveId.Name = "txtSlaveId";
            this.txtSlaveId.Size = new System.Drawing.Size(90, 30);
            this.txtSlaveId.TabIndex = 2;
            this.txtSlaveId.Text = "15";
            this.txtSlaveId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPort.Location = new System.Drawing.Point(557, 31);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(90, 30);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "502";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIP
            // 
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIP.Location = new System.Drawing.Point(298, 31);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(170, 30);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(655, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "站地址：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(474, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口号：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleShow1
            // 
            this.titleShow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(40)))), ((int)(((byte)(91)))));
            this.titleShow1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titleShow1.BackgroundImage")));
            this.titleShow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.titleShow1.Location = new System.Drawing.Point(37, 31);
            this.titleShow1.Name = "titleShow1";
            this.titleShow1.Size = new System.Drawing.Size(110, 31);
            this.titleShow1.TabIndex = 0;
            this.titleShow1.Title = "标题名称";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "设备IP地址：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateShow1
            // 
            this.stateShow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.stateShow1.Location = new System.Drawing.Point(37, 95);
            this.stateShow1.Name = "stateShow1";
            this.stateShow1.Size = new System.Drawing.Size(401, 50);
            this.stateShow1.TabIndex = 4;
            // 
            // FrmParamSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 716);
            this.Controls.Add(this.panelEnhanced1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmParamSet";
            this.Text = "系统配置";
            this.panelEnhanced1.ResumeLayout(false);
            this.panelEnhanced1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MTHControlLib.PanelEnhanced panelEnhanced1;
        private MTHControlLib.TitleShow titleShow1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSlaveId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button btnVariableConfig;
        private System.Windows.Forms.Button btnGroupConfig;
        private MTHControlLib.StateShow stateShow1;
    }
}