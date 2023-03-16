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
    public partial class BesinciIslevsellikForm : Form
    {
        public BesinciIslevsellikForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int writedValue;
            if (!int.TryParse(textBox1.Text, out writedValue))
            {
                MessageBox.Show("Lütfen Bir Sayı Giriniz!");
                return;
            }

            if (writedValue == 0)
            {
                MessageBox.Show($"Fibonacci Dizisindeki Bir Sonraki Sayı {0} ");
                return;
            }
            if (writedValue == 1)
            {
                MessageBox.Show($"Fibonacci Dizisindeki Bir Sonraki Sayı {1} ");
                return;
            }
            int x = 0;
            int y = 1;
            int currentValue = 0;
            for (int i = 3; i <= writedValue; i++)
            {
                int z = x + y;
                currentValue = z;
                x = y;
                y = z;
            }
            MessageBox.Show($"Fibonacci Dizisindeki Bir Sonraki Sayı {currentValue} ");
        }
    }
}
