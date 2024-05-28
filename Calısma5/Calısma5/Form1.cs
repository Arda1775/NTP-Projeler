using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calısma5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanıcıAdı, şifre;
            kullanıcıAdı = textBox1.Text;
            şifre = textBox1.Text;
            if (kullanıcıAdı == "evin" || kullanıcıAdı == "Evin" || kullanıcıAdı == "EVİN" && şifre == "")
            {
                Form2 Form = new Form2();
                Form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Başarısız Giriş");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar='*';

        }
    }
}