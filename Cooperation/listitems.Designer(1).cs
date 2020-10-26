namespace Cooperation
{
    partial class listitems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listitems));
            this.dataitem = new System.Windows.Forms.DataGridView();
            this.acode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aitems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnback = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.txtcari = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataitem)).BeginInit();
            this.SuspendLayout();
            // 
            // dataitem
            // 
            this.dataitem.AllowUserToAddRows = false;
            this.dataitem.AllowUserToDeleteRows = false;
            this.dataitem.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataitem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataitem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.acode,
            this.aitems,
            this.aPrice,
            this.aStock});
            this.dataitem.Location = new System.Drawing.Point(208, 296);
            this.dataitem.Name = "dataitem";
            this.dataitem.ReadOnly = true;
            this.dataitem.Size = new System.Drawing.Size(644, 211);
            this.dataitem.TabIndex = 11;
            // 
            // acode
            // 
            this.acode.HeaderText = "code";
            this.acode.Name = "acode";
            this.acode.ReadOnly = true;
            // 
            // aitems
            // 
            this.aitems.HeaderText = "Name Items";
            this.aitems.Name = "aitems";
            this.aitems.ReadOnly = true;
            this.aitems.Width = 200;
            // 
            // aPrice
            // 
            this.aPrice.HeaderText = "Price";
            this.aPrice.Name = "aPrice";
            this.aPrice.ReadOnly = true;
            this.aPrice.Width = 150;
            // 
            // aStock
            // 
            this.aStock.HeaderText = "Stock";
            this.aStock.Name = "aStock";
            this.aStock.ReadOnly = true;
            this.aStock.Width = 150;
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
            this.btnback.TabIndex = 22;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnfind
            // 
            this.btnfind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnfind.BackgroundImage = global::Cooperation.Properties.Resources.images__12_;
            this.btnfind.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.ForeColor = System.Drawing.Color.White;
            this.btnfind.Location = new System.Drawing.Point(589, 223);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(88, 40);
            this.btnfind.TabIndex = 23;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // txtcari
            // 
            this.txtcari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcari.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcari.Font = new System.Drawing.Font("Kristen ITC", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcari.Location = new System.Drawing.Point(380, 223);
            this.txtcari.Multiline = true;
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(161, 40);
            this.txtcari.TabIndex = 24;
            // 
            // listitems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cooperation.Properties.Resources.free_business_powerpoint_templates_ppt_652905;
            this.ClientSize = new System.Drawing.Size(1028, 620);
            this.Controls.Add(this.txtcari);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dataitem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listitems";
            this.Text = "listitems";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.listitems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn acode;
        private System.Windows.Forms.DataGridViewTextBoxColumn aitems;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn aStock;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.TextBox txtcari;
    }
}