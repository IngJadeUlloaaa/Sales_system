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
    public partial class Form9 : Form
    {

        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invoice ✓✓");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataproduct.Clear();
            dataproduct.Focus();
            dataquantity.Clear();
            datacolor.Clear();
            datavoucher.Clear();
            dataaddress.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
