namespace Cooperation
{
    partial class additems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(additems));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lberrornameitems = new System.Windows.Forms.Label();
            this.lberrorstock = new System.Windows.Forms.Label();
            this.lberrorprice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtnameitems = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataitem = new System.Windows.Forms.DataGridView();
            this.acode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aitems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataitem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.lberrornameitems);
            this.groupBox1.Controls.Add(this.lberrorstock);
            this.groupBox1.Controls.Add(this.lberrorprice);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.enter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.txtnameitems);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(141, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 317);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Items";
            // 
            // lberrornameitems
            // 
            this.lberrornameitems.AutoSize = true;
            this.lberrornameitems.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberrornameitems.ForeColor = System.Drawing.Color.Red;
            this.lberrornameitems.Location = new System.Drawing.Point(458, 79);
            this.lberrornameitems.Name = "lberrornameitems";
            this.lberrornameitems.Size = new System.Drawing.Size(148, 23);
            this.lberrornameitems.TabIndex = 20;
            this.lberrornameitems.Text = "Not Null Allowed";
            this.lberrornameitems.Visible = false;
            // 
            // lberrorstock
            // 
            this.lberrorstock.AutoSize = true;
            this.lberrorstock.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberrorstock.ForeColor = System.Drawing.Color.Red;
            this.lberrorstock.Location = new System.Drawing.Point(462, 198);
            this.lberrorstock.Name = "lberrorstock";
            this.lberrorstock.Size = new System.Drawing.Size(148, 23);
            this.lberrorstock.TabIndex = 19;
            this.lberrorstock.Text = "Not Null Allowed";
            this.lberrorstock.Visible = false;
            // 
            // lberrorprice
            // 
            this.lberrorprice.AutoSize = true;
            this.lberrorprice.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberrorprice.ForeColor = System.Drawing.Color.Red;
            this.lberrorprice.Location = new System.Drawing.Point(462, 137);
            this.lberrorprice.Name = "lberrorprice";
            this.lberrorprice.Size = new System.Drawing.Size(148, 23);
            this.lberrorprice.TabIndex = 18;
            this.lberrorprice.Text = "Not Null Allowed";
            this.lberrorprice.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(355, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // enter
            // 
            this.enter.BackgroundImage = global::Cooperation.Properties.Resources.images__12_;
            this.enter.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.ForeColor = System.Drawing.Color.White;
            this.enter.Location = new System.Drawing.Point(175, 271);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(88, 40);
            this.enter.TabIndex = 15;
            this.enter.Text = "Save";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name Items";
            // 
            // txtstock
            // 
            this.txtstock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtstock.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.Location = new System.Drawing.Point(175, 190);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(268, 34);
            this.txtstock.TabIndex = 14;
            this.txtstock.TextChanged += new System.EventHandler(this.txtstock_TextChanged);
            this.txtstock.Validating += new System.ComponentModel.CancelEventHandler(this.txtstock_Validating);
            // 
            // txtnameitems
            // 
            this.txtnameitems.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtnameitems.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnameitems.Location = new System.Drawing.Point(175, 71);
            this.txtnameitems.Name = "txtnameitems";
            this.txtnameitems.Size = new System.Drawing.Size(268, 34);
            this.txtnameitems.TabIndex = 10;
            this.txtnameitems.TextChanged += new System.EventHandler(this.txtnameitems_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Price";
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtprice.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(175, 129);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(268, 34);
            this.txtprice.TabIndex = 12;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            this.txtprice.Validating += new System.ComponentModel.CancelEventHandler(this.txtprice_Validating);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Cooperation.Properties.Resources.super_mono_3d_01;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(-1, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 75);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.dataitem.Location = new System.Drawing.Point(141, 500);
            this.dataitem.Name = "dataitem";
            this.dataitem.ReadOnly = true;
            this.dataitem.Size = new System.Drawing.Size(644, 138);
            this.dataitem.TabIndex = 9;
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
            // additems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cooperation.Properties.Resources.free_business_powerpoint_templates_ppt_652905;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 620);
            this.Controls.Add(this.dataitem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "additems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "additems";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.additems_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtnameitems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label lberrornameitems;
        private System.Windows.Forms.Label lberrorstock;
        private System.Windows.Forms.Label lberrorprice;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn acode;
        private System.Windows.Forms.DataGridViewTextBoxColumn aitems;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn aStock;
    }
}