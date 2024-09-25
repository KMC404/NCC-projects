using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Raddison_Premiere_Resort
{
    [Serializable()]
    public partial class frmRaddison : Form , ISerializable
    {//creates a list of accounts
        List<Accounts> myaccount;
        public frmRaddison()
        {
            InitializeComponent();
        }

        private void addAccount(String name, String pass, bool admin)
        {
            Accounts a;
            if (chkAdmin.Checked)                         // allowing admin to login
            {
                a = new AdminAccount();
                a.realname = name;
                a.password = pass;
                a.admin = true;
                
                myaccount.Add(a);
            }
            else 
            {
                a = new NormalAccount();                  // otherwise user should login normally
                a.realname = name;
                a.password = pass;
                myaccount.Add(a);
            }
            

        }
       
        private void frmRaddison_Load(object sender, EventArgs e)
        {// Creates a specific admin account
           
            if (myaccount == null)
            {
                myaccount = new List<Accounts>();

                addAccount("Admin", "administrator", true);
            }


        }

        

        private Accounts findAccount(string us)                  //  Finding an already registered account function
        {
            for (int i = 0; i < myaccount.Count; i++)
            {
                if (myaccount[i].Realname.ToLower() == us.ToLower())
                {
                    return myaccount[i];
                }
            }
            return null;
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            
            // Checks to see if textboxes are empty
            if (txtFullname.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your Username and Password");
            }
            else if (!Regex.IsMatch(txtFullname.Text, "^[a-zA-Z1-9]+"))  
            {
                 MessageBox.Show("ERROR! The Username field can only accept letters and numbers ");
            }
            
            else
            {

                string realname;
                string password;
                bool admin;
                Accounts a;


                realname = txtFullname.Text;
                password = txtPassword.Text;
                admin = chkAdmin.Checked;

                a = new Accounts(realname, password, admin);

                myaccount.Add(a);

                MessageBox.Show("Successful registration");
                
            }

            

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (txtFullname.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your Full Name and Password");
            }
            else
            {


                // Checking if account has been registered 
                Accounts accounts;
                accounts = findAccount(txtFullname.Text);
                if (accounts == null)
                {
                    MessageBox.Show("No account exists with that name. Please register an account  ");
                    return;
                }
                if (accounts.checkPassword(txtPassword.Text))
                {
                    MessageBox.Show("Successful Login");
                    // show bookings page
                    this.Hide();
                    Bookings bookings = new Bookings();
                    bookings.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Incorrect Name or password!");
                }

            }  
                      
        }
        // show password code
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

            
        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You must know the Administrator password to Login as an admin!");

            

        }

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
