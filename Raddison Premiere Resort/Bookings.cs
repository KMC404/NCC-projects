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
using System.Runtime.Serialization.Formatters.Binary;

namespace Raddison_Premiere_Resort
{

    public partial class Bookings : Form 
    {
        List<CreateBookings> bookings = new List<CreateBookings>();
        public Bookings()
        {
            InitializeComponent();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide ();
            CreateBooking createBooking = new CreateBooking();
            createBooking.ShowDialog ();
        }

        private void cmdChange_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateBooking createBooking = new CreateBooking();
            createBooking.ShowDialog();
        }

        private void cmdCheckout_Click(object sender, EventArgs e)
        {

        }

        public void  cmdView_Click(object sender, EventArgs e)
        {
           
        }

        
       

        private void cmdlogout_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            frmRaddison frmRaddison = new frmRaddison();
            frmRaddison.ShowDialog();
        }

        private void cmdCurrent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These are your current bookings \n\n" + bookings);

            

        }

        private static void saveData()
        {
            Stream output;
            BinaryFormatter bf = new BinaryFormatter();
            output = File.Open("bookings", FileMode.OpenOrCreate);
            bf.Deserialize(output);
            output.Close();
        }

       

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You must create a booking first");
        }
    }
}
