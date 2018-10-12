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
    public partial class uc_bus : UserControl
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;database=ibus_database;username=root;password=");
        MySqlCommand cmd;
        MySqlDataReader rdr;

        public uc_bus()
        {
            InitializeComponent();
        }

        private void uc_bus_Load(object sender, EventArgs e)
        {
            refresh();
        }

        void refresh()
        {
            listView1.Items.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            cmd = new MySqlCommand("Select * From tbl_bus where bus_company = '"+ lbl_company.Text +"'", conn);
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bus add_bus = new bus();
            add_bus.tb_company.Text = lbl_company.Text;
            add_bus.lbl_user.Text = lbl_type.Text + " " + lbl_user.Text;
            add_bus.ShowDialog();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to update this information?", "iBUS Message", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmd = new MySqlCommand("SELECT * FROM tbl_bus WHERE ibus_bus_no =" + listView1.SelectedItems[0].Text + " and bus_company = '"+ lbl_company.Text +"'", conn);
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {

                    }
                }
                
                bus update_bus = new bus();
                update_bus.btn_save.Text = "Update";
                update_bus.btn_save.TextAlign = ContentAlignment.MiddleCenter;
                update_bus.btn_clear.Text = "Delete";
                update_bus.btn_clear.TextAlign = ContentAlignment.MiddleCenter;
                update_bus.lbl_bus.Text = "Update Bus Record";
                update_bus.tb_ibusno.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text;
                update_bus.tb_company.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text;
                update_bus.tb_busno.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text;
                update_bus.cb_model.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[3].Text;
                update_bus.cb_class.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[4].Text;
                update_bus.cb_routefrom.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[5].Text;
                update_bus.cb_routeto.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[6].Text;
                update_bus.tb_plateno.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[7].Text;
                update_bus.dt_added.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[8].Text;
                update_bus.ShowDialog();
                conn.Close();
            }
            else { }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            cmd = new MySqlCommand("SELECT * FROM tbl_bus where bus_no like '%" + tb_search.Text + "%' or bus_model like '%" + tb_search.Text + "%' or bus_class like '%" + tb_search.Text + "%'", conn);
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

      
    }
}
