namespace WInFormsMockPOS
{
    partial class Settings
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
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioImage = new System.Windows.Forms.RadioButton();
            this.radioDropdown = new System.Windows.Forms.RadioButton();
            this.radioLabel = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.popupWindow = new System.Windows.Forms.RadioButton();
            this.radioWindow = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.Location = new System.Drawing.Point(7, 35);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(61, 17);
            this.radioButton.TabIndex = 2;
            this.radioButton.Text = "Buttons";
            this.radioButton.UseVisualStyleBackColor = true;
            this.radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.okBtn);
            this.groupBox1.Controls.Add(this.radioImage);
            this.groupBox1.Controls.Add(this.radioDropdown);
            this.groupBox1.Controls.Add(this.radioLabel);
            this.groupBox1.Controls.Add(this.radioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioImage
            // 
            this.radioImage.AutoSize = true;
            this.radioImage.Location = new System.Drawing.Point(7, 81);
            this.radioImage.Name = "radioImage";
            this.radioImage.Size = new System.Drawing.Size(59, 17);
            this.radioImage.TabIndex = 4;
            this.radioImage.Text = "Images";
            this.radioImage.UseVisualStyleBackColor = true;
            this.radioImage.CheckedChanged += new System.EventHandler(this.radioImage_CheckedChanged);
            // 
            // radioDropdown
            // 
            this.radioDropdown.AutoSize = true;
            this.radioDropdown.Location = new System.Drawing.Point(7, 58);
            this.radioDropdown.Name = "radioDropdown";
            this.radioDropdown.Size = new System.Drawing.Size(74, 17);
            this.radioDropdown.TabIndex = 3;
            this.radioDropdown.Text = "Dropdown";
            this.radioDropdown.UseVisualStyleBackColor = true;
            this.radioDropdown.CheckedChanged += new System.EventHandler(this.radioDropdown_CheckedChanged);
            // 
            // radioLabel
            // 
            this.radioLabel.AutoSize = true;
            this.radioLabel.Location = new System.Drawing.Point(7, 12);
            this.radioLabel.Name = "radioLabel";
            this.radioLabel.Size = new System.Drawing.Size(56, 17);
            this.radioLabel.TabIndex = 1;
            this.radioLabel.Text = "Labels";
            this.radioLabel.UseVisualStyleBackColor = true;
            this.radioLabel.Click += new System.EventHandler(this.radioLabel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.popupWindow);
            this.groupBox2.Controls.Add(this.radioWindow);
            this.groupBox2.Location = new System.Drawing.Point(167, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 138);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // popupWindow
            // 
            this.popupWindow.AutoSize = true;
            this.popupWindow.Location = new System.Drawing.Point(7, 35);
            this.popupWindow.Name = "popupWindow";
            this.popupWindow.Size = new System.Drawing.Size(98, 17);
            this.popupWindow.TabIndex = 1;
            this.popupWindow.Text = "Popup Window";
            this.popupWindow.UseVisualStyleBackColor = true;
            this.popupWindow.CheckedChanged += new System.EventHandler(this.PopupWindow_CheckedChanged);
            // 
            // radioWindow
            // 
            this.radioWindow.AutoSize = true;
            this.radioWindow.Checked = true;
            this.radioWindow.Location = new System.Drawing.Point(7, 12);
            this.radioWindow.Name = "radioWindow";
            this.radioWindow.Size = new System.Drawing.Size(95, 17);
            this.radioWindow.TabIndex = 0;
            this.radioWindow.TabStop = true;
            this.radioWindow.Text = "Inside Window";
            this.radioWindow.UseVisualStyleBackColor = true;
            this.radioWindow.CheckedChanged += new System.EventHandler(this.radioWindow_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pay Settings";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(182, 163);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 235);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioLabel;
        private System.Windows.Forms.RadioButton radioButton;
        private System.Windows.Forms.RadioButton radioImage;
        private System.Windows.Forms.RadioButton radioDropdown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton popupWindow;
        private System.Windows.Forms.RadioButton radioWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okBtn;
    }
}