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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.chAllocation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblEmrgFund = new System.Windows.Forms.Label();
            this.nudMonths = new System.Windows.Forms.NumericUpDown();
            this.lblEmrgFundLbl = new System.Windows.Forms.Label();
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
            chartArea2.Name = "ChartArea1";
            this.chAllocation.ChartAreas.Add(chartArea2);
            this.chAllocation.Dock = System.Windows.Forms.DockStyle.Left;
            legend2.Name = "Legend1";
            this.chAllocation.Legends.Add(legend2);
            this.chAllocation.Location = new System.Drawing.Point(0, 41);
            this.chAllocation.Name = "chAllocation";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "s1";
            this.chAllocation.Series.Add(series2);
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
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(652, 380);
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
    }
}