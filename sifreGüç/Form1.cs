using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifreGüç
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            if (radioButton1.Checked)
            {
                sonuc = sayi1 + sayi2;
            }
            else if (radioButton2.Checked)
            {
                sonuc = sayi1 - sayi2;
            }
            else if (radioButton3.Checked)
            {
                sonuc = sayi1 * sayi2;
            }
            else
            {
                sonuc = sayi1 / sayi2;
            }

            textBox3.Text = sonuc.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int karakter = textBox5.Text.Length;
            if (karakter > 0 && karakter < 4)
            {
                progressBar1.Value = 1;
                progressBar1.ForeColor = Color.Red;
                label6.Text = "Zayıf";
            }
            else if (karakter >= 4 && karakter < 8)
            {
                progressBar1.Value = 2;
                progressBar1.ForeColor = Color.Yellow;
                label6.Text = "Orta";
            }
            else if (karakter >=8)
            {
                progressBar1.Value = 3;
                progressBar1.ForeColor = Color.Green;
                label6.Text = "Güçlü";
            }
            else
            {
                progressBar1.Value = 0;
            }
        }
    }
}