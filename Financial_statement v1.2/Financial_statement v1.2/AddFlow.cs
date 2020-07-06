using System;
using System.Windows.Forms;

namespace Financial_statement_v1._2
{
    public partial class AddFlow : Form
    {
        // konstruktor
        public AddFlow()
        {
            InitializeComponent();
        }

        // Button Add
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string flow = cbFlow.Text;
            string name = txtName.Text;
            decimal cashflow = nudCashflow.Value;

            if (!Main.GetInstance().ValidInfo(ID, flow, name, cashflow))
                MessageBox.Show("Invalid Information");
            else {
                Main.GetInstance().WriteToFile(new Flow(ID, name, double.Parse(cashflow.ToString()), Config.GetFlow(flow)));
                Main.GetInstance().Update();
                MessageBox.Show(flow + " Added Successfully");
                Close();
            }
        }
    }
}
