namespace Financial_statement_v1._2
{
    partial class AddBalance
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
            this.lblValue = new System.Windows.Forms.Label();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.lblCashflow = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFlow = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudCashflow = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbFlow = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCashflow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(12, 286);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(45, 17);
            this.lblValue.TabIndex = 24;
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
            this.nudValue.TabIndex = 23;
            // 
            // lblCashflow
            // 
            this.lblCashflow.AutoSize = true;
            this.lblCashflow.Location = new System.Drawing.Point(12, 219);
            this.lblCashflow.Name = "lblCashflow";
            this.lblCashflow.Size = new System.Drawing.Size(69, 17);
            this.lblCashflow.TabIndex = 22;
            this.lblCashflow.Text = "Cashflow";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 147);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 17);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name";
            // 
            // lblFlow
            // 
            this.lblFlow.AutoSize = true;
            this.lblFlow.Location = new System.Drawing.Point(12, 77);
            this.lblFlow.Name = "lblFlow";
            this.lblFlow.Size = new System.Drawing.Size(92, 17);
            this.lblFlow.TabIndex = 20;
            this.lblFlow.Text = "Balance Type";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 356);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 33);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            this.nudCashflow.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 171);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 23);
            this.txtName.TabIndex = 17;
            // 
            // cbFlow
            // 
            this.cbFlow.FormattingEnabled = true;
            this.cbFlow.Items.AddRange(new object[] {
            "Asset",
            "Liability"});
            this.cbFlow.Location = new System.Drawing.Point(12, 101);
            this.cbFlow.Name = "cbFlow";
            this.cbFlow.Size = new System.Drawing.Size(151, 25);
            this.cbFlow.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 26;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(151, 23);
            this.txtID.TabIndex = 25;
            // 
            // AddBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 409);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.lblCashflow);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFlow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudCashflow);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbFlow);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Balance";
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCashflow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Label lblCashflow;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFlow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudCashflow;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbFlow;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
    }
}