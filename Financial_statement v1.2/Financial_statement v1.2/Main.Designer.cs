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
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gboxFlow.SuspendLayout();
            this.gboxBalance.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPayday
            // 
            this.lblPayday.AutoSize = true;
            this.lblPayday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPayday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblPayday.Location = new System.Drawing.Point(470, 253);
            this.lblPayday.Name = "lblPayday";
            this.lblPayday.Size = new System.Drawing.Size(95, 19);
            this.lblPayday.TabIndex = 32;
            this.lblPayday.Text = "Payday: 0€";
            // 
            // lblPassive
            // 
            this.lblPassive.AutoSize = true;
            this.lblPassive.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassive.Location = new System.Drawing.Point(476, 108);
            this.lblPassive.Name = "lblPassive";
            this.lblPassive.Size = new System.Drawing.Size(115, 20);
            this.lblPassive.TabIndex = 31;
            this.lblPassive.Text = "Passiv: 0€ (0 %)";
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalExpenses.Location = new System.Drawing.Point(470, 207);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(136, 20);
            this.lblTotalExpenses.TabIndex = 30;
            this.lblTotalExpenses.Text = "Total Expenses: 0€";
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalIncome.Location = new System.Drawing.Point(470, 64);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(127, 20);
            this.lblTotalIncome.TabIndex = 29;
            this.lblTotalIncome.Text = "Total Income: 0€";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(0, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 50);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(0, 148);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(200, 50);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAddBalance
            // 
            this.btnAddBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAddBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBalance.FlatAppearance.BorderSize = 0;
            this.btnAddBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBalance.Location = new System.Drawing.Point(0, 92);
            this.btnAddBalance.Name = "btnAddBalance";
            this.btnAddBalance.Size = new System.Drawing.Size(200, 50);
            this.btnAddBalance.TabIndex = 26;
            this.btnAddBalance.Text = "Add Balance";
            this.btnAddBalance.UseVisualStyleBackColor = false;
            this.btnAddBalance.Click += new System.EventHandler(this.BtnAddBalance_Click);
            // 
            // btnAddFlow
            // 
            this.btnAddFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAddFlow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFlow.FlatAppearance.BorderSize = 0;
            this.btnAddFlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFlow.Location = new System.Drawing.Point(0, 36);
            this.btnAddFlow.Name = "btnAddFlow";
            this.btnAddFlow.Size = new System.Drawing.Size(200, 50);
            this.btnAddFlow.TabIndex = 25;
            this.btnAddFlow.Text = "Add Flow";
            this.btnAddFlow.UseVisualStyleBackColor = false;
            this.btnAddFlow.Click += new System.EventHandler(this.BtnAddFlow_Click);
            // 
            // gboxFlow
            // 
            this.gboxFlow.Controls.Add(this.lbExpense);
            this.gboxFlow.Controls.Add(this.lblExpense);
            this.gboxFlow.Controls.Add(this.lblIncome);
            this.gboxFlow.Controls.Add(this.lbIncome);
            this.gboxFlow.Location = new System.Drawing.Point(216, 12);
            this.gboxFlow.Name = "gboxFlow";
            this.gboxFlow.Size = new System.Drawing.Size(248, 283);
            this.gboxFlow.TabIndex = 33;
            this.gboxFlow.TabStop = false;
            this.gboxFlow.Text = "Flow";
            // 
            // lbExpense
            // 
            this.lbExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lbExpense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lbExpense.FormattingEnabled = true;
            this.lbExpense.ItemHeight = 17;
            this.lbExpense.Location = new System.Drawing.Point(6, 195);
            this.lbExpense.Name = "lbExpense";
            this.lbExpense.Size = new System.Drawing.Size(229, 68);
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
            this.lbIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lbIncome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lbIncome.FormattingEnabled = true;
            this.lbIncome.ItemHeight = 17;
            this.lbIncome.Location = new System.Drawing.Point(10, 52);
            this.lbIncome.Name = "lbIncome";
            this.lbIncome.Size = new System.Drawing.Size(229, 68);
            this.lbIncome.TabIndex = 23;
            this.lbIncome.SelectedIndexChanged += new System.EventHandler(this.LbIncome_SelectedIndexChanged);
            // 
            // gboxBalance
            // 
            this.gboxBalance.Controls.Add(this.lbLiabilities);
            this.gboxBalance.Controls.Add(this.lbAssets);
            this.gboxBalance.Controls.Add(this.lblLiabilities);
            this.gboxBalance.Controls.Add(this.lblAssets);
            this.gboxBalance.Location = new System.Drawing.Point(216, 301);
            this.gboxBalance.Name = "gboxBalance";
            this.gboxBalance.Size = new System.Drawing.Size(498, 126);
            this.gboxBalance.TabIndex = 34;
            this.gboxBalance.TabStop = false;
            this.gboxBalance.Text = "Balance";
            // 
            // lbLiabilities
            // 
            this.lbLiabilities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lbLiabilities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbLiabilities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lbLiabilities.FormattingEnabled = true;
            this.lbLiabilities.ItemHeight = 17;
            this.lbLiabilities.Location = new System.Drawing.Point(263, 48);
            this.lbLiabilities.Name = "lbLiabilities";
            this.lbLiabilities.Size = new System.Drawing.Size(229, 68);
            this.lbLiabilities.TabIndex = 28;
            this.lbLiabilities.SelectedIndexChanged += new System.EventHandler(this.LbLiabilities_SelectedIndexChanged);
            // 
            // lbAssets
            // 
            this.lbAssets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lbAssets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbAssets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lbAssets.FormattingEnabled = true;
            this.lbAssets.ItemHeight = 17;
            this.lbAssets.Location = new System.Drawing.Point(6, 48);
            this.lbAssets.Name = "lbAssets";
            this.lbAssets.Size = new System.Drawing.Size(229, 68);
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
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(686, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 44);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.pnlMain.Controls.Add(this.btnAddFlow);
            this.pnlMain.Controls.Add(this.btnAddBalance);
            this.pnlMain.Controls.Add(this.btnEdit);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(200, 443);
            this.pnlMain.TabIndex = 36;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(732, 443);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gboxBalance);
            this.Controls.Add(this.gboxFlow);
            this.Controls.Add(this.lblPayday);
            this.Controls.Add(this.lblPassive);
            this.Controls.Add(this.lblTotalExpenses);
            this.Controls.Add(this.lblTotalIncome);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.pnlMain.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMain;
    }
}

