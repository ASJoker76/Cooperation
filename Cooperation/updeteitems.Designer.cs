namespace Cooperation
{
    partial class updeteitems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updeteitems));
            this.dataitem = new System.Windows.Forms.DataGridView();
            this.acode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aitems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtnameitems = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.lbcode = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
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
            this.dataitem.Location = new System.Drawing.Point(239, 300);
            this.dataitem.Name = "dataitem";
            this.dataitem.ReadOnly = true;
            this.dataitem.Size = new System.Drawing.Size(644, 148);
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
            // txtstock
            // 
            this.txtstock.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtstock.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.Location = new System.Drawing.Point(533, 644);
            this.txtstock.Multiline = true;
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(268, 42);
            this.txtstock.TabIndex = 17;
            this.txtstock.TextChanged += new System.EventHandler(this.txtstock_TextChanged);
            // 
            // txtnameitems
            // 
            this.txtnameitems.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtnameitems.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnameitems.Location = new System.Drawing.Point(533, 525);
            this.txtnameitems.Multiline = true;
            this.txtnameitems.Name = "txtnameitems";
            this.txtnameitems.Size = new System.Drawing.Size(268, 36);
            this.txtnameitems.TabIndex = 15;
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtprice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(533, 583);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(268, 36);
            this.txtprice.TabIndex = 16;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 644);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 27);
            this.label3.TabIndex = 20;
            this.label3.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "Price";
            // 
            // txtcode
            // 
            this.txtcode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcode.Enabled = false;
            this.txtcode.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.ForeColor = System.Drawing.Color.White;
            this.txtcode.Location = new System.Drawing.Point(533, 470);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(268, 36);
            this.txtcode.TabIndex = 21;
            // 
            // lbcode
            // 
            this.lbcode.AutoSize = true;
            this.lbcode.BackColor = System.Drawing.Color.Transparent;
            this.lbcode.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcode.Location = new System.Drawing.Point(303, 465);
            this.lbcode.Name = "lbcode";
            this.lbcode.Size = new System.Drawing.Size(54, 27);
            this.lbcode.TabIndex = 22;
            this.lbcode.Text = "code";
            // 
            // enter
            // 
            this.enter.BackgroundImage = global::Cooperation.Properties.Resources.images__12_;
            this.enter.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.ForeColor = System.Drawing.Color.White;
            this.enter.Location = new System.Drawing.Point(555, 692);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(211, 46);
            this.enter.TabIndex = 23;
            this.enter.Text = "Save";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
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
            this.btnback.TabIndex = 24;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // updeteitems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cooperation.Properties.Resources.free_business_powerpoint_templates_ppt_652905;
            this.ClientSize = new System.Drawing.Size(1028, 750);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.lbcode);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.txtnameitems);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.dataitem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updeteitems";
            this.Text = "updeteitems";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.updeteitems_Load);
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
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtnameitems;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label lbcode;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button btnback;
    }
}