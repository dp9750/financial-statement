using System;
using System.Windows.Forms;

namespace Financial_statement_v1._2
{
    public partial class EditFlow : Form
    {
        // povezava na main
        private Main Main = null;

        // element za obdelavo
        private Element element { set; get; }

        // File Handler za datoteke
        private FileHandler FileHandler { set; get; }

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
            Main = Main.GetInstance();
            FillInfo();
        }

        // button 'Update'
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string flow = cbFlow.Text;
            string name = txtName.Text;
            decimal cashflow = nudCashflow.Value;

            if (!Main.ValidInfo(flow, name, cashflow))
                MessageBox.Show("Invalid Information");
            else {
                Element newElement = new Flow(name, double.Parse(cashflow.ToString()), Config.GetFlow(flow));

                FileHandler.DeleteElement(element);
                FileHandler.WriteToFile(newElement);

                Main.Update();
                Main.DisableButtons();

                MessageBox.Show("Element Updated Successfully");
                Main.Show();
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Main.Show();
            Close();
        }
    }
}
