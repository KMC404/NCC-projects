using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SecureHub_Application
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            
        }
        // Setting up connection to database //
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_usersp.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            // Linking the input fields to the database // 
            con.Open();
            string login = "SELECT * FROM tbl_usersp WHERE username= '" + txtUsername.Text + "' and password= '" + txtPassword.Text + "' ";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true) 
            {
                MessageBox.Show("Successful login","Welcome to SecureHub", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Menu().Show();
                this.Hide();
            }

            else
            {
                //validation for the login process//
                MessageBox.Show("Invalid credentials, Try again.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Clear function//
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            //To toggle the show password functcion//
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
              
            }
            else
            {
                txtPassword.PasswordChar = '•';
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
