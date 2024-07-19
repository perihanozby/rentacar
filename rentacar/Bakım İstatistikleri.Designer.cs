namespace rentacar
{
    partial class Bakım_İstatistikleri
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
            this.btn_kapat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_bakimistatistikleri = new System.Windows.Forms.DataGridView();
            this.lbl_topkiralamasayisi = new System.Windows.Forms.Label();
            this.lbl_topmusterisayisi = new System.Windows.Forms.Label();
            this.lbl_toparacsayisi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_bakimistatistikleri)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(692, 437);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(119, 28);
            this.btn_kapat.TabIndex = 15;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_bakimistatistikleri);
            this.groupBox1.Location = new System.Drawing.Point(25, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 302);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // dtg_bakimistatistikleri
            // 
            this.dtg_bakimistatistikleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_bakimistatistikleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_bakimistatistikleri.Location = new System.Drawing.Point(3, 21);
            this.dtg_bakimistatistikleri.Name = "dtg_bakimistatistikleri";
            this.dtg_bakimistatistikleri.Size = new System.Drawing.Size(780, 278);
            this.dtg_bakimistatistikleri.TabIndex = 0;
            // 
            // lbl_topkiralamasayisi
            // 
            this.lbl_topkiralamasayisi.AutoSize = true;
            this.lbl_topkiralamasayisi.Location = new System.Drawing.Point(216, 93);
            this.lbl_topkiralamasayisi.Name = "lbl_topkiralamasayisi";
            this.lbl_topkiralamasayisi.Size = new System.Drawing.Size(16, 18);
            this.lbl_topkiralamasayisi.TabIndex = 13;
            this.lbl_topkiralamasayisi.Text = "0";
            // 
            // lbl_topmusterisayisi
            // 
            this.lbl_topmusterisayisi.AutoSize = true;
            this.lbl_topmusterisayisi.Location = new System.Drawing.Point(216, 66);
            this.lbl_topmusterisayisi.Name = "lbl_topmusterisayisi";
            this.lbl_topmusterisayisi.Size = new System.Drawing.Size(16, 18);
            this.lbl_topmusterisayisi.TabIndex = 12;
            this.lbl_topmusterisayisi.Text = "0";
            // 
            // lbl_toparacsayisi
            // 
            this.lbl_toparacsayisi.AutoSize = true;
            this.lbl_toparacsayisi.Location = new System.Drawing.Point(216, 39);
            this.lbl_toparacsayisi.Name = "lbl_toparacsayisi";
            this.lbl_toparacsayisi.Size = new System.Drawing.Size(16, 18);
            this.lbl_toparacsayisi.TabIndex = 11;
            this.lbl_toparacsayisi.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Toplam Kiralama Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Toplam Müşteri Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Toplam Araç sayısı:";
            // 
            // btn_ileri
            // 
            this.btn_ileri.Location = new System.Drawing.Point(51, 10);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(25, 24);
            this.btn_ileri.TabIndex = 29;
            this.btn_ileri.Text = "↪";
            this.btn_ileri.UseVisualStyleBackColor = true;
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(17, 10);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(28, 23);
            this.btn_geri.TabIndex = 28;
            this.btn_geri.Text = "↩";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Bakım_İstatistikleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(832, 485);
            this.Controls.Add(this.btn_ileri);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_topkiralamasayisi);
            this.Controls.Add(this.lbl_topmusterisayisi);
            this.Controls.Add(this.lbl_toparacsayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bakım_İstatistikleri";
            this.Text = "Bakım_İstatistikleri";
            this.Load += new System.EventHandler(this.Bakım_İstatistikleri_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_bakimistatistikleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_bakimistatistikleri;
        private System.Windows.Forms.Label lbl_topkiralamasayisi;
        private System.Windows.Forms.Label lbl_topmusterisayisi;
        private System.Windows.Forms.Label lbl_toparacsayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.Button btn_geri;
    }
}