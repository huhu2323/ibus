using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.IO;

namespace iBUS
{
    public partial class frm_uc_profile : UserControl
    {
        
        //MemoryStream ms;

        public frm_uc_profile()
        {
            InitializeComponent();
            cb_position.Text = Auth.user_position;
            tb_fname.Text = Auth.user_fname;
            tb_lname.Text = Auth.user_lname;
            tb_email.Text = Auth.user_email;
            mt_contact.Text = Auth.user_contact;
            tb_username.Text = Auth.user_username;
            Console.WriteLine(Auth.user_company.ToString()+ "----" + Auth.getCompany().name);
            tb_company.Text = Auth.getCompany().name;
        }

        private void tb_idno_TextChanged(object sender, EventArgs e)
        {
            //if (conn.State == ConnectionState.Closed) conn.Open();
            //cmd = new MySqlCommand("SELECT * FROM tbl_accounts where company_idno= '" + tb_idno.Text + "' ", conn);
            //rdr = cmd.ExecuteReader();
            //if (rdr.HasRows == true)
            //{
            //    while (rdr.Read())
            //    {
            //        byte[] Pictures = new byte[0];
            //        Pictures = (Byte[])(rdr["user_pic"]);
            //        MemoryStream Pic = new MemoryStream(Pictures);
            //        user_pic.Image = Image.FromStream(Pic);
            //        user_pic.SizeMode = PictureBoxSizeMode.StretchImage;

            //        cb_position.Text = (rdr[3].ToString());
            //        tb_fname.Text = (rdr[4].ToString());
            //        tb_lname.Text = (rdr[5].ToString());
            //        dt_bday.Text = (rdr[6].ToString());
            //        tb_age.Text = (rdr[7].ToString());
            //        cb_gender.Text = (rdr[8].ToString());
            //        cb_civilstatus.Text = (rdr[9].ToString());
            //        rtb_address.Text = (rdr[10].ToString());
            //        tb_email.Text = (rdr[11].ToString());
            //        mt_contact.Text = (rdr[12].ToString());
            //        tb_username.Text = (rdr[13].ToString());
            //        tb_password.Text = (rdr[14].ToString());
            //        cb_sq1.Text = (rdr[15].ToString());
            //        tb_a1.Text = (rdr[16].ToString());
            //        cb_sq2.Text = (rdr[17].ToString());
            //        tb_a2.Text = (rdr[18].ToString());

            //    }
            //}
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(btn_edit.Text == "Edit")
            {
                enables();
                btn_edit.Text = "Update";
            }
            else if(btn_edit.Text == "Update")
            {
                disables();
                btn_edit.Text = "Edit";
            }
            


        }

        void enables()
        {
            tb_a1.Enabled = true;
            tb_a2.Enabled = true;
            tb_age.Enabled = true;
            tb_company.Enabled = true;
            tb_email.Enabled = true;
            tb_fname.Enabled = true;
            tb_idno.Enabled = true;
            tb_lname.Enabled = true;
            tb_password.Enabled = true;
            tb_retype.Enabled = true;
            tb_username.Enabled = true;
            cb_civilstatus.Enabled = true;
            cb_gender.Enabled = true;
            cb_position.Enabled = true;
            cb_sq1.Enabled = true;
            cb_sq2.Enabled = true;
            btn_browse.Enabled = true;
            rtb_address.Enabled = true;
            mt_contact.Enabled = true;
        }

        void disables()
        {
            tb_a1.Enabled = false;
            tb_a2.Enabled = false;
            tb_age.Enabled = false;
            tb_company.Enabled = false;
            tb_email.Enabled = false;
            tb_fname.Enabled = false;
            tb_idno.Enabled = false;
            tb_lname.Enabled = false;
            tb_password.Enabled = false;
            tb_retype.Enabled = false;
            tb_username.Enabled = false;
            cb_civilstatus.Enabled = false;
            cb_gender.Enabled = false;
            cb_position.Enabled = false;
            cb_sq1.Enabled = false;
            cb_sq2.Enabled = false;
            btn_browse.Enabled = false;
            rtb_address.Enabled = false;
            mt_contact.Enabled = false;
        }
       

       
      
       
    }
}
