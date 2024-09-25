using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // connection to database 

namespace Financial_expense_tracker
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();

            
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            if (txtusername.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Please provide a Username and Password", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Your Password must have a minimum of 8 characters and must have One Uppercase letter", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); // validation of textboxes
            }
            else if (txtPassword.Text == txtComPassword.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + txtusername.Text + "','" + txtPassword.Text + " ' )";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtusername.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";

                MessageBox.Show("Your account has been successfully created", "Registration complete", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


            else 
            {
                MessageBox.Show("Password does not match, Re-enter Password", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }

            
            
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)   // To show/hide the password
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtusername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))  // Only accepting alphanumeric values
            {
                e.Handled = true;
            }
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
