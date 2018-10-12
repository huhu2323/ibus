using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;


namespace iBUS
{
    public partial class uc_driver : UserControl
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;database=ibus_database;username=root;password=");
        MySqlCommand cmd;
        MySqlDataReader rdr;

        public uc_driver()
        {
            InitializeComponent();
        }

        private void uc_driver_Load(object sender, EventArgs e)
        {
            refresh();
        }

        void refresh()
        {
            listView1.Items.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            cmd = new MySqlCommand("Select * From tbl_bus where bus_company = '" + lbl_company.Text + "'", conn);
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows == true)
            {
                listView1.Items.Clear();

                while (rdr.Read())
                {
                    ListViewItem list = new ListViewItem(rdr[0].ToString());
                    list.SubItems.Add(rdr[1].ToString());
                    list.SubItems.Add(rdr[2].ToString());
                    list.SubItems.Add(rdr[3].ToString());
                    list.SubItems.Add(rdr[4].ToString());
                    list.SubItems.Add(rdr[5].ToString());
                    list.SubItems.Add(rdr[6].ToString());
                    list.SubItems.Add(rdr[7].ToString());
                    list.SubItems.Add(rdr[8].ToString());
                    listView1.Items.Add(list);
                }
            }
            else
            {
                MessageBox.Show("No record found!");
            }
            conn.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            driver add_driver = new driver();
            add_driver.tb_company.Text = lbl_company.Text;
            add_driver.lbl_user.Text = lbl_type.Text + " " + lbl_user.Text;
            add_driver.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            cmd = new MySqlCommand("SELECT * FROM tbl_driver where driver_no like '%" + tb_search.Text + "%' or fname like '%" + tb_search.Text + "%' or lname like '%" + tb_search.Text + "%'", conn);
            rdr = cmd.ExecuteReader();
            if (tb_search.Text == null)
            {
                refresh();
            }
            else
            {
                if (rdr.HasRows == true)
                {
                    listView1.Items.Clear();
                    while (rdr.Read())
                    {
                        ListViewItem list = new ListViewItem(rdr[0].ToString());
                        list.SubItems.Add(rdr[1].ToString());
                        list.SubItems.Add(rdr[2].ToString());
                        list.SubItems.Add(rdr[3].ToString());
                        list.SubItems.Add(rdr[4].ToString());
                        list.SubItems.Add(rdr[5].ToString());
                        list.SubItems.Add(rdr[6].ToString());
                        list.SubItems.Add(rdr[7].ToString());
                        list.SubItems.Add(rdr[8].ToString());
                        list.SubItems.Add(rdr[9].ToString());
                        list.SubItems.Add(rdr[10].ToString());
                        list.SubItems.Add(rdr[11].ToString());
                        list.SubItems.Add(rdr[12].ToString());
                        list.SubItems.Add(rdr[13].ToString());
                        list.SubItems.Add(rdr[14].ToString());
                        list.SubItems.Add(rdr[15].ToString());
                        list.SubItems.Add(rdr[16].ToString());
                        list.SubItems.Add(rdr[17].ToString());
                        list.SubItems.Add(rdr[18].ToString());
                        list.SubItems.Add(rdr[19].ToString());
                        list.SubItems.Add(rdr[20].ToString());
                        list.SubItems.Add(rdr[21].ToString());
                        listView1.Items.Add(list);
                    }
                }
                /*else
                {
                    MessageBox.Show("Record not found." + "\n" + "Unfortunately, the record you've searched does not exists or no longer exists.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
            conn.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to update this information?", "iBUS Message", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmd = new MySqlCommand("SELECT * FROM tbl_driver WHERE ibus_driver_no =" + listView1.SelectedItems[0].Text + " and company_name = '" + lbl_company.Text + "'", conn);
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {

                    }
                }

                driver update_driver = new driver();
                update_driver.btn_save.Text = "Update";
                update_driver.btn_save.TextAlign = ContentAlignment.MiddleCenter;
                update_driver.btn_clear.Text = "Delete";
                update_driver.btn_clear.TextAlign = ContentAlignment.MiddleCenter;
                update_driver.lbl_driver.Text = "Update Driver Record";
                update_driver.tb_ibusno.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text;
                update_driver.tb_company.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text;
                update_driver.tb_driverno.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text;
                update_driver.tb_fname.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[3].Text;
                update_driver.tb_lname.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[4].Text;
                update_driver.dt_bday.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[5].Text;
                update_driver.tb_age.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[6].Text;
                update_driver.cb_gender.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[7].Text;
                update_driver.cb_civilstatus.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[8].Text;
                update_driver.tb_address.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[9].Text;
                update_driver.mt_contact.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[10].Text;
                update_driver.tb_email.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[11].Text;
                update_driver.tb_licenseno.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[12].Text;
                update_driver.tb_issue.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[13].Text;
                update_driver.tb_expiration.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[14].Text;
                update_driver.cb_shiftstart.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[15].Text;
                update_driver.cb_shiftend.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[16].Text;
                update_driver.dt_datejoin.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[17].Text;
                //update_driver.pic_driver.Image = listView1.Items[listView1.FocusedItem.Index].SubItems[8].Text;
                update_driver.ShowDialog();
                conn.Close();
            }
            else { }
        }

    }
}
