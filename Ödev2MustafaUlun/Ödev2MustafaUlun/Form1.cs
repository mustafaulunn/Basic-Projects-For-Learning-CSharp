namespace Ödev2MustafaUlun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void temizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void elek_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(textBox1.Text);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int randomIndex = random.Next(listBox1.Items.Count);
                listBox1.Items.Add(randomIndex);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sırala_Click(object sender, EventArgs e)
        {

        }

        private void göster_Click(object sender, EventArgs e)
        {
            textBox2.Text = listBox1.SelectedItem.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void say_Click(object sender, EventArgs e)
        {
            int count = listBox1.Items.Count;
            textBox2.Text = count.ToString();
        }
    }
}