using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quiz1 = Convert.ToInt32(quizt.Text);
            int quiz2 = Convert.ToInt32(quiz1t.Text);
            int quiz3 = Convert.ToInt32(quiz2t.Text);
            int quiz4 = Convert.ToInt32(quiz3t.Text);
            int quiz5 = Convert.ToInt32(quiz4t.Text);
            int midterm = Convert.ToInt32(midt.Text);
            int final = Convert.ToInt32(finalt.Text);
            int devam = Convert.ToInt32(derst.Text);

            double quizAgırlık = Convert.ToDouble(QuizAgırlık.Text);
            double midtermAgırlık = Convert.ToDouble(MidtermAgırlık.Text);
            double finalAgırlık = Convert.ToDouble(FinalAgırlık.Text);
            double devamAgırlık = Convert.ToDouble(DevamAgırlık.Text);

            double ağırlıklıPuan = (quiz1 * quizAgırlık / 100) + (quiz2 * quizAgırlık / 100)+ (quiz3 * quizAgırlık / 100)+ (quiz4 * quizAgırlık / 100)+ (quiz5 * quizAgırlık / 100) + (midterm * midtermAgırlık / 100) + (final * finalAgırlık / 100) + (devam * devamAgırlık / 100);
            label5.Text = "Ağırlıklı Puanın" + ağırlıklıPuan.ToString();

        }
    }
}
