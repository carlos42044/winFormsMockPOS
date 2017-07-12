namespace WInFormsMockPOS
{
    partial class Popup
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
            this.tenderTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.required = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.process = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tenderTextBox
            // 
            this.tenderTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tenderTextBox.Location = new System.Drawing.Point(48, 69);
            this.tenderTextBox.Multiline = true;
            this.tenderTextBox.Name = "tenderTextBox";
            this.tenderTextBox.Size = new System.Drawing.Size(94, 20);
            this.tenderTextBox.TabIndex = 8;
            this.tenderTextBox.TextChanged += new System.EventHandler(this.tenderTextBox_TextChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.totalLabel.Location = new System.Drawing.Point(107, 15);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(35, 13);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "label1";
            // 
            // Total
            // 
            this.Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Total.AutoSize = true;
            this.Total.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(45, 13);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(39, 16);
            this.Total.TabIndex = 6;
            this.Total.Text = "Total";
            // 
            // required
            // 
            this.required.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.required.AutoSize = true;
            this.required.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.required.ForeColor = System.Drawing.Color.Red;
            this.required.Location = new System.Drawing.Point(45, 41);
            this.required.Name = "required";
            this.required.Size = new System.Drawing.Size(58, 16);
            this.required.TabIndex = 12;
            this.required.Text = "required";
            this.required.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.process, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(177, 31);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(3, 3);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(75, 23);
            this.process.TabIndex = 0;
            this.process.Text = "Process";
            this.process.UseVisualStyleBackColor = true;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(91, 3);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.totalLabel);
            this.splitContainer1.Panel1.Controls.Add(this.Total);
            this.splitContainer1.Panel1.Controls.Add(this.tenderTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.required);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Size = new System.Drawing.Size(193, 185);
            this.splitContainer1.SplitterDistance = 92;
            this.splitContainer1.TabIndex = 15;
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 220);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Popup";
            this.Text = "Popup";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tenderTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label required;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.Button cancel;
    }
}