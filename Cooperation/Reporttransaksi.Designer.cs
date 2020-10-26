namespace Cooperation
{
    partial class Reporttransaksi
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
            this.reportdagang = new System.Windows.Forms.DataGridView();
            this.adatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aemployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akembali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportdagang)).BeginInit();
            this.SuspendLayout();
            // 
            // reportdagang
            // 
            this.reportdagang.AllowUserToAddRows = false;
            this.reportdagang.AllowUserToDeleteRows = false;
            this.reportdagang.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportdagang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.reportdagang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportdagang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adatetime,
            this.aemployee,
            this.atotal,
            this.abayar,
            this.akembali});
            this.reportdagang.Location = new System.Drawing.Point(62, 216);
            this.reportdagang.Name = "reportdagang";
            this.reportdagang.ReadOnly = true;
            this.reportdagang.Size = new System.Drawing.Size(925, 424);
            this.reportdagang.TabIndex = 34;
            // 
            // adatetime
            // 
            this.adatetime.HeaderText = "Date time";
            this.adatetime.Name = "adatetime";
            this.adatetime.ReadOnly = true;
            this.adatetime.Width = 200;
            // 
            // aemployee
            // 
            this.aemployee.HeaderText = "Employee";
            this.aemployee.Name = "aemployee";
            this.aemployee.ReadOnly = true;
            this.aemployee.Width = 200;
            // 
            // atotal
            // 
            this.atotal.HeaderText = "Total Belanja";
            this.atotal.Name = "atotal";
            this.atotal.ReadOnly = true;
            this.atotal.Width = 180;
            // 
            // abayar
            // 
            this.abayar.HeaderText = "Bayar";
            this.abayar.Name = "abayar";
            this.abayar.ReadOnly = true;
            this.abayar.Width = 150;
            // 
            // akembali
            // 
            this.akembali.HeaderText = "Kembalian";
            this.akembali.Name = "akembali";
            this.akembali.ReadOnly = true;
            this.akembali.Width = 150;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Cooperation.Properties.Resources.super_mono_3d_01;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(-2, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 75);
            this.button2.TabIndex = 35;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reporttransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cooperation.Properties.Resources.free_business_powerpoint_templates_ppt_652905;
            this.ClientSize = new System.Drawing.Size(1020, 620);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportdagang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporttransaksi";
            this.Text = "Reporttransaksi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reporttransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportdagang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reportdagang;
        private System.Windows.Forms.DataGridViewTextBoxColumn adatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn aemployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn atotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn abayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn akembali;
        private System.Windows.Forms.Button button2;
    }
}