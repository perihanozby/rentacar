namespace rentacar
{
    partial class arac_istatistikleri
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
            this.lbl_toparacsayisi = new System.Windows.Forms.Label();
            this.lbl_topmusterisayisi = new System.Windows.Forms.Label();
            this.lbl_topkiralamasayisi = new System.Windows.Forms.Label();
            this.gb_aracistatistikleri = new System.Windows.Forms.GroupBox();
            this.dtg_aracistatistikleri = new System.Windows.Forms.DataGridView();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.gb_aracistatistikleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_aracistatistikleri)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Araç sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Müşteri Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toplam Kiralama Sayısı:";
            // 
            // lbl_toparacsayisi
            // 
            this.lbl_toparacsayisi.AutoSize = true;
            this.lbl_toparacsayisi.Location = new System.Drawing.Point(201, 42);
            this.lbl_toparacsayisi.Name = "lbl_toparacsayisi";
            this.lbl_toparacsayisi.Size = new System.Drawing.Size(16, 18);
            this.lbl_toparacsayisi.TabIndex = 3;
            this.lbl_toparacsayisi.Text = "0";
            // 
            // lbl_topmusterisayisi
            // 
            this.lbl_topmusterisayisi.AutoSize = true;
            this.lbl_topmusterisayisi.Location = new System.Drawing.Point(201, 69);
            this.lbl_topmusterisayisi.Name = "lbl_topmusterisayisi";
            this.lbl_topmusterisayisi.Size = new System.Drawing.Size(16, 18);
            this.lbl_topmusterisayisi.TabIndex = 4;
            this.lbl_topmusterisayisi.Text = "0";
            // 
            // lbl_topkiralamasayisi
            // 
            this.lbl_topkiralamasayisi.AutoSize = true;
            this.lbl_topkiralamasayisi.Location = new System.Drawing.Point(201, 95);
            this.lbl_topkiralamasayisi.Name = "lbl_topkiralamasayisi";
            this.lbl_topkiralamasayisi.Size = new System.Drawing.Size(16, 18);
            this.lbl_topkiralamasayisi.TabIndex = 5;
            this.lbl_topkiralamasayisi.Text = "0";
            // 
            // gb_aracistatistikleri
            // 
            this.gb_aracistatistikleri.Controls.Add(this.dtg_aracistatistikleri);
            this.gb_aracistatistikleri.Location = new System.Drawing.Point(13, 131);
            this.gb_aracistatistikleri.Name = "gb_aracistatistikleri";
            this.gb_aracistatistikleri.Size = new System.Drawing.Size(786, 302);
            this.gb_aracistatistikleri.TabIndex = 6;
            this.gb_aracistatistikleri.TabStop = false;
            // 
            // dtg_aracistatistikleri
            // 
            this.dtg_aracistatistikleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_aracistatistikleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_aracistatistikleri.Location = new System.Drawing.Point(3, 21);
            this.dtg_aracistatistikleri.Name = "dtg_aracistatistikleri";
            this.dtg_aracistatistikleri.Size = new System.Drawing.Size(780, 278);
            this.dtg_aracistatistikleri.TabIndex = 0;
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(680, 440);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(119, 28);
            this.btn_kapat.TabIndex = 7;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_ileri
            // 
            this.btn_ileri.Location = new System.Drawing.Point(49, 9);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(25, 24);
            this.btn_ileri.TabIndex = 29;
            this.btn_ileri.Text = "↪";
            this.btn_ileri.UseVisualStyleBackColor = true;
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(15, 9);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(28, 23);
            this.btn_geri.TabIndex = 28;
            this.btn_geri.Text = "↩";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // arac_istatistikleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(811, 483);
            this.Controls.Add(this.btn_ileri);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.gb_aracistatistikleri);
            this.Controls.Add(this.lbl_topkiralamasayisi);
            this.Controls.Add(this.lbl_topmusterisayisi);
            this.Controls.Add(this.lbl_toparacsayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "arac_istatistikleri";
            this.Text = "arac_istatistikleri";
            this.Load += new System.EventHandler(this.arac_istatistikleri_Load);
            this.gb_aracistatistikleri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_aracistatistikleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_toparacsayisi;
        private System.Windows.Forms.Label lbl_topmusterisayisi;
        private System.Windows.Forms.Label lbl_topkiralamasayisi;
        private System.Windows.Forms.GroupBox gb_aracistatistikleri;
        private System.Windows.Forms.DataGridView dtg_aracistatistikleri;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.Button btn_geri;
    }
}