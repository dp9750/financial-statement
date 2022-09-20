using System;
using System.Windows.Forms; 
using System.Collections.Generic;
using System.Drawing;

namespace Financial_statement_v1._2
{
    public partial class Main : Form
    {

        #region Variables

        // povezava
        private static Main instance = null;

        // ime datoteke
        private string file = "file.bin";

        // vsi elementi
        public List<Element> elements;

        // total of everything
        public double totalIncome = 0, totalExpenses = 0, passive = 0, badDebth = 0, totalAssets = 0, totalLiabilities = 0;

        // the selected ID to update or delete
        private int selectedID = 0;

        private FileHandler FileHandler;

        #endregion

        #region Setup

        // konstruktor
        public Main()
        {
            InitializeComponent();
            instance = this;
            elements = new List<Element>();
            FileHandler = new FileHandler(file);
        }

        // form load
        private void Main_Load(object sender, EventArgs e)
        {
            Update();
        }

        // povezava
        public static Main GetInstance()
        {
            return instance;
        }

        #endregion

        #region Validators

        public bool ValidLine(string line)
        {
            string[] words = line.Split(';');

            if (words.Length != 4 && words.Length != 5)
                return false;

            if (!Config.ValidType(words[0]))
                return false;

            if (!int.TryParse(words[1], out _))
                return false;

            if (ExistsID(int.Parse(words[1])))
                return false;

            if (!double.TryParse(words[3], out _))
                return false;

            if (words.Length == 5)
                if (!double.TryParse(words[4], out _))
                    return false;

            return true;
        }

        // used in 'Add Flow'
        public bool ValidInfo(string flow, string name, decimal cashflow)
        {
            if (name == "")
                return false;

            if (!Config.IsFlow(flow))
                return false;

            return double.TryParse(cashflow.ToString(), out _);
        }

        // used in 'Add Balance'
        public bool ValidInfo(string flow, string name, decimal cashflow, decimal value)
        {
            if (name == null || name == "")
                return false;

            if (!Config.IsBalance(flow))
                return false;

            if (!double.TryParse(value.ToString(), out _))
                return false;

            return double.TryParse(cashflow.ToString(), out _);
        }

        public bool ExistsID(int ID)
        {
            foreach (Element e in elements)
                if (e.GetID() == ID)
                    return true;
            return false;
        }

        #endregion

        #region Updates

        // clear all listboxes, reset values
        private void ClearAll()
        {
            lbIncome.Items.Clear();
            lbExpense.Items.Clear();
            lbAssets.Items.Clear();
            lbLiabilities.Items.Clear();

            elements = new List<Element>();
            totalIncome = totalExpenses = passive = badDebth = totalAssets = totalLiabilities = 0;
        }

        // Get passive income in percents
        private int GetPassive()
        {
            if (totalExpenses == 0)
                return 100;

            double percents = passive / totalExpenses * 100;

            if (percents >= 100)
                return 100;

            return (int)percents;
        }

        // updates total income text, passive ...
        private void UpdateInformation()
        {
            double payday = totalIncome - totalExpenses;

            // Set label text's
            lblTotalIncome.Text = "Total Income: " + totalIncome + " €";
            lblTotalExpenses.Text = "Total Expenses: " +  totalExpenses + " €";
            lblPassive.Text = "Passive: " + passive + " € (" + GetPassive() + " %)";
            lblPayday.Text = "Payday: " + payday + " €";
            lblAssets.Text = "Assets: " + totalAssets + " €";

            // Set passive income progress bar width
            pnlProgressActive.Width = pnlProgress.Width * GetPassive() / 100;

            // Set payday label color
            if (payday == 0)
                lblPayday.ForeColor = Color.Black;
            else if (payday > 0)
                lblPayday.ForeColor = Color.Green;
            else
                lblPayday.ForeColor = Color.Red;
        }

        // update all listboxes, total income, total expenses, passive income (+ %)
        public new void Update()
        {
            ClearAll();
            FileHandler.ReadFile();

            foreach (Element e in elements) { // loop through every valid element in read file
                int ID = e.GetID();
                string name = e.GetName();
                double cashflow = e.GetCashflow();

                if(e.GetType() == typeof(Balance)) {                    // if element is asset or liability
                    try {
                        double value = e.GetValue();
                        string output = ID + " " + name + " - " + value + " €";
                        if(e.GetBalance() == Config.Balance.Asset) {    // element is asset
                            lbAssets.Items.Add(output);

                            if(cashflow > 0)
                                lbIncome.Items.Add(ID + " " + name + " - " + cashflow + " €");

                            totalIncome += cashflow;
                            passive += cashflow;
                            totalAssets += e.GetValue();
                        } else {                                        // is liability
                            lbLiabilities.Items.Add(output);
                            lbExpense.Items.Add(ID + " " + name + " - " + cashflow + " €");

                            totalExpenses += cashflow;
                            badDebth += value;
                        }
                    } catch(NotImplementedException) {

                    }              
                } else {
                    string output = ID + " " + name + " - " + cashflow + " €";
                    if (e.GetFlow() == Config.Flow.Income) {
                        lbIncome.Items.Add(output);

                        totalIncome += cashflow;
                    } else {
                        lbExpense.Items.Add(output);

                        totalExpenses += cashflow;
                    }
                }
            }

            UpdateInformation();
        }

        #endregion

        // Build the list with all elements
        public void ProcessLine(string line)
        {
            try {
                string[] words = line.Split(';');

                int ID = int.Parse(words[1]);
                string name = words[2];
                string type = words[0];
                double cashflow = double.Parse(words[3]);

                Element e;
                if (words.Length == 4)
                    e = new Flow(name, cashflow, Config.GetFlow(type));
                else
                    e = new Balance(name, cashflow, Config.GetBalance(type), double.Parse(words[4]));

                e.SetID(ID);
                elements.Add(e);

            } catch(Exception) {
                Console.WriteLine("Error Proccessing Line");
            }
        }

        // Finds the element with given ID
        private Element FindID(int ID)
        {
            foreach (Element e in elements)
                if (ID == e.GetID())
                    return e;
            return null;
        }

        private void EnableButtons()
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        public void DisableButtons()
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            selectedID = 0;
        }

        private int GetID(string line)
        {
            return int.Parse(line.Split(' ')[0]);
        }

        private void ProcessID()
        {
            if (selectedID == 0)
            {
                DisableButtons();
                MessageBox.Show("ID error");
            }
            else
                EnableButtons();
        }

        #region Button Clicks

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAddFlow_Click(object sender, EventArgs e)
        {
            AddFlow window = new AddFlow(FileHandler);
            window.Show();
            Hide();
        }

        private void BtnAddBalance_Click(object sender, EventArgs e)
        {
            AddBalance window = new AddBalance(FileHandler);
            window.Show();
            Hide();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if(selectedID != 0) { 
                Element element = FindID(selectedID);

                if (element == null) {
                    MessageBox.Show("Error with element ID");
                    selectedID = 0;
                } else {
                    if(Balance.ToString() == element.GetType().Name) {
                        EditBalance editBalance = new EditBalance(element, FileHandler);
                        editBalance.Show();
                    } else {
                        EditFlow editFlow = new EditFlow(element, FileHandler);
                        editFlow.Show();
                    }
                    Hide();
                }

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == 0) return;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this element? ", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                FileHandler.DeleteElement(FindID(selectedID));
                selectedID = 0;
                DisableButtons();
                Update();
                MessageBox.Show("Element deleted successfully");
            }
        }

        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            if(elements.Count > 0) {
                Statistics window = new Statistics();
                window.Show();
                Hide();
            }
        }

        #endregion

        #region Selected Index Changed

        private void LbIncome_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                selectedID = GetID(lbIncome.SelectedItem.ToString());
                ProcessID();
            } catch(Exception) {
                selectedID = 0;
                DisableButtons();
            }
        }

        private void LbExpense_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                selectedID = GetID(lbExpense.SelectedItem.ToString());
                ProcessID();
            } catch (Exception) {
                selectedID = 0;
                DisableButtons();
            }
        }

        private void LbAssets_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                selectedID = GetID(lbAssets.SelectedItem.ToString());
                ProcessID();
            } catch (Exception) {
                selectedID = 0;
                DisableButtons();
            }
        }

        private void LbLiabilities_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                selectedID = GetID(lbLiabilities.SelectedItem.ToString());
                ProcessID();
            } catch (Exception) {
                selectedID = 0;
                DisableButtons();
            }
        }

        #endregion

    }
}
