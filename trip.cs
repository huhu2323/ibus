using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace iBUS
{
    public partial class trip : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;database=ibusdb;username=root;password=");
        MySqlCommand cmd = new MySqlCommand();
        public trip()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (tb_busno.Text == "" || cb_company.Text == "" || bunifuMetroTextbox6.Text == "" || cb_model.Text == "" || cb_class.Text == "" || cb_routefrom.Text == "" || bunifuMetroTextbox1.Text == "" || cb_routeto.Text == "" || bunifuMetroTextbox5.Text == "" || bunifuMetroTextbox2.Text == "" || bunifuMetroTextbox3.Text == "" || bunifuMetroTextbox4.Text == "")
            {
                MessageBox.Show("Fill all blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        cmd = new MySqlCommand("INSERT INTO tbl_trip (bus_company,trip_no,bus_no,trip_driver,trip_conductor,trip_start,time_start,trip_end,time_end,trip_rate,trip_passengers,trip_collection,date_added) VALUES ('" + cb_company.Text + "','" + tb_busno.Text + "','" + bunifuMetroTextbox6.Text + "','" + cb_model.Text + "','" + cb_class.Text + "','" + cb_routefrom.Text + "','" + bunifuMetroTextbox1.Text + "','" + cb_routeto.Text + "','" + bunifuMetroTextbox5.Text + "','" + bunifuMetroTextbox2.Text + "','" + bunifuMetroTextbox3.Text + "','" + bunifuMetroTextbox4.Text + "','" + dt_added.Value.Date.ToString("yyyy-MM-dd") + "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                }
            }
            conn.Close();
        }

        void clear()
        {
            tb_busno.Text = "";
            cb_company.Text = "";
            bunifuMetroTextbox6.Text = "";
            cb_model.Text = "";
            cb_class.Text = "";
            cb_routefrom.Text = "";
            bunifuMetroTextbox1.Text = "";
            cb_routeto.Text = "";
            bunifuMetroTextbox5.Text = "";
            bunifuMetroTextbox2.Text = "";
            bunifuMetroTextbox3.Text = "";
            bunifuMetroTextbox4.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                int product;
                product = int.Parse(bunifuMetroTextbox2.Text) * int.Parse(bunifuMetroTextbox3.Text);
                bunifuMetroTextbox4.Text = "" + product.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
