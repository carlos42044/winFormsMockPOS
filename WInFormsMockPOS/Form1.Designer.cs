﻿namespace WInFormsMockPOS
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.required = new System.Windows.Forms.Label();
            this.tendered = new System.Windows.Forms.TextBox();
            this.pay = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.process = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(446, 215);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 279);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(452, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cart";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(452, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trans";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(456, 253);
            this.dataGridView2.TabIndex = 0;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(3, 3);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button2_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(84, 3);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(3, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(51, 16);
            this.username.TabIndex = 3;
            this.username.Text = "label1";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(60, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(45, 16);
            this.date.TabIndex = 4;
            this.date.Text = "label1";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.username);
            this.flowLayoutPanel2.Controls.Add(this.date);
            this.flowLayoutPanel2.Controls.Add(this.tabControl1);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(522, 337);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.add);
            this.flowLayoutPanel3.Controls.Add(this.clear);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(218, 26);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // required
            // 
            this.required.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.required.AutoSize = true;
            this.required.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.required.Location = new System.Drawing.Point(235, 6);
            this.required.Name = "required";
            this.required.Size = new System.Drawing.Size(58, 16);
            this.required.TabIndex = 8;
            this.required.Text = "required";
            this.required.Visible = false;
            // 
            // tendered
            // 
            this.tendered.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tendered.Location = new System.Drawing.Point(171, 4);
            this.tendered.Name = "tendered";
            this.tendered.Size = new System.Drawing.Size(58, 20);
            this.tendered.TabIndex = 7;
            this.tendered.Text = "0.00";
            this.tendered.Visible = false;
            this.tendered.TextChanged += new System.EventHandler(this.tendered_TextChanged);
            // 
            // pay
            // 
            this.pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.Location = new System.Drawing.Point(90, 3);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(75, 23);
            this.pay.TabIndex = 0;
            this.pay.Text = "Pay";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(48, 6);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(36, 16);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "0.00";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.totalLabel);
            this.flowLayoutPanel1.Controls.Add(this.pay);
            this.flowLayoutPanel1.Controls.Add(this.tendered);
            this.flowLayoutPanel1.Controls.Add(this.required);
            this.flowLayoutPanel1.Controls.Add(this.process);
            this.flowLayoutPanel1.Controls.Add(this.cancel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 304);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(519, 32);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // process
            // 
            this.process.Enabled = false;
            this.process.Location = new System.Drawing.Point(299, 3);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(75, 23);
            this.process.TabIndex = 9;
            this.process.Text = "Process";
            this.process.UseVisualStyleBackColor = true;
            this.process.Visible = false;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(380, 3);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Visible = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 339);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "Form1";
            this.Text = "WinFormsMockPos";
            this.Load += new System.EventHandler(this.WinFormsMockPOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.TextBox tendered;
        private System.Windows.Forms.Label required;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.Button cancel;
    }
}

