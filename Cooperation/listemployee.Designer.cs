namespace Cooperation
{
    partial class listemployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listemployee));
            this.datapersonal = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lasteducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birtofday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataaccount = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnback = new System.Windows.Forms.Button();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.btnfind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datapersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaccount)).BeginInit();
            this.SuspendLayout();
            // 
            // datapersonal
            // 
            this.datapersonal.AllowUserToAddRows = false;
            this.datapersonal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.datapersonal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datapersonal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datapersonal.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datapersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datapersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datapersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.datapersonal.DefaultCellStyle = dataGridViewCellStyle3;
            this.datapersonal.Location = new System.Drawing.Point(41, 337);
            this.datapersonal.Name = "datapersonal";
            this.datapersonal.ReadOnly = true;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.datapersonal.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datapersonal.Size = new System.Drawing.Size(936, 184);
            this.datapersonal.TabIndex = 11;
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
            // dataaccount
            // 
            this.dataaccount.AllowUserToAddRows = false;
            this.dataaccount.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataaccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataaccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataaccount.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataaccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataaccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataaccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.iname,
            this.iusername,
            this.ipassword,
            this.iemail});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataaccount.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataaccount.Location = new System.Drawing.Point(41, 538);
            this.dataaccount.Name = "dataaccount";
            this.dataaccount.ReadOnly = true;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dataaccount.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataaccount.Size = new System.Drawing.Size(936, 189);
            this.dataaccount.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iname
            // 
            this.iname.HeaderText = "name";
            this.iname.Name = "iname";
            this.iname.ReadOnly = true;
            this.iname.Width = 200;
            // 
            // iusername
            // 
            this.iusername.HeaderText = "username";
            this.iusername.Name = "iusername";
            this.iusername.ReadOnly = true;
            this.iusername.Width = 200;
            // 
            // ipassword
            // 
            this.ipassword.HeaderText = "password";
            this.ipassword.Name = "ipassword";
            this.ipassword.ReadOnly = true;
            this.ipassword.Width = 200;
            // 
            // iemail
            // 
            this.iemail.HeaderText = "email";
            this.iemail.Name = "iemail";
            this.iemail.ReadOnly = true;
            this.iemail.Width = 200;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Yellow;
            this.btnback.Location = new System.Drawing.Point(12, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(98, 95);
            this.btnback.TabIndex = 13;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtcari
            // 
            this.txtcari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcari.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcari.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcari.Location = new System.Drawing.Point(379, 291);
            this.txtcari.Multiline = true;
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(161, 40);
            this.txtcari.TabIndex = 26;
            // 
            // btnfind
            // 
            this.btnfind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnfind.BackgroundImage = global::Cooperation.Properties.Resources.images__12_;
            this.btnfind.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.ForeColor = System.Drawing.Color.White;
            this.btnfind.Location = new System.Drawing.Point(588, 291);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(88, 40);
            this.btnfind.TabIndex = 25;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // listemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cooperation.Properties.Resources.free_business_powerpoint_templates_ppt_652905;
            this.ClientSize = new System.Drawing.Size(1028, 750);
            this.Controls.Add(this.txtcari);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dataaccount);
            this.Controls.Add(this.datapersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listemployee";
            this.Text = "listemployee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.listemployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datapersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datapersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn UName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn jk;
        private System.Windows.Forms.DataGridViewTextBoxColumn lasteducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birtofday;
        private System.Windows.Forms.DataGridView dataaccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iname;
        private System.Windows.Forms.DataGridViewTextBoxColumn iusername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn iemail;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.Button btnfind;
    }
}