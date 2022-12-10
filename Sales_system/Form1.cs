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
    public partial class Form1 : Form
    {
        //permissions
        string user = "Admin";
        string pass = "Admin12345";
        public Form1()
        {
            InitializeComponent();
        }
        //counter
        int intento = 1;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //credential validation
            if (textuser.Text == user && textpass.Text == pass) {
                Form clientes = new Form2();
                clientes.Show();
            }
            else {
                //user and password
                MessageBox.Show("Incorrect user " + intento + " Closing at 3 Attempt\nUser: Admin\nPassword: Admin12345");
                intento++;
                textuser.Clear();
                textpass.Clear();
                textuser.Focus();
            }
            if (intento == 4) {
                MessageBox.Show("Limit reached");
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
