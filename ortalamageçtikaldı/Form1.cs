using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortalamageçtikaldı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Byte ortalama, devamsizlik;
            ortalama = Convert.ToByte(textBox1.Text);
            devamsizlik = Convert.ToByte(textBox2.Text);
            if (ortalama > 49 && devamsizlik < 30)
            {
                label4.Text = "geçtiniz!";
            }
            else
            {
                label4.Text= "kaldınız! ";   
            }
        }
    }
}
