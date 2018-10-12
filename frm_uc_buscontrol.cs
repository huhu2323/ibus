using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace iBUS
{
    public partial class frm_uc_buscontrol : UserControl
    {
        bool isOpen = true;
        SerialPort port3 = new SerialPort();
        public frm_uc_buscontrol()
        {
            InitializeComponent();
            //while (!serialPort1.IsOpen)
            //{
            //    try
            //    {
            //        serialPort1.Open();
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}
            this.port3.PortName = "COM3";
            this.port3.BaudRate = 9600;
            this.port3.DataBits = 8;
            this.port3.Parity = Parity.None;
        }

        private void btn_enable_Click(object sender, EventArgs e)
        {
            try
            {
                this.port3.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                this.port3.WriteLine("b");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_toggle_Click(object sender, EventArgs e)
        {
            

            try
            {
                this.port3.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                this.port3.WriteLine("a");
                isOpen = !isOpen;
                if (isOpen)
                {
                    btn_toggle.color = Color.SeaGreen;
                    btn_toggle.colorActive = Color.MediumSeaGreen;
                }
                else
                {
                    btn_toggle.color = Color.IndianRed;
                    btn_toggle.colorActive = Color.DarkRed;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btn_disable_Click(object sender, EventArgs e)
        {

            try
            {
                this.port3.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                this.port3.WriteLine("c");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string x = this.port3.ReadExisting();
                if (x != "")
                {
                    if (x == "open")
                    {
                        listBox1.Items.Add("The bus driver opened his door manually. " + DateTime.Now.ToString());
                        var newLog = new Log();
                        newLog.message = "The bus driver opened his door manually.";
                        newLog.date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        newLog.save();
                        btn_toggle.color = Color.SeaGreen;
                        btn_toggle.colorActive = Color.MediumSeaGreen;
                    }
                    else if (x == "close")
                    {
                        listBox1.Items.Add("The bus driver closed his door manually. " + DateTime.Now.ToString());
                        var newLog = new Log();
                        newLog.message = "The bus driver closed his door manually.";
                        newLog.date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        newLog.save();
                        btn_toggle.color = Color.IndianRed;
                        btn_toggle.colorActive = Color.DarkRed;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }

}