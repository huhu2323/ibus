namespace iBUS
{
    partial class home
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.logo1 = new System.Windows.Forms.PictureBox();
            this.side_menu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_company = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_idno = new System.Windows.Forms.Label();
            this.btn_dashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.user_pic = new iBUS.OvalPictureBox();
            this.btn_addtrip = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_conductor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_driver = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_bus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_emergency = new Bunifu.Framework.UI.BunifuFlatButton();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.lbl_user = new System.Windows.Forms.Label();
            this.contextmenu_trip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenu_bus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewBusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenu_conductor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewConductorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenu_reports = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.condtuctorReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tripReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenu_driver = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_message = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_profile = new Bunifu.Framework.UI.BunifuImageButton();
            this.contextmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.uc_profile1 = new iBUS.uc_profile();
            this.uc_company1 = new iBUS.uc_company();
            this.uc_conductor1 = new iBUS.uc_conductor();
            this.uc_driver1 = new iBUS.uc_driver();
            this.uc_bus1 = new iBUS.uc_bus();
            this.uc_dashboard1 = new iBUS.uc_dashboard();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).BeginInit();
            this.side_menu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pic)).BeginInit();
            this.contextmenu_trip.SuspendLayout();
            this.contextmenu_bus.SuspendLayout();
            this.contextmenu_conductor.SuspendLayout();
            this.contextmenu_reports.SuspendLayout();
            this.contextmenu_driver.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_message)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_profile)).BeginInit();
            this.contextmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.time, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.time, BunifuAnimatorNS.DecorationType.None);
            this.time.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(475, 3);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(194, 33);
            this.time.TabIndex = 67;
            this.time.Text = "time";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.date, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.date, BunifuAnimatorNS.DecorationType.None);
            this.date.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(425, 31);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(295, 25);
            this.date.TabIndex = 68;
            this.date.Text = "date";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo2
            // 
            this.bunifuTransition1.SetDecoration(this.logo2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.logo2, BunifuAnimatorNS.DecorationType.None);
            this.logo2.Image = ((System.Drawing.Image)(resources.GetObject("logo2.Image")));
            this.logo2.Location = new System.Drawing.Point(94, 20);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(124, 23);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo2.TabIndex = 25;
            this.logo2.TabStop = false;
            // 
            // logo1
            // 
            this.bunifuTransition1.SetDecoration(this.logo1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.logo1, BunifuAnimatorNS.DecorationType.None);
            this.logo1.Image = ((System.Drawing.Image)(resources.GetObject("logo1.Image")));
            this.logo1.Location = new System.Drawing.Point(5, 3);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(94, 53);
            this.logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo1.TabIndex = 24;
            this.logo1.TabStop = false;
            // 
            // side_menu
            // 
            this.side_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.side_menu.Controls.Add(this.panel2);
            this.side_menu.Controls.Add(this.lbl_type);
            this.side_menu.Controls.Add(this.lbl_idno);
            this.side_menu.Controls.Add(this.btn_dashboard);
            this.side_menu.Controls.Add(this.bunifuFlatButton2);
            this.side_menu.Controls.Add(this.user_pic);
            this.side_menu.Controls.Add(this.btn_addtrip);
            this.side_menu.Controls.Add(this.btn_conductor);
            this.side_menu.Controls.Add(this.btn_driver);
            this.side_menu.Controls.Add(this.btn_bus);
            this.side_menu.Controls.Add(this.btn_emergency);
            this.side_menu.Controls.Add(this.shapeContainer1);
            this.side_menu.Controls.Add(this.lbl_user);
            this.bunifuTransition1.SetDecoration(this.side_menu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.side_menu, BunifuAnimatorNS.DecorationType.None);
            this.side_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_menu.Location = new System.Drawing.Point(0, 0);
            this.side_menu.Name = "side_menu";
            this.side_menu.Size = new System.Drawing.Size(225, 772);
            this.side_menu.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.panel2.Controls.Add(this.logo2);
            this.panel2.Controls.Add(this.logo1);
            this.panel2.Controls.Add(this.lbl_company);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 60);
            this.panel2.TabIndex = 61;
            // 
            // lbl_company
            // 
            this.bunifuTransition1.SetDecoration(this.lbl_company, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbl_company, BunifuAnimatorNS.DecorationType.None);
            this.lbl_company.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_company.ForeColor = System.Drawing.Color.White;
            this.lbl_company.Location = new System.Drawing.Point(4, 9);
            this.lbl_company.Name = "lbl_company";
            this.lbl_company.Size = new System.Drawing.Size(215, 43);
            this.lbl_company.TabIndex = 67;
            this.lbl_company.Text = "company";
            this.lbl_company.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_company.Visible = false;
            // 
            // lbl_type
            // 
            this.bunifuTransition1.SetDecoration(this.lbl_type, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbl_type, BunifuAnimatorNS.DecorationType.None);
            this.lbl_type.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.ForeColor = System.Drawing.Color.Red;
            this.lbl_type.Location = new System.Drawing.Point(32, 261);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(160, 24);
            this.lbl_type.TabIndex = 28;
            this.lbl_type.Text = "type";
            this.lbl_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_idno
            // 
            this.bunifuTransition1.SetDecoration(this.lbl_idno, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbl_idno, BunifuAnimatorNS.DecorationType.None);
            this.lbl_idno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_idno.Location = new System.Drawing.Point(80, 267);
            this.lbl_idno.Name = "lbl_idno";
            this.lbl_idno.Size = new System.Drawing.Size(68, 21);
            this.lbl_idno.TabIndex = 36;
            this.lbl_idno.Text = "id";
            this.lbl_idno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_idno.Visible = false;
            this.lbl_idno.TextChanged += new System.EventHandler(this.lbl_idno_TextChanged);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dashboard.BorderRadius = 0;
            this.btn_dashboard.ButtonText = "     Dashboard";
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_dashboard, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btn_dashboard, BunifuAnimatorNS.DecorationType.None);
            this.btn_dashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btn_dashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_dashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_dashboard.Iconimage")));
            this.btn_dashboard.Iconimage_right = null;
            this.btn_dashboard.Iconimage_right_Selected = null;
            this.btn_dashboard.Iconimage_Selected = null;
            this.btn_dashboard.IconMarginLeft = 13;
            this.btn_dashboard.IconMarginRight = 0;
            this.btn_dashboard.IconRightVisible = true;
            this.btn_dashboard.IconRightZoom = 0D;
            this.btn_dashboard.IconVisible = true;
            this.btn_dashboard.IconZoom = 50D;
            this.btn_dashboard.IsTab = true;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 302);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_dashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_dashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_dashboard.selected = false;
            this.btn_dashboard.Size = new System.Drawing.Size(227, 35);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Text = "     Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Textcolor = System.Drawing.Color.Gray;
            this.btn_dashboard.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "     Reports";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 13;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 512);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(227, 35);
            this.bunifuFlatButton2.TabIndex = 6;
            this.bunifuFlatButton2.Text = "     Reports";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // user_pic
            // 
            this.user_pic.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.user_pic, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.user_pic, BunifuAnimatorNS.DecorationType.None);
            this.user_pic.Image = ((System.Drawing.Image)(resources.GetObject("user_pic.Image")));
            this.user_pic.Location = new System.Drawing.Point(31, 79);
            this.user_pic.Name = "user_pic";
            this.user_pic.Size = new System.Drawing.Size(157, 142);
            this.user_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_pic.TabIndex = 59;
            this.user_pic.TabStop = false;
            // 
            // btn_addtrip
            // 
            this.btn_addtrip.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_addtrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_addtrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addtrip.BorderRadius = 0;
            this.btn_addtrip.ButtonText = "     Bus Trip";
            this.btn_addtrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_addtrip, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btn_addtrip, BunifuAnimatorNS.DecorationType.None);
            this.btn_addtrip.DisabledColor = System.Drawing.Color.Gray;
            this.btn_addtrip.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_addtrip.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_addtrip.Iconimage")));
            this.btn_addtrip.Iconimage_right = null;
            this.btn_addtrip.Iconimage_right_Selected = null;
            this.btn_addtrip.Iconimage_Selected = null;
            this.btn_addtrip.IconMarginLeft = 13;
            this.btn_addtrip.IconMarginRight = 0;
            this.btn_addtrip.IconRightVisible = true;
            this.btn_addtrip.IconRightZoom = 0D;
            this.btn_addtrip.IconVisible = true;
            this.btn_addtrip.IconZoom = 50D;
            this.btn_addtrip.IsTab = true;
            this.btn_addtrip.Location = new System.Drawing.Point(0, 442);
            this.btn_addtrip.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addtrip.Name = "btn_addtrip";
            this.btn_addtrip.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_addtrip.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_addtrip.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_addtrip.selected = false;
            this.btn_addtrip.Size = new System.Drawing.Size(227, 35);
            this.btn_addtrip.TabIndex = 4;
            this.btn_addtrip.Text = "     Bus Trip";
            this.btn_addtrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addtrip.Textcolor = System.Drawing.Color.Gray;
            this.btn_addtrip.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_conductor
            // 
            this.btn_conductor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_conductor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_conductor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_conductor.BorderRadius = 0;
            this.btn_conductor.ButtonText = "     Conductor";
            this.btn_conductor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_conductor, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btn_conductor, BunifuAnimatorNS.DecorationType.None);
            this.btn_conductor.DisabledColor = System.Drawing.Color.Gray;
            this.btn_conductor.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_conductor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_conductor.Iconimage")));
            this.btn_conductor.Iconimage_right = null;
            this.btn_conductor.Iconimage_right_Selected = null;
            this.btn_conductor.Iconimage_Selected = null;
            this.btn_conductor.IconMarginLeft = 13;
            this.btn_conductor.IconMarginRight = 0;
            this.btn_conductor.IconRightVisible = true;
            this.btn_conductor.IconRightZoom = 0D;
            this.btn_conductor.IconVisible = true;
            this.btn_conductor.IconZoom = 50D;
            this.btn_conductor.IsTab = true;
            this.btn_conductor.Location = new System.Drawing.Point(0, 407);
            this.btn_conductor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_conductor.Name = "btn_conductor";
            this.btn_conductor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_conductor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_conductor.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_conductor.selected = false;
            this.btn_conductor.Size = new System.Drawing.Size(227, 35);
            this.btn_conductor.TabIndex = 3;
            this.btn_conductor.Text = "     Conductor";
            this.btn_conductor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_conductor.Textcolor = System.Drawing.Color.Gray;
            this.btn_conductor.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conductor.Click += new System.EventHandler(this.btn_addconductor_Click);
            // 
            // btn_driver
            // 
            this.btn_driver.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_driver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_driver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_driver.BorderRadius = 0;
            this.btn_driver.ButtonText = "     Driver";
            this.btn_driver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_driver, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btn_driver, BunifuAnimatorNS.DecorationType.None);
            this.btn_driver.DisabledColor = System.Drawing.Color.Gray;
            this.btn_driver.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_driver.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_driver.Iconimage")));
            this.btn_driver.Iconimage_right = null;
            this.btn_driver.Iconimage_right_Selected = null;
            this.btn_driver.Iconimage_Selected = null;
            this.btn_driver.IconMarginLeft = 13;
            this.btn_driver.IconMarginRight = 0;
            this.btn_driver.IconRightVisible = true;
            this.btn_driver.IconRightZoom = 0D;
            this.btn_driver.IconVisible = true;
            this.btn_driver.IconZoom = 50D;
            this.btn_driver.IsTab = true;
            this.btn_driver.Location = new System.Drawing.Point(0, 372);
            this.btn_driver.Margin = new System.Windows.Forms.Padding(4);
            this.btn_driver.Name = "btn_driver";
            this.btn_driver.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_driver.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_driver.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_driver.selected = false;
            this.btn_driver.Size = new System.Drawing.Size(227, 35);
            this.btn_driver.TabIndex = 2;
            this.btn_driver.Text = "     Driver";
            this.btn_driver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_driver.Textcolor = System.Drawing.Color.Gray;
            this.btn_driver.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_driver.Click += new System.EventHandler(this.btn_adddriver_Click);
            // 
            // btn_bus
            // 
            this.btn_bus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_bus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_bus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bus.BorderRadius = 0;
            this.btn_bus.ButtonText = "     Bus";
            this.btn_bus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_bus, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btn_bus, BunifuAnimatorNS.DecorationType.None);
            this.btn_bus.DisabledColor = System.Drawing.Color.Gray;
            this.btn_bus.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_bus.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_bus.Iconimage")));
            this.btn_bus.Iconimage_right = null;
            this.btn_bus.Iconimage_right_Selected = null;
            this.btn_bus.Iconimage_Selected = null;
            this.btn_bus.IconMarginLeft = 13;
            this.btn_bus.IconMarginRight = 0;
            this.btn_bus.IconRightVisible = true;
            this.btn_bus.IconRightZoom = 0D;
            this.btn_bus.IconVisible = true;
            this.btn_bus.IconZoom = 50D;
            this.btn_bus.IsTab = true;
            this.btn_bus.Location = new System.Drawing.Point(0, 337);
            this.btn_bus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_bus.Name = "btn_bus";
            this.btn_bus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_bus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_bus.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_bus.selected = false;
            this.btn_bus.Size = new System.Drawing.Size(227, 35);
            this.btn_bus.TabIndex = 1;
            this.btn_bus.Text = "     Bus";
            this.btn_bus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bus.Textcolor = System.Drawing.Color.Gray;
            this.btn_bus.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bus.Click += new System.EventHandler(this.btn_addbus_Click);
            // 
            // btn_emergency
            // 
            this.btn_emergency.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_emergency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_emergency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_emergency.BorderRadius = 0;
            this.btn_emergency.ButtonText = "     Emergency";
            this.btn_emergency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_emergency, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btn_emergency, BunifuAnimatorNS.DecorationType.None);
            this.btn_emergency.DisabledColor = System.Drawing.Color.Gray;
            this.btn_emergency.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_emergency.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_emergency.Iconimage")));
            this.btn_emergency.Iconimage_right = null;
            this.btn_emergency.Iconimage_right_Selected = null;
            this.btn_emergency.Iconimage_Selected = null;
            this.btn_emergency.IconMarginLeft = 13;
            this.btn_emergency.IconMarginRight = 0;
            this.btn_emergency.IconRightVisible = true;
            this.btn_emergency.IconRightZoom = 0D;
            this.btn_emergency.IconVisible = true;
            this.btn_emergency.IconZoom = 50D;
            this.btn_emergency.IsTab = true;
            this.btn_emergency.Location = new System.Drawing.Point(0, 477);
            this.btn_emergency.Margin = new System.Windows.Forms.Padding(4);
            this.btn_emergency.Name = "btn_emergency";
            this.btn_emergency.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_emergency.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_emergency.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_emergency.selected = false;
            this.btn_emergency.Size = new System.Drawing.Size(227, 35);
            this.btn_emergency.TabIndex = 5;
            this.btn_emergency.Text = "     Emergency";
            this.btn_emergency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_emergency.Textcolor = System.Drawing.Color.Gray;
            this.btn_emergency.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // shapeContainer1
            // 
            this.bunifuTransition1.SetDecoration(this.shapeContainer1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.shapeContainer1, BunifuAnimatorNS.DecorationType.None);
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(225, 772);
            this.shapeContainer1.TabIndex = 60;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape1
            // 
            this.ovalShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(252)))));
            this.ovalShape1.BorderWidth = 3;
            this.ovalShape1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(252)))));
            this.ovalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape1.Location = new System.Drawing.Point(31, 78);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(157, 142);
            // 
            // lbl_user
            // 
            this.bunifuTransition1.SetDecoration(this.lbl_user, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbl_user, BunifuAnimatorNS.DecorationType.None);
            this.lbl_user.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.Gray;
            this.lbl_user.Location = new System.Drawing.Point(32, 227);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(160, 40);
            this.lbl_user.TabIndex = 29;
            this.lbl_user.Text = "user";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextmenu_trip
            // 
            this.bunifuTransition1.SetDecoration(this.contextmenu_trip, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.contextmenu_trip, BunifuAnimatorNS.DecorationType.None);
            this.contextmenu_trip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextmenu_trip.Name = "contextmenu_conductor";
            this.contextmenu_trip.Size = new System.Drawing.Size(155, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem1.Text = "Add New Trip";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem2.Text = "View List";
            // 
            // contextmenu_bus
            // 
            this.bunifuTransition1.SetDecoration(this.contextmenu_bus, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.contextmenu_bus, BunifuAnimatorNS.DecorationType.None);
            this.contextmenu_bus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBusToolStripMenuItem,
            this.viewListToolStripMenuItem});
            this.contextmenu_bus.Name = "contextmenu_bus";
            this.contextmenu_bus.Size = new System.Drawing.Size(153, 48);
            // 
            // addNewBusToolStripMenuItem
            // 
            this.addNewBusToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewBusToolStripMenuItem.Image")));
            this.addNewBusToolStripMenuItem.Name = "addNewBusToolStripMenuItem";
            this.addNewBusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addNewBusToolStripMenuItem.Text = "Add New Bus";
            // 
            // viewListToolStripMenuItem
            // 
            this.viewListToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewListToolStripMenuItem.Image")));
            this.viewListToolStripMenuItem.Name = "viewListToolStripMenuItem";
            this.viewListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewListToolStripMenuItem.Text = "View List";
            // 
            // contextmenu_conductor
            // 
            this.bunifuTransition1.SetDecoration(this.contextmenu_conductor, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.contextmenu_conductor, BunifuAnimatorNS.DecorationType.None);
            this.contextmenu_conductor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewConductorToolStripMenuItem,
            this.viewListToolStripMenuItem2});
            this.contextmenu_conductor.Name = "contextmenu_conductor";
            this.contextmenu_conductor.Size = new System.Drawing.Size(196, 48);
            // 
            // addNewConductorToolStripMenuItem
            // 
            this.addNewConductorToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewConductorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewConductorToolStripMenuItem.Image")));
            this.addNewConductorToolStripMenuItem.Name = "addNewConductorToolStripMenuItem";
            this.addNewConductorToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.addNewConductorToolStripMenuItem.Text = "Add New Conductor";
            // 
            // viewListToolStripMenuItem2
            // 
            this.viewListToolStripMenuItem2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewListToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("viewListToolStripMenuItem2.Image")));
            this.viewListToolStripMenuItem2.Name = "viewListToolStripMenuItem2";
            this.viewListToolStripMenuItem2.Size = new System.Drawing.Size(195, 22);
            this.viewListToolStripMenuItem2.Text = "View List";
            // 
            // contextmenu_reports
            // 
            this.bunifuTransition1.SetDecoration(this.contextmenu_reports, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.contextmenu_reports, BunifuAnimatorNS.DecorationType.None);
            this.contextmenu_reports.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.condtuctorReportsToolStripMenuItem,
            this.tripReportsToolStripMenuItem,
            this.userReportsToolStripMenuItem});
            this.contextmenu_reports.Name = "contextmenu_conductor";
            this.contextmenu_reports.Size = new System.Drawing.Size(187, 114);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem3.Text = "Bus Reports";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem4.Text = "Driver Reports";
            // 
            // condtuctorReportsToolStripMenuItem
            // 
            this.condtuctorReportsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condtuctorReportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("condtuctorReportsToolStripMenuItem.Image")));
            this.condtuctorReportsToolStripMenuItem.Name = "condtuctorReportsToolStripMenuItem";
            this.condtuctorReportsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.condtuctorReportsToolStripMenuItem.Text = "Condtuctor Reports";
            // 
            // tripReportsToolStripMenuItem
            // 
            this.tripReportsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tripReportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tripReportsToolStripMenuItem.Image")));
            this.tripReportsToolStripMenuItem.Name = "tripReportsToolStripMenuItem";
            this.tripReportsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.tripReportsToolStripMenuItem.Text = "Trip Reports";
            // 
            // userReportsToolStripMenuItem
            // 
            this.userReportsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userReportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userReportsToolStripMenuItem.Image")));
            this.userReportsToolStripMenuItem.Name = "userReportsToolStripMenuItem";
            this.userReportsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.userReportsToolStripMenuItem.Text = "User Reports";
            // 
            // contextmenu_driver
            // 
            this.bunifuTransition1.SetDecoration(this.contextmenu_driver, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.contextmenu_driver, BunifuAnimatorNS.DecorationType.None);
            this.contextmenu_driver.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDriverToolStripMenuItem,
            this.viewListToolStripMenuItem1});
            this.contextmenu_driver.Name = "contextmenu_driver";
            this.contextmenu_driver.Size = new System.Drawing.Size(168, 48);
            // 
            // addNewDriverToolStripMenuItem
            // 
            this.addNewDriverToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewDriverToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewDriverToolStripMenuItem.Image")));
            this.addNewDriverToolStripMenuItem.Name = "addNewDriverToolStripMenuItem";
            this.addNewDriverToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addNewDriverToolStripMenuItem.Text = "Add New Driver";
            // 
            // viewListToolStripMenuItem1
            // 
            this.viewListToolStripMenuItem1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewListToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("viewListToolStripMenuItem1.Image")));
            this.viewListToolStripMenuItem1.Name = "viewListToolStripMenuItem1";
            this.viewListToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.viewListToolStripMenuItem1.Text = "View List";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_message);
            this.panel1.Controls.Add(this.btn_profile);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.date);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(225, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 60);
            this.panel1.TabIndex = 2;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_logout, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btn_logout, BunifuAnimatorNS.DecorationType.None);
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageActive = null;
            this.btn_logout.Location = new System.Drawing.Point(1098, 15);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(37, 31);
            this.btn_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_logout.TabIndex = 72;
            this.btn_logout.TabStop = false;
            this.btn_logout.Zoom = 10;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_message
            // 
            this.btn_message.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_message, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btn_message, BunifuAnimatorNS.DecorationType.None);
            this.btn_message.Image = ((System.Drawing.Image)(resources.GetObject("btn_message.Image")));
            this.btn_message.ImageActive = null;
            this.btn_message.Location = new System.Drawing.Point(992, 15);
            this.btn_message.Name = "btn_message";
            this.btn_message.Size = new System.Drawing.Size(37, 31);
            this.btn_message.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_message.TabIndex = 71;
            this.btn_message.TabStop = false;
            this.btn_message.Zoom = 10;
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_profile, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btn_profile, BunifuAnimatorNS.DecorationType.None);
            this.btn_profile.Image = ((System.Drawing.Image)(resources.GetObject("btn_profile.Image")));
            this.btn_profile.ImageActive = null;
            this.btn_profile.Location = new System.Drawing.Point(1045, 15);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(37, 31);
            this.btn_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_profile.TabIndex = 70;
            this.btn_profile.TabStop = false;
            this.btn_profile.Zoom = 10;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // contextmenu
            // 
            this.bunifuTransition1.SetDecoration(this.contextmenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.contextmenu, BunifuAnimatorNS.DecorationType.None);
            this.contextmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.contextmenu.Name = "contextmenu_conductor";
            this.contextmenu.Size = new System.Drawing.Size(173, 48);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem5.Text = "My Profile";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem6.Image")));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem6.Text = "Company Profile";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // uc_profile1
            // 
            this.uc_profile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.bunifuTransition2.SetDecoration(this.uc_profile1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.uc_profile1, BunifuAnimatorNS.DecorationType.None);
            this.uc_profile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_profile1.Location = new System.Drawing.Point(225, 60);
            this.uc_profile1.Name = "uc_profile1";
            this.uc_profile1.Size = new System.Drawing.Size(1145, 712);
            this.uc_profile1.TabIndex = 75;
            this.uc_profile1.Visible = false;
            // 
            // uc_company1
            // 
            this.uc_company1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.bunifuTransition2.SetDecoration(this.uc_company1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.uc_company1, BunifuAnimatorNS.DecorationType.None);
            this.uc_company1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_company1.Location = new System.Drawing.Point(225, 60);
            this.uc_company1.Name = "uc_company1";
            this.uc_company1.Size = new System.Drawing.Size(1145, 712);
            this.uc_company1.TabIndex = 74;
            this.uc_company1.Visible = false;
            // 
            // uc_conductor1
            // 
            this.uc_conductor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.bunifuTransition2.SetDecoration(this.uc_conductor1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.uc_conductor1, BunifuAnimatorNS.DecorationType.None);
            this.uc_conductor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_conductor1.Location = new System.Drawing.Point(225, 60);
            this.uc_conductor1.Name = "uc_conductor1";
            this.uc_conductor1.Size = new System.Drawing.Size(1145, 712);
            this.uc_conductor1.TabIndex = 73;
            this.uc_conductor1.Visible = false;
            // 
            // uc_driver1
            // 
            this.uc_driver1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.bunifuTransition2.SetDecoration(this.uc_driver1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.uc_driver1, BunifuAnimatorNS.DecorationType.None);
            this.uc_driver1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_driver1.Location = new System.Drawing.Point(225, 60);
            this.uc_driver1.Name = "uc_driver1";
            this.uc_driver1.Size = new System.Drawing.Size(1145, 712);
            this.uc_driver1.TabIndex = 72;
            this.uc_driver1.Visible = false;
            // 
            // uc_bus1
            // 
            this.uc_bus1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.bunifuTransition2.SetDecoration(this.uc_bus1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.uc_bus1, BunifuAnimatorNS.DecorationType.None);
            this.uc_bus1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_bus1.Location = new System.Drawing.Point(225, 60);
            this.uc_bus1.Name = "uc_bus1";
            this.uc_bus1.Size = new System.Drawing.Size(1145, 712);
            this.uc_bus1.TabIndex = 71;
            this.uc_bus1.Visible = false;
            // 
            // uc_dashboard1
            // 
            this.uc_dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.bunifuTransition2.SetDecoration(this.uc_dashboard1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.uc_dashboard1, BunifuAnimatorNS.DecorationType.None);
            this.uc_dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_dashboard1.Location = new System.Drawing.Point(225, 60);
            this.uc_dashboard1.Name = "uc_dashboard1";
            this.uc_dashboard1.Size = new System.Drawing.Size(1145, 712);
            this.uc_dashboard1.TabIndex = 70;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation2;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.uc_profile1);
            this.Controls.Add(this.uc_company1);
            this.Controls.Add(this.uc_conductor1);
            this.Controls.Add(this.uc_driver1);
            this.Controls.Add(this.uc_bus1);
            this.Controls.Add(this.uc_dashboard1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.side_menu);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).EndInit();
            this.side_menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_pic)).EndInit();
            this.contextmenu_trip.ResumeLayout(false);
            this.contextmenu_bus.ResumeLayout(false);
            this.contextmenu_conductor.ResumeLayout(false);
            this.contextmenu_reports.ResumeLayout(false);
            this.contextmenu_driver.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_message)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_profile)).EndInit();
            this.contextmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel side_menu;
        public Bunifu.Framework.UI.BunifuFlatButton btn_emergency;
        public System.Windows.Forms.PictureBox logo2;
        public System.Windows.Forms.PictureBox logo1;
        public Bunifu.Framework.UI.BunifuFlatButton btn_conductor;
        public Bunifu.Framework.UI.BunifuFlatButton btn_driver;
        public Bunifu.Framework.UI.BunifuFlatButton btn_bus;
        public System.Windows.Forms.Label lbl_user;
        public System.Windows.Forms.Label lbl_type;
        public System.Windows.Forms.ContextMenuStrip contextmenu_trip;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        public System.Windows.Forms.ContextMenuStrip contextmenu_bus;
        public System.Windows.Forms.ToolStripMenuItem addNewBusToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem viewListToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextmenu_conductor;
        public System.Windows.Forms.ToolStripMenuItem addNewConductorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem viewListToolStripMenuItem2;
        public System.Windows.Forms.ContextMenuStrip contextmenu_reports;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        public System.Windows.Forms.ToolStripMenuItem condtuctorReportsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem tripReportsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem userReportsToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextmenu_driver;
        public System.Windows.Forms.ToolStripMenuItem addNewDriverToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem viewListToolStripMenuItem1;
        public Bunifu.Framework.UI.BunifuFlatButton btn_addtrip;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label lbl_idno;
        private OvalPictureBox user_pic;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        public Bunifu.Framework.UI.BunifuFlatButton btn_dashboard;
        public System.Windows.Forms.Label lbl_company;
        private System.Windows.Forms.Timer timer1;
        public BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        public BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Label date;
        public System.Windows.Forms.Label time;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_logout;
        private Bunifu.Framework.UI.BunifuImageButton btn_message;
        private Bunifu.Framework.UI.BunifuImageButton btn_profile;
        private uc_dashboard uc_dashboard1;
        private uc_bus uc_bus1;
        private uc_driver uc_driver1;
        private uc_conductor uc_conductor1;
        private uc_company uc_company1;
        private uc_profile uc_profile1;
        public System.Windows.Forms.ContextMenuStrip contextmenu;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}