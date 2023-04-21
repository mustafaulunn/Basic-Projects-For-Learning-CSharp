using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ödev1MustafaUlun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int birim = Convert.ToInt32(birimt.Text);
            int miktar = Convert.ToInt32(adett.Text);
            double vergi = Convert.ToDouble(vergit.Text);
            double vergiM = vergi / 100;
            


            double toplamfiyat;
            if (indirim.Checked)
            {
                toplamfiyat = birim * miktar * (1 + vergiM) * 0.95;
            }

            else
            {
                toplamfiyat = birim * miktar * (1 + vergiM);
            }

            
            label1.Text = "Ödenecek Tutar: " + toplamfiyat.ToString();
        }

        private void indirim_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

