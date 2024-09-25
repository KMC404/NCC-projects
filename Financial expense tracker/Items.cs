using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Financial_expense_tracker
{
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_transactions.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Description: " + txtDescription.Text + "\n\n " + "Cost: " + txtCost.Text + "\n\n " + "Type: " + cmbType.SelectedItem + "\n\n " + "Month: " + cmbMonth.SelectedItem);

            con.Open();
            string transaction = "SELECT *  FROM tbl_transactions WHERE Description= '" + txtDescription.Text + "' and Cost= '" + txtCost.Text + "' and Payment Type= '" +cmbType.SelectedItem+ "' and Month= '"+cmbMonth.SelectedItem+"'" ;
            cmd = new OleDbCommand(transaction, con);
           

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmWelcome().Show();
            this.Hide();
        }
    }
}
