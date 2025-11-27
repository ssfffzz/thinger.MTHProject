namespace thinger.MTHControlLib
{
    partial class RecipeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeControl));
            this.checkBoxEx2 = new thinger.MTHControlLib.CheckBoxEx();
            this.checkBoxEx1 = new thinger.MTHControlLib.CheckBoxEx();
            this.siteTitleName = new thinger.MTHControlLib.TitleShow();
            this.stateShowEx1 = new thinger.MTHControlLib.StateShowEx();
            this.stateShowEx2 = new thinger.MTHControlLib.StateShowEx();
            this.stateShowEx3 = new thinger.MTHControlLib.StateShowEx();
            this.stateShowEx4 = new thinger.MTHControlLib.StateShowEx();
            this.SuspendLayout();
            // 
            // checkBoxEx2
            // 
            this.checkBoxEx2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEx2.CkbWidth = 20;
            this.checkBoxEx2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxEx2.ForeColor = System.Drawing.Color.White;
            this.checkBoxEx2.Location = new System.Drawing.Point(170, 281);
            this.checkBoxEx2.Name = "checkBoxEx2";
            this.checkBoxEx2.Size = new System.Drawing.Size(137, 24);
            this.checkBoxEx2.TabIndex = 2;
            this.checkBoxEx2.Text = "湿度报警启用";
            this.checkBoxEx2.UseVisualStyleBackColor = true;
            // 
            // checkBoxEx1
            // 
            this.checkBoxEx1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEx1.CkbWidth = 20;
            this.checkBoxEx1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxEx1.ForeColor = System.Drawing.Color.White;
            this.checkBoxEx1.Location = new System.Drawing.Point(22, 281);
            this.checkBoxEx1.Name = "checkBoxEx1";
            this.checkBoxEx1.Size = new System.Drawing.Size(137, 24);
            this.checkBoxEx1.TabIndex = 2;
            this.checkBoxEx1.Text = "温度报警启用";
            this.checkBoxEx1.UseVisualStyleBackColor = true;
            // 
            // siteTitleName
            // 
            this.siteTitleName.BackColor = System.Drawing.Color.Transparent;
            this.siteTitleName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("siteTitleName.BackgroundImage")));
            this.siteTitleName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.siteTitleName.Location = new System.Drawing.Point(23, 16);
            this.siteTitleName.Name = "siteTitleName";
            this.siteTitleName.Size = new System.Drawing.Size(110, 31);
            this.siteTitleName.TabIndex = 0;
            this.siteTitleName.Title = "标题名称";
            // 
            // stateShowEx1
            // 
            this.stateShowEx1.BackColor = System.Drawing.Color.Transparent;
            this.stateShowEx1.CurrentValue = 0F;
            this.stateShowEx1.Location = new System.Drawing.Point(5, 62);
            this.stateShowEx1.Name = "stateShowEx1";
            this.stateShowEx1.Size = new System.Drawing.Size(300, 45);
            this.stateShowEx1.TabIndex = 3;
            this.stateShowEx1.TitleName = "模块1温度高限";
            this.stateShowEx1.Unit = "°C";
            // 
            // stateShowEx2
            // 
            this.stateShowEx2.BackColor = System.Drawing.Color.Transparent;
            this.stateShowEx2.CurrentValue = 0F;
            this.stateShowEx2.Location = new System.Drawing.Point(5, 115);
            this.stateShowEx2.Name = "stateShowEx2";
            this.stateShowEx2.Size = new System.Drawing.Size(300, 45);
            this.stateShowEx2.TabIndex = 3;
            this.stateShowEx2.TitleName = "模块1温度低限";
            this.stateShowEx2.Unit = "°C";
            // 
            // stateShowEx3
            // 
            this.stateShowEx3.BackColor = System.Drawing.Color.Transparent;
            this.stateShowEx3.CurrentValue = 0F;
            this.stateShowEx3.Location = new System.Drawing.Point(5, 168);
            this.stateShowEx3.Name = "stateShowEx3";
            this.stateShowEx3.Size = new System.Drawing.Size(300, 45);
            this.stateShowEx3.TabIndex = 3;
            this.stateShowEx3.TitleName = "模块1湿度高限";
            this.stateShowEx3.Unit = "%";
            // 
            // stateShowEx4
            // 
            this.stateShowEx4.BackColor = System.Drawing.Color.Transparent;
            this.stateShowEx4.CurrentValue = 0F;
            this.stateShowEx4.Location = new System.Drawing.Point(5, 221);
            this.stateShowEx4.Name = "stateShowEx4";
            this.stateShowEx4.Size = new System.Drawing.Size(300, 45);
            this.stateShowEx4.TabIndex = 3;
            this.stateShowEx4.TitleName = "模块1湿度低限";
            this.stateShowEx4.Unit = "%";
            // 
            // RecipeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.stateShowEx4);
            this.Controls.Add(this.stateShowEx3);
            this.Controls.Add(this.stateShowEx2);
            this.Controls.Add(this.stateShowEx1);
            this.Controls.Add(this.checkBoxEx2);
            this.Controls.Add(this.checkBoxEx1);
            this.Controls.Add(this.siteTitleName);
            this.Name = "RecipeControl";
            this.Size = new System.Drawing.Size(311, 324);
            this.ResumeLayout(false);

        }

        #endregion

        private TitleShow siteTitleName;
        private CheckBoxEx checkBoxEx1;
        private CheckBoxEx checkBoxEx2;
        private StateShowEx stateShowEx1;
        private StateShowEx stateShowEx2;
        private StateShowEx stateShowEx3;
        private StateShowEx stateShowEx4;
    }
}
