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
    public partial class Form5 : Form
    {
        //attributes
        private string namep, company, codep, email, productp, quantityp, datep, pricep;

        //properties
        public string s_name
        {
            set
            {
                namep = value;
            }
        }

        public string s_company
        {
            set
            {
                company = value;
            }
        }

        public string s_codep
        {
            set
            {
                codep = value;
            }
        }

        public string s_mailp
        {
            set
            {
                email = value;
            }
        }

        private void cRUDDATAGRIDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cRUDDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEFRESHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int reglon2 = dataGridView1.Rows.Add();

            dataGridView1.Rows[reglon2].Cells["sname"].Value = namep;
            dataGridView1.Rows[reglon2].Cells["scompany"].Value = company;
            dataGridView1.Rows[reglon2].Cells["scode"].Value = codep;
            dataGridView1.Rows[reglon2].Cells["smail"].Value = email;
            dataGridView1.Rows[reglon2].Cells["sproduct"].Value = productp;
            dataGridView1.Rows[reglon2].Cells["squantity"].Value = quantityp;
            dataGridView1.Rows[reglon2].Cells["sdate"].Value = datep;
            dataGridView1.Rows[reglon2].Cells["sprice"].Value = pricep;
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //delete
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form rt = new Form4();
            rt.Show();
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

        private void rEFRESHToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void dELETEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        public string s_productp
        {
            set
            {
                productp = value;
            }
        }

        public string s_quantityp
        {
            set
            {
                quantityp = value;
            }
        }

        public string s_datep
        {
            set
            {
                datep = value;
            }
        }

        public string s_pricep
        {
            set
            {
                pricep = value;
            }
        }

        public Form5()
        {
            InitializeComponent();
        }
    }
}
