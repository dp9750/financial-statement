using System;
using System.Windows.Forms;

namespace Financial_statement_v1._2
{
    public partial class AddBalance : Form
    {
        private Main Main;
        private FileHandler FileHandler;

        public AddBalance(FileHandler FileHandler)
        {
            InitializeComponent();
            this.Main = Main.GetInstance();
            this.FileHandler = FileHandler;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string flow = cbFlow.Text;
            string name = txtName.Text;
            decimal cashflow = nudCashflow.Value;
            decimal value = nudValue.Value;

            if (!Main.ValidInfo(flow, name, cashflow, value))
                MessageBox.Show("Invalid Information");
            else {
                FileHandler.WriteToFile(new Balance(name, double.Parse(cashflow.ToString()), Config.GetBalance(flow), double.Parse(value.ToString())));
                Main.Update();
                MessageBox.Show(flow + " Added Successfully");
                Main.Show();
                Close();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Main.Show();
            Close();
        }
    }
}
