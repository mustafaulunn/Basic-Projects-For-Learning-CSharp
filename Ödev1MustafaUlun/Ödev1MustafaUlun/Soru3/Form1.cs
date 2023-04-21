using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int j = 0; j < 10; j++) { listBox1.Items.Add(random.Next(1, 100000)); }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Maksimum Değer")
            {
                int max = int.MinValue;
                foreach (int item in listBox1.Items)
                {
                    if (item > max)
                        max = item;
                }
                label1.Text=("En Büyük Değer: " + max);
            }

            else if (comboBox1.SelectedItem == "Ortalama Değer")
            {
                int sum = 0;
                foreach (int item in listBox1.Items)
                {
                    sum += item;
                }
                double avg = (double)sum / listBox1.Items.Count;
                label1.Text=("Değerlerin Ortalaması: " + avg.ToString("0.00"));
            }
            else if (comboBox1.SelectedItem == "En Büyük ile En Küçüğün Farkı")
            {
                int max = int.MinValue;
                int min = int.MaxValue;
                foreach (int item in listBox1.Items)
                {
                    if (item > max)
                        max = item;
                    if (item < min)
                        min = item;
                }
                int diff = max - min;
                label1.Text=("En Büyük Değerle En Küçük Değerin Farkı: " + diff);
            }
            else if (comboBox1.SelectedItem == "Minimum Değer")
            {
                int min = int.MaxValue;
                foreach (int item in listBox1.Items)
                {
                    if (item < min)
                        min = item;
                }
                label1.Text=("En Düşük Değer: " + min);
            }

        }
    }
}


