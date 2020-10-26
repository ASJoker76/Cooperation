namespace Cooperation
{
    partial class updateemployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateemployee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.btnchoise = new System.Windows.Forms.Button();
            this.pbfoto = new System.Windows.Forms.PictureBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.datacategory = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lasteducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birtofday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.ofdimage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).BeginInit();
            this.grgender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacategory)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpath
            // 
            this.txtpath.Enabled = false;
            this.txtpath.Location = new System.Drawing.Point(20, 604);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(154, 20);
            this.txtpath.TabIndex = 27;
            // 
            // btnchoise
            // 
            this.btnchoise.BackColor = System.Drawing.Color.Transparent;
            this.btnchoise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnchoise.BackgroundImage")));
            this.btnchoise.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchoise.ForeColor = System.Drawing.Color.White;
            this.btnchoise.Location = new System.Drawing.Point(31, 556);
            this.btnchoise.Name = "btnchoise";
            this.btnchoise.Size = new System.Drawing.Size(130, 46);
            this.btnchoise.TabIndex = 28;
            this.btnchoise.Text = "Choise Image";
            this.btnchoise.UseVisualStyleBackColor = false;
            this.btnchoise.Click += new System.EventHandler(this.btnchoise_Click);
            // 
            // pbfoto
            // 
            this.pbfoto.Location = new System.Drawing.Point(21, 373);
            this.pbfoto.Name = "pbfoto";
            this.pbfoto.Size = new System.Drawing.Size(153, 176);
            this.pbfoto.TabIndex = 34;
            this.pbfoto.TabStop = false;
            // 
            // grgender
            // 
            this.grgender.BackColor = System.Drawing.Color.Transparent;
            this.grgender.Controls.Add(this.rbfemale);
            this.grgender.Controls.Add(this.rbmale);
            this.grgender.Font = new System.Drawing.Font("Eraser", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grgender.ForeColor = System.Drawing.Color.Black;
            this.grgender.Location = new System.Drawing.Point(185, 532);
            this.grgender.Name = "grgender";
            this.grgender.Size = new System.Drawing.Size(285, 92);
            this.grgender.TabIndex = 30;
            this.grgender.TabStop = false;
            this.grgender.Text = "Gender";
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfemale.Location = new System.Drawing.Point(178, 33);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(92, 30);
            this.rbfemale.TabIndex = 14;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmale.Location = new System.Drawing.Point(41, 33);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(72, 30);
            this.rbmale.TabIndex = 13;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // txtbirtofday
            // 
            this.txtbirtofday.Location = new System.Drawing.Point(184, 645);
            this.txtbirtofday.Name = "txtbirtofday";
            this.txtbirtofday.Size = new System.Drawing.Size(181, 20);
            this.txtbirtofday.TabIndex = 32;
            this.txtbirtofday.Value = new System.DateTime(1997, 1, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(54, 642);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 27);
            this.label9.TabIndex = 31;
            this.label9.Text = "Birt of day";
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtaddress.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.ForeColor = System.Drawing.SystemColors.Info;
            this.txtaddress.Location = new System.Drawing.Point(185, 686);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(365, 56);
            this.txtaddress.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(54, 683);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 27);
            this.label5.TabIndex = 25;
            this.label5.Text = "Address";
            // 
            // txtage
            // 
            this.txtage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtage.Enabled = false;
            this.txtage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.ForeColor = System.Drawing.SystemColors.Info;
            this.txtage.Location = new System.Drawing.Point(320, 496);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(150, 30);
            this.txtage.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(181, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "Age";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtlasteducation
            // 
            this.txtlasteducation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtlasteducation.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlasteducation.ForeColor = System.Drawing.SystemColors.Info;
            this.txtlasteducation.FormattingEnabled = true;
            this.txtlasteducation.Items.AddRange(new object[] {
            "Junior High Scool",
            "Senior High Scool",
            "Diploma 3",
            "Sarjana 1"});
            this.txtlasteducation.Location = new System.Drawing.Point(319, 457);
            this.txtlasteducation.Name = "txtlasteducation";
            this.txtlasteducation.Size = new System.Drawing.Size(150, 31);
            this.txtlasteducation.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(180, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = "Last Education";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(181, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Full Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtname.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.SystemColors.Info;
            this.txtname.Location = new System.Drawing.Point(320, 412);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(150, 30);
            this.txtname.TabIndex = 20;
            // 
            // txtpw
            // 
            this.txtpw.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtpw.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpw.ForeColor = System.Drawing.SystemColors.Info;
            this.txtpw.Location = new System.Drawing.Point(773, 481);
            this.txtpw.Multiline = true;
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(214, 29);
            this.txtpw.TabIndex = 43;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtemail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.SystemColors.Info;
            this.txtemail.Location = new System.Drawing.Point(773, 522);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(214, 29);
            this.txtemail.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(658, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 27);
            this.label7.TabIndex = 39;
            this.label7.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(658, 481);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 27);
            this.label10.TabIndex = 38;
            this.label10.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(658, 447);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 27);
            this.label11.TabIndex = 36;
            this.label11.Text = "User Name";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtusername.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.SystemColors.Info;
            this.txtusername.Location = new System.Drawing.Point(764, 444);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(223, 29);
            this.txtusername.TabIndex = 37;
            // 
            // datacategory
            // 
            this.datacategory.AllowUserToAddRows = false;
            this.datacategory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.datacategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.Birtofday,
            this.iusername,
            this.ipassword,
            this.iemail,
            this.ipath});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datacategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.datacategory.Location = new System.Drawing.Point(59, 235);
            this.datacategory.Name = "datacategory";
            this.datacategory.ReadOnly = true;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.datacategory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datacategory.Size = new System.Drawing.Size(936, 132);
            this.datacategory.TabIndex = 44;
            this.datacategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datacategory_CellClick);
            this.datacategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datacategory_CellContentClick);
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
            // iusername
            // 
            this.iusername.HeaderText = "username";
            this.iusername.Name = "iusername";
            this.iusername.ReadOnly = true;
            // 
            // ipassword
            // 
            this.ipassword.HeaderText = "password";
            this.ipassword.Name = "ipassword";
            this.ipassword.ReadOnly = true;
            // 
            // iemail
            // 
            this.iemail.HeaderText = "email";
            this.iemail.Name = "iemail";
            this.iemail.ReadOnly = true;
            // 
            // ipath
            // 
            this.ipath.HeaderText = "path";
            this.ipath.Name = "ipath";
            this.ipath.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(181, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 27);
            this.label2.TabIndex = 45;
            this.label2.Text = "Code";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtcode
            // 
            this.txtcode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcode.Enabled = false;
            this.txtcode.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.ForeColor = System.Drawing.SystemColors.Info;
            this.txtcode.Location = new System.Drawing.Point(319, 375);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(150, 30);
            this.txtcode.TabIndex = 46;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsave.BackgroundImage")));
            this.btnsave.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(662, 683);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(130, 46);
            this.btnsave.TabIndex = 47;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(857, 683);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(130, 46);
            this.btnclose.TabIndex = 48;
            this.btnclose.Text = "back";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(453, 468);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(16, 20);
            this.vScrollBar1.TabIndex = 49;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // ofdimage
            // 
            this.ofdimage.FileName = "openFileDialog1";
            // 
            // updateemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cooperation.Properties.Resources.free_business_powerpoint_templates_ppt_652905;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 750);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.datacategory);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.btnchoise);
            this.Controls.Add(this.pbfoto);
            this.Controls.Add(this.grgender);
            this.Controls.Add(this.txtbirtofday);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtlasteducation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateemployee";
            this.Text = "updateemployee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.updateemployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).EndInit();
            this.grgender.ResumeLayout(false);
            this.grgender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button btnchoise;
        private System.Windows.Forms.PictureBox pbfoto;
        private System.Windows.Forms.GroupBox grgender;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.DateTimePicker txtbirtofday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtlasteducation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.DataGridView datacategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn UName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn jk;
        private System.Windows.Forms.DataGridViewTextBoxColumn lasteducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birtofday;
        private System.Windows.Forms.DataGridViewTextBoxColumn iusername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn iemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipath;
        private System.Windows.Forms.OpenFileDialog ofdimage;
    }
}