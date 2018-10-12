using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;

namespace iBUS
{
    public partial class frm_home : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;database=ibus_database;username=root;password=");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader rdr;

        public frm_home()
        {
            InitializeComponent();
        }
       

        private void btn_addbus_Click(object sender, EventArgs e)
        {
            uc_bus1.lbl_company.Text = lbl_company.Text;
            uc_bus1.lbl_type.Text = lbl_type.Text;
            uc_bus1.lbl_user.Text = lbl_user.Text;
            uc_bus1.Show();
            uc_dashboard1.Hide();
            uc_driver1.Hide();
            uc_company1.Hide();
            uc_conductor1.Hide();
            uc_profile1.Hide();

        }

        private void home_Load(object sender, EventArgs e)
        {
        }

        private void btn_adddriver_Click(object sender, EventArgs e)
        {
            uc_driver1.lbl_company.Text = lbl_company.Text;
            uc_driver1.lbl_type.Text = lbl_type.Text;
            uc_driver1.lbl_user.Text = lbl_user.Text;
            uc_driver1.Show();
            uc_bus1.Hide();
            uc_dashboard1.Hide();
            uc_company1.Hide();
            uc_conductor1.Hide();
            uc_profile1.Hide();
        }

        private void btn_addconductor_Click(object sender, EventArgs e)
        {
            uc_conductor1.lbl_company.Text = lbl_company.Text;
            uc_conductor1.lbl_type.Text = lbl_type.Text;
            uc_conductor1.lbl_user.Text = lbl_user.Text;
            uc_conductor1.Show();
            uc_bus1.Hide();
            uc_driver1.Hide();
            uc_dashboard1.Hide();
        }

        private void lbl_idno_TextChanged(object sender, EventArgs e)
        {
            
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
            {
                bunifuTransition2.HideSync(lbl_company);
                bunifuTransition1.ShowSync(logo1);
                bunifuTransition1.ShowSync(logo2);
            }
            if (count == 10)
            {
                bunifuTransition1.HideSync(logo1);
                bunifuTransition1.HideSync(logo2);
                bunifuTransition2.ShowSync(lbl_company);
            }
            if (count == 20)
            {
                count = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("MMMM" + ", dd" + " yyyy" + " " + "(dddd)");
            time.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            uc_dashboard1.Show();
            uc_bus1.Hide();
            uc_driver1.Hide();
            uc_company1.Hide();
            uc_conductor1.Hide();
            uc_profile1.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "iBUS Message", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                frm_login login = new frm_login();
                login.Show();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                //...
            }
            else
            {
                //...
            }
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            contextmenu.Show(btn_profile, -135, btn_profile.Height);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            uc_profile1.tb_idno.Text = lbl_idno.Text;
            uc_profile1.tb_company.Text = lbl_company.Text;
            uc_profile1.Show();
            uc_driver1.Hide();
            uc_dashboard1.Hide();
            uc_conductor1.Hide();
            uc_company1.Hide();
            uc_bus1.Hide();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            uc_company1.Show();
            uc_profile1.Hide();
            uc_driver1.Hide();
            uc_dashboard1.Hide();
            uc_conductor1.Hide();
            uc_bus1.Hide();
        }


       

        

       
       



    }
}
