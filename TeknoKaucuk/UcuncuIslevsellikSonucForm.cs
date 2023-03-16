using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeknoKaucuk
{
    public partial class UcuncuIslevsellikSonucForm : Form
    {
        public UcuncuIslevsellikSonucForm(int Deger)
        {
            InitializeComponent();
            SetupGridView(Deger);
        }
        private void SetupGridView(int Deger_1)
        {
            int loc_X = 15;
            int loc_Y = 50;
            this.Controls.Add(
                    new Label
                    {
                        Location = new Point(loc_X, loc_Y),
                        Size = new System.Drawing.Size(30, 18),
                        Text = "0"
                    });

            for (int i = 0; i <= Deger_1; i++)
            {
                this.Controls.Add(
                    new Label
                    {
                        Location = new Point(loc_X, loc_Y),
                        Size = new System.Drawing.Size(30, 18),
                        Text = i.ToString()
                    }); ;
                loc_X = loc_X + 35;
            }
            loc_X = 15;
            for (int i = 0; i <= Deger_1; i++)
            {
                loc_X = 15;
                this.Controls.Add(
                   new Label
                   {
                       Location = new Point(loc_X, loc_Y),
                       Size = new System.Drawing.Size(30, 18),
                       Text = i.ToString()
                   }); ;
                for (int j = 0; j <= Deger_1; j++)
                {
                    this.Controls.Add(
                    new Label
                    {
                        Location = new Point(loc_X, loc_Y),
                        Size = new System.Drawing.Size(30, 18),
                        Text = (i * j).ToString()
                    }); ;
                    loc_X = loc_X + 35;
                }
                loc_Y = loc_Y + 25;
            }

            this.Size = new System.Drawing.Size(loc_X + 35, loc_Y + 50);





        }
    }
}
