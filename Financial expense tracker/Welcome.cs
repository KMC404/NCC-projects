using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_expense_tracker
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            new frmCategory().Show();
            this.Hide();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            new frmCategory().Show();
            this.Hide();
        }

        private void btnSUMMARY_Click(object sender, EventArgs e)
        {
            new frmItems().Show();


        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {

        }
    }
}
