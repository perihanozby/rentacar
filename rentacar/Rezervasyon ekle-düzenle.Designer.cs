namespace rentacar
{
    partial class Rezervasyon_ekle_düzenle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_musteriadisoyadi = new System.Windows.Forms.TextBox();
            this.txt_plakano = new System.Windows.Forms.TextBox();
            this.msk_rezervasyonbaslangic = new System.Windows.Forms.MaskedTextBox();
            this.msk_rezervasyonbitis = new System.Windows.Forms.MaskedTextBox();
            this.cmb_alislokasyonu = new System.Windows.Forms.ComboBox();
            this.cmb_teslimatlokasyonu = new System.Windows.Forms.ComboBox();
            this.rct_rezervasyonnot = new System.Windows.Forms.RichTextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Araç Plaka No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alış Lokasyonu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Teslimat Lokasyonu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rezervasyon Başlangıç Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Rezervasyon Bitiş Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rezervasyon Notu:";
            // 
            // txt_musteriadisoyadi
            // 
            this.txt_musteriadisoyadi.Location = new System.Drawing.Point(256, 47);
            this.txt_musteriadisoyadi.Name = "txt_musteriadisoyadi";
            this.txt_musteriadisoyadi.Size = new System.Drawing.Size(150, 25);
            this.txt_musteriadisoyadi.TabIndex = 1;
            this.txt_musteriadisoyadi.Text = "perihan özbay";
            // 
            // txt_plakano
            // 
            this.txt_plakano.Location = new System.Drawing.Point(256, 78);
            this.txt_plakano.Name = "txt_plakano";
            this.txt_plakano.Size = new System.Drawing.Size(150, 25);
            this.txt_plakano.TabIndex = 2;
            this.txt_plakano.Text = "12abd12";
            // 
            // msk_rezervasyonbaslangic
            // 
            this.msk_rezervasyonbaslangic.Location = new System.Drawing.Point(256, 175);
            this.msk_rezervasyonbaslangic.Mask = "00/00/0000";
            this.msk_rezervasyonbaslangic.Name = "msk_rezervasyonbaslangic";
            this.msk_rezervasyonbaslangic.Size = new System.Drawing.Size(150, 25);
            this.msk_rezervasyonbaslangic.TabIndex = 5;
            this.msk_rezervasyonbaslangic.ValidatingType = typeof(System.DateTime);
            // 
            // msk_rezervasyonbitis
            // 
            this.msk_rezervasyonbitis.Location = new System.Drawing.Point(256, 206);
            this.msk_rezervasyonbitis.Mask = "00/00/0000";
            this.msk_rezervasyonbitis.Name = "msk_rezervasyonbitis";
            this.msk_rezervasyonbitis.Size = new System.Drawing.Size(150, 25);
            this.msk_rezervasyonbitis.TabIndex = 6;
            this.msk_rezervasyonbitis.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_alislokasyonu
            // 
            this.cmb_alislokasyonu.FormattingEnabled = true;
            this.cmb_alislokasyonu.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmb_alislokasyonu.Location = new System.Drawing.Point(256, 111);
            this.cmb_alislokasyonu.Name = "cmb_alislokasyonu";
            this.cmb_alislokasyonu.Size = new System.Drawing.Size(150, 26);
            this.cmb_alislokasyonu.TabIndex = 3;
            // 
            // cmb_teslimatlokasyonu
            // 
            this.cmb_teslimatlokasyonu.FormattingEnabled = true;
            this.cmb_teslimatlokasyonu.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmb_teslimatlokasyonu.Location = new System.Drawing.Point(256, 143);
            this.cmb_teslimatlokasyonu.Name = "cmb_teslimatlokasyonu";
            this.cmb_teslimatlokasyonu.Size = new System.Drawing.Size(150, 26);
            this.cmb_teslimatlokasyonu.TabIndex = 4;
            // 
            // rct_rezervasyonnot
            // 
            this.rct_rezervasyonnot.Location = new System.Drawing.Point(256, 237);
            this.rct_rezervasyonnot.Name = "rct_rezervasyonnot";
            this.rct_rezervasyonnot.Size = new System.Drawing.Size(150, 96);
            this.rct_rezervasyonnot.TabIndex = 7;
            this.rct_rezervasyonnot.Text = "zxdsdcd";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(327, 345);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 33);
            this.btn_kaydet.TabIndex = 8;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_ileri
            // 
            this.btn_ileri.Location = new System.Drawing.Point(48, 12);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(25, 24);
            this.btn_ileri.TabIndex = 29;
            this.btn_ileri.Text = "↪";
            this.btn_ileri.UseVisualStyleBackColor = true;
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(14, 12);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(28, 23);
            this.btn_geri.TabIndex = 28;
            this.btn_geri.Text = "↩";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Rezervasyon_ekle_düzenle
            // 
            this.AcceptButton = this.btn_kaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(438, 400);
            this.Controls.Add(this.btn_ileri);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.rct_rezervasyonnot);
            this.Controls.Add(this.cmb_teslimatlokasyonu);
            this.Controls.Add(this.cmb_alislokasyonu);
            this.Controls.Add(this.msk_rezervasyonbitis);
            this.Controls.Add(this.msk_rezervasyonbaslangic);
            this.Controls.Add(this.txt_plakano);
            this.Controls.Add(this.txt_musteriadisoyadi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Rezervasyon_ekle_düzenle";
            this.Text = "Rezervasyon_ekle_düzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_musteriadisoyadi;
        private System.Windows.Forms.TextBox txt_plakano;
        private System.Windows.Forms.MaskedTextBox msk_rezervasyonbaslangic;
        private System.Windows.Forms.MaskedTextBox msk_rezervasyonbitis;
        private System.Windows.Forms.ComboBox cmb_alislokasyonu;
        private System.Windows.Forms.ComboBox cmb_teslimatlokasyonu;
        private System.Windows.Forms.RichTextBox rct_rezervasyonnot;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.Button btn_geri;
    }
}