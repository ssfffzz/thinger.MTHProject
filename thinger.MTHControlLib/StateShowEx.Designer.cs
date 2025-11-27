namespace thinger.MTHControlLib
{
    partial class StateShowEx
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.num_Value = new System.Windows.Forms.NumericUpDown();
            this.lbl_Unit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_Value)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(13, 11);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(142, 23);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "模块1温度高限";
            // 
            // num_Value
            // 
            this.num_Value.DecimalPlaces = 1;
            this.num_Value.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Value.Location = new System.Drawing.Point(161, 8);
            this.num_Value.Name = "num_Value";
            this.num_Value.Size = new System.Drawing.Size(73, 26);
            this.num_Value.TabIndex = 1;
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Unit.ForeColor = System.Drawing.Color.White;
            this.lbl_Unit.Location = new System.Drawing.Point(240, 11);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(50, 23);
            this.lbl_Unit.TabIndex = 0;
            this.lbl_Unit.Text = "°C";
            // 
            // StateShowEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.num_Value);
            this.Controls.Add(this.lbl_Unit);
            this.Controls.Add(this.lbl_Title);
            this.Name = "StateShowEx";
            this.Size = new System.Drawing.Size(300, 45);
            ((System.ComponentModel.ISupportInitialize)(this.num_Value)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.NumericUpDown num_Value;
        private System.Windows.Forms.Label lbl_Unit;
    }
}
