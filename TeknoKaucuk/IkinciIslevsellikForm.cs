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
    public partial class IkinciIslevsellikForm : Form
    {
        public IkinciIslevsellikForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 200; i++)
            {
                if ((i % 5 == 0) && (i % 3 == 0))
                {
                    if (i < 100)
                        listBox1.Items.Add("zigzag");
                    else
                        listBox1.Items.Add("zagzig");

                    continue;
                }
                if (i % 3 == 0)
                {
                    listBox1.Items.Add("zig");
                    continue;
                }
                if (i % 5 == 0)
                {
                    listBox1.Items.Add("zag");
                    continue;
                }
               

                listBox1.Items.Add(i);


            }
        }
    }
}
