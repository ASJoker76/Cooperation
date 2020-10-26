namespace Cooperation
{
    partial class add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add));
            this.btnadditems = new System.Windows.Forms.Button();
            this.btnaddemployee = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadditems
            // 
            this.btnadditems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnadditems.BackColor = System.Drawing.Color.Transparent;
            this.btnadditems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadditems.BackgroundImage")));
            this.btnadditems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadditems.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadditems.ForeColor = System.Drawing.Color.Yellow;
            this.btnadditems.Location = new System.Drawing.Point(475, 197);
            this.btnadditems.Name = "btnadditems";
            this.btnadditems.Size = new System.Drawing.Size(171, 150);
            this.btnadditems.TabIndex = 0;
            this.btnadditems.Text = "Add Items";
            this.btnadditems.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadditems.UseVisualStyleBackColor = false;
            this.btnadditems.Click += new System.EventHandler(this.btnadditems_Click);
            // 
            // btnaddemployee
            // 
            this.btnaddemployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnaddemployee.BackColor = System.Drawing.Color.Transparent;
            this.btnaddemployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaddemployee.BackgroundImage")));
            this.btnaddemployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaddemployee.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddemployee.ForeColor = System.Drawing.Color.Yellow;
            this.btnaddemployee.Location = new System.Drawing.Point(475, 478);
            this.btnaddemployee.Name = "btnaddemployee";
            this.btnaddemployee.Size = new System.Drawing.Size(171, 150);
            this.btnaddemployee.TabIndex = 1;
            this.btnaddemployee.Text = "Add Employee";
            this.btnaddemployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaddemployee.UseVisualStyleBackColor = false;
            this.btnaddemployee.Click += new System.EventHandler(this.btnaddemployee_Click);
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
            this.btnback.TabIndex = 7;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Cooperation.Properties.Resources._3;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(392, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(317, 187);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Cooperation.Properties.Resources._3;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(387, 441);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(317, 187);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Cooperation.Properties.Resources.cubes_squares_lights_ppt_backgrounds_powerpoint;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1028, 750);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnaddemployee);
            this.Controls.Add(this.btnadditems);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add";
            this.Text = "add";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadditems;
        private System.Windows.Forms.Button btnaddemployee;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}