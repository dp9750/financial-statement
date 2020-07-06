namespace Financial_statement_v1._2
{
    partial class EditBalance
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.lblCashflow = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFlow = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.nudCashflow = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbBalance = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCashflow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(151, 23);
            this.txtID.TabIndex = 36;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(12, 286);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(45, 17);
            this.lblValue.TabIndex = 35;
            this.lblValue.Text = "Value";
            // 
            // nudValue
            // 
            this.nudValue.Location = new System.Drawing.Point(16, 310);
            this.nudValue.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(147, 23);
            this.nudValue.TabIndex = 34;
            // 
            // lblCashflow
            // 
            this.lblCashflow.AutoSize = true;
            this.lblCashflow.Location = new System.Drawing.Point(12, 219);
            this.lblCashflow.Name = "lblCashflow";
            this.lblCashflow.Size = new System.Drawing.Size(69, 17);
            this.lblCashflow.TabIndex = 33;
            this.lblCashflow.Text = "Cashflow";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 147);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 17);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "Name";
            // 
            // lblFlow
            // 
            this.lblFlow.AutoSize = true;
            this.lblFlow.Location = new System.Drawing.Point(12, 77);
            this.lblFlow.Name = "lblFlow";
            this.lblFlow.Size = new System.Drawing.Size(92, 17);
            this.lblFlow.TabIndex = 31;
            this.lblFlow.Text = "Balance Type";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(16, 356);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 33);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // nudCashflow
            // 
            this.nudCashflow.Location = new System.Drawing.Point(16, 243);
            this.nudCashflow.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudCashflow.Name = "nudCashflow";
            this.nudCashflow.Size = new System.Drawing.Size(147, 23);
            this.nudCashflow.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 171);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 23);
            this.txtName.TabIndex = 28;
            // 
            // cbBalance
            // 
            this.cbBalance.FormattingEnabled = true;
            this.cbBalance.Items.AddRange(new object[] {
            "Asset",
            "Liability"});
            this.cbBalance.Location = new System.Drawing.Point(12, 101);
            this.cbBalance.Name = "cbBalance";
            this.cbBalance.Size = new System.Drawing.Size(151, 25);
            this.cbBalance.TabIndex = 27;
            // 
            // EditBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 412);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.lblCashflow);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFlow);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.nudCashflow);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbBalance);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Balance";
            this.Load += new System.EventHandler(this.EditBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCashflow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Label lblCashflow;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFlow;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown nudCashflow;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbBalance;
    }
}