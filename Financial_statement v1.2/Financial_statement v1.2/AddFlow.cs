using System;
using System.Windows.Forms;

namespace Financial_statement_v1._2
{
    public partial class AddFlow : Form
    {
        private FileHandler FileHandler { set; get; }

        // konstruktor
        public AddFlow(FileHandler FileHandler)
        {
            InitializeComponent();
            this.FileHandler = FileHandler;
        }

        // Button Add
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string flow = cbFlow.Text;
            string name = txtName.Text;
            decimal cashflow = nudCashflow.Value;

            if (!Main.GetInstance().ValidInfo(flow, name, cashflow))
                MessageBox.Show("Invalid Information");
            else {
                FileHandler.WriteToFile(new Flow(name, double.Parse(cashflow.ToString()), Config.GetFlow(flow)));
                Main.GetInstance().Update();
                MessageBox.Show(flow + " Added Successfully");
                Close();
            }
        }
    }
}
