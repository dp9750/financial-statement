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
    public partial class EditBalance : Form
    {
        private Main instance = null; // povezava na main

        private Element element = null; // element za obdelavo

        // konstuktor
        public EditBalance(Element element)
        {
            InitializeComponent();
            this.element = element;
        }

        // form load
        private void EditBalance_Load(object sender, EventArgs e)
        {
            instance = Main.GetInstance();
            FillInfo();
        }

        // button 'Update'
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string balance = cbBalance.Text;
            string name = txtName.Text;
            decimal cashflow = nudCashflow.Value;
            decimal value = nudValue.Value;

            if (!instance.ValidInfo(balance, name, cashflow, value))
                MessageBox.Show("Invalid Information");
            else {
                Element newElement = new Balance(name, double.Parse(cashflow.ToString()), Config.GetBalance(balance), double.Parse(value.ToString()));

                instance.DeleteElement(element);
                instance.WriteToFile(newElement);
                instance.Update();
                instance.DisableButtons();

                MessageBox.Show("Element Updated Successfully");
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

    }
}
