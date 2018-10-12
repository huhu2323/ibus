namespace iBUS
{
    partial class frm_uc_profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_uc_profile));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_idno = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_retype = new System.Windows.Forms.TextBox();
            this.rtb_address = new System.Windows.Forms.RichTextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mt_contact = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_browse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.user_pic = new System.Windows.Forms.PictureBox();
            this.tb_lname = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_bday = new System.Windows.Forms.DateTimePicker();
            this.tb_company = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_civilstatus = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_position = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_fname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_a2 = new System.Windows.Forms.TextBox();
            this.cb_sq2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_a1 = new System.Windows.Forms.TextBox();
            this.cb_sq1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_edit = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.user_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 37);
            this.label1.TabIndex = 189;
            this.label1.Text = "My Profile";
            // 
            // tb_idno
            // 
            this.tb_idno.BackColor = System.Drawing.Color.White;
            this.tb_idno.Enabled = false;
            this.tb_idno.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idno.Location = new System.Drawing.Point(841, 144);
            this.tb_idno.Name = "tb_idno";
            this.tb_idno.Size = new System.Drawing.Size(271, 26);
            this.tb_idno.TabIndex = 281;
            this.tb_idno.TextChanged += new System.EventHandler(this.tb_idno_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(838, 126);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 15);
            this.label21.TabIndex = 280;
            this.label21.Text = "Company ID No:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(569, 465);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 15);
            this.label20.TabIndex = 279;
            this.label20.Text = "Re-type Password:";
            this.label20.Visible = false;
            // 
            // tb_retype
            // 
            this.tb_retype.Enabled = false;
            this.tb_retype.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_retype.Location = new System.Drawing.Point(572, 483);
            this.tb_retype.Name = "tb_retype";
            this.tb_retype.PasswordChar = '*';
            this.tb_retype.Size = new System.Drawing.Size(253, 26);
            this.tb_retype.TabIndex = 278;
            this.tb_retype.Visible = false;
            // 
            // rtb_address
            // 
            this.rtb_address.Enabled = false;
            this.rtb_address.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_address.Location = new System.Drawing.Point(267, 318);
            this.rtb_address.Name = "rtb_address";
            this.rtb_address.Size = new System.Drawing.Size(558, 48);
            this.rtb_address.TabIndex = 277;
            this.rtb_address.Text = "";
            // 
            // tb_email
            // 
            this.tb_email.Enabled = false;
            this.tb_email.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(267, 398);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(271, 26);
            this.tb_email.TabIndex = 248;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(264, 300);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 15);
            this.label19.TabIndex = 276;
            this.label19.Text = "Home Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(264, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 244;
            this.label4.Text = "Email Address:";
            // 
            // mt_contact
            // 
            this.mt_contact.Enabled = false;
            this.mt_contact.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_contact.Location = new System.Drawing.Point(554, 398);
            this.mt_contact.Mask = "(999) 000-0000";
            this.mt_contact.Name = "mt_contact";
            this.mt_contact.Size = new System.Drawing.Size(271, 26);
            this.mt_contact.TabIndex = 245;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(551, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 249;
            this.label5.Text = "Contact No.:";
            // 
            // btn_browse
            // 
            this.btn_browse.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btn_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_browse.BorderRadius = 0;
            this.btn_browse.ButtonText = "";
            this.btn_browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_browse.DisabledColor = System.Drawing.Color.Gray;
            this.btn_browse.Enabled = false;
            this.btn_browse.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_browse.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_browse.Iconimage")));
            this.btn_browse.Iconimage_right = null;
            this.btn_browse.Iconimage_right_Selected = null;
            this.btn_browse.Iconimage_Selected = null;
            this.btn_browse.IconMarginLeft = 8;
            this.btn_browse.IconMarginRight = 0;
            this.btn_browse.IconRightVisible = true;
            this.btn_browse.IconRightZoom = 0D;
            this.btn_browse.IconVisible = true;
            this.btn_browse.IconZoom = 40D;
            this.btn_browse.IsTab = false;
            this.btn_browse.Location = new System.Drawing.Point(206, 325);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_browse.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btn_browse.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_browse.selected = false;
            this.btn_browse.Size = new System.Drawing.Size(40, 40);
            this.btn_browse.TabIndex = 264;
            this.btn_browse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_browse.Textcolor = System.Drawing.Color.White;
            this.btn_browse.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cb_gender
            // 
            this.cb_gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_gender.Enabled = false;
            this.cb_gender.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_gender.Location = new System.Drawing.Point(554, 260);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(271, 26);
            this.cb_gender.TabIndex = 269;
            // 
            // user_pic
            // 
            this.user_pic.BackColor = System.Drawing.Color.White;
            this.user_pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.user_pic.Location = new System.Drawing.Point(31, 126);
            this.user_pic.Name = "user_pic";
            this.user_pic.Size = new System.Drawing.Size(214, 240);
            this.user_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_pic.TabIndex = 263;
            this.user_pic.TabStop = false;
            // 
            // tb_lname
            // 
            this.tb_lname.Enabled = false;
            this.tb_lname.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lname.Location = new System.Drawing.Point(554, 202);
            this.tb_lname.Name = "tb_lname";
            this.tb_lname.Size = new System.Drawing.Size(271, 26);
            this.tb_lname.TabIndex = 247;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(838, 242);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 15);
            this.label18.TabIndex = 275;
            this.label18.Text = "Civil Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(551, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 243;
            this.label3.Text = "Last Name:";
            // 
            // dt_bday
            // 
            this.dt_bday.CalendarFont = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_bday.CustomFormat = "yyyy-MM-dd";
            this.dt_bday.Enabled = false;
            this.dt_bday.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_bday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_bday.Location = new System.Drawing.Point(267, 260);
            this.dt_bday.Name = "dt_bday";
            this.dt_bday.Size = new System.Drawing.Size(182, 26);
            this.dt_bday.TabIndex = 268;
            // 
            // tb_company
            // 
            this.tb_company.Enabled = false;
            this.tb_company.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_company.Location = new System.Drawing.Point(267, 144);
            this.tb_company.Name = "tb_company";
            this.tb_company.Size = new System.Drawing.Size(271, 26);
            this.tb_company.TabIndex = 267;
            this.tb_company.Text = "Admin";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(551, 242);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 15);
            this.label17.TabIndex = 274;
            this.label17.Text = "Gender:";
            // 
            // tb_age
            // 
            this.tb_age.BackColor = System.Drawing.Color.White;
            this.tb_age.Enabled = false;
            this.tb_age.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_age.Location = new System.Drawing.Point(467, 260);
            this.tb_age.Name = "tb_age";
            this.tb_age.ReadOnly = true;
            this.tb_age.Size = new System.Drawing.Size(71, 26);
            this.tb_age.TabIndex = 270;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(264, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 242;
            this.label2.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(264, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 250;
            this.label6.Text = "Company Name:";
            // 
            // cb_civilstatus
            // 
            this.cb_civilstatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_civilstatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_civilstatus.Enabled = false;
            this.cb_civilstatus.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_civilstatus.FormattingEnabled = true;
            this.cb_civilstatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widowed"});
            this.cb_civilstatus.Location = new System.Drawing.Point(841, 260);
            this.cb_civilstatus.Name = "cb_civilstatus";
            this.cb_civilstatus.Size = new System.Drawing.Size(271, 26);
            this.cb_civilstatus.TabIndex = 271;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(551, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 15);
            this.label14.TabIndex = 265;
            this.label14.Text = "Position:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(464, 242);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 15);
            this.label16.TabIndex = 273;
            this.label16.Text = "Age:";
            // 
            // cb_position
            // 
            this.cb_position.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_position.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_position.Enabled = false;
            this.cb_position.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_position.FormattingEnabled = true;
            this.cb_position.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cb_position.Location = new System.Drawing.Point(554, 144);
            this.cb_position.Name = "cb_position";
            this.cb_position.Size = new System.Drawing.Size(271, 26);
            this.cb_position.TabIndex = 266;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(264, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 15);
            this.label15.TabIndex = 272;
            this.label15.Text = "Birthday:";
            // 
            // tb_fname
            // 
            this.tb_fname.Enabled = false;
            this.tb_fname.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fname.Location = new System.Drawing.Point(267, 202);
            this.tb_fname.Name = "tb_fname";
            this.tb_fname.Size = new System.Drawing.Size(271, 26);
            this.tb_fname.TabIndex = 246;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(571, 591);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 15);
            this.label12.TabIndex = 262;
            this.label12.Text = "Answer:";
            // 
            // tb_a2
            // 
            this.tb_a2.Enabled = false;
            this.tb_a2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_a2.Location = new System.Drawing.Point(572, 609);
            this.tb_a2.Name = "tb_a2";
            this.tb_a2.PasswordChar = '*';
            this.tb_a2.Size = new System.Drawing.Size(253, 26);
            this.tb_a2.TabIndex = 261;
            // 
            // cb_sq2
            // 
            this.cb_sq2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_sq2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_sq2.Enabled = false;
            this.cb_sq2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sq2.FormattingEnabled = true;
            this.cb_sq2.Items.AddRange(new object[] {
            "What is your mother\'s maiden name?",
            "What street did you grow up on?",
            "What was the make of your first car?",
            "When is your anniversary?",
            "What is your favorite color?",
            "What is your father\'s middle name?",
            "What is the name of your first grade teacher?",
            "What is your favorite social media website?"});
            this.cb_sq2.Location = new System.Drawing.Point(31, 609);
            this.cb_sq2.Name = "cb_sq2";
            this.cb_sq2.Size = new System.Drawing.Size(525, 26);
            this.cb_sq2.TabIndex = 260;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(28, 591);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 15);
            this.label13.TabIndex = 259;
            this.label13.Text = "Security Question #2:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(569, 527);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 258;
            this.label11.Text = "Answer:";
            // 
            // tb_a1
            // 
            this.tb_a1.Enabled = false;
            this.tb_a1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_a1.Location = new System.Drawing.Point(572, 545);
            this.tb_a1.Name = "tb_a1";
            this.tb_a1.PasswordChar = '*';
            this.tb_a1.Size = new System.Drawing.Size(253, 26);
            this.tb_a1.TabIndex = 257;
            // 
            // cb_sq1
            // 
            this.cb_sq1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_sq1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_sq1.Enabled = false;
            this.cb_sq1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sq1.FormattingEnabled = true;
            this.cb_sq1.Items.AddRange(new object[] {
            "What is the first and last name of your first boyfriend or girlfriend?",
            "What was your favorite place to visit as a child?",
            "Who is your favorite actor, musician, or artist?",
            "What is the name of your favorite pet?",
            "In what city were you born?",
            "What high school did you attend?",
            "What is the name of your first school?",
            "What is your favorite movie?"});
            this.cb_sq1.Location = new System.Drawing.Point(31, 545);
            this.cb_sq1.Name = "cb_sq1";
            this.cb_sq1.Size = new System.Drawing.Size(525, 26);
            this.cb_sq1.TabIndex = 256;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(28, 527);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 15);
            this.label10.TabIndex = 255;
            this.label10.Text = "Security Question #1:";
            // 
            // tb_password
            // 
            this.tb_password.Enabled = false;
            this.tb_password.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(303, 483);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(253, 26);
            this.tb_password.TabIndex = 254;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(300, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 253;
            this.label9.Text = "Password:";
            // 
            // tb_username
            // 
            this.tb_username.Enabled = false;
            this.tb_username.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(31, 483);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(253, 26);
            this.tb_username.TabIndex = 252;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(28, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 251;
            this.label8.Text = "Username:";
            // 
            // btn_edit
            // 
            this.btn_edit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.BorderRadius = 5;
            this.btn_edit.ButtonText = "Edit";
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_edit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_edit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_edit.Iconimage")));
            this.btn_edit.Iconimage_right = null;
            this.btn_edit.Iconimage_right_Selected = null;
            this.btn_edit.Iconimage_Selected = null;
            this.btn_edit.IconMarginLeft = 8;
            this.btn_edit.IconMarginRight = 0;
            this.btn_edit.IconRightVisible = true;
            this.btn_edit.IconRightZoom = 0D;
            this.btn_edit.IconVisible = true;
            this.btn_edit.IconZoom = 45D;
            this.btn_edit.IsTab = false;
            this.btn_edit.Location = new System.Drawing.Point(31, 394);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btn_edit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btn_edit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_edit.selected = false;
            this.btn_edit.Size = new System.Drawing.Size(215, 30);
            this.btn_edit.TabIndex = 283;
            this.btn_edit.Text = "Edit";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit.Textcolor = System.Drawing.Color.White;
            this.btn_edit.TextFont = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // frm_uc_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.tb_idno);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tb_retype);
            this.Controls.Add(this.rtb_address);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mt_contact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.user_pic);
            this.Controls.Add(this.tb_lname);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_bday);
            this.Controls.Add(this.tb_company);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_civilstatus);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cb_position);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_fname);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_a2);
            this.Controls.Add(this.cb_sq2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_a1);
            this.Controls.Add(this.cb_sq1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "frm_uc_profile";
            this.Size = new System.Drawing.Size(1145, 712);
            ((System.ComponentModel.ISupportInitialize)(this.user_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_idno;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox tb_retype;
        private System.Windows.Forms.RichTextBox rtb_address;
        public System.Windows.Forms.TextBox tb_email;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.MaskedTextBox mt_contact;
        public System.Windows.Forms.Label label5;
        public Bunifu.Framework.UI.BunifuFlatButton btn_browse;
        public System.Windows.Forms.ComboBox cb_gender;
        public System.Windows.Forms.PictureBox user_pic;
        public System.Windows.Forms.TextBox tb_lname;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_bday;
        public System.Windows.Forms.TextBox tb_company;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox tb_age;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cb_civilstatus;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.ComboBox cb_position;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox tb_fname;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox tb_a2;
        public System.Windows.Forms.ComboBox cb_sq2;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox tb_a1;
        public System.Windows.Forms.ComboBox cb_sq1;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tb_password;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tb_username;
        public System.Windows.Forms.Label label8;
        public Bunifu.Framework.UI.BunifuFlatButton btn_edit;
    }
}
