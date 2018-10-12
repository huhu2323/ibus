using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;

namespace iBUS
{
    public partial class register : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;database=ibus_database;username=root;password=");
        MySqlCommand cmd = new MySqlCommand();
        MemoryStream ms;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public register()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        void images()
        {
            if (pic.Image != null)
            {
                //using MemoryStream:
                ms = new MemoryStream();
                pic.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@photo", photo_aray);
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "C:/Pictures/";
                f.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
                f.FilterIndex = 2;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pic.Image = Image.FromFile(f.FileName);
                }
            }
            catch { }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (pic.Image == null || tb_company.Text == "" || tb_idno.Text == "" ||  cb_position.Text == "" || tb_fname.Text == "" || tb_lname.Text == "" ||
                dt_bday.Text == "" || tb_age.Text == "" || cb_gender.Text == "" || cb_civilstatus.Text == "" || rtb_address.Text == "" ||
                tb_email.Text == "" || mt_contact.Text == "" || tb_username.Text == "" || tb_password.Text == "" || tb_retype.Text == "" ||
                cb_sq1.Text == "" || cb_sq2.Text == "" || tb_a1.Text == "" || tb_a2.Text == "")
            {
                MessageBox.Show("In order to create a new account, please fill in the following fields.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    cmd = new MySqlCommand("INSERT INTO tbl_accounts(company_name, company_idno, position, fname, lname, bday, age, gender, civil_status, address, email_address, contact_no, username, password, security_q1, answer_1, security_q2, answer_2, user_pic) VALUES ('" + tb_company.Text + "', '" + tb_idno.Text + "', '" + cb_position.Text + "', '" + tb_fname.Text + "', '" + tb_lname.Text + "', '" + dt_bday.Value.Date.ToString("yyyy-MM-dd") + "', " + tb_age.Text + ", '" + cb_gender.Text + "', '" + cb_civilstatus.Text + "', '" + rtb_address.Text + "', '" + tb_email.Text + "', '" + mt_contact.Text + "', '" + tb_username.Text + "', '" + tb_password.Text + "', '" + cb_sq1.Text + "', '" + tb_a1.Text + "', '" + cb_sq2.Text + "', '" + tb_a2.Text + "', @photo)", conn);
                    images();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your iBUS account has been successfully created!", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("An unknown error occurred." +"\n"+ "If problem persist, restart iBUS.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conn.Close();
        }

        private void dt_bday_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Today.Year - dt_bday.Value.Year;
            tb_age.Text = age.ToString();
        }

    }
}
