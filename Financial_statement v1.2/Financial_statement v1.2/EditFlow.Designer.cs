namespace Financial_statement_v1._2
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCashflow = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFlow = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.nudCashflow = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbFlow = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCashflow)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(11, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(151, 23);
            this.txtID.TabIndex = 24;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "ID";
            // 
            // lblCashflow
            // 
            this.lblCashflow.AutoSize = true;
            this.lblCashflow.Location = new System.Drawing.Point(11, 212);
            this.lblCashflow.Name = "lblCashflow";
            this.lblCashflow.Size = new System.Drawing.Size(69, 17);
            this.lblCashflow.TabIndex = 22;
            this.lblCashflow.Text = "Cashflow";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 17);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name";
            // 
            // lblFlow
            // 
            this.lblFlow.AutoSize = true;
            this.lblFlow.Location = new System.Drawing.Point(11, 70);
            this.lblFlow.Name = "lblFlow";
            this.lblFlow.Size = new System.Drawing.Size(100, 17);
            this.lblFlow.TabIndex = 20;
            this.lblFlow.Text = "Flow Direction";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 290);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 33);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // nudCashflow
            // 
            this.nudCashflow.Location = new System.Drawing.Point(15, 236);
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
            this.txtName.Location = new System.Drawing.Point(11, 164);
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
            this.cbFlow.Location = new System.Drawing.Point(11, 94);
            this.cbFlow.Name = "cbFlow";
            this.cbFlow.Size = new System.Drawing.Size(151, 25);
            this.cbFlow.TabIndex = 16;
            // 
            // EditFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 345);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCashflow);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFlow);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.nudCashflow);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbFlow);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Flow";
            this.Load += new System.EventHandler(this.EditFlow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCashflow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCashflow;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFlow;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown nudCashflow;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbFlow;
    }
}