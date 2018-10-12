using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;

namespace iBUS
{
    public partial class frm_login : Form
    {



        public frm_login()
        {
            InitializeComponent();
            var x = User.all();
        }

        private void login_Load(object sender, EventArgs e)
        {
            btn_exit.Focus();
            
            tb_username.Text = "Username";
            tb_company.Text = "My Company";
            tb_password.Text = "Password";

            //string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            //using (conn = new MySqlConnection(ConString))
            //{
            //}
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
            {
                bunifuTransition2.HideSync(logo2);
                bunifuTransition1.ShowSync(logo1);
            }
            if (count == 10)
            {
                bunifuTransition1.HideSync(logo1);
                bunifuTransition2.ShowSync(logo2);
            }
            if (count == 20)
            {
                count = 0;
            }
        }

        private void tb_username_Enter(object sender, EventArgs e)
        {
            if (tb_username.Text == "Username")
            {
                tb_username.Text = "";
                tb_username.ForeColor = Color.Black;
            }
        }

        private void tb_username_Leave(object sender, EventArgs e)
        {
            if (tb_username.Text == "")
            {
                tb_username.Text = "Username";
                tb_username.ForeColor = Color.Gray;
            }
        }

        private void tb_company_Enter(object sender, EventArgs e)
        {
            if (tb_company.Text == "My Company")
            {
                tb_company.Text = "";
                tb_company.ForeColor = Color.Black;
            }
        }

        private void tb_company_Leave(object sender, EventArgs e)
        {
            if (tb_company.Text == "")
            {
                tb_company.Text = "My Company";
                tb_company.ForeColor = Color.Gray;
            }
        }

        private void tb_password_Enter(object sender, EventArgs e)
        {
            if (tb_password.Text == "Password")
            {
                tb_password.Text = "";
                tb_password.ForeColor = Color.Black;
                tb_password.PasswordChar = '*';
            }
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                tb_password.PasswordChar = '\0';
                tb_password.Text = "Password";
                tb_password.ForeColor = Color.Gray;
                
            }

        }

        private void link_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_register register = new frm_register();
            register.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var x = Auth.login(this.tb_username.Text, this.tb_password.Text);
            if (x)
            {
                frm_home home = new frm_home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

     

    }
}
