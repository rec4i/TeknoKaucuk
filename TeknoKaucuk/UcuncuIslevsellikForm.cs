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
    public partial class UcuncuIslevsellikForm : Form
    {
        public UcuncuIslevsellikForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Deger_1;
            if (int.TryParse(textBox1.Text, out Deger_1))
            {
                if (Deger_1 < 0)
                {
                    MessageBox.Show("Lütfen 0 Dan Büyük Bir Sayı Giriniz");
                    return;
                }
                if (Deger_1 > 15)
                {
                    MessageBox.Show("Lütfen 15'den Küçük Bir Sayı Giriniz");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Lütfen Bir Sayı Giriniz");
                return;
            }



            UcuncuIslevsellikSonucForm ucuncuIslevsellikSonucForm = new UcuncuIslevsellikSonucForm(Convert.ToInt32(Deger_1));
            ucuncuIslevsellikSonucForm.Show();


        }


    }
}
