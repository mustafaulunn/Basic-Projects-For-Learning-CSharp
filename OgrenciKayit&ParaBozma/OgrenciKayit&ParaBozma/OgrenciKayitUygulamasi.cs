using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Ödev3
{
    public partial class OgrenciKayitUygulamasi : Form
    {
        public OgrenciKayitUygulamasi()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ekleb_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(öğrenciadt.Text) | string.IsNullOrEmpty(öğrencinot.Text))
            {

                MessageBox.Show("Lütfen her iki değeri de girin.");
            }
            else
            {
                listBoxö.Items.Add(öğrenciadt.Text);
                listBoxn.Items.Add(öğrencinot.Text);
                ListboxKayitSayisiGuncelle();
            }
        }

        private void silb_Click(object sender, EventArgs e)
        {
            string arananAd = öğrenciadt.Text.ToLower();
            string arananNumara = öğrencinot.Text;
            int index = -1;
            for (int i = 0; i < listBoxö.Items.Count; i++)
            {
                string ad = listBoxö.Items[i].ToString().ToLower();
                string numara = listBoxn.Items[i].ToString();
                if (ad.Contains(arananAd) && numara == arananNumara)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                listBoxö.Items.RemoveAt(index);
                listBoxn.Items.RemoveAt(index);
                ListboxKayitSayisiGuncelle();
                MessageBox.Show("Kayıt silindi!");
            }
            else // eğer kayıt bulunamadıysa
            {
                MessageBox.Show("Kayıt bulunamadı!");
            }
        }

        private void temizleb_Click(object sender, EventArgs e)
        {
            listBoxö.Items.Clear();
            listBoxn.Items.Clear();
            ListboxKayitSayisiGuncelle();

        }
        private void ListboxKayitSayisiGuncelle()
        {
            label1.Text = "Toplam Kayıt Sayısı: " + listBoxö.Items.Count.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Toplam Kayıt Sayısı: " + listBoxö.Items.Count.ToString();
        }

        private void listBoxö_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListboxKayitSayisiGuncelle();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParaBozmaUygulamasi ParaBozmaUygulamasi = new ParaBozmaUygulamasi();


            ParaBozmaUygulamasi.Show();


            this.Hide();
        }
    }
}

