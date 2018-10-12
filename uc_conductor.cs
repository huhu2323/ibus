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
    public partial class uc_conductor : UserControl
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;database=ibus_database;username=root;password=");
        MySqlCommand cmd;
        MySqlDataReader rdr;

        public uc_conductor()
        {
            InitializeComponent();
        }

        private void uc_conductor_Load(object sender, EventArgs e)
        {
            refresh();
        }



        /// void

        void refresh()
        {
            listView1.Items.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            cmd = new MySqlCommand("Select * From tbl_conductor where company_name = '" + lbl_company.Text + "'", conn);
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
                    list.SubItems.Add(rdr[9].ToString());
                    list.SubItems.Add(rdr[10].ToString());
                    list.SubItems.Add(rdr[11].ToString());
                    list.SubItems.Add(rdr[12].ToString());
                    list.SubItems.Add(rdr[13].ToString());
                    list.SubItems.Add(rdr[14].ToString());
                    list.SubItems.Add(rdr[15].ToString());
                    list.SubItems.Add(rdr[16].ToString());
                    list.SubItems.Add(rdr[17].ToString());
                    listView1.Items.Add(list);
                }
            }
            else
            {
                //MessageBox.Show("No record found.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            conductor add_conductor = new conductor();
            add_conductor.tb_company.Text = lbl_company.Text;
            add_conductor.lbl_user.Text = lbl_type.Text + " " + lbl_user.Text;
            add_conductor.ShowDialog();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            cmd = new MySqlCommand("SELECT * FROM tbl_conductor where conductor_no like '%" + tb_search.Text + "%' or fname like '%" + tb_search.Text + "%' or lname like '%" + tb_search.Text + "%'", conn);
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
