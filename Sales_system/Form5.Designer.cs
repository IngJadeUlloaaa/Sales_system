namespace Sales_system
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.forToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.providersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDDATAGRIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEFRESHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 398);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sname,
            this.scompany,
            this.scode,
            this.smail,
            this.sproduct,
            this.squantity,
            this.sdate,
            this.sprice});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // sname
            // 
            this.sname.HeaderText = "Name";
            this.sname.Name = "sname";
            // 
            // scompany
            // 
            this.scompany.HeaderText = "Company";
            this.scompany.Name = "scompany";
            // 
            // scode
            // 
            this.scode.HeaderText = "Code";
            this.scode.Name = "scode";
            // 
            // smail
            // 
            this.smail.HeaderText = "E-Mail";
            this.smail.Name = "smail";
            // 
            // sproduct
            // 
            this.sproduct.HeaderText = "Product";
            this.sproduct.Name = "sproduct";
            // 
            // squantity
            // 
            this.squantity.HeaderText = "Quantity";
            this.squantity.Name = "squantity";
            // 
            // sdate
            // 
            this.sdate.HeaderText = "Date";
            this.sdate.Name = "sdate";
            // 
            // sprice
            // 
            this.sprice.HeaderText = "Price";
            this.sprice.Name = "sprice";
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
            this.shoppingToolStripMenuItem,
            this.cRUDDATAGRIDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(153, 13);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
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
            // cRUDDATAGRIDToolStripMenuItem
            // 
            this.cRUDDATAGRIDToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cRUDDATAGRIDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEFRESHToolStripMenuItem,
            this.dELETEToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.cRUDDATAGRIDToolStripMenuItem.Name = "cRUDDATAGRIDToolStripMenuItem";
            this.cRUDDATAGRIDToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.cRUDDATAGRIDToolStripMenuItem.Text = "CRUD-DATAGRID";
            // 
            // rEFRESHToolStripMenuItem
            // 
            this.rEFRESHToolStripMenuItem.Name = "rEFRESHToolStripMenuItem";
            this.rEFRESHToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rEFRESHToolStripMenuItem.Text = "REFRESH";
            this.rEFRESHToolStripMenuItem.Click += new System.EventHandler(this.rEFRESHToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eXITToolStripMenuItem.Text = "RETURN";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Supplier Information";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn scompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn scode;
        private System.Windows.Forms.DataGridViewTextBoxColumn smail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn squantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem forToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem providersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoppingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDDATAGRIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEFRESHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
    }
}