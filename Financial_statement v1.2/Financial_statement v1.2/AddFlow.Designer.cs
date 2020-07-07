namespace Financial_statement_v1._2
{
    partial class AddFlow
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudCashflow = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbFlow = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCashflow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCashflow
            // 
            this.lblCashflow.AutoSize = true;
            this.lblCashflow.Location = new System.Drawing.Point(12, 151);
            this.lblCashflow.Name = "lblCashflow";
            this.lblCashflow.Size = new System.Drawing.Size(69, 17);
            this.lblCashflow.TabIndex = 13;
            this.lblCashflow.Text = "Cashflow";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 17);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // lblFlow
            // 
            this.lblFlow.AutoSize = true;
            this.lblFlow.Location = new System.Drawing.Point(12, 9);
            this.lblFlow.Name = "lblFlow";
            this.lblFlow.Size = new System.Drawing.Size(100, 17);
            this.lblFlow.TabIndex = 11;
            this.lblFlow.Text = "Flow Direction";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 229);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 33);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // nudCashflow
            // 
            this.nudCashflow.Location = new System.Drawing.Point(16, 175);
            this.nudCashflow.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudCashflow.Name = "nudCashflow";
            this.nudCashflow.Size = new System.Drawing.Size(147, 23);
            this.nudCashflow.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 23);
            this.txtName.TabIndex = 8;
            // 
            // cbFlow
            // 
            this.cbFlow.FormattingEnabled = true;
            this.cbFlow.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cbFlow.Location = new System.Drawing.Point(12, 33);
            this.cbFlow.Name = "cbFlow";
            this.cbFlow.Size = new System.Drawing.Size(151, 25);
            this.cbFlow.TabIndex = 7;
            // 
            // AddFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 273);
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
            this.Name = "AddFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Flow";
            ((System.ComponentModel.ISupportInitialize)(this.nudCashflow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCashflow;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFlow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudCashflow;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbFlow;
    }
}