namespace autoReportInput
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.secondSettingText = new System.Windows.Forms.TextBox();
            this.countSettingText = new System.Windows.Forms.TextBox();
            this.numberText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.substractionSettingText = new System.Windows.Forms.TextBox();
            this.substractionCheckbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.drivingTimeText2 = new System.Windows.Forms.TextBox();
            this.drivingTimeText1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mulchStringText = new System.Windows.Forms.TextBox();
            this.numberRadioButton = new System.Windows.Forms.RadioButton();
            this.drivingTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.mulchStringRadioButton = new System.Windows.Forms.RadioButton();
            this.inputFormatGroupBox = new System.Windows.Forms.GroupBox();
            this.stringText = new System.Windows.Forms.TextBox();
            this.stringRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.inputFormatGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "*秒後、入力開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // secondSettingText
            // 
            this.secondSettingText.Location = new System.Drawing.Point(12, 47);
            this.secondSettingText.Name = "secondSettingText";
            this.secondSettingText.Size = new System.Drawing.Size(174, 19);
            this.secondSettingText.TabIndex = 1;
            this.secondSettingText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.secondSettingText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // countSettingText
            // 
            this.countSettingText.Location = new System.Drawing.Point(12, 94);
            this.countSettingText.Name = "countSettingText";
            this.countSettingText.Size = new System.Drawing.Size(174, 19);
            this.countSettingText.TabIndex = 2;
            this.countSettingText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // numberText
            // 
            this.numberText.Enabled = false;
            this.numberText.Location = new System.Drawing.Point(12, 40);
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(170, 19);
            this.numberText.TabIndex = 3;
            this.numberText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_point_hifun_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "①入力開始までの秒数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "②繰り返し入力回数";
            // 
            // substractionSettingText
            // 
            this.substractionSettingText.Enabled = false;
            this.substractionSettingText.Location = new System.Drawing.Point(6, 45);
            this.substractionSettingText.Name = "substractionSettingText";
            this.substractionSettingText.Size = new System.Drawing.Size(162, 19);
            this.substractionSettingText.TabIndex = 7;
            this.substractionSettingText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.substractionSettingText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_point_hifun_KeyPress);
            // 
            // substractionCheckbox
            // 
            this.substractionCheckbox.AutoSize = true;
            this.substractionCheckbox.Location = new System.Drawing.Point(6, 23);
            this.substractionCheckbox.Name = "substractionCheckbox";
            this.substractionCheckbox.Size = new System.Drawing.Size(60, 16);
            this.substractionCheckbox.TabIndex = 9;
            this.substractionCheckbox.Text = "減算値";
            this.substractionCheckbox.UseVisualStyleBackColor = true;
            this.substractionCheckbox.CheckedChanged += new System.EventHandler(this.substractionCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "：";
            // 
            // drivingTimeText2
            // 
            this.drivingTimeText2.Enabled = false;
            this.drivingTimeText2.Location = new System.Drawing.Point(107, 82);
            this.drivingTimeText2.Name = "drivingTimeText2";
            this.drivingTimeText2.Size = new System.Drawing.Size(75, 19);
            this.drivingTimeText2.TabIndex = 12;
            this.drivingTimeText2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.drivingTimeText2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // drivingTimeText1
            // 
            this.drivingTimeText1.Enabled = false;
            this.drivingTimeText1.Location = new System.Drawing.Point(12, 82);
            this.drivingTimeText1.Name = "drivingTimeText1";
            this.drivingTimeText1.Size = new System.Drawing.Size(75, 19);
            this.drivingTimeText1.TabIndex = 13;
            this.drivingTimeText1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.drivingTimeText1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.substractionCheckbox);
            this.groupBox1.Controls.Add(this.substractionSettingText);
            this.groupBox1.Location = new System.Drawing.Point(12, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 94);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "オプション";
            // 
            // mulchStringText
            // 
            this.mulchStringText.Enabled = false;
            this.mulchStringText.Location = new System.Drawing.Point(12, 176);
            this.mulchStringText.Multiline = true;
            this.mulchStringText.Name = "mulchStringText";
            this.mulchStringText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mulchStringText.Size = new System.Drawing.Size(170, 254);
            this.mulchStringText.TabIndex = 15;
            // 
            // numberRadioButton
            // 
            this.numberRadioButton.AutoSize = true;
            this.numberRadioButton.Location = new System.Drawing.Point(12, 18);
            this.numberRadioButton.Name = "numberRadioButton";
            this.numberRadioButton.Size = new System.Drawing.Size(47, 16);
            this.numberRadioButton.TabIndex = 16;
            this.numberRadioButton.TabStop = true;
            this.numberRadioButton.Text = "数値";
            this.numberRadioButton.UseVisualStyleBackColor = true;
            this.numberRadioButton.CheckedChanged += new System.EventHandler(this.numberRadioButton_CheckedChanged);
            // 
            // drivingTimeRadioButton
            // 
            this.drivingTimeRadioButton.AutoSize = true;
            this.drivingTimeRadioButton.Location = new System.Drawing.Point(12, 65);
            this.drivingTimeRadioButton.Name = "drivingTimeRadioButton";
            this.drivingTimeRadioButton.Size = new System.Drawing.Size(71, 16);
            this.drivingTimeRadioButton.TabIndex = 17;
            this.drivingTimeRadioButton.TabStop = true;
            this.drivingTimeRadioButton.Text = "運転時間";
            this.drivingTimeRadioButton.UseVisualStyleBackColor = true;
            this.drivingTimeRadioButton.CheckedChanged += new System.EventHandler(this.drivingTimeRadioButton_CheckedChanged);
            // 
            // mulchStringRadioButton
            // 
            this.mulchStringRadioButton.AutoSize = true;
            this.mulchStringRadioButton.Location = new System.Drawing.Point(12, 154);
            this.mulchStringRadioButton.Name = "mulchStringRadioButton";
            this.mulchStringRadioButton.Size = new System.Drawing.Size(95, 16);
            this.mulchStringRadioButton.TabIndex = 18;
            this.mulchStringRadioButton.TabStop = true;
            this.mulchStringRadioButton.Text = "複数行テキスト";
            this.mulchStringRadioButton.UseVisualStyleBackColor = true;
            this.mulchStringRadioButton.CheckedChanged += new System.EventHandler(this.mulchStringRadioButton_CheckedChanged);
            // 
            // inputFormatGroupBox
            // 
            this.inputFormatGroupBox.Controls.Add(this.label6);
            this.inputFormatGroupBox.Controls.Add(this.clearButton);
            this.inputFormatGroupBox.Controls.Add(this.label3);
            this.inputFormatGroupBox.Controls.Add(this.stringText);
            this.inputFormatGroupBox.Controls.Add(this.stringRadioButton);
            this.inputFormatGroupBox.Controls.Add(this.numberRadioButton);
            this.inputFormatGroupBox.Controls.Add(this.mulchStringText);
            this.inputFormatGroupBox.Controls.Add(this.numberText);
            this.inputFormatGroupBox.Controls.Add(this.mulchStringRadioButton);
            this.inputFormatGroupBox.Controls.Add(this.label4);
            this.inputFormatGroupBox.Controls.Add(this.drivingTimeRadioButton);
            this.inputFormatGroupBox.Controls.Add(this.drivingTimeText1);
            this.inputFormatGroupBox.Controls.Add(this.drivingTimeText2);
            this.inputFormatGroupBox.Location = new System.Drawing.Point(197, 24);
            this.inputFormatGroupBox.Name = "inputFormatGroupBox";
            this.inputFormatGroupBox.Size = new System.Drawing.Size(195, 460);
            this.inputFormatGroupBox.TabIndex = 19;
            this.inputFormatGroupBox.TabStop = false;
            this.inputFormatGroupBox.Text = "③入力形式";
            // 
            // stringText
            // 
            this.stringText.Enabled = false;
            this.stringText.Location = new System.Drawing.Point(12, 129);
            this.stringText.Name = "stringText";
            this.stringText.Size = new System.Drawing.Size(170, 19);
            this.stringText.TabIndex = 20;
            // 
            // stringRadioButton
            // 
            this.stringRadioButton.AutoSize = true;
            this.stringRadioButton.Location = new System.Drawing.Point(12, 109);
            this.stringRadioButton.Name = "stringRadioButton";
            this.stringRadioButton.Size = new System.Drawing.Size(59, 16);
            this.stringRadioButton.TabIndex = 19;
            this.stringRadioButton.TabStop = true;
            this.stringRadioButton.Text = "文字列";
            this.stringRadioButton.UseVisualStyleBackColor = true;
            this.stringRadioButton.CheckedChanged += new System.EventHandler(this.stringRadioButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "（0～59）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "※負の数を入れると加算";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(132, 152);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(50, 20);
            this.clearButton.TabIndex = 22;
            this.clearButton.Text = "クリア";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "※上のテキストボックスに貼り付け\r\nられた内容が一行ずつ入力されます";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 496);
            this.Controls.Add(this.inputFormatGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countSettingText);
            this.Controls.Add(this.secondSettingText);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "AutoInput";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.inputFormatGroupBox.ResumeLayout(false);
            this.inputFormatGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox secondSettingText;
        private System.Windows.Forms.TextBox countSettingText;
        private System.Windows.Forms.TextBox numberText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox substractionSettingText;
        private System.Windows.Forms.CheckBox substractionCheckbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox drivingTimeText2;
        private System.Windows.Forms.TextBox drivingTimeText1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mulchStringText;
        private System.Windows.Forms.RadioButton numberRadioButton;
        private System.Windows.Forms.RadioButton drivingTimeRadioButton;
        private System.Windows.Forms.RadioButton mulchStringRadioButton;
        private System.Windows.Forms.GroupBox inputFormatGroupBox;
        private System.Windows.Forms.TextBox stringText;
        private System.Windows.Forms.RadioButton stringRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clearButton;
    }
}

