namespace rentacar
{
    partial class araç_ekle_düzenle
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
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.msk_plaka = new System.Windows.Forms.MaskedTextBox();
            this.msk_model = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_kayittarihi = new System.Windows.Forms.TextBox();
            this.txt_emisyonbitistarihi = new System.Windows.Forms.TextBox();
            this.txt_kaskobitistarihi = new System.Windows.Forms.TextBox();
            this.txt_muayenebitistarihi = new System.Windows.Forms.TextBox();
            this.txt_sigortabitistarihi = new System.Windows.Forms.TextBox();
            this.numeric_silindirhacim = new System.Windows.Forms.NumericUpDown();
            this.numeric_motorgucu = new System.Windows.Forms.NumericUpDown();
            this.numeric_ucret = new System.Windows.Forms.NumericUpDown();
            this.numeric_bakimperiyodu = new System.Windows.Forms.NumericUpDown();
            this.numeric_yil = new System.Windows.Forms.NumericUpDown();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.cmb_subeid = new System.Windows.Forms.ComboBox();
            this.gb_aracekleduzenle = new System.Windows.Forms.GroupBox();
            this.dtg_aracekleduzenle = new System.Windows.Forms.DataGridView();
            this.cmb_kasa = new System.Windows.Forms.ComboBox();
            this.cmb_renk = new System.Windows.Forms.ComboBox();
            this.cmb_yakit = new System.Windows.Forms.ComboBox();
            this.cmb_marka = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_silindirhacim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_motorgucu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ucret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_bakimperiyodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_yil)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_aracekleduzenle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_aracekleduzenle)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(4, 14);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(83, 33);
            this.btn_kaydet.TabIndex = 18;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şube:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Plaka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kasa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Renk:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Yakıt:";
            // 
            // msk_plaka
            // 
            this.msk_plaka.Location = new System.Drawing.Point(77, 180);
            this.msk_plaka.Name = "msk_plaka";
            this.msk_plaka.Size = new System.Drawing.Size(120, 25);
            this.msk_plaka.TabIndex = 4;
            // 
            // msk_model
            // 
            this.msk_model.Location = new System.Drawing.Point(77, 150);
            this.msk_model.Name = "msk_model";
            this.msk_model.Size = new System.Drawing.Size(120, 25);
            this.msk_model.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(237, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Yıl:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(237, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Bakım Periyodu:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(237, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "Ücret:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(237, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 18);
            this.label13.TabIndex = 16;
            this.label13.Text = "Motor Gücü:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(237, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 18);
            this.label14.TabIndex = 15;
            this.label14.Text = "Silindir Hacmi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Kayıt Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(505, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Emisyon Bitiş Tarihi:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(505, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 18);
            this.label15.TabIndex = 27;
            this.label15.Text = "Kasko Bitiş Tarihi:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(505, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(156, 18);
            this.label16.TabIndex = 26;
            this.label16.Text = "Muayene Bitiş Tarihi:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(505, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 18);
            this.label17.TabIndex = 25;
            this.label17.Text = "Sigorta Bitiş Tarihi:";
            // 
            // txt_kayittarihi
            // 
            this.txt_kayittarihi.Location = new System.Drawing.Point(663, 200);
            this.txt_kayittarihi.Name = "txt_kayittarihi";
            this.txt_kayittarihi.Size = new System.Drawing.Size(120, 25);
            this.txt_kayittarihi.TabIndex = 17;
            // 
            // txt_emisyonbitistarihi
            // 
            this.txt_emisyonbitistarihi.Location = new System.Drawing.Point(663, 171);
            this.txt_emisyonbitistarihi.Name = "txt_emisyonbitistarihi";
            this.txt_emisyonbitistarihi.Size = new System.Drawing.Size(120, 25);
            this.txt_emisyonbitistarihi.TabIndex = 16;
            // 
            // txt_kaskobitistarihi
            // 
            this.txt_kaskobitistarihi.Location = new System.Drawing.Point(663, 141);
            this.txt_kaskobitistarihi.Name = "txt_kaskobitistarihi";
            this.txt_kaskobitistarihi.Size = new System.Drawing.Size(120, 25);
            this.txt_kaskobitistarihi.TabIndex = 15;
            // 
            // txt_muayenebitistarihi
            // 
            this.txt_muayenebitistarihi.Location = new System.Drawing.Point(663, 112);
            this.txt_muayenebitistarihi.Name = "txt_muayenebitistarihi";
            this.txt_muayenebitistarihi.Size = new System.Drawing.Size(120, 25);
            this.txt_muayenebitistarihi.TabIndex = 14;
            // 
            // txt_sigortabitistarihi
            // 
            this.txt_sigortabitistarihi.Location = new System.Drawing.Point(663, 82);
            this.txt_sigortabitistarihi.Name = "txt_sigortabitistarihi";
            this.txt_sigortabitistarihi.Size = new System.Drawing.Size(120, 25);
            this.txt_sigortabitistarihi.TabIndex = 13;
            // 
            // numeric_silindirhacim
            // 
            this.numeric_silindirhacim.Location = new System.Drawing.Point(364, 82);
            this.numeric_silindirhacim.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numeric_silindirhacim.Name = "numeric_silindirhacim";
            this.numeric_silindirhacim.Size = new System.Drawing.Size(120, 25);
            this.numeric_silindirhacim.TabIndex = 8;
            // 
            // numeric_motorgucu
            // 
            this.numeric_motorgucu.Location = new System.Drawing.Point(364, 112);
            this.numeric_motorgucu.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numeric_motorgucu.Name = "numeric_motorgucu";
            this.numeric_motorgucu.Size = new System.Drawing.Size(120, 25);
            this.numeric_motorgucu.TabIndex = 9;
            // 
            // numeric_ucret
            // 
            this.numeric_ucret.Location = new System.Drawing.Point(364, 141);
            this.numeric_ucret.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numeric_ucret.Name = "numeric_ucret";
            this.numeric_ucret.Size = new System.Drawing.Size(120, 25);
            this.numeric_ucret.TabIndex = 10;
            // 
            // numeric_bakimperiyodu
            // 
            this.numeric_bakimperiyodu.Location = new System.Drawing.Point(364, 171);
            this.numeric_bakimperiyodu.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numeric_bakimperiyodu.Name = "numeric_bakimperiyodu";
            this.numeric_bakimperiyodu.Size = new System.Drawing.Size(120, 25);
            this.numeric_bakimperiyodu.TabIndex = 11;
            // 
            // numeric_yil
            // 
            this.numeric_yil.Location = new System.Drawing.Point(364, 200);
            this.numeric_yil.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numeric_yil.Name = "numeric_yil";
            this.numeric_yil.Size = new System.Drawing.Size(120, 25);
            this.numeric_yil.TabIndex = 12;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(203, 14);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(83, 33);
            this.btn_cikis.TabIndex = 19;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_duzenle);
            this.groupBox1.Controls.Add(this.btn_cikis);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Location = new System.Drawing.Point(6, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 53);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // btn_ileri
            // 
            this.btn_ileri.Location = new System.Drawing.Point(44, 8);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(25, 24);
            this.btn_ileri.TabIndex = 45;
            this.btn_ileri.Text = "↪";
            this.btn_ileri.UseVisualStyleBackColor = true;
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(103, 14);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(83, 33);
            this.btn_duzenle.TabIndex = 20;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(10, 9);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(28, 23);
            this.btn_geri.TabIndex = 44;
            this.btn_geri.Text = "↩";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // cmb_subeid
            // 
            this.cmb_subeid.FormattingEnabled = true;
            this.cmb_subeid.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmb_subeid.Location = new System.Drawing.Point(77, 89);
            this.cmb_subeid.Name = "cmb_subeid";
            this.cmb_subeid.Size = new System.Drawing.Size(121, 26);
            this.cmb_subeid.TabIndex = 38;
            // 
            // gb_aracekleduzenle
            // 
            this.gb_aracekleduzenle.Controls.Add(this.dtg_aracekleduzenle);
            this.gb_aracekleduzenle.Location = new System.Drawing.Point(12, 303);
            this.gb_aracekleduzenle.Name = "gb_aracekleduzenle";
            this.gb_aracekleduzenle.Size = new System.Drawing.Size(779, 196);
            this.gb_aracekleduzenle.TabIndex = 39;
            this.gb_aracekleduzenle.TabStop = false;
            // 
            // dtg_aracekleduzenle
            // 
            this.dtg_aracekleduzenle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_aracekleduzenle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_aracekleduzenle.Location = new System.Drawing.Point(3, 21);
            this.dtg_aracekleduzenle.Name = "dtg_aracekleduzenle";
            this.dtg_aracekleduzenle.Size = new System.Drawing.Size(773, 172);
            this.dtg_aracekleduzenle.TabIndex = 0;
            this.dtg_aracekleduzenle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_aracekleduzenle_CellClick);
            // 
            // cmb_kasa
            // 
            this.cmb_kasa.FormattingEnabled = true;
            this.cmb_kasa.Items.AddRange(new object[] {
            "Sedan",
            "Hatchback",
            "station"});
            this.cmb_kasa.Location = new System.Drawing.Point(76, 211);
            this.cmb_kasa.Name = "cmb_kasa";
            this.cmb_kasa.Size = new System.Drawing.Size(121, 26);
            this.cmb_kasa.TabIndex = 40;
            // 
            // cmb_renk
            // 
            this.cmb_renk.FormattingEnabled = true;
            this.cmb_renk.Items.AddRange(new object[] {
            "Kırmızı",
            "Mavi",
            "Siyah",
            "Lacivert",
            "Mor",
            "Sarı",
            "Gri",
            "Beyaz",
            "Pembe"});
            this.cmb_renk.Location = new System.Drawing.Point(77, 241);
            this.cmb_renk.Name = "cmb_renk";
            this.cmb_renk.Size = new System.Drawing.Size(121, 26);
            this.cmb_renk.TabIndex = 41;
            // 
            // cmb_yakit
            // 
            this.cmb_yakit.FormattingEnabled = true;
            this.cmb_yakit.Items.AddRange(new object[] {
            "Benzin",
            "Motorin",
            "LPG",
            "Dizel"});
            this.cmb_yakit.Location = new System.Drawing.Point(76, 272);
            this.cmb_yakit.Name = "cmb_yakit";
            this.cmb_yakit.Size = new System.Drawing.Size(121, 26);
            this.cmb_yakit.TabIndex = 42;
            // 
            // cmb_marka
            // 
            this.cmb_marka.FormattingEnabled = true;
            this.cmb_marka.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Bugatti",
            "Dacia",
            "Ferrari",
            "Fiat",
            "Ford",
            "Honda",
            "Hyundai",
            "Isuzu",
            "Lamborghini",
            "Maserati",
            "Mini",
            "Mercedes-Benz",
            "Nissan",
            "Opel",
            "Peugeot",
            "Porsche",
            "Renault",
            "Rolls Royce",
            "Skoda",
            "Suzuki",
            "Tofaş",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.cmb_marka.Location = new System.Drawing.Point(77, 119);
            this.cmb_marka.Name = "cmb_marka";
            this.cmb_marka.Size = new System.Drawing.Size(121, 26);
            this.cmb_marka.TabIndex = 43;
            // 
            // araç_ekle_düzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(814, 525);
            this.Controls.Add(this.btn_ileri);
            this.Controls.Add(this.cmb_marka);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.cmb_yakit);
            this.Controls.Add(this.cmb_renk);
            this.Controls.Add(this.cmb_kasa);
            this.Controls.Add(this.gb_aracekleduzenle);
            this.Controls.Add(this.cmb_subeid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numeric_yil);
            this.Controls.Add(this.numeric_bakimperiyodu);
            this.Controls.Add(this.numeric_ucret);
            this.Controls.Add(this.numeric_motorgucu);
            this.Controls.Add(this.numeric_silindirhacim);
            this.Controls.Add(this.txt_kayittarihi);
            this.Controls.Add(this.txt_emisyonbitistarihi);
            this.Controls.Add(this.txt_kaskobitistarihi);
            this.Controls.Add(this.txt_muayenebitistarihi);
            this.Controls.Add(this.txt_sigortabitistarihi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.msk_plaka);
            this.Controls.Add(this.msk_model);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "araç_ekle_düzenle";
            this.Text = "araç_ekle_düzenle";
            this.Load += new System.EventHandler(this.araç_ekle_düzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_silindirhacim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_motorgucu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ucret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_bakimperiyodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_yil)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gb_aracekleduzenle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_aracekleduzenle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox msk_plaka;
        private System.Windows.Forms.MaskedTextBox msk_model;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_kayittarihi;
        private System.Windows.Forms.TextBox txt_emisyonbitistarihi;
        private System.Windows.Forms.TextBox txt_kaskobitistarihi;
        private System.Windows.Forms.TextBox txt_muayenebitistarihi;
        private System.Windows.Forms.TextBox txt_sigortabitistarihi;
        private System.Windows.Forms.NumericUpDown numeric_silindirhacim;
        private System.Windows.Forms.NumericUpDown numeric_motorgucu;
        private System.Windows.Forms.NumericUpDown numeric_ucret;
        private System.Windows.Forms.NumericUpDown numeric_bakimperiyodu;
        private System.Windows.Forms.NumericUpDown numeric_yil;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_subeid;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.GroupBox gb_aracekleduzenle;
        private System.Windows.Forms.DataGridView dtg_aracekleduzenle;
        private System.Windows.Forms.ComboBox cmb_kasa;
        private System.Windows.Forms.ComboBox cmb_renk;
        private System.Windows.Forms.ComboBox cmb_yakit;
        private System.Windows.Forms.ComboBox cmb_marka;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.Button btn_geri;
    }
}