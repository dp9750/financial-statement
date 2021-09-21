namespace Financial_statement_v1._2
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.chAllocation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblEmrgFund = new System.Windows.Forms.Label();
            this.nudMonths = new System.Windows.Forms.NumericUpDown();
            this.lblEmrgFundLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTotalIncome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblTotalExpenses = new System.Windows.Forms.Label();
            this.LblTotalAssets = new System.Windows.Forms.Label();
            this.LblTotalLiabilities = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chAllocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonths)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(604, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 41);
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
            this.pnlTop.Size = new System.Drawing.Size(652, 41);
            this.pnlTop.TabIndex = 37;
            // 
            // chAllocation
            // 
            chartArea1.Name = "ChartArea1";
            this.chAllocation.ChartAreas.Add(chartArea1);
            this.chAllocation.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.chAllocation.Legends.Add(legend1);
            this.chAllocation.Location = new System.Drawing.Point(0, 41);
            this.chAllocation.Name = "chAllocation";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chAllocation.Series.Add(series1);
            this.chAllocation.Size = new System.Drawing.Size(330, 339);
            this.chAllocation.TabIndex = 38;
            this.chAllocation.Text = "Allocation";
            // 
            // lblEmrgFund
            // 
            this.lblEmrgFund.AutoSize = true;
            this.lblEmrgFund.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmrgFund.ForeColor = System.Drawing.Color.Black;
            this.lblEmrgFund.Location = new System.Drawing.Point(352, 96);
            this.lblEmrgFund.Name = "lblEmrgFund";
            this.lblEmrgFund.Size = new System.Drawing.Size(31, 19);
            this.lblEmrgFund.TabIndex = 40;
            this.lblEmrgFund.Text = "0 €";
            // 
            // nudMonths
            // 
            this.nudMonths.Location = new System.Drawing.Point(352, 61);
            this.nudMonths.Name = "nudMonths";
            this.nudMonths.Size = new System.Drawing.Size(53, 23);
            this.nudMonths.TabIndex = 41;
            this.nudMonths.ValueChanged += new System.EventHandler(this.NudMonths_ValueChanged);
            // 
            // lblEmrgFundLbl
            // 
            this.lblEmrgFundLbl.AutoSize = true;
            this.lblEmrgFundLbl.ForeColor = System.Drawing.Color.Black;
            this.lblEmrgFundLbl.Location = new System.Drawing.Point(411, 63);
            this.lblEmrgFundLbl.Name = "lblEmrgFundLbl";
            this.lblEmrgFundLbl.Size = new System.Drawing.Size(163, 17);
            this.lblEmrgFundLbl.TabIndex = 42;
            this.lblEmrgFundLbl.Text = "Month Emergency Fund:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(353, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Income";
            // 
            // LblTotalIncome
            // 
            this.LblTotalIncome.AutoSize = true;
            this.LblTotalIncome.ForeColor = System.Drawing.Color.Black;
            this.LblTotalIncome.Location = new System.Drawing.Point(506, 133);
            this.LblTotalIncome.Name = "LblTotalIncome";
            this.LblTotalIncome.Size = new System.Drawing.Size(26, 17);
            this.LblTotalIncome.TabIndex = 45;
            this.LblTotalIncome.Text = "0 €";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(353, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Expenses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(353, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Assets";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(353, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Liabilities";
            // 
            // LblTotalExpenses
            // 
            this.LblTotalExpenses.AutoSize = true;
            this.LblTotalExpenses.ForeColor = System.Drawing.Color.Black;
            this.LblTotalExpenses.Location = new System.Drawing.Point(506, 162);
            this.LblTotalExpenses.Name = "LblTotalExpenses";
            this.LblTotalExpenses.Size = new System.Drawing.Size(26, 17);
            this.LblTotalExpenses.TabIndex = 49;
            this.LblTotalExpenses.Text = "0 €";
            // 
            // LblTotalAssets
            // 
            this.LblTotalAssets.AutoSize = true;
            this.LblTotalAssets.ForeColor = System.Drawing.Color.Black;
            this.LblTotalAssets.Location = new System.Drawing.Point(506, 191);
            this.LblTotalAssets.Name = "LblTotalAssets";
            this.LblTotalAssets.Size = new System.Drawing.Size(26, 17);
            this.LblTotalAssets.TabIndex = 50;
            this.LblTotalAssets.Text = "0 €";
            // 
            // LblTotalLiabilities
            // 
            this.LblTotalLiabilities.AutoSize = true;
            this.LblTotalLiabilities.ForeColor = System.Drawing.Color.Black;
            this.LblTotalLiabilities.Location = new System.Drawing.Point(506, 220);
            this.LblTotalLiabilities.Name = "LblTotalLiabilities";
            this.LblTotalLiabilities.Size = new System.Drawing.Size(26, 17);
            this.LblTotalLiabilities.TabIndex = 51;
            this.LblTotalLiabilities.Text = "0 €";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(652, 380);
            this.Controls.Add(this.LblTotalLiabilities);
            this.Controls.Add(this.LblTotalAssets);
            this.Controls.Add(this.LblTotalExpenses);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblTotalIncome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmrgFundLbl);
            this.Controls.Add(this.nudMonths);
            this.Controls.Add(this.lblEmrgFund);
            this.Controls.Add(this.chAllocation);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chAllocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonths)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.DataVisualization.Charting.Chart chAllocation;
        private System.Windows.Forms.Label lblEmrgFund;
        private System.Windows.Forms.NumericUpDown nudMonths;
        private System.Windows.Forms.Label lblEmrgFundLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTotalIncome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblTotalExpenses;
        private System.Windows.Forms.Label LblTotalAssets;
        private System.Windows.Forms.Label LblTotalLiabilities;
    }
}