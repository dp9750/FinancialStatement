﻿namespace Financial_statement_v1._2
{
    partial class EditFlow
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
            this.lblCashflow = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFlow = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.nudCashflow = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbFlow = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudCashflow)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCashflow
            // 
            this.lblCashflow.AutoSize = true;
            this.lblCashflow.Location = new System.Drawing.Point(23, 200);
            this.lblCashflow.Name = "lblCashflow";
            this.lblCashflow.Size = new System.Drawing.Size(69, 17);
            this.lblCashflow.TabIndex = 22;
            this.lblCashflow.Text = "Cashflow";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 128);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 17);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name";
            // 
            // lblFlow
            // 
            this.lblFlow.AutoSize = true;
            this.lblFlow.Location = new System.Drawing.Point(23, 58);
            this.lblFlow.Name = "lblFlow";
            this.lblFlow.Size = new System.Drawing.Size(100, 17);
            this.lblFlow.TabIndex = 20;
            this.lblFlow.Text = "Flow Direction";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdate.Location = new System.Drawing.Point(27, 278);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 33);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // nudCashflow
            // 
            this.nudCashflow.Location = new System.Drawing.Point(27, 224);
            this.nudCashflow.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudCashflow.Name = "nudCashflow";
            this.nudCashflow.Size = new System.Drawing.Size(147, 23);
            this.nudCashflow.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(23, 152);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 23);
            this.txtName.TabIndex = 17;
            // 
            // cbFlow
            // 
            this.cbFlow.FormattingEnabled = true;
            this.cbFlow.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cbFlow.Location = new System.Drawing.Point(23, 82);
            this.cbFlow.Name = "cbFlow";
            this.cbFlow.Size = new System.Drawing.Size(151, 25);
            this.cbFlow.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(149, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 44);
            this.btnExit.TabIndex = 36;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(197, 44);
            this.pnlTop.TabIndex = 37;
            // 
            // EditFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(197, 324);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblCashflow);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFlow);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.nudCashflow);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbFlow);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Flow";
            this.Load += new System.EventHandler(this.EditFlow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCashflow)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCashflow;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFlow;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown nudCashflow;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbFlow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlTop;
    }
}