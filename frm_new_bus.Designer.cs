namespace iBUS
{
    partial class frm_new_bus
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_new_bus));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_company = new System.Windows.Forms.ComboBox();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_bus = new System.Windows.Forms.Label();
            this.btn_cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tb_plateno = new System.Windows.Forms.TextBox();
            this.btn_clear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cb_routeto = new System.Windows.Forms.ComboBox();
            this.btn_save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tb_busno = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_routefrom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.cb_company);
            this.panel1.Controls.Add(this.tb_model);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.tb_plateno);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.cb_routeto);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.tb_busno);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb_routefrom);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_class);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(21, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 400);
            this.panel1.TabIndex = 0;
            // 
            // cb_company
            // 
            this.cb_company.BackColor = System.Drawing.Color.White;
            this.cb_company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_company.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_company.FormattingEnabled = true;
            this.cb_company.Location = new System.Drawing.Point(34, 101);
            this.cb_company.Name = "cb_company";
            this.cb_company.Size = new System.Drawing.Size(381, 30);
            this.cb_company.TabIndex = 165;
            // 
            // tb_model
            // 
            this.tb_model.BackColor = System.Drawing.Color.White;
            this.tb_model.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_model.Location = new System.Drawing.Point(240, 176);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(188, 29);
            this.tb_model.TabIndex = 164;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.panel2.Controls.Add(this.lbl_bus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 40);
            this.panel2.TabIndex = 162;
            // 
            // lbl_bus
            // 
            this.lbl_bus.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bus.ForeColor = System.Drawing.Color.White;
            this.lbl_bus.Location = new System.Drawing.Point(3, 10);
            this.lbl_bus.Name = "lbl_bus";
            this.lbl_bus.Size = new System.Drawing.Size(870, 19);
            this.lbl_bus.TabIndex = 163;
            this.lbl_bus.Text = "Add New Bus";
            this.lbl_bus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.BorderRadius = 5;
            this.btn_cancel.ButtonText = "Cancel";
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Iconimage")));
            this.btn_cancel.Iconimage_right = null;
            this.btn_cancel.Iconimage_right_Selected = null;
            this.btn_cancel.Iconimage_Selected = null;
            this.btn_cancel.IconMarginLeft = 20;
            this.btn_cancel.IconMarginRight = 0;
            this.btn_cancel.IconRightVisible = true;
            this.btn_cancel.IconRightZoom = 0D;
            this.btn_cancel.IconVisible = true;
            this.btn_cancel.IconZoom = 50D;
            this.btn_cancel.IsTab = false;
            this.btn_cancel.Location = new System.Drawing.Point(522, 329);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_cancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btn_cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancel.selected = false;
            this.btn_cancel.Size = new System.Drawing.Size(136, 33);
            this.btn_cancel.TabIndex = 161;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Textcolor = System.Drawing.Color.White;
            this.btn_cancel.TextFont = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // tb_plateno
            // 
            this.tb_plateno.BackColor = System.Drawing.Color.White;
            this.tb_plateno.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_plateno.Location = new System.Drawing.Point(448, 257);
            this.tb_plateno.Name = "tb_plateno";
            this.tb_plateno.Size = new System.Drawing.Size(186, 29);
            this.tb_plateno.TabIndex = 136;
            // 
            // btn_clear
            // 
            this.btn_clear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.BorderRadius = 5;
            this.btn_clear.ButtonText = "Clear";
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.DisabledColor = System.Drawing.Color.Gray;
            this.btn_clear.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_clear.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_clear.Iconimage")));
            this.btn_clear.Iconimage_right = null;
            this.btn_clear.Iconimage_right_Selected = null;
            this.btn_clear.Iconimage_Selected = null;
            this.btn_clear.IconMarginLeft = 20;
            this.btn_clear.IconMarginRight = 0;
            this.btn_clear.IconRightVisible = true;
            this.btn_clear.IconRightZoom = 0D;
            this.btn_clear.IconVisible = true;
            this.btn_clear.IconZoom = 50D;
            this.btn_clear.IsTab = false;
            this.btn_clear.Location = new System.Drawing.Point(370, 329);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_clear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btn_clear.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_clear.selected = false;
            this.btn_clear.Size = new System.Drawing.Size(136, 33);
            this.btn_clear.TabIndex = 160;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clear.Textcolor = System.Drawing.Color.White;
            this.btn_clear.TextFont = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // cb_routeto
            // 
            this.cb_routeto.BackColor = System.Drawing.Color.White;
            this.cb_routeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_routeto.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_routeto.FormattingEnabled = true;
            this.cb_routeto.Location = new System.Drawing.Point(240, 257);
            this.cb_routeto.Name = "cb_routeto";
            this.cb_routeto.Size = new System.Drawing.Size(186, 30);
            this.cb_routeto.TabIndex = 129;
            // 
            // btn_save
            // 
            this.btn_save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.BorderRadius = 5;
            this.btn_save.ButtonText = "Save";
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DisabledColor = System.Drawing.Color.Gray;
            this.btn_save.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_save.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_save.Iconimage")));
            this.btn_save.Iconimage_right = null;
            this.btn_save.Iconimage_right_Selected = null;
            this.btn_save.Iconimage_Selected = null;
            this.btn_save.IconMarginLeft = 20;
            this.btn_save.IconMarginRight = 0;
            this.btn_save.IconRightVisible = true;
            this.btn_save.IconRightZoom = 0D;
            this.btn_save.IconVisible = true;
            this.btn_save.IconZoom = 50D;
            this.btn_save.IsTab = false;
            this.btn_save.Location = new System.Drawing.Point(218, 329);
            this.btn_save.Name = "btn_save";
            this.btn_save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btn_save.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save.selected = false;
            this.btn_save.Size = new System.Drawing.Size(136, 33);
            this.btn_save.TabIndex = 159;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.Textcolor = System.Drawing.Color.White;
            this.btn_save.TextFont = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_busno
            // 
            this.tb_busno.BackColor = System.Drawing.Color.White;
            this.tb_busno.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_busno.Location = new System.Drawing.Point(34, 175);
            this.tb_busno.Name = "tb_busno";
            this.tb_busno.Size = new System.Drawing.Size(188, 29);
            this.tb_busno.TabIndex = 135;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(444, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 19);
            this.label16.TabIndex = 127;
            this.label16.Text = "Class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 121;
            this.label2.Text = "Bus No:";
            // 
            // cb_routefrom
            // 
            this.cb_routefrom.BackColor = System.Drawing.Color.White;
            this.cb_routefrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_routefrom.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_routefrom.FormattingEnabled = true;
            this.cb_routefrom.Location = new System.Drawing.Point(34, 257);
            this.cb_routefrom.Name = "cb_routefrom";
            this.cb_routefrom.Size = new System.Drawing.Size(188, 30);
            this.cb_routefrom.TabIndex = 128;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(30, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 133;
            this.label6.Text = "Bus Company:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(444, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 122;
            this.label3.Text = "Plate No:";
            // 
            // cb_class
            // 
            this.cb_class.BackColor = System.Drawing.Color.White;
            this.cb_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_class.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Location = new System.Drawing.Point(448, 175);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(186, 30);
            this.cb_class.TabIndex = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(236, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 130;
            this.label1.Text = "Route: (To)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(236, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 123;
            this.label4.Text = "Model:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(30, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 19);
            this.label7.TabIndex = 124;
            this.label7.Text = "Route: (From)";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.White;
            this.lbl_user.Location = new System.Drawing.Point(2, 428);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(35, 14);
            this.lbl_user.TabIndex = 163;
            this.lbl_user.Text = "user";
            this.lbl_user.Visible = false;
            // 
            // frm_new_bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(919, 448);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(330, 170);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_new_bus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.bus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cb_routeto;
        public System.Windows.Forms.ComboBox cb_routefrom;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.ComboBox cb_class;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuFlatButton btn_cancel;
        public Bunifu.Framework.UI.BunifuFlatButton btn_clear;
        public Bunifu.Framework.UI.BunifuFlatButton btn_save;
        public System.Windows.Forms.Label lbl_bus;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox tb_plateno;
        public System.Windows.Forms.TextBox tb_busno;
        public System.Windows.Forms.Label lbl_user;
        public System.Windows.Forms.TextBox tb_model;
        public System.Windows.Forms.ComboBox cb_company;
    }
}