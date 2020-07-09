using System;
using System.Windows.Forms;

namespace Financial_statement_v1._2
{
    public partial class AddFlow : Form
    {
        private Main Main { set; get; }
        private FileHandler FileHandler { set; get; }

        public AddFlow(FileHandler FileHandler)
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

            if (!Main.ValidInfo(flow, name, cashflow))
                MessageBox.Show("Invalid Information");
            else {
                FileHandler.WriteToFile(new Flow(name, double.Parse(cashflow.ToString()), Config.GetFlow(flow)));
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
