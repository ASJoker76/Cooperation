﻿namespace Cooperation
{
    partial class viewlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewlist));
            this.btnlistemployee = new System.Windows.Forms.Button();
            this.btnlistitems = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlistemployee
            // 
            this.btnlistemployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlistemployee.BackColor = System.Drawing.Color.Transparent;
            this.btnlistemployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlistemployee.BackgroundImage")));
            this.btnlistemployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlistemployee.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistemployee.ForeColor = System.Drawing.Color.Cyan;
            this.btnlistemployee.Location = new System.Drawing.Point(595, 398);
            this.btnlistemployee.Name = "btnlistemployee";
            this.btnlistemployee.Size = new System.Drawing.Size(171, 150);
            this.btnlistemployee.TabIndex = 5;
            this.btnlistemployee.Text = "list Employee";
            this.btnlistemployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnlistemployee.UseVisualStyleBackColor = false;
            this.btnlistemployee.Click += new System.EventHandler(this.btnlistemployee_Click);
            // 
            // btnlistitems
            // 
            this.btnlistitems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlistitems.BackColor = System.Drawing.Color.Transparent;
            this.btnlistitems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlistitems.BackgroundImage")));
            this.btnlistitems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlistitems.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistitems.ForeColor = System.Drawing.Color.Cyan;
            this.btnlistitems.Location = new System.Drawing.Point(232, 398);
            this.btnlistitems.Name = "btnlistitems";
            this.btnlistitems.Size = new System.Drawing.Size(171, 150);
            this.btnlistitems.TabIndex = 4;
            this.btnlistitems.Text = "List Items";
            this.btnlistitems.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnlistitems.UseVisualStyleBackColor = false;
            this.btnlistitems.Click += new System.EventHandler(this.btnlistitems_Click);
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
            this.btnback.TabIndex = 9;
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
            this.pictureBox3.Location = new System.Drawing.Point(152, 364);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(317, 187);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Cooperation.Properties.Resources._3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(524, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 187);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // viewlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cooperation.Properties.Resources.cubes_squares_lights_ppt_backgrounds_powerpoint;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 750);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnlistemployee);
            this.Controls.Add(this.btnlistitems);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewlist";
            this.Text = "viewlist";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlistemployee;
        private System.Windows.Forms.Button btnlistitems;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}