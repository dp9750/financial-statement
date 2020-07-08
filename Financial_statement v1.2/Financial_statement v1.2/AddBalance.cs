using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_statement_v1._2
{
    public partial class AddBalance : Form
    {
        private FileHandler FileHandler { set; get; }

        // konstruktor
        public AddBalance(FileHandler FileHandler)
        {
            InitializeComponent();
            this.FileHandler = FileHandler;
        }

        // add button
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string flow = cbFlow.Text;
            string name = txtName.Text;
            decimal cashflow = nudCashflow.Value;
            decimal value = nudValue.Value;

            if (!Main.GetInstance().ValidInfo(flow, name, cashflow, value))
                MessageBox.Show("Invalid Information");
            else {
                FileHandler.WriteToFile(new Balance(name, double.Parse(cashflow.ToString()), Config.GetBalance(flow), double.Parse(value.ToString())));
                Main.GetInstance().Update();
                MessageBox.Show(flow + " Added Successfully");
                Close();
            }
        }

    }
}
