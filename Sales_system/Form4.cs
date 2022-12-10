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
    public partial class Form4 : Form
    {
        //sending data
        Form5 enviar2 = new Form5();
        public Form4()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            enviar2.s_name = textprovee.Text;
            enviar2.s_company = textcompany.Text;
            enviar2.s_codep = textcode.Text;
            enviar2.s_mailp = textemailpro.Text;
            enviar2.s_productp = textproducto.Text;
            enviar2.s_quantityp = textcantidad.Text;
            enviar2.s_datep = textdate.Text;
            enviar2.s_pricep = textprecio.Text;

            MessageBox.Show("Information Sent");
            //clean
            textprovee.Clear();
            textprovee.Focus();
            textcompany.Clear();
            textcode.Clear();
            textemailpro.Clear();
            textproducto.Clear();
            textcantidad.Clear();
            textdate.Clear();
            textprecio.Clear();

            enviar2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textprovee.Clear();
            textprovee.Focus();
            textcompany.Clear();
            textcode.Clear();
            textemailpro.Clear();
            textproducto.Clear();
            textcantidad.Clear();
            textdate.Clear();
            textprecio.Clear();
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
