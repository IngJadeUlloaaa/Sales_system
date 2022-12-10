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
    public partial class Form7 : Form
    {
        Form8 enviar3 = new Form8();

        public Form7()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            enviar3.oooproduct = textprdencar.Text;
            enviar3.oooquantity = textqtityencar.Text;
            enviar3.ooocolor = textcolorencar.Text;
            enviar3.ooovoucher = textvoucherencar.Text;
            enviar3.oooaddress = textaddencar.Text;
            enviar3.ooopayments = combopayments.Text;

            //message
            MessageBox.Show("Information Sent");

            textprdencar.Clear();
            textprdencar.Focus();
            textqtityencar.Clear();
            textcolorencar.Clear();
            textvoucherencar.Clear();
            textaddencar.Clear();

            enviar3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textprdencar.Clear();
            textprdencar.Focus();
            textqtityencar.Clear();
            textcolorencar.Clear();
            textvoucherencar.Clear();
            textaddencar.Clear();
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
