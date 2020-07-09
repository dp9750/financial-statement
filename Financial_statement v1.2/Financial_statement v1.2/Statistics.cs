using System;
using System.Windows.Forms;

namespace Financial_statement_v1._2
{
    public partial class Statistics : Form
    {
        private Main Main { set; get; }

        public Statistics()
        {
            InitializeComponent();
            Main = Main.GetInstance();
            SetChart();

            nudMonths.Value = 6;
            EmergencyFund();
        }

        private void SetChart()
        {
            chAllocation.Titles.Add("Cashflow");

            double income, expenses, assets, liabilities;
            income = expenses = assets = liabilities = 0;

            foreach(Element e in Main.elements) {
                if (e.GetType() == typeof(Balance)) {
                    if (e.GetBalance() == Config.Balance.Asset)
                        assets += e.GetCashflow();
                    else
                        liabilities += e.GetCashflow();
                } else {
                    if (e.GetFlow() == Config.Flow.Income)
                        income += e.GetCashflow();
                    else
                        expenses += e.GetCashflow();
                }
            }

            chAllocation.Series["s1"].Points.AddXY("Income", income);
            chAllocation.Series["s1"].Points.AddXY("Expenses", expenses);
            chAllocation.Series["s1"].Points.AddXY("Assets", assets);
            chAllocation.Series["s1"].Points.AddXY("Liabilities", liabilities);
        }

        private void EmergencyFund()
        {
            lblEmrgFund.Text = double.Parse(nudMonths.Value.ToString()) * Main.TotalExpenses() + "";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Main.Show();
            Close();
        }

        private void NudMonths_ValueChanged(object sender, EventArgs e)
        {
            EmergencyFund();
        }

    }
}
