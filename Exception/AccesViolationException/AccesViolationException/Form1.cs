using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesViolationException
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

                int[] dizi = null;
                MessageBox.Show(""+dizi[0]);
                throw new AccessViolationException("Bu Özel Bir AccessViolationException Hatası !!");
            }
            catch(AccessViolationException ex)
            {
                MessageBox.Show("AccessViolationException Yakalandı"+ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Beklenmeyen Bir Hata Oluştu" + ex.Message);
            }
        }
    }
}
