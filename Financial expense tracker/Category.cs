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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new frmChart().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new frmWelcome().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmItems().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmItems().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmItems().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmItems().Show();
            this.Hide();
        }
    }
}
