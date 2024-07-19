namespace rentacar
{
    partial class Aracı_Bakıma_Al
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
            this.gb_aracbilgileri = new System.Windows.Forms.GroupBox();
            this.cmb_model = new System.Windows.Forms.ComboBox();
            this.cmb_marka = new System.Windows.Forms.ComboBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.txt_plaka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_bakimbilgileri = new System.Windows.Forms.GroupBox();
            this.txt_bakimyeri = new System.Windows.Forms.TextBox();
            this.txt_istibatkisi = new System.Windows.Forms.TextBox();
            this.msk_giristarihi = new System.Windows.Forms.MaskedTextBox();
            this.numeric_girisKM = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_degisenparcalar = new System.Windows.Forms.GroupBox();
            this.dtg_degisenparcalar = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numeric_bakimtutari = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.gb_aracbilgileri.SuspendLayout();
            this.gb_bakimbilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_girisKM)).BeginInit();
            this.gb_degisenparcalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_degisenparcalar)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_bakimtutari)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_aracbilgileri
            // 
            this.gb_aracbilgileri.Controls.Add(this.cmb_model);
            this.gb_aracbilgileri.Controls.Add(this.cmb_marka);
            this.gb_aracbilgileri.Controls.Add(this.btn_ara);
            this.gb_aracbilgileri.Controls.Add(this.txt_plaka);
            this.gb_aracbilgileri.Controls.Add(this.label4);
            this.gb_aracbilgileri.Controls.Add(this.label5);
            this.gb_aracbilgileri.Controls.Add(this.label6);
            this.gb_aracbilgileri.Location = new System.Drawing.Point(12, 33);
            this.gb_aracbilgileri.Name = "gb_aracbilgileri";
            this.gb_aracbilgileri.Size = new System.Drawing.Size(266, 170);
            this.gb_aracbilgileri.TabIndex = 5;
            this.gb_aracbilgileri.TabStop = false;
            this.gb_aracbilgileri.Text = "Araç Bilgileri";
            // 
            // cmb_model
            // 
            this.cmb_model.FormattingEnabled = true;
            this.cmb_model.Location = new System.Drawing.Point(126, 99);
            this.cmb_model.Name = "cmb_model";
            this.cmb_model.Size = new System.Drawing.Size(115, 26);
            this.cmb_model.TabIndex = 3;
            // 
            // cmb_marka
            // 
            this.cmb_marka.FormattingEnabled = true;
            this.cmb_marka.Location = new System.Drawing.Point(127, 68);
            this.cmb_marka.Name = "cmb_marka";
            this.cmb_marka.Size = new System.Drawing.Size(115, 26);
            this.cmb_marka.TabIndex = 2;
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(127, 130);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(114, 23);
            this.btn_ara.TabIndex = 4;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // txt_plaka
            // 
            this.txt_plaka.Location = new System.Drawing.Point(127, 38);
            this.txt_plaka.Name = "txt_plaka";
            this.txt_plaka.Size = new System.Drawing.Size(115, 25);
            this.txt_plaka.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Marka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Plaka:";
            // 
            // gb_bakimbilgileri
            // 
            this.gb_bakimbilgileri.Controls.Add(this.txt_bakimyeri);
            this.gb_bakimbilgileri.Controls.Add(this.txt_istibatkisi);
            this.gb_bakimbilgileri.Controls.Add(this.msk_giristarihi);
            this.gb_bakimbilgileri.Controls.Add(this.numeric_girisKM);
            this.gb_bakimbilgileri.Controls.Add(this.label7);
            this.gb_bakimbilgileri.Controls.Add(this.label3);
            this.gb_bakimbilgileri.Controls.Add(this.label2);
            this.gb_bakimbilgileri.Controls.Add(this.label1);
            this.gb_bakimbilgileri.Location = new System.Drawing.Point(284, 33);
            this.gb_bakimbilgileri.Name = "gb_bakimbilgileri";
            this.gb_bakimbilgileri.Size = new System.Drawing.Size(306, 170);
            this.gb_bakimbilgileri.TabIndex = 6;
            this.gb_bakimbilgileri.TabStop = false;
            this.gb_bakimbilgileri.Text = "Bakım Bilgileri";
            // 
            // txt_bakimyeri
            // 
            this.txt_bakimyeri.Location = new System.Drawing.Point(129, 130);
            this.txt_bakimyeri.Name = "txt_bakimyeri";
            this.txt_bakimyeri.Size = new System.Drawing.Size(120, 25);
            this.txt_bakimyeri.TabIndex = 8;
            // 
            // txt_istibatkisi
            // 
            this.txt_istibatkisi.Location = new System.Drawing.Point(129, 99);
            this.txt_istibatkisi.Name = "txt_istibatkisi";
            this.txt_istibatkisi.Size = new System.Drawing.Size(120, 25);
            this.txt_istibatkisi.TabIndex = 7;
            // 
            // msk_giristarihi
            // 
            this.msk_giristarihi.Location = new System.Drawing.Point(129, 68);
            this.msk_giristarihi.Name = "msk_giristarihi";
            this.msk_giristarihi.Size = new System.Drawing.Size(120, 25);
            this.msk_giristarihi.TabIndex = 6;
            // 
            // numeric_girisKM
            // 
            this.numeric_girisKM.Location = new System.Drawing.Point(129, 39);
            this.numeric_girisKM.Name = "numeric_girisKM";
            this.numeric_girisKM.Size = new System.Drawing.Size(120, 25);
            this.numeric_girisKM.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Bakım Yeri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "İrtibat Kişi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giriş Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş KM:";
            // 
            // gb_degisenparcalar
            // 
            this.gb_degisenparcalar.Controls.Add(this.dtg_degisenparcalar);
            this.gb_degisenparcalar.Location = new System.Drawing.Point(12, 200);
            this.gb_degisenparcalar.Name = "gb_degisenparcalar";
            this.gb_degisenparcalar.Size = new System.Drawing.Size(578, 182);
            this.gb_degisenparcalar.TabIndex = 7;
            this.gb_degisenparcalar.TabStop = false;
            // 
            // dtg_degisenparcalar
            // 
            this.dtg_degisenparcalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_degisenparcalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_degisenparcalar.Location = new System.Drawing.Point(3, 21);
            this.dtg_degisenparcalar.Name = "dtg_degisenparcalar";
            this.dtg_degisenparcalar.Size = new System.Drawing.Size(572, 158);
            this.dtg_degisenparcalar.TabIndex = 0;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(467, 385);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(55, 38);
            this.btn_ekle.TabIndex = 9;
            this.btn_ekle.Text = "ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(532, 385);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(55, 38);
            this.btn_sil.TabIndex = 10;
            this.btn_sil.Text = "sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numeric_bakimtutari);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(15, 422);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(575, 50);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // numeric_bakimtutari
            // 
            this.numeric_bakimtutari.Location = new System.Drawing.Point(112, 19);
            this.numeric_bakimtutari.Name = "numeric_bakimtutari";
            this.numeric_bakimtutari.Size = new System.Drawing.Size(79, 25);
            this.numeric_bakimtutari.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bakım Tutarı:";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(387, 476);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(97, 39);
            this.btn_kaydet.TabIndex = 12;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(490, 476);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(97, 39);
            this.btn_kapat.TabIndex = 13;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_ileri
            // 
            this.btn_ileri.Location = new System.Drawing.Point(50, 3);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(25, 24);
            this.btn_ileri.TabIndex = 29;
            this.btn_ileri.Text = "↪";
            this.btn_ileri.UseVisualStyleBackColor = true;
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(16, 4);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(28, 23);
            this.btn_geri.TabIndex = 28;
            this.btn_geri.Text = "↩";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Aracı_Bakıma_Al
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(601, 530);
            this.Controls.Add(this.btn_ileri);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.gb_degisenparcalar);
            this.Controls.Add(this.gb_bakimbilgileri);
            this.Controls.Add(this.gb_aracbilgileri);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Aracı_Bakıma_Al";
            this.Text = "Aracı_Bakıma_Al";
            this.Load += new System.EventHandler(this.Aracı_Bakıma_Al_Load);
            this.gb_aracbilgileri.ResumeLayout(false);
            this.gb_aracbilgileri.PerformLayout();
            this.gb_bakimbilgileri.ResumeLayout(false);
            this.gb_bakimbilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_girisKM)).EndInit();
            this.gb_degisenparcalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_degisenparcalar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_bakimtutari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_aracbilgileri;
        private System.Windows.Forms.ComboBox cmb_model;
        private System.Windows.Forms.ComboBox cmb_marka;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox txt_plaka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gb_bakimbilgileri;
        private System.Windows.Forms.TextBox txt_bakimyeri;
        private System.Windows.Forms.TextBox txt_istibatkisi;
        private System.Windows.Forms.MaskedTextBox msk_giristarihi;
        private System.Windows.Forms.NumericUpDown numeric_girisKM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_degisenparcalar;
        private System.Windows.Forms.DataGridView dtg_degisenparcalar;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numeric_bakimtutari;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.Button btn_geri;
    }
}