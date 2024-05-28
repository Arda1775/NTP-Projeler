using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmacaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        string secilen;
        string acilan;
        string temp;
        int hata = 0;
        int harfLimiti = 10;
        int joker = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            gameStart();
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void gameStart()
        {
            hata = -1;
            cinAliCiz();
            acilan = "";
            hata = 0;
            harfLimiti = 10;
            label2.Text = "HATA:" + hata.ToString();
            label3.Text = "HARF LİMİTİ:" + harfLimiti.ToString();

            String[] words =
            {
                "ATATÜRK",
                "BİLGİSAYAR",
                "FARE",
                "AĞ",
                "KABLO",
                "DOLAP",
                "FENERBAHÇE"
            };
            secilen = words[rd.Next(0, words.Length)];

            label1.Text = "";
            for (int i = 0; i < secilen.Length; i++)
            {
                label1.Text += "_";
                acilan += ' ';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") harfKontrol();
        }

        private void harfkontrol()
        {
            char harf = Convert.ToChar(textBox1.Text);
            if (secilen.Contains(harf))
            {
                label1.Text = "";
                for (int i = 0; i < secilen.Length; i++)
                {
                    if (secilen[i] == harf)
                    {
                        label1.Text += harf + " ";
                        yerlestir(i, harf);
                    }
                    else if (acilan[i] != ' ')
                    {
                        label1.Text += acilan[i] + "";
                    }
                    else
                    {
                        label1.Text += "_";
                    }
                }
            }
            else
            {
                hata++;
                label2.Text = "HATA:" + hata.ToString();
                cinAliCiz();
            }

            harfLimiti--;
            label3.Text = "HARF LİMİTİ:" + harfLimiti.ToString();
            oyunBittiMi();
            textBox1.Clear();
        }
        public void oyunBittiMi()
        {
            if (hata >= 10)
            {
                MessageBox.Show("OYUNU KAYBETTİNİZ");
                gameStart();
            }
            else
            {
                if (secilen == acilan)
                {
                    if (harfLimiti >= 0)
                    {
                        joker++;
                        button4.Enabled = true;
                    }
                    label4.Text = "JOKER:" + joker;
                    MessageBox.Show("Kazandınız Tebrikler!\nHata Sayısı:" + hata.ToString());
                    gameStart();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == secilen)
            {
                joker++;
                button4.Enabled = true;
            }
            label4.Text = "JOKER" + joker;
            MessageBox.Show("Kazandınız Tebrikler!\bHata Sayısı" + hata.ToString());
            gameStart();
            {
                else
            }
            while (hata !=10)
            {
                hata++;
                cinAliCiz();

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
    label2.Text="HATA:"+hata.Tostring();
            oyunBittiMi();
        }
        textbox2.Clear();
    }


    private void cinAliCiz()
    {
           Graphics g = this.CreateGraphics();
           Pen p = new Pen(Color.Black, 5);
           if hata = 0;
           }
           if(hata == 1)g.DrawLine(p,500,400,650,400);
           else if (hata == 2)g.DrawLine(p,525,400,525,200);
           else if (hata == 3)g.DrawLine(p,525,200,575,200);
           else if (hata == 4)g.DrawLine(p,575,200,575,220);
           else if (hata == 5)g.DrawEllipse(p,560,220,30,30);
           else if (hata == 6)g.DrawLine(p,575,250,575,330);
           else if (hata == 7)g.DrawLine(p,575,250,545,280);
           else if (hata == 8)g.DrawLine(p,575,250,605,280);
           else if (hata == 9)g.DrawLine(p,575,325,545,355);
           else if (hata == 3)g.DrawLine(p,575,325,605,355);
    }

    private void yerlestir(int indis,char a)
    {
        temp = acılan;
        acılan = "";
        for (int i =0;i<temp.lenght;i++)
        {
        if (i == indis) acilan += a;
        else acilan += temp[i];
        }
    }
