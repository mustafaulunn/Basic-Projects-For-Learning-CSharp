namespace Ödev2MustafaUlun
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            temizle = new Button();
            elek = new Button();
            göster = new Button();
            sırala = new Button();
            say = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(275, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(467, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // temizle
            // 
            temizle.Location = new Point(177, 175);
            temizle.Name = "temizle";
            temizle.Size = new Size(75, 23);
            temizle.TabIndex = 2;
            temizle.Text = "Temizle";
            temizle.UseVisualStyleBackColor = true;
            temizle.Click += temizle_Click;
            // 
            // elek
            // 
            elek.Location = new Point(258, 175);
            elek.Name = "elek";
            elek.Size = new Size(88, 23);
            elek.TabIndex = 2;
            elek.Text = "Eleman Ekle";
            elek.UseVisualStyleBackColor = true;
            elek.Click += elek_Click;
            // 
            // göster
            // 
            göster.Location = new Point(433, 175);
            göster.Name = "göster";
            göster.Size = new Size(134, 23);
            göster.TabIndex = 2;
            göster.Text = "Seçili Elemanı Göster";
            göster.UseVisualStyleBackColor = true;
            göster.Click += göster_Click;
            // 
            // sırala
            // 
            sırala.Location = new Point(352, 175);
            sırala.Name = "sırala";
            sırala.Size = new Size(75, 23);
            sırala.TabIndex = 2;
            sırala.Text = "Sırala";
            sırala.UseVisualStyleBackColor = true;
            sırala.Click += sırala_Click;
            // 
            // say
            // 
            say.Location = new Point(573, 175);
            say.Name = "say";
            say.Size = new Size(75, 23);
            say.TabIndex = 2;
            say.Text = "Say";
            say.UseVisualStyleBackColor = true;
            say.Click += say_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(70, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 50);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 4;
            label1.Text = "Sayı Ekle:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 55);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Sonuç:";
            label2.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(sırala);
            Controls.Add(say);
            Controls.Add(göster);
            Controls.Add(elek);
            Controls.Add(temizle);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button temizle;
        private Button elek;
        private Button göster;
        private Button sırala;
        private Button say;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
    }
}