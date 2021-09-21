using System;
using System.Windows.Forms;

namespace Financial_statement_v1._2
{
    public partial class Statistics : Form
    {
        private Main Main;

        // Konstruktor
        // Set chart
        // Set emergency fund
        // Set total income, expenses, assets & liabilities
        public Statistics()
        {
            InitializeComponent();
            Main = Main.GetInstance();

            nudMonths.Value = 6;
            SetData();
            SetChart();
            EmergencyFund();
        }

        // Set total income, expenses, assets & liabilities
        private void SetData()
        {
            double assets = 0, liabilties = 0;

            // loop through every valid element
            foreach (Element e in Main.elements)
            { 
                // if element is asset or liability
                if (e.GetType() == typeof(Balance))
                {
                    // element is asset
                    if (e.GetBalance() == Config.Balance.Asset)
                    {
                        if (e.GetValue() > 0)
                            assets += e.GetValue();
                    } 
                    // element is a liabilitie
                    else
                    {
                        if (e.GetValue() > 0)
                            liabilties += e.GetValue();
                    }
                }
            }

            LblTotalIncome.Text = Main.totalIncome.ToString();
            LblTotalExpenses.Text = Main.totalExpenses.ToString();
            LblTotalAssets.Text = assets.ToString();
            LblTotalLiabilities.Text = liabilties.ToString();
        }

        // Add all flows & balances to chart
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

        // Set emergency fund label text to appropriate value
        private void EmergencyFund()
        {
            lblEmrgFund.Text = double.Parse(nudMonths.Value.ToString()) * Main.totalExpenses + "";
        }

        // On exit
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Main.Show();
            Close();
        }

        // Months for emergency fund changed
        private void NudMonths_ValueChanged(object sender, EventArgs e)
        {
            EmergencyFund();
        }

    }
}
