using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;

namespace Raddison_Premiere_Resort
{
      
    public partial class CreateBooking : Form , ISerializable
        
    {
        public static List<bool> rooms; 

        public CreateBooking()
        {
            InitializeComponent();
        }
        
        private void CreateBooking_Load(object sender, EventArgs e)
        {
             
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmdProceed_Click(object sender, EventArgs e)
        {
           
            // booking validation

            if (txtName.Text == "" ||  txtaddress.Text == "")
           {
               MessageBox.Show("Please enter your name and address");
           }
           if (txtnumber.Text == "" )
           {
               MessageBox.Show("Please enter your number");
           }
            if (txtduration.Text == "")
            {
                MessageBox.Show("Please enter a duration");
            }
            else if (!Regex.IsMatch(txtnumber.Text, "[0-9]+"))
            {
                MessageBox.Show("ERROR! Your phone number must only be numbers ");
            }
            else
            {
                // Creating arrays to store bookings and services
                
                string[,] services = new string[3, 3];
                string[,] booking = new string[4, 4];

                services[0, 0] = "Standard Room - 2 King size beds, Breakfast included ";
                services[0, 1] = "Premium Suite - 5 King size beds, fully furnished, all meals included, private swimming pool ";
                services[0, 2] = "Executive room - 2 King size beds, all meals included, fully furnished, free access to conference roomsv";


                services[1, 0] = "85";
                services[1, 1] = "200";
                services[1, 2] = "100";

                // Creating the receipt
                if (optStandard.Checked)
                {
                    int choosen = Convert.ToInt32(services[1, 0]);
                    choosen = choosen * Convert.ToInt32(txtduration.Text);
                   

                    MessageBox.Show("NAME" + txtName.Text + "\n\n " + "PHONE NUMBER: " + txtnumber.Text + "\n\n" + txtaddress.Text + "\n\n" + optStandard.Text + "\n\n" + "TOTAL PRICE: £" + Convert.ToString(choosen));
                }
                else if (optPremium.Checked)
                {
                    int choosen = Convert.ToInt32(services[1, 1]);
                    choosen = choosen * Convert.ToInt32(txtduration.Text);
                    
                    MessageBox.Show("NAME" + txtName.Text + "\n\n " + "PHONE NUMBER: " + txtnumber.Text + "\n\n" + txtaddress.Text + "\n\n" + optPremium.Text + "\n\n" + "TOTAL PRICE: £" + Convert.ToString(choosen));
                }
                else if (optExecutive.Checked)
                {
                    int choosen = Convert.ToInt32(services[1, 2]);
                    choosen = choosen * Convert.ToInt32(txtduration.Text);
                    
                    MessageBox.Show("NAME" + txtName.Text + "\n\n " + "PHONE NUMBER: " + txtnumber.Text + "\n\n" + txtaddress.Text + "\n\n" + optExecutive.Text + "\n\n" + "TOTAL PRICE: £" + Convert.ToString(choosen));
                }

                booking[0, 0] = txtName.Text;
                booking[0, 1] = txtName.Text;
                booking[0, 2] = txtName.Text;

                booking[1, 0] = txtnumber.Text;
                booking[1, 1] = txtnumber.Text;
                booking[1, 2] = txtnumber.Text;

                booking[2, 0] = optStandard.Text;
                booking[2, 1] = optPremium.Text;
                booking[2, 2] = optExecutive.Text;

                DialogResult res = MessageBox.Show("Are you sure you want to book these selections", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    MessageBox.Show("Thank you for your purchase!");
                    this.Hide();
                    Bookings bookings = new Bookings();
                    bookings.ShowDialog();

                }

                if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("You have cancelled your selection");

                }
               



            }
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bookings bookings = new Bookings();
            bookings.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtduration_TextChanged(object sender, EventArgs e)
        {
           
            if (!Regex.IsMatch(txtduration.Text, "[1-3]+"))
            {
                MessageBox.Show("ERROR! maximum stay is 3 days ");

                txtduration.Text = "";

                
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
