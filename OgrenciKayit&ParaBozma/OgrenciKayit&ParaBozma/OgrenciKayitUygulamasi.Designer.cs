namespace Ödev3
{
    partial class OgrenciKayitUygulamasi
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            öğrencinot = new TextBox();
            öğrenciadt = new TextBox();
            groupBox2 = new GroupBox();
            silb = new Button();
            temizleb = new Button();
            ekleb = new Button();
            groupBox3 = new GroupBox();
            label1 = new Label();
            listBoxn = new ListBox();
            listBoxö = new ListBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(öğrencinot);
            groupBox1.Controls.Add(öğrenciadt);
            groupBox1.Location = new Point(35, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(227, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Bilgileri Girişi";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 62);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 2;
            label3.Text = "Öğrenci Numarası:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 33);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "Öğrenci Adı:";
            // 
            // öğrencinot
            // 
            öğrencinot.Location = new Point(121, 59);
            öğrencinot.Name = "öğrencinot";
            öğrencinot.Size = new Size(100, 23);
            öğrencinot.TabIndex = 1;
            // 
            // öğrenciadt
            // 
            öğrenciadt.Location = new Point(121, 30);
            öğrenciadt.Name = "öğrenciadt";
            öğrenciadt.Size = new Size(100, 23);
            öğrenciadt.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(silb);
            groupBox2.Controls.Add(temizleb);
            groupBox2.Controls.Add(ekleb);
            groupBox2.Location = new Point(443, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(257, 124);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "İşlemler";
            // 
            // silb
            // 
            silb.Location = new Point(116, 62);
            silb.Name = "silb";
            silb.Size = new Size(117, 45);
            silb.TabIndex = 0;
            silb.Text = "Kayıt Sil";
            silb.UseVisualStyleBackColor = true;
            silb.Click += silb_Click;
            // 
            // temizleb
            // 
            temizleb.Location = new Point(6, 62);
            temizleb.Name = "temizleb";
            temizleb.Size = new Size(104, 45);
            temizleb.TabIndex = 0;
            temizleb.Text = "Kayıtları Temizle";
            temizleb.UseVisualStyleBackColor = true;
            temizleb.Click += temizleb_Click;
            // 
            // ekleb
            // 
            ekleb.Location = new Point(61, 11);
            ekleb.Name = "ekleb";
            ekleb.Size = new Size(114, 45);
            ekleb.TabIndex = 0;
            ekleb.Text = "Öğrenci Ekle";
            ekleb.UseVisualStyleBackColor = true;
            ekleb.Click += ekleb_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(listBoxn);
            groupBox3.Controls.Add(listBoxö);
            groupBox3.Location = new Point(241, 212);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(338, 194);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Öğrenci Kayıtları";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 134);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 2;
            label1.Text = "Toplam Kayıt Sayısı: 0";
            label1.Click += label1_Click;
            // 
            // listBoxn
            // 
            listBoxn.FormattingEnabled = true;
            listBoxn.ItemHeight = 15;
            listBoxn.Location = new Point(212, 22);
            listBoxn.Name = "listBoxn";
            listBoxn.Size = new Size(120, 94);
            listBoxn.TabIndex = 1;
            listBoxn.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // listBoxö
            // 
            listBoxö.FormattingEnabled = true;
            listBoxö.ItemHeight = 15;
            listBoxö.Location = new Point(6, 22);
            listBoxö.Name = "listBoxö";
            listBoxö.Size = new Size(120, 94);
            listBoxö.TabIndex = 0;
            listBoxö.SelectedIndexChanged += listBoxö_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(631, 368);
            button1.Name = "button1";
            button1.Size = new Size(148, 55);
            button1.TabIndex = 3;
            button1.Text = "Para Bozma Uygulaması";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OgrenciKayitUygulamasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "OgrenciKayitUygulamasi";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox öğrencinot;
        private TextBox öğrenciadt;
        private GroupBox groupBox2;
        private Button silb;
        private Button temizleb;
        private Button ekleb;
        private GroupBox groupBox3;
        private ListBox listBoxn;
        private ListBox listBoxö;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button button1;
    }
}