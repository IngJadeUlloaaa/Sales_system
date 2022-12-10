using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_system
{
    public partial class Form3 : Form
    {
        //attributes
        private string name, lastname, dni, phone, mail, address, age, cstatus;

        //properties
        public string pname {
            set { 
                name = value;
            }
        }
        public string plastname {
            set { 
                lastname  = value;
            }
        }

        public string pdni {
            set { 
                dni = value;
            }
        }

        public string pphone
        {
            set
            {
                phone = value;
            }
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //delete
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void rEFRESHToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int reglon = dataGridView1.Rows.Add();

            dataGridView1.Rows[reglon].Cells["c_name"].Value = name;
            dataGridView1.Rows[reglon].Cells["c_lastname"].Value = lastname;
            dataGridView1.Rows[reglon].Cells["c_dni"].Value = dni;
            dataGridView1.Rows[reglon].Cells["c_phone"].Value = phone;
            dataGridView1.Rows[reglon].Cells["c_mail"].Value = mail;
            dataGridView1.Rows[reglon].Cells["c_add"].Value = address;
            dataGridView1.Rows[reglon].Cells["c_age"].Value = age;
            dataGridView1.Rows[reglon].Cells["c_status"].Value = cstatus;
        }

        private void dELETEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // delete
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ret = new Form2();
            ret.Show();
        }

        private void forToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form clientesforms = new Form2();
            clientesforms.Show();
        }

        private void customerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form provforms = new Form4();
            provforms.Show();
        }

        private void providersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form shpp = new Form6();
            shpp.Show();
        }

        private void supplierInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form orderr = new Form7();
            orderr.Show();
        }

        private void customerOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form bll = new Form9();
            bll.Show();
        }

        private void shoppingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string pmail
        {
            set
            {
                mail = value;
            }
        }

        public string paddress
        {
            set
            {
                address = value;
            }
        }

        public string page
        {
            set
            {
                age = value;
            }
        }

        public string pstatus
        {
            set
            {
                cstatus = value;
            }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int reglon = dataGridView1.Rows.Add();

            dataGridView1.Rows[reglon].Cells["c_name"].Value = name;
            dataGridView1.Rows[reglon].Cells["c_lastname"].Value = lastname;
            dataGridView1.Rows[reglon].Cells["c_dni"].Value = dni;
            dataGridView1.Rows[reglon].Cells["c_phone"].Value = phone;
            dataGridView1.Rows[reglon].Cells["c_mail"].Value = mail;
            dataGridView1.Rows[reglon].Cells["c_add"].Value = address;
            dataGridView1.Rows[reglon].Cells["c_age"].Value = age;
            dataGridView1.Rows[reglon].Cells["c_status"].Value = cstatus;
        }
    }
}
