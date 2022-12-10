namespace Sales_system
{
    partial class Form8
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
            this.oproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ovoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.opayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.forToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.providersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordering";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oproduct,
            this.oquantity,
            this.ocolor,
            this.ovoucher,
            this.oaddress,
            this.opayments});
            this.dataGridView3.Location = new System.Drawing.Point(6, 33);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(643, 315);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // oproduct
            // 
            this.oproduct.HeaderText = "Product";
            this.oproduct.Name = "oproduct";
            // 
            // oquantity
            // 
            this.oquantity.HeaderText = "Amount";
            this.oquantity.Name = "oquantity";
            // 
            // ocolor
            // 
            this.ocolor.HeaderText = "Color";
            this.ocolor.Name = "ocolor";
            // 
            // ovoucher
            // 
            this.ovoucher.HeaderText = "Voucher";
            this.ovoucher.Name = "ovoucher";
            // 
            // oaddress
            // 
            this.oaddress.HeaderText = "Address";
            this.oaddress.Name = "oaddress";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "REFRESH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(673, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "BILLING";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(673, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // opayments
            // 
            this.opayments.HeaderText = "Payments";
            this.opayments.Name = "opayments";
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
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form8";
            this.Text = "Orders";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn oproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn oquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ovoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn oaddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn opayments;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem forToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem providersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoppingToolStripMenuItem;
    }
}