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
    public partial class frm_new_bus : Form
    {
        List<Station> stations;
        List<BusClass> busClasses;
        public frm_new_bus()
        {
            InitializeComponent();
            this.stations = Station.all();
            this.busClasses = BusClass.all();
            foreach (var x in this.stations)
            {
                cb_routefrom.Items.Add(x.name);
                cb_routeto.Items.Add(x.name);
            }
            foreach (var x in this.busClasses)
            {
                cb_class.Items.Add(x.name);
            }
        }

        private void bus_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Bus newBus = new Bus();
            
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
