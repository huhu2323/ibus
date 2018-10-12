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
    public partial class frm_uc_dashboard : UserControl
    {
        

        public frm_uc_dashboard()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_events add_events = new frm_events();
            add_events.lbl_company.Text = lbl_company.Text;
            add_events.lbl_user.Text = lbl_user.Text;
            add_events.ShowDialog();
        }

        private void uc_dashboard_Load(object sender, EventArgs e)
        {

        }

        void refresh()
        {
            
        }
       
       
    }
}
