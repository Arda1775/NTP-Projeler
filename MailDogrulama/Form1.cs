using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailDogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Kullanici_adi;
            Kullanici_adi = textBox1.Text;
            if (Kullanici_adi == "milliegitim@meb.k12.tr")
            {
                MessageBox.Show("Kullanıcı sisteme kayıtlıdır.");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız yanlıştır");
            }
        }
    }
}
