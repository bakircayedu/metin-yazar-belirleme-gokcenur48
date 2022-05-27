
namespace metin_yazar_210601694
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArananKelime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKelimeSirasi = new System.Windows.Forms.TextBox();
            this.btnHash = new System.Windows.Forms.Button();
            this.btnHashKelimeAra = new System.Windows.Forms.Button();
            this.txtCumlenumarasi = new System.Windows.Forms.TextBox();
            this.buttontree = new System.Windows.Forms.Button();
            this.txtMetininBilgiler = new System.Windows.Forms.TextBox();
            this.buttonStack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDosya = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.EnCokKullanilanKelimeler = new System.Windows.Forms.ListBox();
            this.lblKelimeSayisi = new System.Windows.Forms.Label();
            this.txtGirilenKelimeSayisi = new System.Windows.Forms.TextBox();
            this.btnKelimeleriGoster = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 665);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.buttontree);
            this.tabPage1.Controls.Add(this.txtMetininBilgiler);
            this.tabPage1.Controls.Add(this.buttonStack);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TxtDosya);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(699, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Metini Girme";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtArananKelime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtKelimeSirasi);
            this.groupBox1.Controls.Add(this.btnHash);
            this.groupBox1.Controls.Add(this.btnHashKelimeAra);
            this.groupBox1.Controls.Add(this.txtCumlenumarasi);
            this.groupBox1.Location = new System.Drawing.Point(17, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 387);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hash Tablo Uygulamaları";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Aranan Kelime: ";
            // 
            // txtArananKelime
            // 
            this.txtArananKelime.Location = new System.Drawing.Point(120, 302);
            this.txtArananKelime.Name = "txtArananKelime";
            this.txtArananKelime.Size = new System.Drawing.Size(200, 22);
            this.txtArananKelime.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kelime Sırası: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cümle Sırası: ";
            // 
            // txtKelimeSirasi
            // 
            this.txtKelimeSirasi.Location = new System.Drawing.Point(119, 202);
            this.txtKelimeSirasi.Name = "txtKelimeSirasi";
            this.txtKelimeSirasi.Size = new System.Drawing.Size(100, 22);
            this.txtKelimeSirasi.TabIndex = 9;
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(120, 44);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(97, 40);
            this.btnHash.TabIndex = 6;
            this.btnHash.Text = "Hashe aktar";
            this.btnHash.UseVisualStyleBackColor = true;
            // 
            // btnHashKelimeAra
            // 
            this.btnHashKelimeAra.Location = new System.Drawing.Point(120, 243);
            this.btnHashKelimeAra.Name = "btnHashKelimeAra";
            this.btnHashKelimeAra.Size = new System.Drawing.Size(97, 40);
            this.btnHashKelimeAra.TabIndex = 7;
            this.btnHashKelimeAra.Text = "Hashte ara";
            this.btnHashKelimeAra.UseVisualStyleBackColor = true;
            // 
            // txtCumlenumarasi
            // 
            this.txtCumlenumarasi.Location = new System.Drawing.Point(119, 155);
            this.txtCumlenumarasi.Name = "txtCumlenumarasi";
            this.txtCumlenumarasi.Size = new System.Drawing.Size(100, 22);
            this.txtCumlenumarasi.TabIndex = 8;
            // 
            // buttontree
            // 
            this.buttontree.Location = new System.Drawing.Point(17, 200);
            this.buttontree.Name = "buttontree";
            this.buttontree.Size = new System.Drawing.Size(93, 37);
            this.buttontree.TabIndex = 6;
            this.buttontree.Text = "Agaca Aktar";
            this.buttontree.UseVisualStyleBackColor = true;
            // 
            // txtMetininBilgiler
            // 
            this.txtMetininBilgiler.Location = new System.Drawing.Point(141, 92);
            this.txtMetininBilgiler.Multiline = true;
            this.txtMetininBilgiler.Name = "txtMetininBilgiler";
            this.txtMetininBilgiler.Size = new System.Drawing.Size(284, 85);
            this.txtMetininBilgiler.TabIndex = 5;
            // 
            // buttonStack
            // 
            this.buttonStack.Location = new System.Drawing.Point(17, 113);
            this.buttonStack.Name = "buttonStack";
            this.buttonStack.Size = new System.Drawing.Size(93, 53);
            this.buttonStack.TabIndex = 4;
            this.buttonStack.Text = "Stacke Oku";
            this.buttonStack.UseVisualStyleBackColor = true;
            this.buttonStack.Click += new System.EventHandler(this.buttonStack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dosya Seç:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtDosya
            // 
            this.TxtDosya.Location = new System.Drawing.Point(234, 47);
            this.TxtDosya.Name = "TxtDosya";
            this.TxtDosya.ReadOnly = true;
            this.TxtDosya.Size = new System.Drawing.Size(178, 22);
            this.TxtDosya.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Metin Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.EnCokKullanilanKelimeler);
            this.tabPage2.Controls.Add(this.lblKelimeSayisi);
            this.tabPage2.Controls.Add(this.txtGirilenKelimeSayisi);
            this.tabPage2.Controls.Add(this.btnKelimeleriGoster);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(699, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Metinin Bilgileri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // EnCokKullanilanKelimeler
            // 
            this.EnCokKullanilanKelimeler.FormattingEnabled = true;
            this.EnCokKullanilanKelimeler.ItemHeight = 16;
            this.EnCokKullanilanKelimeler.Location = new System.Drawing.Point(21, 156);
            this.EnCokKullanilanKelimeler.Name = "EnCokKullanilanKelimeler";
            this.EnCokKullanilanKelimeler.Size = new System.Drawing.Size(335, 260);
            this.EnCokKullanilanKelimeler.TabIndex = 8;
            // 
            // lblKelimeSayisi
            // 
            this.lblKelimeSayisi.AutoSize = true;
            this.lblKelimeSayisi.Location = new System.Drawing.Point(18, 28);
            this.lblKelimeSayisi.Name = "lblKelimeSayisi";
            this.lblKelimeSayisi.Size = new System.Drawing.Size(142, 17);
            this.lblKelimeSayisi.TabIndex = 7;
            this.lblKelimeSayisi.Text = "Toplam Kelime Sayısı";
            // 
            // txtGirilenKelimeSayisi
            // 
            this.txtGirilenKelimeSayisi.Location = new System.Drawing.Point(163, 25);
            this.txtGirilenKelimeSayisi.Name = "txtGirilenKelimeSayisi";
            this.txtGirilenKelimeSayisi.Size = new System.Drawing.Size(100, 22);
            this.txtGirilenKelimeSayisi.TabIndex = 6;
            // 
            // btnKelimeleriGoster
            // 
            this.btnKelimeleriGoster.Location = new System.Drawing.Point(21, 60);
            this.btnKelimeleriGoster.Name = "btnKelimeleriGoster";
            this.btnKelimeleriGoster.Size = new System.Drawing.Size(97, 50);
            this.btnKelimeleriGoster.TabIndex = 5;
            this.btnKelimeleriGoster.Text = "Kelimeleri Göster";
            this.btnKelimeleriGoster.UseVisualStyleBackColor = true;
            this.btnKelimeleriGoster.Click += new System.EventHandler(this.btnKelimeleriGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 676);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDosya;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttontree;
        private System.Windows.Forms.TextBox txtMetininBilgiler;
        private System.Windows.Forms.Button buttonStack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArananKelime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKelimeSirasi;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Button btnHashKelimeAra;
        private System.Windows.Forms.TextBox txtCumlenumarasi;
        private System.Windows.Forms.ListBox EnCokKullanilanKelimeler;
        private System.Windows.Forms.Label lblKelimeSayisi;
        private System.Windows.Forms.TextBox txtGirilenKelimeSayisi;
        private System.Windows.Forms.Button btnKelimeleriGoster;
    }
}

