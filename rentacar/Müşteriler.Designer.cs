namespace rentacar
{
    partial class Müşteriler
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
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.txt_soyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_musteriler = new System.Windows.Forms.DataGridView();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_musteriekle = new System.Windows.Forms.Button();
            this.btn_musteriduzenle = new System.Windows.Forms.Button();
            this.btn_arackirala = new System.Windows.Forms.Button();
            this.btn_aracrezerveet = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_musteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // msk_tc
            // 
            this.msk_tc.Location = new System.Drawing.Point(132, 42);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(100, 25);
            this.msk_tc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı:";
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(312, 42);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(120, 25);
            this.txt_adi.TabIndex = 2;
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Location = new System.Drawing.Point(522, 42);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(120, 25);
            this.txt_soyadi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyadı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_musteriler);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 336);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // dtg_musteriler
            // 
            this.dtg_musteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_musteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_musteriler.Location = new System.Drawing.Point(3, 21);
            this.dtg_musteriler.Name = "dtg_musteriler";
            this.dtg_musteriler.Size = new System.Drawing.Size(665, 312);
            this.dtg_musteriler.TabIndex = 0;
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(12, 415);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(84, 36);
            this.btn_listele.TabIndex = 4;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_musteriekle
            // 
            this.btn_musteriekle.Location = new System.Drawing.Point(102, 415);
            this.btn_musteriekle.Name = "btn_musteriekle";
            this.btn_musteriekle.Size = new System.Drawing.Size(110, 36);
            this.btn_musteriekle.TabIndex = 5;
            this.btn_musteriekle.Text = "Müşteri Ekle";
            this.btn_musteriekle.UseVisualStyleBackColor = true;
            this.btn_musteriekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_musteriduzenle
            // 
            this.btn_musteriduzenle.Location = new System.Drawing.Point(218, 415);
            this.btn_musteriduzenle.Name = "btn_musteriduzenle";
            this.btn_musteriduzenle.Size = new System.Drawing.Size(135, 36);
            this.btn_musteriduzenle.TabIndex = 6;
            this.btn_musteriduzenle.Text = "Müşteri Düzenle";
            this.btn_musteriduzenle.UseVisualStyleBackColor = true;
            this.btn_musteriduzenle.Click += new System.EventHandler(this.btn_musteriduzenle_Click);
            // 
            // btn_arackirala
            // 
            this.btn_arackirala.Location = new System.Drawing.Point(359, 415);
            this.btn_arackirala.Name = "btn_arackirala";
            this.btn_arackirala.Size = new System.Drawing.Size(93, 36);
            this.btn_arackirala.TabIndex = 7;
            this.btn_arackirala.Text = "Araç Kirala";
            this.btn_arackirala.UseVisualStyleBackColor = true;
            this.btn_arackirala.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_aracrezerveet
            // 
            this.btn_aracrezerveet.Location = new System.Drawing.Point(459, 415);
            this.btn_aracrezerveet.Name = "btn_aracrezerveet";
            this.btn_aracrezerveet.Size = new System.Drawing.Size(134, 36);
            this.btn_aracrezerveet.TabIndex = 8;
            this.btn_aracrezerveet.Text = "Araç Rezerve Et";
            this.btn_aracrezerveet.UseVisualStyleBackColor = true;
            this.btn_aracrezerveet.Click += new System.EventHandler(this.btn_aracrezerveet_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(599, 415);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(84, 36);
            this.btn_kapat.TabIndex = 10;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_ileri
            // 
            this.btn_ileri.Location = new System.Drawing.Point(46, 5);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(25, 24);
            this.btn_ileri.TabIndex = 27;
            this.btn_ileri.Text = "↪";
            this.btn_ileri.UseVisualStyleBackColor = true;
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(12, 5);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(28, 23);
            this.btn_geri.TabIndex = 26;
            this.btn_geri.Text = "↩";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Müşteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(699, 468);
            this.Controls.Add(this.btn_ileri);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_aracrezerveet);
            this.Controls.Add(this.btn_arackirala);
            this.Controls.Add(this.btn_musteriduzenle);
            this.Controls.Add(this.btn_musteriekle);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_soyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msk_tc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Müşteriler";
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.Müşteriler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_musteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.TextBox txt_soyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_musteriler;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_musteriekle;
        private System.Windows.Forms.Button btn_musteriduzenle;
        private System.Windows.Forms.Button btn_arackirala;
        private System.Windows.Forms.Button btn_aracrezerveet;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.Button btn_geri;
    }
}