using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;

namespace iBUS
{
    public partial class driver : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;database=ibusdb;username=root;password=");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader rdr;
        MemoryStream ms;



        public driver()
        {
            InitializeComponent();
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
                    pic_driver.Image = Image.FromFile(f.FileName);
                }
            }
            catch { }
        }

        void images()
        {
            if (pic_driver.Image != null)
            {
                //using MemoryStream:
                ms = new MemoryStream();
                pic_driver.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@photo", photo_aray);
            }
        }

        private void driver_Load(object sender, EventArgs e)
        {
           
        }

        private void Images()
        {
            MemoryStream ms;
            ms = new MemoryStream();
            pic_driver.Image.Save(ms, ImageFormat.Jpeg);
            byte[] photo_aray = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo_aray, 0, photo_aray.Length);
            cmd.Parameters.AddWithValue("@pics", photo_aray);
            ms.Close();
        }

        private void btn_browse_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "C:/Pictures/";
                f.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
                f.FilterIndex = 2;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pic_driver.Image = Image.FromFile(f.FileName);
                }
            }
            catch { }
        }

        private void dt_bday_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Today.Year - dt_bday.Value.Year;
            tb_age.Text = age.ToString();
        }

        void clear()
        {
            cb_gender.SelectedIndex = -1;
            cb_shiftend.SelectedIndex = -1;
            cb_shiftstart.SelectedIndex = -1;
            cb_civilstatus.SelectedIndex = -1;
            tb_company.Text = "";
            cb_gender.Text = "";
            cb_shiftend.Text = "";
            cb_shiftstart.Text = "";
            cb_civilstatus.Text = "";
            tb_address.Text = "";
            tb_age.Text = "";
            tb_driverno.Text = "";
            tb_email.Text = "";
            tb_fname.Text = "";
            tb_lname.Text = "";
            dt_bday.Text = "";
            dt_bday.Text = "";
            mt_contact.Text = "";
            tb_expiration.Text = "";
            tb_issue.Text = "";
            tb_licenseno.Text = "";
            pic_driver.Image = null;
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            if (btn_save.Text == "Save")
            {
                if (pic_driver.Image == null || tb_lname.Text == null || tb_licenseno.Text == null || tb_issue.Text == null || tb_fname.Text == null || tb_expiration.Text == null || tb_email.Text == null || tb_driverno.Text == null || tb_company.Text == null | tb_age.Text == null || tb_address.Text == null)
                {
                    MessageBox.Show("In order to add a new driver, please fill in the following fields.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conn.Open();
                    cmd = new MySqlCommand("SELECT * FROM tbl_driver where company_name = '" + tb_company.Text + "' and driver_no = '" + tb_driverno.Text + "' and fname = '"+ tb_fname.Text +"' and lname = '"+ tb_lname.Text +"'", conn);
                    cmd.ExecuteNonQuery();
                    rdr = cmd.ExecuteReader();

                    if (rdr.HasRows == true)
                    {
                        MessageBox.Show("Driver already exists.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        rdr.Close();
                        if (conn.State == ConnectionState.Closed) conn.Open();
                        cmd = new MySqlCommand("INSERT INTO tbl_driver (company_name, driver_no, fname, lname, bday, age, gender, civil_status, home_address, contact_no, email_add, license_no, license_issue, license_expiration, time_start, time_end, date_join, pic_driver, status, added_by)VALUES('" + tb_company.Text + "', '" + tb_driverno.Text + "', '" + tb_fname.Text + "', '" + tb_lname.Text + "', '" + dt_bday.Text + "', '" + tb_age.Text + "', '" + cb_gender.Text + "', '" + cb_civilstatus.Text + "', '" + tb_address.Text + "', '" + mt_contact.Text + "', '" + tb_email.Text + "', '" + tb_licenseno.Text + "', '" + tb_issue.Text + "', '" + tb_expiration.Text + "', '" + cb_shiftstart.Text + "', '" + cb_shiftend.Text + "', '" + dt_datejoin.Value.Date.ToString("yyyy-MM-dd") + "', '" + comboBox1.Text + "', '" + lbl_user.Text + "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You've successfully added a Driver!", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        clear();
                        this.Close();
                    }
                    conn.Close();
                }
            }
            else if (btn_save.Text == "Update")
            {
                try
                {
                    if (pic_driver.Image == null || tb_lname.Text == null || tb_licenseno.Text == null || tb_issue.Text == null || tb_fname.Text == null || tb_expiration.Text == null || tb_email.Text == null || tb_driverno.Text == null || tb_company.Text == null | tb_age.Text == null || tb_address.Text == null)
                    {
                        MessageBox.Show("In order to update this driver record, please fill in the following fields.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        conn.Open();
                        cmd = new MySqlCommand("Update tbl_driver set company_name='" + tb_company.Text + "', driver_no='" + tb_driverno.Text + "', fname='" + tb_fname.Text + "', lname='" + tb_lname.Text + "', bday='" + dt_bday.Value.Date.ToString("yyyy-MM-dd") + "', age ='" + tb_age.Text + "', gender='" + cb_gender.Text + "', civil_status='" + cb_civilstatus.Text + "', home_address='" + tb_address.Text + "', contact_no='" + mt_contact.Text + "', email_add='" + tb_email.Text + "', license_no='" + tb_licenseno.Text + "', license_issue='" + tb_issue.Text + "', license_expiration='" + tb_expiration.Text + "', time_start='" + cb_shiftstart.Text + "', time_end='" + cb_shiftend.Text + "', date_join = '" + dt_datejoin.Value.Date.ToString("yyyy-MM-dd") + "', pic_driver = @pics, status = '"+ comboBox1.Text +"', added_by = '"+ lbl_user.Text +"' where ibus_driver_no = '" + tb_ibusno.Text + "'", conn);
                        Images();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record has been updated!" + "\n" + "To see the changes, click the refresh button.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("An unknown error occurred." + "\n" + "If problem persist, restart iBUS.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    
    }
}
