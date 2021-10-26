namespace StudentBooking
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCollage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.paneName = new System.Windows.Forms.Panel();
            this.txtPhone = new advanceEnterface.EhabTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtAvrage = new advanceEnterface.EhabTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGraduate = new advanceEnterface.EhabTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ehabTextBox6 = new advanceEnterface.EhabTextBox();
            this.txtAddrees = new advanceEnterface.EhabTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimeOfPirth = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPlaceOFPirth = new advanceEnterface.EhabTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNational = new advanceEnterface.EhabTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.txtCardID = new advanceEnterface.EhabTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new advanceEnterface.EhabTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ehabBUttons2 = new advanceEnterface.EhabBUttons();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dateTimeBooking = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtID = new advanceEnterface.EhabTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnOpenFile = new advanceEnterface.EhabBUttons();
            this.photo = new advanceEnterface.EhabPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ehabBUttons10 = new advanceEnterface.EhabBUttons();
            this.btnFirst = new advanceEnterface.EhabBUttons();
            this.ehabBUttons9 = new advanceEnterface.EhabBUttons();
            this.ehabBUttons8 = new advanceEnterface.EhabBUttons();
            this.btnDelete = new advanceEnterface.EhabBUttons();
            this.ehabBUttons7 = new advanceEnterface.EhabBUttons();
            this.btnSave = new advanceEnterface.EhabBUttons();
            this.btnAdd = new advanceEnterface.EhabBUttons();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.paneName.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 60);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(324, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "طلب تسجيل الطالب";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbCollage);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbDepartment);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 73);
            this.panel2.TabIndex = 1;
            // 
            // cmbCollage
            // 
            this.cmbCollage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCollage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(179)))), ((int)(((byte)(177)))));
            this.cmbCollage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCollage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCollage.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbCollage.FormattingEnabled = true;
            this.cmbCollage.Location = new System.Drawing.Point(407, 19);
            this.cmbCollage.Name = "cmbCollage";
            this.cmbCollage.Size = new System.Drawing.Size(140, 22);
            this.cmbCollage.TabIndex = 8;
            this.cmbCollage.SelectedIndexChanged += new System.EventHandler(this.cmbCollage_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(569, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "الكلية";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(179)))), ((int)(((byte)(177)))));
            this.cmbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(177, 16);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(140, 22);
            this.cmbDepartment.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(339, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "القسم";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.paneName);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.panel4);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 133);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(840, 616);
            this.panelMain.TabIndex = 2;
            // 
            // paneName
            // 
            this.paneName.Controls.Add(this.txtPhone);
            this.paneName.Controls.Add(this.label15);
            this.paneName.Controls.Add(this.panel7);
            this.paneName.Controls.Add(this.label10);
            this.paneName.Controls.Add(this.ehabTextBox6);
            this.paneName.Controls.Add(this.txtAddrees);
            this.paneName.Controls.Add(this.label9);
            this.paneName.Controls.Add(this.dateTimeOfPirth);
            this.paneName.Controls.Add(this.label8);
            this.paneName.Controls.Add(this.txtPlaceOFPirth);
            this.paneName.Controls.Add(this.label7);
            this.paneName.Controls.Add(this.txtNational);
            this.paneName.Controls.Add(this.label6);
            this.paneName.Controls.Add(this.groupBox1);
            this.paneName.Controls.Add(this.txtCardID);
            this.paneName.Controls.Add(this.label5);
            this.paneName.Controls.Add(this.txtName);
            this.paneName.Controls.Add(this.label4);
            this.paneName.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneName.Location = new System.Drawing.Point(390, 0);
            this.paneName.Name = "paneName";
            this.paneName.Size = new System.Drawing.Size(450, 491);
            this.paneName.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.txtPhone.BoarderColor = System.Drawing.Color.SkyBlue;
            this.txtPhone.BoarderSize = 3;
            this.txtPhone.BorderFoucs = System.Drawing.Color.Magenta;
            this.txtPhone.BorderRaduis = 0;
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txtPhone.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPhone.Location = new System.Drawing.Point(118, 84);
            this.txtPhone.multiLine = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtPhone.passwordChar = false;
            this.txtPhone.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtPhone.PlaceHolderText = "";
            this.txtPhone.Size = new System.Drawing.Size(179, 31);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.Texts = "";
            this.txtPhone.UnderLineStyle = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(313, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 14);
            this.label15.TabIndex = 16;
            this.label15.Text = "رقم التلفون";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtAvrage);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.txtGraduate);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 368);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(450, 123);
            this.panel7.TabIndex = 15;
            // 
            // txtAvrage
            // 
            this.txtAvrage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.txtAvrage.BoarderColor = System.Drawing.Color.Gold;
            this.txtAvrage.BoarderSize = 2;
            this.txtAvrage.BorderFoucs = System.Drawing.Color.SkyBlue;
            this.txtAvrage.BorderRaduis = 0;
            this.txtAvrage.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txtAvrage.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtAvrage.Location = new System.Drawing.Point(169, 54);
            this.txtAvrage.multiLine = false;
            this.txtAvrage.Name = "txtAvrage";
            this.txtAvrage.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtAvrage.passwordChar = false;
            this.txtAvrage.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtAvrage.PlaceHolderText = "";
            this.txtAvrage.Size = new System.Drawing.Size(117, 31);
            this.txtAvrage.TabIndex = 16;
            this.txtAvrage.Texts = "";
            this.txtAvrage.UnderLineStyle = false;
            this.txtAvrage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ehabTextBox8_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 14);
            this.label12.TabIndex = 15;
            this.label12.Text = "النسبة";
            // 
            // txtGraduate
            // 
            this.txtGraduate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.txtGraduate.BoarderColor = System.Drawing.Color.Gold;
            this.txtGraduate.BoarderSize = 2;
            this.txtGraduate.BorderFoucs = System.Drawing.Color.SkyBlue;
            this.txtGraduate.BorderRaduis = 0;
            this.txtGraduate.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txtGraduate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtGraduate.Location = new System.Drawing.Point(169, 17);
            this.txtGraduate.multiLine = false;
            this.txtGraduate.Name = "txtGraduate";
            this.txtGraduate.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtGraduate.passwordChar = false;
            this.txtGraduate.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtGraduate.PlaceHolderText = "";
            this.txtGraduate.Size = new System.Drawing.Size(117, 31);
            this.txtGraduate.TabIndex = 14;
            this.txtGraduate.Texts = "";
            this.txtGraduate.UnderLineStyle = false;
            this.txtGraduate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ehabTextBox7_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(302, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 14);
            this.label11.TabIndex = 13;
            this.label11.Text = "سنة التخرج من الثانوية";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 14);
            this.label10.TabIndex = 14;
            this.label10.Text = "رقم الهاتف";
            // 
            // ehabTextBox6
            // 
            this.ehabTextBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ehabTextBox6.BoarderColor = System.Drawing.Color.Gold;
            this.ehabTextBox6.BoarderSize = 2;
            this.ehabTextBox6.BorderFoucs = System.Drawing.Color.SkyBlue;
            this.ehabTextBox6.BorderRaduis = 0;
            this.ehabTextBox6.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ehabTextBox6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ehabTextBox6.Location = new System.Drawing.Point(128, 374);
            this.ehabTextBox6.multiLine = false;
            this.ehabTextBox6.Name = "ehabTextBox6";
            this.ehabTextBox6.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.ehabTextBox6.passwordChar = false;
            this.ehabTextBox6.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.ehabTextBox6.PlaceHolderText = "";
            this.ehabTextBox6.Size = new System.Drawing.Size(198, 31);
            this.ehabTextBox6.TabIndex = 13;
            this.ehabTextBox6.Texts = "";
            this.ehabTextBox6.UnderLineStyle = false;
            // 
            // txtAddrees
            // 
            this.txtAddrees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.txtAddrees.BoarderColor = System.Drawing.Color.Gold;
            this.txtAddrees.BoarderSize = 2;
            this.txtAddrees.BorderFoucs = System.Drawing.Color.SkyBlue;
            this.txtAddrees.BorderRaduis = 0;
            this.txtAddrees.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txtAddrees.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtAddrees.Location = new System.Drawing.Point(127, 327);
            this.txtAddrees.multiLine = false;
            this.txtAddrees.Name = "txtAddrees";
            this.txtAddrees.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtAddrees.passwordChar = false;
            this.txtAddrees.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtAddrees.PlaceHolderText = "";
            this.txtAddrees.Size = new System.Drawing.Size(198, 31);
            this.txtAddrees.TabIndex = 12;
            this.txtAddrees.Texts = "";
            this.txtAddrees.UnderLineStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "العنوان";
            // 
            // dateTimeOfPirth
            // 
            this.dateTimeOfPirth.Location = new System.Drawing.Point(76, 283);
            this.dateTimeOfPirth.Name = "dateTimeOfPirth";
            this.dateTimeOfPirth.Size = new System.Drawing.Size(232, 22);
            this.dateTimeOfPirth.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "تاريخ الميلاد";
            // 
            // txtPlaceOFPirth
            // 
            this.txtPlaceOFPirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.txtPlaceOFPirth.BoarderColor = System.Drawing.Color.Gold;
            this.txtPlaceOFPirth.BoarderSize = 3;
            this.txtPlaceOFPirth.BorderFoucs = System.Drawing.Color.SkyBlue;
            this.txtPlaceOFPirth.BorderRaduis = 0;
            this.txtPlaceOFPirth.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txtPlaceOFPirth.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPlaceOFPirth.Location = new System.Drawing.Point(156, 232);
            this.txtPlaceOFPirth.multiLine = false;
            this.txtPlaceOFPirth.Name = "txtPlaceOFPirth";
            this.txtPlaceOFPirth.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtPlaceOFPirth.passwordChar = false;
            this.txtPlaceOFPirth.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtPlaceOFPirth.PlaceHolderText = "";
            this.txtPlaceOFPirth.Size = new System.Drawing.Size(152, 31);
            this.txtPlaceOFPirth.TabIndex = 8;
            this.txtPlaceOFPirth.Texts = "";
            this.txtPlaceOFPirth.UnderLineStyle = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "مكان الميلاد";
            // 
            // txtNational
            // 
            this.txtNational.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.txtNational.BoarderColor = System.Drawing.Color.Gold;
            this.txtNational.BoarderSize = 3;
            this.txtNational.BorderFoucs = System.Drawing.Color.SkyBlue;
            this.txtNational.BorderRaduis = 0;
            this.txtNational.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txtNational.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNational.Location = new System.Drawing.Point(156, 195);
            this.txtNational.multiLine = false;
            this.txtNational.Name = "txtNational";
            this.txtNational.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtNational.passwordChar = false;
            this.txtNational.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtNational.PlaceHolderText = "";
            this.txtNational.Size = new System.Drawing.Size(152, 31);
            this.txtNational.TabIndex = 6;
            this.txtNational.Texts = "";
            this.txtNational.UnderLineStyle = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "الجنسية";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.male);
            this.groupBox1.Controls.Add(this.female);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(169, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الجنس";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(108, 31);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(42, 18);
            this.male.TabIndex = 0;
            this.male.TabStop = true;
            this.male.Text = "ذكر";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(25, 31);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(47, 18);
            this.female.TabIndex = 0;
            this.female.TabStop = true;
            this.female.Text = "انثى";
            this.female.UseVisualStyleBackColor = true;
            // 
            // txtCardID
            // 
            this.txtCardID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.txtCardID.BoarderColor = System.Drawing.Color.SkyBlue;
            this.txtCardID.BoarderSize = 3;
            this.txtCardID.BorderFoucs = System.Drawing.Color.Magenta;
            this.txtCardID.BorderRaduis = 0;
            this.txtCardID.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txtCardID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtCardID.Location = new System.Drawing.Point(200, 45);
            this.txtCardID.multiLine = false;
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtCardID.passwordChar = false;
            this.txtCardID.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtCardID.PlaceHolderText = "";
            this.txtCardID.Size = new System.Drawing.Size(90, 31);
            this.txtCardID.TabIndex = 3;
            this.txtCardID.Texts = "";
            this.txtCardID.UnderLineStyle = true;
            this.txtCardID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ehabTextBox2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "رقم الجلوس";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.txtName.BoarderColor = System.Drawing.Color.SkyBlue;
            this.txtName.BoarderSize = 3;
            this.txtName.BorderFoucs = System.Drawing.Color.Magenta;
            this.txtName.BorderRaduis = 0;
            this.txtName.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txtName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtName.Location = new System.Drawing.Point(47, 7);
            this.txtName.multiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtName.passwordChar = false;
            this.txtName.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceHolderText = "";
            this.txtName.Size = new System.Drawing.Size(250, 31);
            this.txtName.TabIndex = 1;
            this.txtName.Texts = "";
            this.txtName.UnderLineStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "اسم الطالب";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ehabBUttons2);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 491);
            this.panel3.TabIndex = 3;
            // 
            // ehabBUttons2
            // 
            this.ehabBUttons2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ehabBUttons2.bordercolor = System.Drawing.Color.Gold;
            this.ehabBUttons2.borderradius = 10;
            this.ehabBUttons2.bordersize = 2;
            this.ehabBUttons2.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.ehabBUttons2.FlatAppearance.BorderSize = 0;
            this.ehabBUttons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ehabBUttons2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ehabBUttons2.ForeColor = System.Drawing.Color.White;
            this.ehabBUttons2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ehabBUttons2.IconColor = System.Drawing.Color.Black;
            this.ehabBUttons2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ehabBUttons2.Location = new System.Drawing.Point(88, 444);
            this.ehabBUttons2.Name = "ehabBUttons2";
            this.ehabBUttons2.Size = new System.Drawing.Size(90, 41);
            this.ehabBUttons2.TabIndex = 4;
            this.ehabBUttons2.Text = "قبول";
            this.ehabBUttons2.TextColor = System.Drawing.Color.White;
            this.ehabBUttons2.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dateTimeBooking);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.txtID);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 328);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(388, 99);
            this.panel6.TabIndex = 1;
            // 
            // dateTimeBooking
            // 
            this.dateTimeBooking.Location = new System.Drawing.Point(88, 78);
            this.dateTimeBooking.Name = "dateTimeBooking";
            this.dateTimeBooking.Size = new System.Drawing.Size(176, 22);
            this.dateTimeBooking.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(275, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 14);
            this.label14.TabIndex = 11;
            this.label14.Text = "تاريخ التسجيل";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.txtID.BoarderColor = System.Drawing.Color.SkyBlue;
            this.txtID.BoarderSize = 3;
            this.txtID.BorderFoucs = System.Drawing.Color.Magenta;
            this.txtID.BorderRaduis = 15;
            this.txtID.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txtID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtID.Location = new System.Drawing.Point(111, 20);
            this.txtID.multiLine = false;
            this.txtID.Name = "txtID";
            this.txtID.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.txtID.passwordChar = false;
            this.txtID.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtID.PlaceHolderText = "";
            this.txtID.Size = new System.Drawing.Size(144, 31);
            this.txtID.TabIndex = 5;
            this.txtID.Texts = "";
            this.txtID.UnderLineStyle = false;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ehabTextBox9_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(275, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 14);
            this.label13.TabIndex = 4;
            this.label13.Text = "رقم القيد";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnOpenFile);
            this.panel5.Controls.Add(this.photo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(388, 328);
            this.panel5.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.btnOpenFile.bordercolor = System.Drawing.Color.Gold;
            this.btnOpenFile.borderradius = 10;
            this.btnOpenFile.bordersize = 2;
            this.btnOpenFile.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnOpenFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOpenFile.IconColor = System.Drawing.Color.Black;
            this.btnOpenFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenFile.Location = new System.Drawing.Point(129, 255);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(114, 51);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.Text = "استعراض";
            this.btnOpenFile.TextColor = System.Drawing.Color.White;
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // photo
            // 
            this.photo.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.photo.BorderColor = System.Drawing.Color.RoyalBlue;
            this.photo.BorderColor2 = System.Drawing.Color.HotPink;
            this.photo.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.photo.BorderSize = 2;
            this.photo.GradintAngle = 50F;
            this.photo.Location = new System.Drawing.Point(88, 13);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(213, 213);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photo.TabIndex = 2;
            this.photo.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ehabBUttons10);
            this.panel4.Controls.Add(this.btnFirst);
            this.panel4.Controls.Add(this.ehabBUttons9);
            this.panel4.Controls.Add(this.ehabBUttons8);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.ehabBUttons7);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 491);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(840, 125);
            this.panel4.TabIndex = 2;
            // 
            // ehabBUttons10
            // 
            this.ehabBUttons10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ehabBUttons10.bordercolor = System.Drawing.Color.Gold;
            this.ehabBUttons10.borderradius = 10;
            this.ehabBUttons10.bordersize = 2;
            this.ehabBUttons10.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.ehabBUttons10.FlatAppearance.BorderSize = 0;
            this.ehabBUttons10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ehabBUttons10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ehabBUttons10.ForeColor = System.Drawing.Color.White;
            this.ehabBUttons10.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ehabBUttons10.IconColor = System.Drawing.Color.Black;
            this.ehabBUttons10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ehabBUttons10.Location = new System.Drawing.Point(9, 28);
            this.ehabBUttons10.Name = "ehabBUttons10";
            this.ehabBUttons10.Size = new System.Drawing.Size(87, 37);
            this.ehabBUttons10.TabIndex = 4;
            this.ehabBUttons10.Text = "خروج";
            this.ehabBUttons10.TextColor = System.Drawing.Color.White;
            this.ehabBUttons10.UseVisualStyleBackColor = false;
            this.ehabBUttons10.Click += new System.EventHandler(this.ehabBUttons10_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.btnFirst.bordercolor = System.Drawing.Color.Gold;
            this.btnFirst.borderradius = 10;
            this.btnFirst.bordersize = 2;
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFirst.IconColor = System.Drawing.Color.Black;
            this.btnFirst.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFirst.Location = new System.Drawing.Point(425, 26);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(87, 37);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "الاول";
            this.btnFirst.TextColor = System.Drawing.Color.White;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // ehabBUttons9
            // 
            this.ehabBUttons9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ehabBUttons9.bordercolor = System.Drawing.Color.Gold;
            this.ehabBUttons9.borderradius = 10;
            this.ehabBUttons9.bordersize = 2;
            this.ehabBUttons9.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.ehabBUttons9.FlatAppearance.BorderSize = 0;
            this.ehabBUttons9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ehabBUttons9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ehabBUttons9.ForeColor = System.Drawing.Color.White;
            this.ehabBUttons9.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ehabBUttons9.IconColor = System.Drawing.Color.Black;
            this.ehabBUttons9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ehabBUttons9.Location = new System.Drawing.Point(113, 28);
            this.ehabBUttons9.Name = "ehabBUttons9";
            this.ehabBUttons9.Size = new System.Drawing.Size(87, 37);
            this.ehabBUttons9.TabIndex = 4;
            this.ehabBUttons9.Text = "الاخير";
            this.ehabBUttons9.TextColor = System.Drawing.Color.White;
            this.ehabBUttons9.UseVisualStyleBackColor = false;
            this.ehabBUttons9.Click += new System.EventHandler(this.ehabBUttons9_Click);
            // 
            // ehabBUttons8
            // 
            this.ehabBUttons8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ehabBUttons8.bordercolor = System.Drawing.Color.Gold;
            this.ehabBUttons8.borderradius = 10;
            this.ehabBUttons8.bordersize = 2;
            this.ehabBUttons8.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.ehabBUttons8.FlatAppearance.BorderSize = 0;
            this.ehabBUttons8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ehabBUttons8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ehabBUttons8.ForeColor = System.Drawing.Color.White;
            this.ehabBUttons8.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ehabBUttons8.IconColor = System.Drawing.Color.Black;
            this.ehabBUttons8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ehabBUttons8.Location = new System.Drawing.Point(217, 28);
            this.ehabBUttons8.Name = "ehabBUttons8";
            this.ehabBUttons8.Size = new System.Drawing.Size(87, 37);
            this.ehabBUttons8.TabIndex = 4;
            this.ehabBUttons8.Text = "السابق";
            this.ehabBUttons8.TextColor = System.Drawing.Color.White;
            this.ehabBUttons8.UseVisualStyleBackColor = false;
            this.ehabBUttons8.Click += new System.EventHandler(this.ehabBUttons8_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.btnDelete.bordercolor = System.Drawing.Color.Gold;
            this.btnDelete.borderradius = 10;
            this.btnDelete.bordersize = 2;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(529, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 37);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ehabBUttons7
            // 
            this.ehabBUttons7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ehabBUttons7.bordercolor = System.Drawing.Color.Gold;
            this.ehabBUttons7.borderradius = 10;
            this.ehabBUttons7.bordersize = 2;
            this.ehabBUttons7.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.ehabBUttons7.FlatAppearance.BorderSize = 0;
            this.ehabBUttons7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ehabBUttons7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ehabBUttons7.ForeColor = System.Drawing.Color.White;
            this.ehabBUttons7.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ehabBUttons7.IconColor = System.Drawing.Color.Black;
            this.ehabBUttons7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ehabBUttons7.Location = new System.Drawing.Point(321, 27);
            this.ehabBUttons7.Name = "ehabBUttons7";
            this.ehabBUttons7.Size = new System.Drawing.Size(87, 37);
            this.ehabBUttons7.TabIndex = 4;
            this.ehabBUttons7.Text = "التالي";
            this.ehabBUttons7.TextColor = System.Drawing.Color.White;
            this.ehabBUttons7.UseVisualStyleBackColor = false;
            this.ehabBUttons7.Click += new System.EventHandler(this.ehabBUttons7_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.btnSave.bordercolor = System.Drawing.Color.Gold;
            this.btnSave.borderradius = 10;
            this.btnSave.bordersize = 2;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.Location = new System.Drawing.Point(633, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 37);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.btnAdd.bordercolor = System.Drawing.Color.Gold;
            this.btnAdd.borderradius = 10;
            this.btnAdd.bordersize = 2;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.Location = new System.Drawing.Point(737, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 37);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(840, 749);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.paneName.ResumeLayout(false);
            this.paneName.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCollage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dateTimeBooking;
        private System.Windows.Forms.Label label14;
        private advanceEnterface.EhabTextBox txtID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private advanceEnterface.EhabBUttons btnOpenFile;
        private advanceEnterface.EhabPictureBox photo;
        private System.Windows.Forms.Panel paneName;
        private System.Windows.Forms.Panel panel7;
        private advanceEnterface.EhabTextBox txtAvrage;
        private System.Windows.Forms.Label label12;
        private advanceEnterface.EhabTextBox txtGraduate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private advanceEnterface.EhabTextBox ehabTextBox6;
        private advanceEnterface.EhabTextBox txtAddrees;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimeOfPirth;
        private System.Windows.Forms.Label label8;
        private advanceEnterface.EhabTextBox txtPlaceOFPirth;
        private System.Windows.Forms.Label label7;
        private advanceEnterface.EhabTextBox txtNational;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private advanceEnterface.EhabTextBox txtCardID;
        private System.Windows.Forms.Label label5;
        private advanceEnterface.EhabTextBox txtName;
        private System.Windows.Forms.Label label4;
        private advanceEnterface.EhabBUttons ehabBUttons2;
        private advanceEnterface.EhabBUttons ehabBUttons10;
        private advanceEnterface.EhabBUttons btnFirst;
        private advanceEnterface.EhabBUttons ehabBUttons9;
        private advanceEnterface.EhabBUttons ehabBUttons8;
        private advanceEnterface.EhabBUttons btnDelete;
        private advanceEnterface.EhabBUttons ehabBUttons7;
        private advanceEnterface.EhabBUttons btnSave;
        private advanceEnterface.EhabBUttons btnAdd;
        private advanceEnterface.EhabTextBox txtPhone;
        private System.Windows.Forms.Label label15;
    }
}

