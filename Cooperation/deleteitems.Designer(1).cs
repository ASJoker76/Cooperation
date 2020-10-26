namespace Cooperation
{
    partial class deleteitems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteitems));
            this.dataitem = new System.Windows.Forms.DataGridView();
            this.acode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aitems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnback = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataitem.Location = new System.Drawing.Point(208, 295);
            this.dataitem.Name = "dataitem";
            this.dataitem.ReadOnly = true;
            this.dataitem.Size = new System.Drawing.Size(644, 211);
            this.dataitem.TabIndex = 10;
            this.dataitem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataitem_CellClick);
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
            this.btnback.TabIndex = 21;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndelete.BackgroundImage = global::Cooperation.Properties.Resources.images__12_;
            this.btndelete.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(496, 544);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(109, 54);
            this.btndelete.TabIndex = 20;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // deleteitems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cooperation.Properties.Resources.free_business_powerpoint_templates_ppt_652905;
            this.ClientSize = new System.Drawing.Size(1028, 750);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dataitem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "deleteitems";
            this.Text = "deleteitems";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.deleteitems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn acode;
        private System.Windows.Forms.DataGridViewTextBoxColumn aitems;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn aStock;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btndelete;
    }
}