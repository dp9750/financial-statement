namespace Financial_statement_v1._2
{
    partial class Main
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
            this.lblPayday = new System.Windows.Forms.Label();
            this.lblPassive = new System.Windows.Forms.Label();
            this.lblTotalExpenses = new System.Windows.Forms.Label();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddBalance = new System.Windows.Forms.Button();
            this.btnAddFlow = new System.Windows.Forms.Button();
            this.gboxFlow = new System.Windows.Forms.GroupBox();
            this.lbExpense = new System.Windows.Forms.ListBox();
            this.lblExpense = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lbIncome = new System.Windows.Forms.ListBox();
            this.gboxBalance = new System.Windows.Forms.GroupBox();
            this.lbLiabilities = new System.Windows.Forms.ListBox();
            this.lbAssets = new System.Windows.Forms.ListBox();
            this.lblLiabilities = new System.Windows.Forms.Label();
            this.lblAssets = new System.Windows.Forms.Label();
            this.gboxFlow.SuspendLayout();
            this.gboxBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPayday
            // 
            this.lblPayday.AutoSize = true;
            this.lblPayday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPayday.ForeColor = System.Drawing.Color.Black;
            this.lblPayday.Location = new System.Drawing.Point(261, 246);
            this.lblPayday.Name = "lblPayday";
            this.lblPayday.Size = new System.Drawing.Size(95, 19);
            this.lblPayday.TabIndex = 32;
            this.lblPayday.Text = "Payday: 0€";
            // 
            // lblPassive
            // 
            this.lblPassive.AutoSize = true;
            this.lblPassive.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassive.Location = new System.Drawing.Point(267, 112);
            this.lblPassive.Name = "lblPassive";
            this.lblPassive.Size = new System.Drawing.Size(115, 20);
            this.lblPassive.TabIndex = 31;
            this.lblPassive.Text = "Passiv: 0€ (0 %)";
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalExpenses.Location = new System.Drawing.Point(261, 200);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(136, 20);
            this.lblTotalExpenses.TabIndex = 30;
            this.lblTotalExpenses.Text = "Total Expenses: 0€";
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalIncome.Location = new System.Drawing.Point(261, 57);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(127, 20);
            this.lblTotalIncome.TabIndex = 29;
            this.lblTotalIncome.Text = "Total Income: 0€";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(403, 426);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 31);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(306, 427);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 31);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAddBalance
            // 
            this.btnAddBalance.Location = new System.Drawing.Point(159, 427);
            this.btnAddBalance.Name = "btnAddBalance";
            this.btnAddBalance.Size = new System.Drawing.Size(131, 31);
            this.btnAddBalance.TabIndex = 26;
            this.btnAddBalance.Text = "Add Balance";
            this.btnAddBalance.UseVisualStyleBackColor = true;
            this.btnAddBalance.Click += new System.EventHandler(this.BtnAddBalance_Click);
            // 
            // btnAddFlow
            // 
            this.btnAddFlow.Location = new System.Drawing.Point(12, 427);
            this.btnAddFlow.Name = "btnAddFlow";
            this.btnAddFlow.Size = new System.Drawing.Size(131, 31);
            this.btnAddFlow.TabIndex = 25;
            this.btnAddFlow.Text = "Add Flow";
            this.btnAddFlow.UseVisualStyleBackColor = true;
            this.btnAddFlow.Click += new System.EventHandler(this.BtnAddFlow_Click);
            // 
            // gboxFlow
            // 
            this.gboxFlow.Controls.Add(this.lbExpense);
            this.gboxFlow.Controls.Add(this.lblExpense);
            this.gboxFlow.Controls.Add(this.lblIncome);
            this.gboxFlow.Controls.Add(this.lbIncome);
            this.gboxFlow.Location = new System.Drawing.Point(7, 5);
            this.gboxFlow.Name = "gboxFlow";
            this.gboxFlow.Size = new System.Drawing.Size(248, 283);
            this.gboxFlow.TabIndex = 33;
            this.gboxFlow.TabStop = false;
            this.gboxFlow.Text = "Flow";
            // 
            // lbExpense
            // 
            this.lbExpense.FormattingEnabled = true;
            this.lbExpense.ItemHeight = 17;
            this.lbExpense.Location = new System.Drawing.Point(6, 195);
            this.lbExpense.Name = "lbExpense";
            this.lbExpense.Size = new System.Drawing.Size(229, 72);
            this.lbExpense.TabIndex = 26;
            this.lbExpense.SelectedIndexChanged += new System.EventHandler(this.LbExpense_SelectedIndexChanged);
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.Location = new System.Drawing.Point(6, 171);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(59, 17);
            this.lblExpense.TabIndex = 25;
            this.lblExpense.Text = "Expense";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(6, 28);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(57, 17);
            this.lblIncome.TabIndex = 24;
            this.lblIncome.Text = "Income";
            // 
            // lbIncome
            // 
            this.lbIncome.FormattingEnabled = true;
            this.lbIncome.ItemHeight = 17;
            this.lbIncome.Location = new System.Drawing.Point(10, 52);
            this.lbIncome.Name = "lbIncome";
            this.lbIncome.Size = new System.Drawing.Size(229, 72);
            this.lbIncome.TabIndex = 23;
            this.lbIncome.SelectedIndexChanged += new System.EventHandler(this.LbIncome_SelectedIndexChanged);
            // 
            // gboxBalance
            // 
            this.gboxBalance.Controls.Add(this.lbLiabilities);
            this.gboxBalance.Controls.Add(this.lbAssets);
            this.gboxBalance.Controls.Add(this.lblLiabilities);
            this.gboxBalance.Controls.Add(this.lblAssets);
            this.gboxBalance.Location = new System.Drawing.Point(7, 294);
            this.gboxBalance.Name = "gboxBalance";
            this.gboxBalance.Size = new System.Drawing.Size(498, 126);
            this.gboxBalance.TabIndex = 34;
            this.gboxBalance.TabStop = false;
            this.gboxBalance.Text = "Balance";
            // 
            // lbLiabilities
            // 
            this.lbLiabilities.FormattingEnabled = true;
            this.lbLiabilities.ItemHeight = 17;
            this.lbLiabilities.Location = new System.Drawing.Point(263, 48);
            this.lbLiabilities.Name = "lbLiabilities";
            this.lbLiabilities.Size = new System.Drawing.Size(229, 72);
            this.lbLiabilities.TabIndex = 28;
            this.lbLiabilities.SelectedIndexChanged += new System.EventHandler(this.LbLiabilities_SelectedIndexChanged);
            // 
            // lbAssets
            // 
            this.lbAssets.FormattingEnabled = true;
            this.lbAssets.ItemHeight = 17;
            this.lbAssets.Location = new System.Drawing.Point(6, 48);
            this.lbAssets.Name = "lbAssets";
            this.lbAssets.Size = new System.Drawing.Size(229, 72);
            this.lbAssets.TabIndex = 27;
            this.lbAssets.SelectedIndexChanged += new System.EventHandler(this.LbAssets_SelectedIndexChanged);
            // 
            // lblLiabilities
            // 
            this.lblLiabilities.AutoSize = true;
            this.lblLiabilities.Location = new System.Drawing.Point(260, 28);
            this.lblLiabilities.Name = "lblLiabilities";
            this.lblLiabilities.Size = new System.Drawing.Size(65, 17);
            this.lblLiabilities.TabIndex = 26;
            this.lblLiabilities.Text = "Liabilities";
            // 
            // lblAssets
            // 
            this.lblAssets.AutoSize = true;
            this.lblAssets.Location = new System.Drawing.Point(5, 28);
            this.lblAssets.Name = "lblAssets";
            this.lblAssets.Size = new System.Drawing.Size(45, 17);
            this.lblAssets.TabIndex = 25;
            this.lblAssets.Text = "Assets";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 470);
            this.Controls.Add(this.gboxBalance);
            this.Controls.Add(this.gboxFlow);
            this.Controls.Add(this.lblPayday);
            this.Controls.Add(this.lblPassive);
            this.Controls.Add(this.lblTotalExpenses);
            this.Controls.Add(this.lblTotalIncome);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddBalance);
            this.Controls.Add(this.btnAddFlow);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gboxFlow.ResumeLayout(false);
            this.gboxFlow.PerformLayout();
            this.gboxBalance.ResumeLayout(false);
            this.gboxBalance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPayday;
        private System.Windows.Forms.Label lblPassive;
        private System.Windows.Forms.Label lblTotalExpenses;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddBalance;
        private System.Windows.Forms.Button btnAddFlow;
        private System.Windows.Forms.GroupBox gboxFlow;
        private System.Windows.Forms.ListBox lbExpense;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.ListBox lbIncome;
        private System.Windows.Forms.GroupBox gboxBalance;
        private System.Windows.Forms.ListBox lbLiabilities;
        private System.Windows.Forms.ListBox lbAssets;
        private System.Windows.Forms.Label lblLiabilities;
        private System.Windows.Forms.Label lblAssets;
    }
}

