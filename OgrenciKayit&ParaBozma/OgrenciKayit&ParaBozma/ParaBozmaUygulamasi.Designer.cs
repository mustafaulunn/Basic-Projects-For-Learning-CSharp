namespace Ödev3
{
    partial class ParaBozmaUygulamasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            lstParaAdetleri = new ListBox();
            txtParaMiktari = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(102, 205);
            button1.Name = "button1";
            button1.Size = new Size(91, 36);
            button1.TabIndex = 0;
            button1.Text = "Miktarı Ayır";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstParaAdetleri
            // 
            lstParaAdetleri.FormattingEnabled = true;
            lstParaAdetleri.ItemHeight = 15;
            lstParaAdetleri.Location = new Point(199, 22);
            lstParaAdetleri.Name = "lstParaAdetleri";
            lstParaAdetleri.Size = new Size(120, 169);
            lstParaAdetleri.TabIndex = 1;
            // 
            // txtParaMiktari
            // 
            txtParaMiktari.Location = new Point(93, 41);
            txtParaMiktari.Name = "txtParaMiktari";
            txtParaMiktari.Size = new Size(100, 23);
            txtParaMiktari.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtParaMiktari);
            groupBox1.Controls.Add(lstParaAdetleri);
            groupBox1.Location = new Point(249, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 283);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Para Bozdur";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 3;
            label1.Text = "Miktar Giriniz:";
            // 
            // button2
            // 
            button2.Location = new Point(654, 392);
            button2.Name = "button2";
            button2.Size = new Size(134, 46);
            button2.TabIndex = 4;
            button2.Text = "Öğrenci Kayıt Uygulaması";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ParaBozmaUygulamasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Name = "ParaBozmaUygulamasi";
            Text = "ParaBozmaUygulamasi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox lstParaAdetleri;
        private TextBox txtParaMiktari;
        private GroupBox groupBox1;
        private Label label1;
        private Button button2;
    }
}