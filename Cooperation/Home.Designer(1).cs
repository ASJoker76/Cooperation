namespace Cooperation
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.btnenter = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cvExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbu
            // 
            this.lbu.AutoSize = true;
            this.lbu.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbu.Location = new System.Drawing.Point(595, 505);
            this.lbu.Name = "lbu";
            this.lbu.Size = new System.Drawing.Size(0, 29);
            this.lbu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME";
            // 
            // txtusername
            // 
            this.txtusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusername.BackColor = System.Drawing.Color.White;
            this.txtusername.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.Location = new System.Drawing.Point(223, 182);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(409, 32);
            this.txtusername.TabIndex = 2;
            this.txtusername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtusername_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "PASSWORD";
            // 
            // txtpw
            // 
            this.txtpw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpw.BackColor = System.Drawing.Color.White;
            this.txtpw.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpw.ForeColor = System.Drawing.Color.Black;
            this.txtpw.Location = new System.Drawing.Point(223, 247);
            this.txtpw.Multiline = true;
            this.txtpw.Name = "txtpw";
            this.txtpw.PasswordChar = '*';
            this.txtpw.Size = new System.Drawing.Size(409, 32);
            this.txtpw.TabIndex = 5;
            this.txtpw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpw_KeyDown);
            // 
            // btnenter
            // 
            this.btnenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnenter.BackgroundImage")));
            this.btnenter.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenter.ForeColor = System.Drawing.Color.Blue;
            this.btnenter.Location = new System.Drawing.Point(364, 337);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(158, 40);
            this.btnenter.TabIndex = 6;
            this.btnenter.Text = "ENTER";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.enter_Click);
            // 
            // btnregister
            // 
            this.btnregister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnregister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregister.BackgroundImage")));
            this.btnregister.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.ForeColor = System.Drawing.Color.Blue;
            this.btnregister.Location = new System.Drawing.Point(364, 400);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(158, 40);
            this.btnregister.TabIndex = 7;
            this.btnregister.Text = "REGISTER";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(456, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "\"If you haven\'t account, You have to Register!\"";
            // 
            // cvExit
            // 
            this.cvExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cvExit.BackColor = System.Drawing.Color.Gray;
            this.cvExit.BackgroundImage = global::Cooperation.Properties.Resources.close;
            this.cvExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cvExit.Location = new System.Drawing.Point(735, 468);
            this.cvExit.Name = "cvExit";
            this.cvExit.Size = new System.Drawing.Size(97, 83);
            this.cvExit.TabIndex = 10;
            this.cvExit.UseVisualStyleBackColor = false;
            this.cvExit.Click += new System.EventHandler(this.cvExit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Cooperation.Properties.Resources.Bonus_main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(978, 620);
            this.Controls.Add(this.cvExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbu);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbu;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cvExit;
    }
}