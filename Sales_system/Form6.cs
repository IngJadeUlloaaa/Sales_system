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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //variables
            int amountproduct;
            float priceproduct, userpay, tl = 0, mult;

            //read
            priceproduct = Convert.ToInt32(textpriceitem.Text);
            amountproduct = Convert.ToInt32(textquantityitem.Text);
            userpay = Convert.ToInt32(textpayitem.Text);

            //operation
            if (userpay < priceproduct)
            {
                MessageBox.Show("Ingrese un Pago legible");
            }
            else
            {
                mult = priceproduct * amountproduct;
                tl = userpay - mult;
            }
            //send data
            texttotalitem.Text = Convert.ToString(tl);


            //datagrid
            int x = dataGridView3.Rows.Add();

            dataGridView3.Rows[x].Cells[0].Value = textnameitem.Text;
            dataGridView3.Rows[x].Cells[1].Value = textpriceitem.Text;
            dataGridView3.Rows[x].Cells[2].Value = textquantityitem.Text;
            dataGridView3.Rows[x].Cells[3].Value = textcodeitem.Text;
            dataGridView3.Rows[x].Cells[4].Value = textdateitem.Text;
            dataGridView3.Rows[x].Cells[5].Value = textpayitem.Text;
            dataGridView3.Rows[x].Cells[6].Value = texttotalitem.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textnameitem.Clear();
            textnameitem.Focus();
            textpriceitem.Clear();
            textquantityitem.Clear();
            textcodeitem.Clear();
            textdateitem.Clear();
            textpayitem.Clear();
            texttotalitem.Clear();
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
