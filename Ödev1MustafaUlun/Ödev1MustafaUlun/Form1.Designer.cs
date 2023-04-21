namespace Ödev1MustafaUlun
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.birimt = new System.Windows.Forms.TextBox();
            this.adett = new System.Windows.Forms.TextBox();
            this.vergit = new System.Windows.Forms.TextBox();
            this.indirim = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.biriml = new System.Windows.Forms.Label();
            this.vergi = new System.Windows.Forms.Label();
            this.adet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // birimt
            // 
            this.birimt.Location = new System.Drawing.Point(361, 61);
            this.birimt.Name = "birimt";
            this.birimt.Size = new System.Drawing.Size(100, 20);
            this.birimt.TabIndex = 1;
            // 
            // adett
            // 
            this.adett.Location = new System.Drawing.Point(361, 98);
            this.adett.Name = "adett";
            this.adett.Size = new System.Drawing.Size(100, 20);
            this.adett.TabIndex = 2;
            // 
            // vergit
            // 
            this.vergit.Location = new System.Drawing.Point(361, 143);
            this.vergit.Name = "vergit";
            this.vergit.Size = new System.Drawing.Size(100, 20);
            this.vergit.TabIndex = 3;
            // 
            // indirim
            // 
            this.indirim.AutoSize = true;
            this.indirim.Location = new System.Drawing.Point(361, 187);
            this.indirim.Name = "indirim";
            this.indirim.Size = new System.Drawing.Size(79, 17);
            this.indirim.TabIndex = 4;
            this.indirim.Text = "İndirim (%5)";
            this.indirim.UseVisualStyleBackColor = true;
            this.indirim.CheckedChanged += new System.EventHandler(this.indirim_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ödenecek Tutar:";
            // 
            // biriml
            // 
            this.biriml.AutoSize = true;
            this.biriml.Location = new System.Drawing.Point(301, 64);
            this.biriml.Name = "biriml";
            this.biriml.Size = new System.Drawing.Size(54, 13);
            this.biriml.TabIndex = 5;
            this.biriml.Text = "Birim Fiyat";
            // 
            // vergi
            // 
            this.vergi.AutoSize = true;
            this.vergi.Location = new System.Drawing.Point(277, 150);
            this.vergi.Name = "vergi";
            this.vergi.Size = new System.Drawing.Size(78, 13);
            this.vergi.TabIndex = 5;
            this.vergi.Text = "Vergi Tutarı (%)";
            // 
            // adet
            // 
            this.adet.AutoSize = true;
            this.adet.Location = new System.Drawing.Point(301, 105);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(29, 13);
            this.adet.TabIndex = 6;
            this.adet.Text = "Adet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adet);
            this.Controls.Add(this.vergi);
            this.Controls.Add(this.biriml);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.indirim);
            this.Controls.Add(this.vergit);
            this.Controls.Add(this.adett);
            this.Controls.Add(this.birimt);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox birimt;
        private System.Windows.Forms.TextBox adett;
        private System.Windows.Forms.TextBox vergit;
        private System.Windows.Forms.CheckBox indirim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label biriml;
        private System.Windows.Forms.Label vergi;
        private System.Windows.Forms.Label adet;
    }
}

