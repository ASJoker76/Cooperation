namespace Cooperation
{
    partial class registration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration));
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.btnchoise = new System.Windows.Forms.Button();
            this.pbfoto = new System.Windows.Forms.PictureBox();
            this.lberrorls = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lberroraddress = new System.Windows.Forms.Label();
            this.lberrorbirt = new System.Windows.Forms.Label();
            this.lbage = new System.Windows.Forms.Label();
            this.lberrorlast = new System.Windows.Forms.Label();
            this.lberrorname = new System.Windows.Forms.Label();
            this.grgender = new System.Windows.Forms.GroupBox();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.txtbirtofday = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlasteducation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.txtdotcom = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdimage = new System.Windows.Forms.OpenFileDialog();
            this.btnenter = new System.Windows.Forms.Button();
            this.datacategory = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lasteducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birtofday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnclose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).BeginInit();
            this.grgender.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datacategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(326, 37);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(150, 30);
            this.txtname.TabIndex = 1;
            this.txtname.Validating += new System.ComponentModel.CancelEventHandler(this.txtname_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.vScrollBar1);
            this.groupBox1.Controls.Add(this.txtpath);
            this.groupBox1.Controls.Add(this.btnchoise);
            this.groupBox1.Controls.Add(this.pbfoto);
            this.groupBox1.Controls.Add(this.lberrorls);
            this.groupBox1.Controls.Add(this.txtlastname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lberroraddress);
            this.groupBox1.Controls.Add(this.lberrorbirt);
            this.groupBox1.Controls.Add(this.lbage);
            this.groupBox1.Controls.Add(this.lberrorlast);
            this.groupBox1.Controls.Add(this.lberrorname);
            this.groupBox1.Controls.Add(this.grgender);
            this.groupBox1.Controls.Add(this.txtbirtofday);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtlasteducation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(27, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 390);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Profile";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(463, 155);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(16, 26);
            this.vScrollBar1.TabIndex = 50;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // txtpath
            // 
            this.txtpath.Enabled = false;
            this.txtpath.Location = new System.Drawing.Point(26, 260);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(154, 34);
            this.txtpath.TabIndex = 9;
            // 
            // btnchoise
            // 
            this.btnchoise.BackgroundImage = global::Cooperation.Properties.Resources.images__12_;
            this.btnchoise.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchoise.ForeColor = System.Drawing.Color.White;
            this.btnchoise.Location = new System.Drawing.Point(37, 212);
            this.btnchoise.Name = "btnchoise";
            this.btnchoise.Size = new System.Drawing.Size(130, 46);
            this.btnchoise.TabIndex = 9;
            this.btnchoise.Text = "Choise Image";
            this.btnchoise.UseVisualStyleBackColor = true;
            this.btnchoise.Click += new System.EventHandler(this.btnchoise_Click);
            // 
            // pbfoto
            // 
            this.pbfoto.Location = new System.Drawing.Point(27, 29);
            this.pbfoto.Name = "pbfoto";
            this.pbfoto.Size = new System.Drawing.Size(153, 176);
            this.pbfoto.TabIndex = 18;
            this.pbfoto.TabStop = false;
            // 
            // lberrorls
            // 
            this.lberrorls.AutoSize = true;
            this.lberrorls.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberrorls.Location = new System.Drawing.Point(521, 75);
            this.lberrorls.Name = "lberrorls";
            this.lberrorls.Size = new System.Drawing.Size(108, 23);
            this.lberrorls.TabIndex = 12;
            this.lberrorls.Text = "Don\'t Empty";
            this.lberrorls.Visible = false;
            // 
            // txtlastname
            // 
            this.txtlastname.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(325, 75);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(150, 30);
            this.txtlastname.TabIndex = 9;
            this.txtlastname.Validating += new System.ComponentModel.CancelEventHandler(this.txtlastname_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Last Name";
            // 
            // lberroraddress
            // 
            this.lberroraddress.AutoSize = true;
            this.lberroraddress.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberroraddress.Location = new System.Drawing.Point(521, 354);
            this.lberroraddress.Name = "lberroraddress";
            this.lberroraddress.Size = new System.Drawing.Size(108, 23);
            this.lberroraddress.TabIndex = 16;
            this.lberroraddress.Text = "Don\'t Empty";
            this.lberroraddress.Visible = false;
            // 
            // lberrorbirt
            // 
            this.lberrorbirt.AutoSize = true;
            this.lberrorbirt.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberrorbirt.Location = new System.Drawing.Point(520, 302);
            this.lberrorbirt.Name = "lberrorbirt";
            this.lberrorbirt.Size = new System.Drawing.Size(108, 23);
            this.lberrorbirt.TabIndex = 15;
            this.lberrorbirt.Text = "Don\'t Empty";
            this.lberrorbirt.Visible = false;
            // 
            // lbage
            // 
            this.lbage.AutoSize = true;
            this.lbage.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbage.Location = new System.Drawing.Point(521, 152);
            this.lbage.Name = "lbage";
            this.lbage.Size = new System.Drawing.Size(108, 23);
            this.lbage.TabIndex = 13;
            this.lbage.Text = "Don\'t Empty";
            this.lbage.Visible = false;
            // 
            // lberrorlast
            // 
            this.lberrorlast.AutoSize = true;
            this.lberrorlast.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberrorlast.Location = new System.Drawing.Point(521, 113);
            this.lberrorlast.Name = "lberrorlast";
            this.lberrorlast.Size = new System.Drawing.Size(108, 23);
            this.lberrorlast.TabIndex = 12;
            this.lberrorlast.Text = "Don\'t Empty";
            this.lberrorlast.Visible = false;
            // 
            // lberrorname
            // 
            this.lberrorname.AutoSize = true;
            this.lberrorname.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberrorname.Location = new System.Drawing.Point(521, 37);
            this.lberrorname.Name = "lberrorname";
            this.lberrorname.Size = new System.Drawing.Size(108, 23);
            this.lberrorname.TabIndex = 11;
            this.lberrorname.Text = "Don\'t Empty";
            this.lberrorname.Visible = false;
            // 
            // grgender
            // 
            this.grgender.BackColor = System.Drawing.Color.Transparent;
            this.grgender.Controls.Add(this.rbfemale);
            this.grgender.Controls.Add(this.rbmale);
            this.grgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grgender.ForeColor = System.Drawing.Color.Black;
            this.grgender.Location = new System.Drawing.Point(206, 184);
            this.grgender.Name = "grgender";
            this.grgender.Size = new System.Drawing.Size(378, 92);
            this.grgender.TabIndex = 9;
            this.grgender.TabStop = false;
            this.grgender.Text = "Gender";
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfemale.Location = new System.Drawing.Point(178, 33);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(95, 31);
            this.rbfemale.TabIndex = 14;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmale.Location = new System.Drawing.Point(41, 33);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(74, 31);
            this.rbmale.TabIndex = 13;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // txtbirtofday
            // 
            this.txtbirtofday.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbirtofday.Location = new System.Drawing.Point(191, 298);
            this.txtbirtofday.Name = "txtbirtofday";
            this.txtbirtofday.Size = new System.Drawing.Size(292, 30);
            this.txtbirtofday.TabIndex = 10;
            this.txtbirtofday.Value = new System.DateTime(1997, 1, 1, 0, 0, 0, 0);
            this.txtbirtofday.Validating += new System.ComponentModel.CancelEventHandler(this.txtdatetime_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Birt of day";
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(158, 339);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(365, 49);
            this.txtaddress.TabIndex = 8;
            this.txtaddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtaddress_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address";
            // 
            // txtage
            // 
            this.txtage.Enabled = false;
            this.txtage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(326, 152);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(150, 30);
            this.txtage.TabIndex = 6;
            this.txtage.Text = "18";
            this.txtage.TextChanged += new System.EventHandler(this.txtage_TextChanged);
            this.txtage.Validating += new System.ComponentModel.CancelEventHandler(this.txtage_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age";
            // 
            // txtlasteducation
            // 
            this.txtlasteducation.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlasteducation.FormattingEnabled = true;
            this.txtlasteducation.Items.AddRange(new object[] {
            "Junior High Scool",
            "Senior High Scool",
            "Diploma 3",
            "Sarjana 1"});
            this.txtlasteducation.Location = new System.Drawing.Point(325, 113);
            this.txtlasteducation.Name = "txtlasteducation";
            this.txtlasteducation.Size = new System.Drawing.Size(150, 31);
            this.txtlasteducation.TabIndex = 4;
            this.txtlasteducation.Validating += new System.ComponentModel.CancelEventHandler(this.txtlasteducation_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Education";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtpw);
            this.groupBox2.Controls.Add(this.txtdotcom);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtusername);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(662, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 187);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Profile";
            // 
            // txtpw
            // 
            this.txtpw.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpw.Location = new System.Drawing.Point(123, 63);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(223, 30);
            this.txtpw.TabIndex = 9;
            // 
            // txtdotcom
            // 
            this.txtdotcom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdotcom.FormattingEnabled = true;
            this.txtdotcom.Items.AddRange(new object[] {
            "gmail.com",
            "yahoo.com",
            "yahoo.co.id"});
            this.txtdotcom.Location = new System.Drawing.Point(238, 139);
            this.txtdotcom.Name = "txtdotcom";
            this.txtdotcom.Size = new System.Drawing.Size(108, 31);
            this.txtdotcom.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "@";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(21, 141);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(179, 30);
            this.txtemail.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 27);
            this.label10.TabIndex = 3;
            this.label10.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 27);
            this.label11.TabIndex = 0;
            this.label11.Text = "User Name";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(123, 31);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(223, 30);
            this.txtusername.TabIndex = 1;
            // 
            // btnclear
            // 
            this.btnclear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnclear.BackgroundImage = global::Cooperation.Properties.Resources.images__12_;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(802, 573);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(98, 52);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ofdimage
            // 
            this.ofdimage.FileName = "openFileDialog1";
            // 
            // btnenter
            // 
            this.btnenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnenter.BackgroundImage = global::Cooperation.Properties.Resources.images__12_;
            this.btnenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenter.ForeColor = System.Drawing.Color.White;
            this.btnenter.Location = new System.Drawing.Point(683, 573);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(103, 52);
            this.btnenter.TabIndex = 9;
            this.btnenter.Text = "Save";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // datacategory
            // 
            this.datacategory.AllowUserToAddRows = false;
            this.datacategory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.datacategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datacategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datacategory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datacategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datacategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.UName,
            this.Age,
            this.Address,
            this.jk,
            this.lasteducation,
            this.Birtofday});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datacategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.datacategory.Location = new System.Drawing.Point(64, 631);
            this.datacategory.Name = "datacategory";
            this.datacategory.ReadOnly = true;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.datacategory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datacategory.Size = new System.Drawing.Size(940, 119);
            this.datacategory.TabIndex = 10;
            // 
            // code
            // 
            this.code.HeaderText = "code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // UName
            // 
            this.UName.HeaderText = "Name";
            this.UName.Name = "UName";
            this.UName.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // jk
            // 
            this.jk.HeaderText = "Gender";
            this.jk.Name = "jk";
            this.jk.ReadOnly = true;
            // 
            // lasteducation
            // 
            this.lasteducation.HeaderText = "Last Education";
            this.lasteducation.Name = "lasteducation";
            this.lasteducation.ReadOnly = true;
            this.lasteducation.Width = 200;
            // 
            // Birtofday
            // 
            this.Birtofday.HeaderText = "Birth Date";
            this.Birtofday.Name = "Birtofday";
            this.Birtofday.ReadOnly = true;
            this.Birtofday.Width = 200;
            // 
            // btnclose
            // 
            this.btnclose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnclose.BackgroundImage = global::Cooperation.Properties.Resources.images__12_;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(906, 573);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(101, 52);
            this.btnclose.TabIndex = 11;
            this.btnclose.Text = "Exit";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cooperation.Properties.Resources.free_business_powerpoint_templates_ppt_652905;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1036, 780);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.datacategory);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.registration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).EndInit();
            this.grgender.ResumeLayout(false);
            this.grgender.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datacategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtlasteducation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.ComboBox txtdotcom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.DateTimePicker txtbirtofday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox grgender;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.Label lberroraddress;
        private System.Windows.Forms.Label lberrorbirt;
        private System.Windows.Forms.Label lbage;
        private System.Windows.Forms.Label lberrorlast;
        private System.Windows.Forms.Label lberrorname;
        private System.Windows.Forms.Label lberrorls;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnchoise;
        private System.Windows.Forms.PictureBox pbfoto;
        private System.Windows.Forms.OpenFileDialog ofdimage;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.DataGridView datacategory;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn UName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn jk;
        private System.Windows.Forms.DataGridViewTextBoxColumn lasteducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birtofday;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}