using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınıfgecme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            short sayi1;
            sayi1 = Convert.ToInt16(textBox1.Text);
            if (sayi1 >=50 && sayi1 <=100 )
            {
                MessageBox.Show("Sınıfı Geçtiniz");
            }
            if (sayi1 <50 && sayi1 >=10 )
                {
                MessageBox.Show("sınıfı sorunlu geçtiniz");
            }
            if (sayi1<10)
            {
                MessageBox.Show("Sınıfta kaldınız");
            }
            else
            {
                MessageBox.Show("geçerli bir sayı giriniz");
            }
        }
    }
}
