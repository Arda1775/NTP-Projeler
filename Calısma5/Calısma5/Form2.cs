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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TcNo, ad, soyad, Cinsiyet, kan, Medenihal, Ünvan;
            TcNo = textBox1.Text;
            ad = textBox2.Text;
            soyad = textBox3.Text;
            if (textBox1.TextLength != 11)
            {
                MessageBox.Show("TC no 11 den uzun olamaz");
                Form2 Form = new Form2();
                Form.Show();
                this.Hide();
            }
            Cinsiyet = "";
            if (radioButton1.Checked)
            {
                Cinsiyet = "Bay";
            }
            if (radioButton2.Checked)
            {
                Cinsiyet = "Bayan";
            }
            kan = Convert.ToString(comboBox1.SelectedItem);
            Medenihal = Convert.ToString(comboBox2.SelectedItem);
            Ünvan = Convert.ToString(comboBox3.SelectedItem);
            listBox1.Items.Add("_____PERSONEL BİLGİLERİ______");
            listBox1.Items.Add("TcNo :" + TcNo);
            listBox1.Items.Add("ad :"+ ad);
            listBox1.Items.Add("Soyad :"+ soyad);
            listBox1.Items.Add("Cınsıyet :" + Cinsiyet);
            listBox1.Items.Add("kan :" + kan);
            listBox1.Items.Add("MedeniHal :" + Medenihal);
            listBox1.Items.Add("Ünvan :" + Ünvan);
        }
    }
}