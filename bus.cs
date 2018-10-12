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
    public partial class bus : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;database=ibus_database;username=root;password=");
        MySqlCommand cmd;
        MySqlDataReader rdr;
        
        public bus()
        {
            InitializeComponent();
        }

        private void bus_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(btn_save.Text == "Save")
            {
                if (cb_class.Text == null || tb_company.Text == null || cb_model.Text == null || cb_routefrom.Text == null || cb_routeto.Text == null || tb_busno.Text == null || tb_plateno.Text == null)
                {
                    MessageBox.Show("In order to add a new bus, please fill in the following fields.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conn.Open();
                    cmd = new MySqlCommand("SELECT * FROM tbl_bus where bus_company = '" + tb_company.Text + "' and bus_no = '" + tb_busno.Text + "' and bus_model = '" + cb_model.Text + "' and bus_class = '" + cb_class.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    rdr = cmd.ExecuteReader();

                    if (rdr.HasRows == true)
                    {
                        MessageBox.Show("The bus is not valid because it already exists." + "\n" + "Type a different bus information.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        rdr.Close();
                        if (conn.State == ConnectionState.Closed) conn.Open();
                        cmd = new MySqlCommand("INSERT INTO tbl_bus (bus_company, bus_no, bus_model, bus_class, route_from, route_to, plate_no, date_added, added_by)VALUES('" + tb_company.Text + "', '" + tb_busno.Text + "', '" + cb_model.Text + "', '" + cb_class.Text + "', '" + cb_routefrom.Text + "', '" + cb_routeto.Text + "', '" + tb_plateno.Text + "', '" + dt_added.Value.Date.ToString("yyyy-MM-dd") + "', '" + lbl_user.Text + "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You've successfully added a Bus!", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        clear();
                    }
                    conn.Close();
                }
            }
            else if(btn_save.Text == "Update")
            {
                try
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
                        MessageBox.Show("Record has been updated!" +"\n"+ "To see the changes, click the refresh button.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        void clear()
        {
            cb_class.SelectedIndex = -1;
            cb_routefrom.SelectedIndex = -1;
            cb_routeto.SelectedIndex = -1;
            cb_model.SelectedIndex = -1;
            cb_class.Text = "";
            tb_company.Text = "";
            cb_routefrom.Text = "";
            cb_routeto.Text = "";
            cb_model.Text = "";
            tb_busno.Text = "";
            tb_plateno.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
