using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace iBUS
{
    public partial class bus_report : Form
    {
        public bus_report()
        {
            InitializeComponent();
        }

        private void bus_report_Load(object sender, EventArgs e)
        {
            LoadDay();
            LoadMonth();
            LoadYear();
        }

        private delegate void del_LoadMonth();
        private delegate void del_LoadYear();

        private void LoadDay()
        {
            
        }

        private void LoadMonth()
        {
            if (cb_month.InvokeRequired)
                cb_month.Invoke(new del_LoadMonth(LoadMonth), null);

            else
            {
                for (int i = 0; i < 12; i++)
                {
                    cb_month.Items.Insert(i, CultureInfo.CurrentUICulture.DateTimeFormat.MonthNames[i]);
                }
                cb_month.SelectedIndex = DateTime.Now.Month - 1;
            }
        }
        
        private void LoadYear()
        {
            try
            {
                if (cb_year.InvokeRequired)
                    cb_year.Invoke(new del_LoadYear(LoadYear), null);
                else
                {
                    int iCurrentYear = DateTime.Now.Year;
                    for (int i = 1990; i <= iCurrentYear; i++)
                    {
                        cb_year.Items.Add(i.ToString());
                    }
                        cb_year.SelectedIndex = (cb_year.Items.Count - 1);
                    }
                }
                catch (Exception)
                {

                }
           }

        private void rbtn_search_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_search.Checked == true)
            {
                tb_search.Enabled = true;
                cb_day.Enabled = false;
                cb_month.Enabled = false;
                cb_year.Enabled = false;
            }
        }

        private void rbtn_month_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_month.Checked == true)
            {
                tb_search.Enabled = false;
                cb_day.Enabled = false;
                cb_month.Enabled = true;
                cb_year.Enabled = true;
            }
        }

        private void rbtn_day_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_day.Checked == true)
            {
                tb_search.Enabled = false;
                cb_day.Enabled = true;
                cb_month.Enabled = true;
                cb_year.Enabled = true;
            }
        }

        private void rbtn_year_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_year.Checked == true)
            {
                tb_search.Enabled = false;
                cb_day.Enabled = false;
                cb_month.Enabled = false;
                cb_year.Enabled = true;
            }
        }

    }
}
