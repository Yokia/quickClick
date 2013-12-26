namespace QuickClick
{
    partial class QuickClick
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton_Enter = new System.Windows.Forms.RadioButton();
            this.radioButton_Click = new System.Windows.Forms.RadioButton();
            this.delayInput = new System.Windows.Forms.TextBox();
            this.clickCountLabel = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(28, 187);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(94, 38);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "开始(F10)";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "鼠标连点";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.delayInput);
            this.groupBox1.Controls.Add(this.clickCountLabel);
            this.groupBox1.Controls.Add(this.stopBtn);
            this.groupBox1.Controls.Add(this.startBtn);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 244);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "延迟";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.radioButton_Enter);
            this.groupBox2.Controls.Add(this.radioButton_Click);
            this.groupBox2.Location = new System.Drawing.Point(30, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 95);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运行方式";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Enter"});
            this.comboBox2.Location = new System.Drawing.Point(123, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(89, 20);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Enter";
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.comboBox1.Items.AddRange(new object[] {
            "鼠标左键",
            "鼠标右键",
            "鼠标左右键"});
            this.comboBox1.Location = new System.Drawing.Point(3, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "鼠标左键";
            // 
            // radioButton_Enter
            // 
            this.radioButton_Enter.AutoSize = true;
            this.radioButton_Enter.Location = new System.Drawing.Point(137, 25);
            this.radioButton_Enter.Name = "radioButton_Enter";
            this.radioButton_Enter.Size = new System.Drawing.Size(71, 16);
            this.radioButton_Enter.TabIndex = 0;
            this.radioButton_Enter.Text = "键盘敲击";
            this.radioButton_Enter.UseVisualStyleBackColor = true;
            // 
            // radioButton_Click
            // 
            this.radioButton_Click.AutoSize = true;
            this.radioButton_Click.Checked = true;
            this.radioButton_Click.Location = new System.Drawing.Point(6, 25);
            this.radioButton_Click.Name = "radioButton_Click";
            this.radioButton_Click.Size = new System.Drawing.Size(71, 16);
            this.radioButton_Click.TabIndex = 0;
            this.radioButton_Click.TabStop = true;
            this.radioButton_Click.Text = "鼠标点击";
            this.radioButton_Click.UseVisualStyleBackColor = true;
            // 
            // delayInput
            // 
            this.delayInput.Location = new System.Drawing.Point(70, 58);
            this.delayInput.Name = "delayInput";
            this.delayInput.Size = new System.Drawing.Size(64, 21);
            this.delayInput.TabIndex = 4;
            this.delayInput.Text = "100";
            // 
            // clickCountLabel
            // 
            this.clickCountLabel.AutoSize = true;
            this.clickCountLabel.Location = new System.Drawing.Point(200, 63);
            this.clickCountLabel.Name = "clickCountLabel";
            this.clickCountLabel.Size = new System.Drawing.Size(11, 12);
            this.clickCountLabel.TabIndex = 2;
            this.clickCountLabel.Text = "0";
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(152, 187);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(94, 38);
            this.stopBtn.TabIndex = 0;
            this.stopBtn.Text = "停止(F11)";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stop_Click);
            // 
            // QuickClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuickClick";
            this.Text = "QuickClick";
            this.MinimumSizeChanged += new System.EventHandler(this.miniSizeClick);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exit);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label clickCountLabel;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TextBox delayInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_Enter;
        private System.Windows.Forms.RadioButton radioButton_Click;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

