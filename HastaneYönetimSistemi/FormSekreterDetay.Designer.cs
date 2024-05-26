namespace HastaneYönetimSistemi
{
    partial class FormSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSekreterDetay));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRandevuListesi = new System.Windows.Forms.Button();
            this.buttonBransPaneli = new System.Windows.Forms.Button();
            this.buttonDoktorPaneli = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonYayinla = new System.Windows.Forms.Button();
            this.richDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelADSoyad = new System.Windows.Forms.Label();
            this.labelTc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.checkDurum = new System.Windows.Forms.CheckBox();
            this.comboDoktor = new System.Windows.Forms.ComboBox();
            this.comboBrans = new System.Windows.Forms.ComboBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.maskedTc = new System.Windows.Forms.MaskedTextBox();
            this.maskedSaat = new System.Windows.Forms.MaskedTextBox();
            this.maskedTarih = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonDuyurular = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(708, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(434, 329);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDuyurular);
            this.groupBox3.Controls.Add(this.buttonRandevuListesi);
            this.groupBox3.Controls.Add(this.buttonBransPaneli);
            this.groupBox3.Controls.Add(this.buttonDoktorPaneli);
            this.groupBox3.Location = new System.Drawing.Point(12, 573);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(663, 116);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hızlı Erişim";
            // 
            // buttonRandevuListesi
            // 
            this.buttonRandevuListesi.Location = new System.Drawing.Point(322, 35);
            this.buttonRandevuListesi.Name = "buttonRandevuListesi";
            this.buttonRandevuListesi.Size = new System.Drawing.Size(168, 60);
            this.buttonRandevuListesi.TabIndex = 2;
            this.buttonRandevuListesi.Text = "Randevu Listesi";
            this.buttonRandevuListesi.UseVisualStyleBackColor = true;
            this.buttonRandevuListesi.Click += new System.EventHandler(this.buttonRandevuListesi_Click);
            // 
            // buttonBransPaneli
            // 
            this.buttonBransPaneli.Location = new System.Drawing.Point(167, 35);
            this.buttonBransPaneli.Name = "buttonBransPaneli";
            this.buttonBransPaneli.Size = new System.Drawing.Size(149, 60);
            this.buttonBransPaneli.TabIndex = 1;
            this.buttonBransPaneli.Text = "Branş Paneli";
            this.buttonBransPaneli.UseVisualStyleBackColor = true;
            this.buttonBransPaneli.Click += new System.EventHandler(this.buttonBransPaneli_Click);
            // 
            // buttonDoktorPaneli
            // 
            this.buttonDoktorPaneli.Location = new System.Drawing.Point(6, 35);
            this.buttonDoktorPaneli.Name = "buttonDoktorPaneli";
            this.buttonDoktorPaneli.Size = new System.Drawing.Size(154, 60);
            this.buttonDoktorPaneli.TabIndex = 0;
            this.buttonDoktorPaneli.Text = "Doktor Paneli";
            this.buttonDoktorPaneli.UseVisualStyleBackColor = true;
            this.buttonDoktorPaneli.Click += new System.EventHandler(this.buttonDoktorPaneli_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonYayinla);
            this.groupBox2.Controls.Add(this.richDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 340);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // buttonYayinla
            // 
            this.buttonYayinla.Location = new System.Drawing.Point(82, 269);
            this.buttonYayinla.Name = "buttonYayinla";
            this.buttonYayinla.Size = new System.Drawing.Size(158, 46);
            this.buttonYayinla.TabIndex = 1;
            this.buttonYayinla.Text = "Yayınla";
            this.buttonYayinla.UseVisualStyleBackColor = true;
            this.buttonYayinla.Click += new System.EventHandler(this.buttonYayinla_Click);
            // 
            // richDuyuru
            // 
            this.richDuyuru.Location = new System.Drawing.Point(3, 32);
            this.richDuyuru.Name = "richDuyuru";
            this.richDuyuru.Size = new System.Drawing.Size(341, 218);
            this.richDuyuru.TabIndex = 0;
            this.richDuyuru.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelADSoyad);
            this.groupBox1.Controls.Add(this.labelTc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 170);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgileri";
            // 
            // labelADSoyad
            // 
            this.labelADSoyad.AutoSize = true;
            this.labelADSoyad.Location = new System.Drawing.Point(132, 94);
            this.labelADSoyad.Name = "labelADSoyad";
            this.labelADSoyad.Size = new System.Drawing.Size(108, 28);
            this.labelADSoyad.TabIndex = 3;
            this.labelADSoyad.Text = "Bilinmiyor";
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.Location = new System.Drawing.Point(132, 47);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(144, 28);
            this.labelTc.TabIndex = 2;
            this.labelTc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonKaydet);
            this.groupBox5.Controls.Add(this.checkDurum);
            this.groupBox5.Controls.Add(this.comboDoktor);
            this.groupBox5.Controls.Add(this.comboBrans);
            this.groupBox5.Controls.Add(this.textId);
            this.groupBox5.Controls.Add(this.maskedTc);
            this.groupBox5.Controls.Add(this.maskedSaat);
            this.groupBox5.Controls.Add(this.maskedTarih);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(380, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(295, 572);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Randevu Paneli";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(106, 469);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(154, 57);
            this.buttonKaydet.TabIndex = 13;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // checkDurum
            // 
            this.checkDurum.AutoSize = true;
            this.checkDurum.Location = new System.Drawing.Point(109, 404);
            this.checkDurum.Name = "checkDurum";
            this.checkDurum.Size = new System.Drawing.Size(100, 32);
            this.checkDurum.TabIndex = 12;
            this.checkDurum.Text = "Durum";
            this.checkDurum.UseVisualStyleBackColor = true;
            // 
            // comboDoktor
            // 
            this.comboDoktor.FormattingEnabled = true;
            this.comboDoktor.Location = new System.Drawing.Point(109, 276);
            this.comboDoktor.Name = "comboDoktor";
            this.comboDoktor.Size = new System.Drawing.Size(154, 36);
            this.comboDoktor.TabIndex = 5;
            // 
            // comboBrans
            // 
            this.comboBrans.FormattingEnabled = true;
            this.comboBrans.Location = new System.Drawing.Point(109, 223);
            this.comboBrans.Name = "comboBrans";
            this.comboBrans.Size = new System.Drawing.Size(154, 36);
            this.comboBrans.TabIndex = 4;
            this.comboBrans.SelectedIndexChanged += new System.EventHandler(this.comboBrans_SelectedIndexChanged);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(109, 47);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(154, 36);
            this.textId.TabIndex = 1;
            // 
            // maskedTc
            // 
            this.maskedTc.Location = new System.Drawing.Point(109, 335);
            this.maskedTc.Mask = "00000000000";
            this.maskedTc.Name = "maskedTc";
            this.maskedTc.Size = new System.Drawing.Size(154, 36);
            this.maskedTc.TabIndex = 6;
            this.maskedTc.ValidatingType = typeof(int);
            // 
            // maskedSaat
            // 
            this.maskedSaat.Location = new System.Drawing.Point(109, 165);
            this.maskedSaat.Mask = "00:00";
            this.maskedSaat.Name = "maskedSaat";
            this.maskedSaat.Size = new System.Drawing.Size(154, 36);
            this.maskedSaat.TabIndex = 3;
            this.maskedSaat.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTarih
            // 
            this.maskedTarih.Location = new System.Drawing.Point(109, 106);
            this.maskedTarih.Mask = "00/00/0000";
            this.maskedTarih.Name = "maskedTarih";
            this.maskedTarih.Size = new System.Drawing.Size(154, 36);
            this.maskedTarih.TabIndex = 2;
            this.maskedTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 28);
            this.label8.TabIndex = 5;
            this.label8.Text = "Doktor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Branş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView2);
            this.groupBox6.Location = new System.Drawing.Point(708, 347);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(431, 342);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(425, 307);
            this.dataGridView2.TabIndex = 0;
            // 
            // buttonDuyurular
            // 
            this.buttonDuyurular.Location = new System.Drawing.Point(496, 35);
            this.buttonDuyurular.Name = "buttonDuyurular";
            this.buttonDuyurular.Size = new System.Drawing.Size(161, 60);
            this.buttonDuyurular.TabIndex = 3;
            this.buttonDuyurular.Text = "Duyurular";
            this.buttonDuyurular.UseVisualStyleBackColor = true;
            this.buttonDuyurular.Click += new System.EventHandler(this.buttonDuyurular_Click);
            // 
            // FormSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1153, 692);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormSekreterDetay";
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.FormSekreterDetay_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richDuyuru;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelADSoyad;
        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonYayinla;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.CheckBox checkDurum;
        private System.Windows.Forms.ComboBox comboDoktor;
        private System.Windows.Forms.ComboBox comboBrans;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.MaskedTextBox maskedTc;
        private System.Windows.Forms.MaskedTextBox maskedSaat;
        private System.Windows.Forms.MaskedTextBox maskedTarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRandevuListesi;
        private System.Windows.Forms.Button buttonBransPaneli;
        private System.Windows.Forms.Button buttonDoktorPaneli;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonDuyurular;
    }
}