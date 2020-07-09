using System;
using System.Windows.Forms;

namespace Financial_statement_v1._2
{
    public partial class EditBalance : Form
    {
        private Main Main = null; // povezava na main

        private Element element; // element za obdelavo

        private FileHandler FileHandler;

        // konstuktor
        public EditBalance(Element element, FileHandler FileHandler)
        {
            InitializeComponent();
            this.element = element;
            this.Main = Main.GetInstance();
            this.FileHandler = FileHandler;
        }

        // form load
        private void EditBalance_Load(object sender, EventArgs e)
        {
            FillInfo();
        }

        // Button Update
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string balance = cbBalance.Text;
            string name = txtName.Text;
            decimal cashflow = nudCashflow.Value;
            decimal value = nudValue.Value;

            if (!Main.ValidInfo(balance, name, cashflow, value))
                MessageBox.Show("Invalid Information");
            else
            {
                Element newElement = new Balance(name, double.Parse(cashflow.ToString()), Config.GetBalance(balance), double.Parse(value.ToString()));

                FileHandler.DeleteElement(element);
                FileHandler.WriteToFile(newElement);

                Main.Update();
                Main.DisableButtons();

                MessageBox.Show("Element Updated Successfully");
                Main.Show();
                Close();
            }
        }

        // Filling the information
        #region Fill Info

        // Select the right Balance
        private void SelectBalance()
        {
            int selectedIndex = 0;

            for (int i = 0; i <= cbBalance.Items.Count - 1; i++) {
                cbBalance.SelectedIndex = i;
                if ((string)cbBalance.SelectedItem.ToString() == element.GetBalance().ToString()) {
                    selectedIndex = i;
                    break;
                }
            }

            cbBalance.SelectedIndex = selectedIndex;
        }

        // Fill The Information
        private void FillInfo()
        {
            txtName.Text = element.GetName();
            nudCashflow.Value = decimal.Parse(element.GetCashflow().ToString());
            SelectBalance();
            nudValue.Value = decimal.Parse(element.GetValue().ToString());
        }

        #endregion

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Main.Show();
            Close();
        }

        
    }
}
