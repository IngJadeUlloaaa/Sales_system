namespace Sales_system
{
    partial class Form3
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
            this.c_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_name,
            this.c_lastname,
            this.c_dni,
            this.c_phone,
            this.c_mail,
            this.c_add,
            this.c_age,
            this.c_status});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // c_name
            // 
            this.c_name.HeaderText = "Name";
            this.c_name.Name = "c_name";
            // 
            // c_lastname
            // 
            this.c_lastname.HeaderText = "Last Name";
            this.c_lastname.Name = "c_lastname";
            // 
            // c_dni
            // 
            this.c_dni.HeaderText = "DNI";
            this.c_dni.Name = "c_dni";
            // 
            // c_phone
            // 
            this.c_phone.HeaderText = "PhoneNumber";
            this.c_phone.Name = "c_phone";
            // 
            // c_mail
            // 
            this.c_mail.HeaderText = "E-Mail";
            this.c_mail.Name = "c_mail";
            // 
            // c_add
            // 
            this.c_add.HeaderText = "Address";
            this.c_add.Name = "c_add";
            // 
            // c_age
            // 
            this.c_age.HeaderText = "Age";
            this.c_age.Name = "c_age";
            // 
            // c_status
            // 
            this.c_status.HeaderText = "CivilStatus";
            this.c_status.Name = "c_status";
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
            this.menuStrip1.Location = new System.Drawing.Point(126, 12);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 2;
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
            this.rEFRESHToolStripMenuItem.Click += new System.EventHandler(this.rEFRESHToolStripMenuItem_Click_1);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click_1);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eXITToolStripMenuItem.Text = "RETURN";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Costumer Information";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn c_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_status;
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