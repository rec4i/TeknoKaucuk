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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool CheckIsOpen(Form Form)
        {
            FormCollection fc = Application.OpenForms;
            bool isOpen = false;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == Form.Name)
                {
                    isOpen = true;
                }
            }
            return isOpen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BirinciIslevsellikForm birinciIslevsellikForm = new BirinciIslevsellikForm();
            if (!CheckIsOpen(birinciIslevsellikForm))
            {
                birinciIslevsellikForm.Show();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            IkinciIslevsellikForm ıkinciIslevsellikForm = new IkinciIslevsellikForm();
            if (!CheckIsOpen(ıkinciIslevsellikForm))
            {
                ıkinciIslevsellikForm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UcuncuIslevsellikForm ucuncuIslevsellikForm = new UcuncuIslevsellikForm();
            if (!CheckIsOpen(ucuncuIslevsellikForm))
            {
                ucuncuIslevsellikForm.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DorduncuIslevsellikForm dorduncuIslevsellikForm = new DorduncuIslevsellikForm();
            if (!CheckIsOpen(dorduncuIslevsellikForm))
            {
                dorduncuIslevsellikForm.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BesinciIslevsellikForm besinciIslevsellikForm = new BesinciIslevsellikForm();
            if (!CheckIsOpen(besinciIslevsellikForm))
            {
                besinciIslevsellikForm.Show();
            }
        }
    }



}
