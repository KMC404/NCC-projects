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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();

           
        }

        OleDbConnection con = new OleDbConnection("Provider= Microsoft.Jet.OLEDB.4.0;Data Source=db_usersp.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Registration validation // 
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Required Username and Password fields are empty!", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if(txtPassword.Text == txtComPassword.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_usersp VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "')";
                cmd= new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";

                MessageBox.Show("Your Account was created successfully!", "Registration confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }

            else
            {
                MessageBox.Show("Password is incorrect, Try again.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•'; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
