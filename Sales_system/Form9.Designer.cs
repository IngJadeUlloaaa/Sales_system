namespace Sales_system
{
    partial class Form9
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataaddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datavoucher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datacolor = new System.Windows.Forms.TextBox();
            this.dataproduct = new System.Windows.Forms.TextBox();
            this.dataquantity = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.forToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.providersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "GET INVOICE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(351, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 32);
            this.button3.TabIndex = 19;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 32);
            this.button2.TabIndex = 20;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataaddress);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.datavoucher);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.datacolor);
            this.groupBox2.Controls.Add(this.dataproduct);
            this.groupBox2.Controls.Add(this.dataquantity);
            this.groupBox2.Location = new System.Drawing.Point(121, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 234);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // dataaddress
            // 
            this.dataaddress.Location = new System.Drawing.Point(104, 184);
            this.dataaddress.Name = "dataaddress";
            this.dataaddress.Size = new System.Drawing.Size(101, 20);
            this.dataaddress.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            // 
            // datavoucher
            // 
            this.datavoucher.Location = new System.Drawing.Point(105, 149);
            this.datavoucher.Name = "datavoucher";
            this.datavoucher.Size = new System.Drawing.Size(101, 20);
            this.datavoucher.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Voucher";
            // 
            // datacolor
            // 
            this.datacolor.Location = new System.Drawing.Point(104, 115);
            this.datacolor.Name = "datacolor";
            this.datacolor.Size = new System.Drawing.Size(101, 20);
            this.datacolor.TabIndex = 9;
            // 
            // dataproduct
            // 
            this.dataproduct.Location = new System.Drawing.Point(104, 41);
            this.dataproduct.Name = "dataproduct";
            this.dataproduct.Size = new System.Drawing.Size(101, 20);
            this.dataproduct.TabIndex = 5;
            // 
            // dataquantity
            // 
            this.dataquantity.Location = new System.Drawing.Point(105, 80);
            this.dataquantity.Name = "dataquantity";
            this.dataquantity.Size = new System.Drawing.Size(101, 20);
            this.dataquantity.TabIndex = 6;
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
            this.menuStrip1.Location = new System.Drawing.Point(155, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 24);
            this.menuStrip1.TabIndex = 23;
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
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form9";
            this.Text = "Billing";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox dataaddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox datavoucher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox datacolor;
        private System.Windows.Forms.TextBox dataproduct;
        private System.Windows.Forms.TextBox dataquantity;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem forToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem providersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoppingToolStripMenuItem;
    }
}