using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;

namespace iBUS
{
    public partial class events : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;database=ibus_database;username=root;password=");
        MySqlCommand cmd;
        MySqlDataReader rdr;

        public events()
        {
            InitializeComponent();
        }

        void clear()
        {
            dt_date.Text = "";
            tb_title.Text = "";
            rt_description.Text = "";
            cb_type.Text = "";
            cb_type.SelectedIndex = -1;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void events_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (btn_save.Text == "Save")
            {
                if (tb_title.Text == null || cb_type.Text == null || rt_description.Text == null || tb_eventno.Text == null)
                {
                    MessageBox.Show("In order to add a new announcement/event, please fill in the following fields.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conn.Open();
                    cmd = new MySqlCommand("SELECT * FROM tbl_events where company_name = '" + lbl_user.Text + "' and event_no = '" + tb_eventno.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    rdr = cmd.ExecuteReader();

                    if (rdr.HasRows == true)
                    {
                        MessageBox.Show("Event no. already exists.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        rdr.Close();
                        if (conn.State == ConnectionState.Closed) conn.Open();
                        cmd = new MySqlCommand("INSERT INTO tbl_events (company_name, event_no, type, title, description, posted_by, date_posted)VALUES('" + lbl_company.Text + "', '" + tb_eventno.Text + "', '" + cb_type.Text + "', '" + tb_title.Text + "', '" + rt_description.Text + "', '" + lbl_user.Text + "', '" + dt_date.Value.Date.ToString("yyyy-MM-dd") + "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You've successfully posted an announcement/event.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        clear();
                    }
                    conn.Close();
                }
            }
            else if (btn_save.Text == "Update")
            {
               /* try
                {
                    if (cb_class.Text == null || tb_company.Text == null || cb_model.Text == null || cb_routefrom.Text == null || cb_routeto.Text == null || tb_busno.Text == null || tb_plateno.Text == null)
                    {
                        MessageBox.Show("In order to update this bus information, please fill in the following fields.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        conn.Open();
                        cmd = new MySqlCommand("Update tbl_bus set bus_company='" + tb_company.Text + "', bus_no='" + tb_busno.Text + "', bus_model='" + cb_model.Text + "', bus_class='" + cb_class.Text + "', route_from='" + cb_routefrom.Text + "', route_to='" + cb_routeto.Text + "', plate_no = '" + tb_plateno.Text + "', date_added = '" + dt_added.Value.Date.ToString("yyyy-MM-dd") + "' where ibus_bus_no = '" + tb_ibusno.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record has been updated!" + "\n" + "To see the changes, click the refresh button.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("An unknown error occurred." + "\n" + "If problem persist, restart iBUS.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
        }

       
    }
}
