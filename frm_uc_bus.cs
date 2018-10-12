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
    public partial class frm_uc_bus : UserControl
    {
        List<Bus> buses;

        public frm_uc_bus()
        {
            InitializeComponent();
            this.refreshData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_new_bus frm_new_bus = new frm_new_bus();
            frm_new_bus.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.refreshData();
        }


        private void refreshData()
        {
            this.buses = Bus.all();
            listView1.Items.Clear();
            foreach (var x in this.buses)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(x.getCompany().name);
                lvi.SubItems.Add(x.bus_no);
                lvi.SubItems.Add(x.bus_model);
                lvi.SubItems.Add(x.getBusClass().name);
                lvi.SubItems.Add(x.getFrom().name);
                lvi.SubItems.Add(x.getTo().name);
                lvi.SubItems.Add(x.bus_plate);
                lvi.SubItems.Add(x.date_added.ToString());
                listView1.Items.Add(lvi);
            }
        }
    }
}
