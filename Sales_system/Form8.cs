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
    public partial class Form8 : Form
    {
        private string ooproduct, ooquantity, oocolor, oovoucher, ooaddress, oopayments;

        public string oooproduct
        {
            set
            {
                ooproduct = value;
            }
        }

        public string oooquantity
        {
            set
            {
                ooquantity = value;
            }
        }

        public string ooocolor
        {
            set
            {
                oocolor = value;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Remove(dataGridView3.CurrentRow);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form bill = new Form9();
            bill.Show();
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

        public string ooovoucher
        {
            set
            {
                oovoucher = value;
            }
        }

        public string oooaddress
        {
            set
            {
                ooaddress = value;
            }
        }

        public string ooopayments
        {
            set
            {
                oopayments = value;
            }
        }

        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int reglon3 = dataGridView3.Rows.Add();
            dataGridView3.Rows[reglon3].Cells["oproduct"].Value = ooproduct;
            dataGridView3.Rows[reglon3].Cells["oquantity"].Value = ooquantity;
            dataGridView3.Rows[reglon3].Cells["ocolor"].Value = oocolor;
            dataGridView3.Rows[reglon3].Cells["ovoucher"].Value = oovoucher;
            dataGridView3.Rows[reglon3].Cells["oaddress"].Value = ooaddress;
            dataGridView3.Rows[reglon3].Cells["opayments"].Value = oopayments;
        }
    }
}
