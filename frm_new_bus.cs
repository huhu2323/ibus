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
        List<Company> companies;
        public frm_new_bus()
        {
            InitializeComponent();
            this.stations = Station.all();
            this.busClasses = BusClass.all();
            this.companies = Company.all();
            foreach (var x in this.stations)
            {
                cb_routefrom.Items.Add(x.name);
                cb_routeto.Items.Add(x.name);
            }
            foreach (var x in this.busClasses)
            {
                cb_class.Items.Add(x.name);
            }
            foreach (var x in this.companies)
            {
                cb_company.Items.Add(x.name);
            }
        }

        private void bus_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                Bus newBus = new Bus();
                var Timestamp = new DateTimeOffset(DateTime.Now);
                newBus.bus_id = null;
                newBus.bus_class = cb_class.SelectedIndex + 1;
                newBus.bus_company = cb_company.SelectedIndex + 1;
                newBus.bus_from = cb_routefrom.SelectedIndex + 1;
                newBus.bus_model = tb_model.Text;
                newBus.bus_no = tb_busno.Text;
                newBus.bus_plate = tb_plateno.Text;
                newBus.bus_to = cb_routeto.SelectedIndex + 1;
                //newBus.date_added = GetTimestamp(DateTime.Now);
                //Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                newBus.date_added = DateTime.Now.ToString();
                if (newBus.save())
                {
                    MessageBox.Show("Success!");
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("error");
            }
            
        }

        void clear()
        {
            cb_class.SelectedIndex = -1;
            cb_routefrom.SelectedIndex = -1;
            cb_routeto.SelectedIndex = -1;
            tb_model.Text = "";
            cb_class.Text = "";
            cb_company.SelectedIndex = -1;
            cb_routefrom.Text = "";
            cb_routeto.Text = "";
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

        public bool validate()
        {
            if (tb_busno.Text == ""
                || cb_company.SelectedIndex < 0
                || tb_busno.Text == ""
                || tb_plateno.Text == ""
                || cb_class.SelectedIndex < 0
                || tb_model.Text == ""
                || cb_routefrom.SelectedIndex < 0
                || cb_routeto.SelectedIndex < 0 )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        

    }
}
