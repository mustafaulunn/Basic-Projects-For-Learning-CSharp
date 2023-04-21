using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tüm.Checked)
            {
                int baş = Convert.ToInt32(başlangıç.Text);
                int bit = Convert.ToInt32(bitiş.Text);
                int toplam = 0;
                for (int i = baş; i <= bit; i++)
                {
                    toplam += i;
                }
                label2.Text = "Toplam: " + toplam.ToString();
            }


            else if (tek.Checked)
            {
                int toplam = 0;
                int baş = Convert.ToInt32(başlangıç.Text);
                int bit = Convert.ToInt32(bitiş.Text);
                for (int i = baş; i <= bit; i++)
                {
                    if (i % 2 == 1) 
                    {
                        toplam += i;
                    }
                }
                label2.Text = "Toplam: " + toplam.ToString();

            }
            else if (çift.Checked)
            {
                int toplam = 0;
                int baş = Convert.ToInt32(başlangıç.Text);
                int bit = Convert.ToInt32(bitiş.Text);
                for (int i = baş; i <= bit; i++)
                {
                    if (i % 2 == 0)
                    {
                        toplam += i;
                    }
                }
                label2.Text = "Toplam " + toplam.ToString();
            }
        }
        
    } 
}
