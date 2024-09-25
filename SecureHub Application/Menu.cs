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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_usersp.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        public void Menu_Load(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_Load(new Updates());
            chkWindows.Hide();
            chkLinux.Hide();
            chkMac.Hide();
            lblplease.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           con.Close(); 
            new frmLogin().Show();
            this.Hide();
            
        }

        private void btnrecs_Click(object sender, EventArgs e)
        {
            Menu_Load(new Recs());
            chkWindows.Hide();
            chkLinux.Hide();
            chkMac.Hide();
            lblplease.Hide();
        }

        private void btnnews_Click(object sender, EventArgs e)
        {
            Menu_Load(new News());
            chkWindows.Hide();
            chkLinux.Hide();
            chkMac.Hide();
            lblplease.Hide();
        }

        private void chkWindows_CheckedChanged(object sender, EventArgs e)
        {
            // OS Information // 
            if (chkWindows.Checked) 
            {
                MessageBox.Show("Windows 10 is still the world's most popular operating system for desktop computers, with more than a billion active PCs running it. This application will provide information on Windows 10 for that reason."); 
            }
        }

        private void chkMac_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMac.Checked) 
            {
                MessageBox.Show("Every Mac user is happy with macOS Ventura, the latest version of Apple's desktop and laptop operating system, available as a free download for any compatible Mac. The information provided in this application will focus on this version.");

            }
        }

        private void chkLinux_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Debian is the most popular Linux distribution. The best part about Debian is that it's a free and open-source Linux-based operating system that is being developed and maintained by a community of people. SecureHub will thus provide information regarding Debian.");
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
