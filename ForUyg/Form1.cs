using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kere;
            kere = Convert.ToInt16(textBox2.Text);
            for (int i = 0 ; i < kere ; i++)
            {
                listBox1.Items.Add(textBox1.Text);
            }
        }
    }
}