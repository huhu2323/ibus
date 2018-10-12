namespace iBUS
{
    partial class frm_uc_buscontrol
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_uc_buscontrol));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_enable = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_disable = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_toggle = new Bunifu.Framework.UI.BunifuTileButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 37);
            this.label1.TabIndex = 189;
            this.label1.Text = "Bus Control";
            // 
            // btn_enable
            // 
            this.btn_enable.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_enable.color = System.Drawing.Color.SeaGreen;
            this.btn_enable.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enable.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_enable.ForeColor = System.Drawing.Color.White;
            this.btn_enable.Image = ((System.Drawing.Image)(resources.GetObject("btn_enable.Image")));
            this.btn_enable.ImagePosition = 20;
            this.btn_enable.ImageZoom = 50;
            this.btn_enable.LabelPosition = 41;
            this.btn_enable.LabelText = "Enable";
            this.btn_enable.Location = new System.Drawing.Point(31, 125);
            this.btn_enable.Margin = new System.Windows.Forms.Padding(6);
            this.btn_enable.Name = "btn_enable";
            this.btn_enable.Size = new System.Drawing.Size(128, 129);
            this.btn_enable.TabIndex = 190;
            this.btn_enable.Click += new System.EventHandler(this.btn_enable_Click);
            // 
            // btn_disable
            // 
            this.btn_disable.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_disable.color = System.Drawing.Color.SeaGreen;
            this.btn_disable.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_disable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_disable.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_disable.ForeColor = System.Drawing.Color.White;
            this.btn_disable.Image = ((System.Drawing.Image)(resources.GetObject("btn_disable.Image")));
            this.btn_disable.ImagePosition = 20;
            this.btn_disable.ImageZoom = 50;
            this.btn_disable.LabelPosition = 41;
            this.btn_disable.LabelText = "Disable";
            this.btn_disable.Location = new System.Drawing.Point(171, 125);
            this.btn_disable.Margin = new System.Windows.Forms.Padding(6);
            this.btn_disable.Name = "btn_disable";
            this.btn_disable.Size = new System.Drawing.Size(128, 129);
            this.btn_disable.TabIndex = 191;
            this.btn_disable.Click += new System.EventHandler(this.btn_disable_Click);
            // 
            // btn_toggle
            // 
            this.btn_toggle.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_toggle.color = System.Drawing.Color.SeaGreen;
            this.btn_toggle.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_toggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_toggle.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_toggle.ForeColor = System.Drawing.Color.White;
            this.btn_toggle.Image = ((System.Drawing.Image)(resources.GetObject("btn_toggle.Image")));
            this.btn_toggle.ImagePosition = 20;
            this.btn_toggle.ImageZoom = 50;
            this.btn_toggle.LabelPosition = 41;
            this.btn_toggle.LabelText = "Toggle Door";
            this.btn_toggle.Location = new System.Drawing.Point(311, 125);
            this.btn_toggle.Margin = new System.Windows.Forms.Padding(6);
            this.btn_toggle.Name = "btn_toggle";
            this.btn_toggle.Size = new System.Drawing.Size(128, 129);
            this.btn_toggle.TabIndex = 192;
            this.btn_toggle.Click += new System.EventHandler(this.btn_toggle_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(461, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(467, 407);
            this.listBox1.TabIndex = 193;
            // 
            // frm_uc_buscontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_toggle);
            this.Controls.Add(this.btn_disable);
            this.Controls.Add(this.btn_enable);
            this.Controls.Add(this.label1);
            this.Name = "frm_uc_buscontrol";
            this.Size = new System.Drawing.Size(1145, 712);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton btn_enable;
        private Bunifu.Framework.UI.BunifuTileButton btn_disable;
        private Bunifu.Framework.UI.BunifuTileButton btn_toggle;
        public System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
    }
}
