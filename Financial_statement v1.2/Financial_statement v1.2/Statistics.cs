using System;
using System.Windows.Forms;

namespace Financial_statement_v1._2
{
    public partial class Statistics : Form
    {
        private Main Main { set; get; }

        public Statistics()
        {
            InitializeComponent();
            Main = Main.GetInstance();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Main.Show();
            Close();
        }
    }
}
