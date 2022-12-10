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
    public partial class Form2 : Form
    {
        //sending data
        Form3 enviar = new Form3();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            enviar.pname = textname.Text;
            enviar.plastname = textlastname.Text;
            enviar.pdni = textdni.Text;
            enviar.pphone = textnumber.Text;
            enviar.pmail = textmail.Text;
            enviar.paddress = textaddres.Text;
            enviar.page = textage.Text;
            enviar.pstatus = textstatus.Text;
            MessageBox.Show("Information Sent");
            //clean
            textname.Clear();
            textname.Focus();
            textlastname.Clear();
            textdni.Clear();
            textnumber.Clear();
            textmail.Clear();
            textaddres.Clear();
            textage.Clear();
            textstatus.Clear();

            enviar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //data cleaning
            textname.Clear();
            textname.Focus();
            textlastname.Clear();
            textdni.Clear();
            textnumber.Clear();
            textmail.Clear();
            textaddres.Clear();
            textage.Clear();
            textstatus.Clear();

        }

        private void providersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form shpp = new Form6();
            shpp.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form facturacion = new Form8();
            //facturacion.Show();
        }
    }
}
