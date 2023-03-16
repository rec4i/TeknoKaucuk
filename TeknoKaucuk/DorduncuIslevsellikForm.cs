using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknoKaucuk
{
    public partial class DorduncuIslevsellikForm : Form
    {

        public DorduncuIslevsellikForm()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }



        private void DosyaSeçBtn_Click(object sender, EventArgs e)
        {
            string fileToOpen = "";
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                fileToOpen = FD.FileName;
            if (fileToOpen == "")
            {
                MessageBox.Show("Lütfen Dosya Seçiniz");
                return;
            }
            textBox1.Text = fileToOpen;
            string readText = File.ReadAllText(fileToOpen);
            List<Decimal> values = new List<decimal>();
            foreach (var item in readText.Split(null))
            {
                if (!item.ToCharArray().Any(x => !Char.IsWhiteSpace(x)))
                    continue;
                decimal value;
                if (!decimal.TryParse(item, out value))
                {
                    MessageBox.Show($"'{item}' Değeri Decimal tipine çevirilemedi. ");
                }
                values.Add(value);
            }
            values = values.OrderByDescending(x => x).ToList();
            listBox1.DataSource = values;


        }
    }
}
