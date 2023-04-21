namespace Ödev3
{
    public partial class ParaBozmaUygulamasi : Form
    {
        public ParaBozmaUygulamasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int paraMiktari;

            if (!int.TryParse(txtParaMiktari.Text, out paraMiktari))
            {
                MessageBox.Show("Lütfen geçerli bir para miktarı giriniz.");
                return;
            }

            int ikiYuzluk = 0, yuzluk = 0, ellilik = 0, yirmilik = 0, onluk = 0, beslik = 0, birlik = 0;

            while (paraMiktari > 0)
            {
                if (paraMiktari >= 200)
                {
                    ikiYuzluk++;
                    paraMiktari -= 200;
                }
                else if (paraMiktari >= 100)
                {
                    yuzluk++;
                    paraMiktari -= 100;
                }
                else if (paraMiktari >= 50)
                {
                    ellilik++;
                    paraMiktari -= 50;
                }
                else if (paraMiktari >= 20)
                {
                    yirmilik++;
                    paraMiktari -= 20;
                }
                else if (paraMiktari >= 10)
                {
                    onluk++;
                    paraMiktari -= 10;
                }
                else if (paraMiktari >= 5)
                {
                    beslik++;
                    paraMiktari -= 5;
                }
                else
                {
                    birlik++;
                    paraMiktari -= 1;
                }
            }

            lstParaAdetleri.Items.Clear();
            lstParaAdetleri.Items.Add($"200 TL: {ikiYuzluk} adet");
            lstParaAdetleri.Items.Add($"100 TL: {yuzluk} adet");
            lstParaAdetleri.Items.Add($"50 TL: {ellilik} adet");
            lstParaAdetleri.Items.Add($"20 TL: {yirmilik} adet");
            lstParaAdetleri.Items.Add($"10 TL: {onluk} adet");
            lstParaAdetleri.Items.Add($"5 TL: {beslik} adet");
            lstParaAdetleri.Items.Add($"1 TL: {birlik} adet");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrenciKayitUygulamasi ogrenciKayitUygulamasi = new OgrenciKayitUygulamasi();
            ogrenciKayitUygulamasi.Show();
            this.Hide();
        }
    }
}
