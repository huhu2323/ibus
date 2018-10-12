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
    public partial class conductor : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;database=ibus_database;username=root;password=");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader rdr;
        MemoryStream ms;

        public conductor()
        {
            InitializeComponent();
        }

        private void conductor_Load(object sender, EventArgs e)
        {

        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///// voids


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
            tb_conductorno.Text = "";
            tb_email.Text = "";
            tb_fname.Text = "";
            tb_lname.Text = "";
            dt_bday.Text = "";
            dt_bday.Text = "";
            mt_contact.Text = "";
            pic_conductor.Image = null;
        }

        void Images()
        {
            if (pic_conductor.Image != null)
            {
                ms = new MemoryStream();
                pic_conductor.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@pics", photo_aray);
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///// buttons


        private void btn_browse_Click_2(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "C:/Pictures/";
                f.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
                f.FilterIndex = 2;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pic_conductor.Image = Image.FromFile(f.FileName);
                }
            }
            catch { }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (btn_save.Text == "Save")
            {
                if (pic_conductor.Image == null || tb_lname.Text == null || tb_fname.Text == null || tb_email.Text == null || tb_conductorno.Text == null || tb_company.Text == null | tb_age.Text == null || tb_address.Text == null)
                {
                    MessageBox.Show("In order to add a new driver, please fill in the following fields.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conn.Open();
                    cmd = new MySqlCommand("SELECT * FROM tbl_conductor where company_name = '" + tb_company.Text + "' and conductor_no = '" + tb_conductorno.Text + "' and fname = '" + tb_fname.Text + "' and lname = '" + tb_lname.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    rdr = cmd.ExecuteReader();

                    if (rdr.HasRows == true)
                    {
                        MessageBox.Show("Conductor already exists.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //rdr.Close();
                        if (conn.State == ConnectionState.Closed) conn.Open();
                        cmd = new MySqlCommand("INSERT INTO tbl_conductor (company_name, conductor_no, fname, lname, bday, age, gender, civil_status, home_address, contact_no, email_add, time_start, time_end, date_join, pic_conductor, status, added_by)VALUES('" + tb_company.Text + "', '" + tb_conductorno.Text + "', '" + tb_fname.Text + "', '" + tb_lname.Text + "', '" + dt_bday.Text + "', '" + tb_age.Text + "', '" + cb_gender.Text + "', '" + cb_civilstatus.Text + "', '" + tb_address.Text + "', '" + mt_contact.Text + "', '" + tb_email.Text + "', '" + cb_shiftstart.Text + "', '" + cb_shiftend.Text + "', '" + dt_datejoin.Value.Date.ToString("yyyy-MM-dd") + "', '" + cb_status.Text + "', '" + lbl_user.Text + "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You've successfully added a Conductor!", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        clear();
                    }
                    conn.Close();
                }
            }
            else if (btn_save.Text == "Update")
            {
                try
                {
                    if (pic_conductor.Image == null || tb_lname.Text == null || tb_fname.Text == null || tb_email.Text == null || tb_conductorno.Text == null || tb_company.Text == null | tb_age.Text == null || tb_address.Text == null)
                    {
                        MessageBox.Show("In order to update this conductor record, please fill in the following fields.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (conn.State == ConnectionState.Closed) conn.Open();
                        cmd = new MySqlCommand("Update tbl_conductor set company_name='" + tb_company.Text + "', conductor_no='" + tb_conductorno.Text + "', fname='" + tb_fname.Text + "', lname='" + tb_lname.Text + "', bday='" + dt_bday.Value.Date.ToString("yyyy-MM-dd") + "', age ='" + tb_age.Text + "', gender='" + cb_gender.Text + "', civil_status='" + cb_civilstatus.Text + "', home_address='" + tb_address.Text + "', contact_no='" + mt_contact.Text + "', email_add='" + tb_email.Text + "', time_start='" + cb_shiftstart.Text + "', time_end='" + cb_shiftend.Text + "', date_join = '" + dt_datejoin.Value.Date.ToString("yyyy-MM-dd") + "', pic_conductor = @pics, status = '" + cb_status.Text + "', added_by = '" + lbl_user.Text + "' where ibus_conductor_no = '" + tb_ibusno.Text + "'", conn);
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (btn_clear.Text == "Clear")
            {
                clear();
            }
            else if (btn_clear.Text == "Dismiss")
            {
                DialogResult result = MessageBox.Show("Are you sure?", "iBUS Message", MessageBoxButtons.YesNo);
                if (pic_conductor.Image == null || tb_lname.Text == null || tb_fname.Text == null || tb_email.Text == null || tb_conductorno.Text == null || tb_company.Text == null | tb_age.Text == null || tb_address.Text == null)
                {
                    MessageBox.Show("In order to dismiss this conductor record, please fill in the following fields.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (result == DialogResult.Yes)
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    cmd = new MySqlCommand("DELETE * FROM tbl_conductor WHERE conductor_no ='" + tb_conductorno.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You've successfully dismissed a conductor.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    clear();
                    this.Close();
                }
                else
                {

                }
            }

        }

       
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void dt_bday_ValueChanged_1(object sender, EventArgs e)
        {
            int age = DateTime.Today.Year - dt_bday.Value.Year;
            tb_age.Text = age.ToString();
        }

        

    }
}
