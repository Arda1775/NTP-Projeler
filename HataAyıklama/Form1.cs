﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataAyıklama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = 10;
                int sonuc = sayi / 0;
            }
            catch (System.DivideByZeroException ex)//Sıfıra Bölünme durumunda kullanılan hata
            {
                MessageBox.Show("Sayı Sıfıra Bölünemez :" + ex.Message);
                
            }
        }
    }
}
