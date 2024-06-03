using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgiİslem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int not;
            not = Convert.ToInt16(textBox1.Text);
            if (not >= 85 && not <= 100)
            {
                MessageBox.Show("Takdir Belgesi Almaya Hak Kazandınız.");
            }
            else if (not >= 70 && not < 85) 
            {
                MessageBox.Show("Teşekkür Belgesi Almaya Hak Kazandınız.");
            }
            
             else if (not >= 50 && not < 70) 
            {
                MessageBox.Show("Belgesiz Sınıf Geçtiniz");
            }
            else if (not >= 0 && not < 50) 
            {
                MessageBox.Show("Sınıfta Kaldınız");
            }
            else if (not>100)
            {
                MessageBox.Show("Geçersiz Sayı Girdiniz");
            }
            else if (not<0)
            {
                MessageBox.Show("Geçersiz Sayı Girdiniz");
            }
        }
    }
}
