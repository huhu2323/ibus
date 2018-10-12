using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace iBUS
{
    public partial class splashscreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public splashscreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private int _Progress = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_Progress < 100)
            {
                _Progress++;
                label2.Text = _Progress.ToString() + "%";
            }
            else
            {
                timer1.Enabled = false;

            }
        }

        int count = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
            {
                bunifuTransition2.HideSync(logo2);
                bunifuTransition1.ShowSync(logo1);
            }
            if (count == 4)
            {
                bunifuTransition1.HideSync(logo1);
                bunifuTransition2.ShowSync(logo2);
            }
            if (count == 7)
            {
                count = 0;
            }
        }

    }
}
