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
    public partial class login : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=192.168.43.99;port=3306;database=ibus_database;username=root;password=");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader rdr;


        public login()
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
                cmd = new MySqlCommand("SELECT distinct company_name FROM tbl_accounts", conn);
                try
                {
                    conn.Open();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                
                rdr = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (rdr.Read())
                {
                    MyCollection.Add(rdr.GetString(0));
                }
                tb_company.AutoCompleteCustomSource = MyCollection;
                conn.Close();
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
            register register = new register();
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
            Auth.login(this.tb_username.Text, this.tb_password.Text);
        }

     

    }
}
