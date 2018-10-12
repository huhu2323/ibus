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
    public partial class uc_dashboard : UserControl
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;database=ibus_database;username=root;password=");
        MySqlCommand cmd;
        MySqlDataReader rdr;

        public uc_dashboard()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            events add_events = new events();
            add_events.lbl_company.Text = lbl_company.Text;
            add_events.lbl_user.Text = lbl_user.Text;
            add_events.ShowDialog();
        }

        private void uc_dashboard_Load(object sender, EventArgs e)
        {
            refresh();
        }

        void refresh()
        {
            listView1.Items.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            cmd = new MySqlCommand("Select * From tbl_events where company_name = '" + lbl_company.Text + "'", conn);
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
                //MessageBox.Show("No record found.", "iBUS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
       
       
    }
}
