namespace Soru2
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
            this.tüm = new System.Windows.Forms.RadioButton();
            this.tek = new System.Windows.Forms.RadioButton();
            this.çift = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.başlangıç = new System.Windows.Forms.TextBox();
            this.bitiş = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tüm
            // 
            this.tüm.AutoSize = true;
            this.tüm.Location = new System.Drawing.Point(90, 35);
            this.tüm.Name = "tüm";
            this.tüm.Size = new System.Drawing.Size(52, 17);
            this.tüm.TabIndex = 0;
            this.tüm.TabStop = true;
            this.tüm.Text = "Tümü";
            this.tüm.UseVisualStyleBackColor = true;
            // 
            // tek
            // 
            this.tek.AutoSize = true;
            this.tek.Location = new System.Drawing.Point(303, 35);
            this.tek.Name = "tek";
            this.tek.Size = new System.Drawing.Size(44, 17);
            this.tek.TabIndex = 1;
            this.tek.TabStop = true;
            this.tek.Text = "Tek";
            this.tek.UseVisualStyleBackColor = true;
            // 
            // çift
            // 
            this.çift.AutoSize = true;
            this.çift.Location = new System.Drawing.Point(486, 35);
            this.çift.Name = "çift";
            this.çift.Size = new System.Drawing.Size(40, 17);
            this.çift.TabIndex = 2;
            this.çift.TabStop = true;
            this.çift.Text = "Çift";
            this.çift.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // başlangıç
            // 
            this.başlangıç.Location = new System.Drawing.Point(303, 86);
            this.başlangıç.Name = "başlangıç";
            this.başlangıç.Size = new System.Drawing.Size(100, 20);
            this.başlangıç.TabIndex = 4;
            // 
            // bitiş
            // 
            this.bitiş.Location = new System.Drawing.Point(303, 112);
            this.bitiş.Name = "bitiş";
            this.bitiş.Size = new System.Drawing.Size(100, 20);
            this.bitiş.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Başlangıç:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Toplam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bitiş:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitiş);
            this.Controls.Add(this.başlangıç);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.çift);
            this.Controls.Add(this.tek);
            this.Controls.Add(this.tüm);
            this.Name = "Form1";
            this.Text = "Soru2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton tüm;
        private System.Windows.Forms.RadioButton tek;
        private System.Windows.Forms.RadioButton çift;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox başlangıç;
        private System.Windows.Forms.TextBox bitiş;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

