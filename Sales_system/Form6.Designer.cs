namespace Sales_system
{
    partial class Form6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.itemsname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemscode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemspay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemstotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.texttotalitem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textpayitem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textdateitem = new System.Windows.Forms.TextBox();
            this.textcodeitem = new System.Windows.Forms.TextBox();
            this.textquantityitem = new System.Windows.Forms.TextBox();
            this.textpriceitem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textnameitem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.forToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.providersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 396);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Information";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemsname,
            this.itemsprice,
            this.itemsquantity,
            this.itemscode,
            this.itemsdate,
            this.itemspay,
            this.itemstotal});
            this.dataGridView3.Location = new System.Drawing.Point(15, 230);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(745, 149);
            this.dataGridView3.TabIndex = 8;
            // 
            // itemsname
            // 
            this.itemsname.HeaderText = "Item Name";
            this.itemsname.Name = "itemsname";
            // 
            // itemsprice
            // 
            this.itemsprice.HeaderText = "Item Price";
            this.itemsprice.Name = "itemsprice";
            // 
            // itemsquantity
            // 
            this.itemsquantity.HeaderText = "Item Quantity";
            this.itemsquantity.Name = "itemsquantity";
            // 
            // itemscode
            // 
            this.itemscode.HeaderText = "Item Code";
            this.itemscode.Name = "itemscode";
            // 
            // itemsdate
            // 
            this.itemsdate.HeaderText = "Item Date";
            this.itemsdate.Name = "itemsdate";
            // 
            // itemspay
            // 
            this.itemspay.HeaderText = "Item Pay";
            this.itemspay.Name = "itemspay";
            // 
            // itemstotal
            // 
            this.itemstotal.HeaderText = "Item Total";
            this.itemstotal.Name = "itemstotal";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.texttotalitem);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textpayitem);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(416, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 184);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payments";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Clean";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // texttotalitem
            // 
            this.texttotalitem.Location = new System.Drawing.Point(65, 80);
            this.texttotalitem.Name = "texttotalitem";
            this.texttotalitem.Size = new System.Drawing.Size(188, 20);
            this.texttotalitem.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total:";
            // 
            // textpayitem
            // 
            this.textpayitem.Location = new System.Drawing.Point(65, 39);
            this.textpayitem.Name = "textpayitem";
            this.textpayitem.Size = new System.Drawing.Size(188, 20);
            this.textpayitem.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pay:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textdateitem);
            this.groupBox2.Controls.Add(this.textcodeitem);
            this.groupBox2.Controls.Add(this.textquantityitem);
            this.groupBox2.Controls.Add(this.textpriceitem);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textnameitem);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(42, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 184);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Article";
            // 
            // textdateitem
            // 
            this.textdateitem.Location = new System.Drawing.Point(96, 152);
            this.textdateitem.Name = "textdateitem";
            this.textdateitem.Size = new System.Drawing.Size(188, 20);
            this.textdateitem.TabIndex = 8;
            // 
            // textcodeitem
            // 
            this.textcodeitem.Location = new System.Drawing.Point(96, 122);
            this.textcodeitem.Name = "textcodeitem";
            this.textcodeitem.Size = new System.Drawing.Size(188, 20);
            this.textcodeitem.TabIndex = 7;
            // 
            // textquantityitem
            // 
            this.textquantityitem.Location = new System.Drawing.Point(96, 94);
            this.textquantityitem.Name = "textquantityitem";
            this.textquantityitem.Size = new System.Drawing.Size(188, 20);
            this.textquantityitem.TabIndex = 6;
            // 
            // textpriceitem
            // 
            this.textpriceitem.Location = new System.Drawing.Point(96, 62);
            this.textpriceitem.Name = "textpriceitem";
            this.textpriceitem.Size = new System.Drawing.Size(188, 20);
            this.textpriceitem.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Code:";
            // 
            // textnameitem
            // 
            this.textnameitem.Location = new System.Drawing.Point(96, 27);
            this.textnameitem.Name = "textnameitem";
            this.textnameitem.Size = new System.Drawing.Size(188, 20);
            this.textnameitem.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Price:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forToolStripMenuItem,
            this.customerInformationToolStripMenuItem,
            this.providersToolStripMenuItem,
            this.supplierInformationToolStripMenuItem,
            this.customerOrdersToolStripMenuItem,
            this.shoppingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(180, 15);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // forToolStripMenuItem
            // 
            this.forToolStripMenuItem.Name = "forToolStripMenuItem";
            this.forToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.forToolStripMenuItem.Text = "Customer Form";
            this.forToolStripMenuItem.Click += new System.EventHandler(this.forToolStripMenuItem_Click);
            // 
            // customerInformationToolStripMenuItem
            // 
            this.customerInformationToolStripMenuItem.Name = "customerInformationToolStripMenuItem";
            this.customerInformationToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.customerInformationToolStripMenuItem.Text = "Supplier Forms";
            this.customerInformationToolStripMenuItem.Click += new System.EventHandler(this.customerInformationToolStripMenuItem_Click);
            // 
            // providersToolStripMenuItem
            // 
            this.providersToolStripMenuItem.Name = "providersToolStripMenuItem";
            this.providersToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.providersToolStripMenuItem.Text = "Shopping";
            this.providersToolStripMenuItem.Click += new System.EventHandler(this.providersToolStripMenuItem_Click);
            // 
            // supplierInformationToolStripMenuItem
            // 
            this.supplierInformationToolStripMenuItem.Name = "supplierInformationToolStripMenuItem";
            this.supplierInformationToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.supplierInformationToolStripMenuItem.Text = "Orders";
            this.supplierInformationToolStripMenuItem.Click += new System.EventHandler(this.supplierInformationToolStripMenuItem_Click);
            // 
            // customerOrdersToolStripMenuItem
            // 
            this.customerOrdersToolStripMenuItem.Name = "customerOrdersToolStripMenuItem";
            this.customerOrdersToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.customerOrdersToolStripMenuItem.Text = "Invoices";
            this.customerOrdersToolStripMenuItem.Click += new System.EventHandler(this.customerOrdersToolStripMenuItem_Click);
            // 
            // shoppingToolStripMenuItem
            // 
            this.shoppingToolStripMenuItem.Name = "shoppingToolStripMenuItem";
            this.shoppingToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.shoppingToolStripMenuItem.Text = "Exit";
            this.shoppingToolStripMenuItem.Click += new System.EventHandler(this.shoppingToolStripMenuItem_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Customer Purchases";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsname;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemscode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemspay;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemstotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox texttotalitem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textpayitem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textdateitem;
        private System.Windows.Forms.TextBox textcodeitem;
        private System.Windows.Forms.TextBox textquantityitem;
        private System.Windows.Forms.TextBox textpriceitem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textnameitem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem forToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem providersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoppingToolStripMenuItem;
    }
}