using System;
using System.Windows.Forms;

namespace Financial_statement_v1._2
{
    public partial class EditFlow : Form
    {
        // povezava na main
        private Main instance = null;

        // element za obdelavo
        private Element element;

        // File Handler za datoteke
        private FileHandler FileHandler;

        // konstruktor
        public EditFlow(Element element, FileHandler FileHandler)
        {
            InitializeComponent();
            this.element = element;
            this.FileHandler = FileHandler;
        }

        // form load
        private void EditFlow_Load(object sender, EventArgs e)
        {
            instance = Main.GetInstance();
            FillInfo();
        }

        // button 'Update'
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string flow = cbFlow.Text;
            string name = txtName.Text;
            decimal cashflow = nudCashflow.Value;

            if (!instance.ValidInfo(flow, name, cashflow))
                MessageBox.Show("Invalid Information");
            else {
                Element newElement = new Flow(name, double.Parse(cashflow.ToString()), Config.GetFlow(flow));

                FileHandler.DeleteElement(element);
                FileHandler.WriteToFile(newElement);

                instance.Update();
                instance.DisableButtons();

                MessageBox.Show("Element Updated Successfully");
                Close();
            }
        }

        #region Fill Info

        // Select The right Type
        private void SelectFlow()
        {
            int selectedIndex = 0;
            
            for (int i = 0; i <= cbFlow.Items.Count - 1; i++) {
                cbFlow.SelectedIndex = i;
                if ((string)cbFlow.SelectedItem.ToString() == element.GetFlow().ToString()) {
                    selectedIndex = i;
                    break;
                }
            }

            cbFlow.SelectedIndex = selectedIndex;
        }

        // Fill The Information
        private void FillInfo()
        {
            SelectFlow();
            txtName.Text = element.GetName();
            nudCashflow.Value = decimal.Parse(element.GetCashflow().ToString());
        }

        #endregion

    }
}
