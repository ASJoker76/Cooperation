namespace Cooperation
{
    partial class deleteemployee
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
            this.btndelete = new System.Windows.Forms.Button();
            this.datacategory = new System.Windows.Forms.DataGridView();
            this.icode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilasteducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birtofday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datacategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndelete.BackgroundImage = global::Cooperation.Properties.Resources.images__12_;
            this.btndelete.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(464, 585);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(121, 64);
            this.btndelete.TabIndex = 16;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.enter_Click);
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
            this.icode,
            this.UName,
            this.iage,
            this.iaddress,
            this.jk,
            this.ilasteducation,
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
            this.datacategory.Location = new System.Drawing.Point(12, 295);
            this.datacategory.Name = "datacategory";
            this.datacategory.ReadOnly = true;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.datacategory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datacategory.Size = new System.Drawing.Size(1004, 246);
            this.datacategory.TabIndex = 18;
            this.datacategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datacategory_CellClick);
            // 
            // icode
            // 
            this.icode.HeaderText = "code";
            this.icode.Name = "icode";
            this.icode.ReadOnly = true;
            // 
            // UName
            // 
            this.UName.HeaderText = "Name";
            this.UName.Name = "UName";
            this.UName.ReadOnly = true;
            // 
            // iage
            // 
            this.iage.HeaderText = "age";
            this.iage.Name = "iage";
            this.iage.ReadOnly = true;
            this.iage.Width = 60;
            // 
            // iaddress
            // 
            this.iaddress.HeaderText = "address";
            this.iaddress.Name = "iaddress";
            this.iaddress.ReadOnly = true;
            // 
            // jk
            // 
            this.jk.HeaderText = "Gender";
            this.jk.Name = "jk";
            this.jk.ReadOnly = true;
            // 
            // ilasteducation
            // 
            this.ilasteducation.HeaderText = "last education";
            this.ilasteducation.Name = "ilasteducation";
            this.ilasteducation.ReadOnly = true;
            this.ilasteducation.Width = 150;
            // 
            // Birtofday
            // 
            this.Birtofday.HeaderText = "Birth Date";
            this.Birtofday.Name = "Birtofday";
            this.Birtofday.ReadOnly = true;
            this.Birtofday.Width = 150;
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
            // button2
            // 
            this.button2.BackgroundImage = global::Cooperation.Properties.Resources.super_mono_3d_01;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(-1, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 75);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cooperation.Properties.Resources.free_business_powerpoint_templates_ppt_652905;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 750);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.datacategory);
            this.Controls.Add(this.btndelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "deleteemployee";
            this.Text = "deleteemployee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.deleteemployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datacategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView datacategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn icode;
        private System.Windows.Forms.DataGridViewTextBoxColumn UName;
        private System.Windows.Forms.DataGridViewTextBoxColumn iage;
        private System.Windows.Forms.DataGridViewTextBoxColumn iaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn jk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilasteducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birtofday;
        private System.Windows.Forms.DataGridViewTextBoxColumn iusername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn iemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipath;
        private System.Windows.Forms.Button button2;
    }
}