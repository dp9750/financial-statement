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
    public partial class RentalManager : Form
    {
        private Main Main = null;

        // Konstruktor
        public RentalManager()
        {
            InitializeComponent();
            this.Main = Main.GetInstance();
        }

        // Form closed
        private void RentalManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Main.Show();
        }
    }
}
