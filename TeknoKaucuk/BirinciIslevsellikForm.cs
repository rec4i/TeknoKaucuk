using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknoKaucuk
{
    public partial class BirinciIslevsellikForm : Form
    {
        public BirinciIslevsellikForm()
        {
            InitializeComponent();
            textBox4.ReadOnly = true;
        }



        private void SonucuGosterBtn_Click(object sender, EventArgs e)
        {
            double BirinciDeger;
            if (!Double.TryParse(textBox1.Text, out BirinciDeger))
            {
                MessageBox.Show("Lütfen 1. Girdiğiniz Değeri Kontrol Ediniz !");
                return;
            }

            double IkinciDeger;
            if (!Double.TryParse(textBox2.Text, out IkinciDeger))
            {
                MessageBox.Show("Lütfen 2. Girdiğiniz Değeri Kontrol Ediniz !");
                return;
            }

            double UcuncuDeger;
            if (!Double.TryParse(textBox3.Text, out UcuncuDeger))
            {

                MessageBox.Show("Lütfen 3. Girdiğiniz Değeri Kontrol Ediniz !");
                return;
            }



            var sonuc = (BirinciDeger + IkinciDeger) * UcuncuDeger;
            textBox4.Text = sonuc.ToString();

        }
    }
}
