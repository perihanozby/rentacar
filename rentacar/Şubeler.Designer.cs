namespace rentacar
{
    partial class Şubeler
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
            this.txt_subeadi = new System.Windows.Forms.TextBox();
            this.txt_subetelefon = new System.Windows.Forms.TextBox();
            this.txt_subetelefon2 = new System.Windows.Forms.TextBox();
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.rct_adresi = new System.Windows.Forms.RichTextBox();
            this.btn_subeekle = new System.Windows.Forms.Button();
            this.btn_subesil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_subeler = new System.Windows.Forms.DataGridView();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_subeler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şube Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şube Telefonu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şube Telefonu 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "e-Posta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresi:";
            // 
            // txt_subeadi
            // 
            this.txt_subeadi.Location = new System.Drawing.Point(159, 26);
            this.txt_subeadi.Name = "txt_subeadi";
            this.txt_subeadi.Size = new System.Drawing.Size(126, 25);
            this.txt_subeadi.TabIndex = 1;
            // 
            // txt_subetelefon
            // 
            this.txt_subetelefon.Location = new System.Drawing.Point(159, 56);
            this.txt_subetelefon.Name = "txt_subetelefon";
            this.txt_subetelefon.Size = new System.Drawing.Size(126, 25);
            this.txt_subetelefon.TabIndex = 2;
            // 
            // txt_subetelefon2
            // 
            this.txt_subetelefon2.Location = new System.Drawing.Point(159, 87);
            this.txt_subetelefon2.Name = "txt_subetelefon2";
            this.txt_subetelefon2.Size = new System.Drawing.Size(126, 25);
            this.txt_subetelefon2.TabIndex = 3;
            // 
            // txt_eposta
            // 
            this.txt_eposta.Location = new System.Drawing.Point(159, 118);
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(126, 25);
            this.txt_eposta.TabIndex = 4;
            // 
            // rct_adresi
            // 
            this.rct_adresi.Location = new System.Drawing.Point(429, 26);
            this.rct_adresi.Name = "rct_adresi";
            this.rct_adresi.Size = new System.Drawing.Size(268, 117);
            this.rct_adresi.TabIndex = 5;
            this.rct_adresi.Text = "";
            // 
            // btn_subeekle
            // 
            this.btn_subeekle.Location = new System.Drawing.Point(312, 162);
            this.btn_subeekle.Name = "btn_subeekle";
            this.btn_subeekle.Size = new System.Drawing.Size(122, 28);
            this.btn_subeekle.TabIndex = 6;
            this.btn_subeekle.Text = "Şube Ekle";
            this.btn_subeekle.UseVisualStyleBackColor = true;
            this.btn_subeekle.Click += new System.EventHandler(this.btn_subeekle_Click);
            // 
            // btn_subesil
            // 
            this.btn_subesil.Location = new System.Drawing.Point(445, 162);
            this.btn_subesil.Name = "btn_subesil";
            this.btn_subesil.Size = new System.Drawing.Size(122, 28);
            this.btn_subesil.TabIndex = 7;
            this.btn_subesil.Text = "Şube Sil";
            this.btn_subesil.UseVisualStyleBackColor = true;
            this.btn_subesil.Click += new System.EventHandler(this.btn_subesil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_subeler);
            this.groupBox1.Location = new System.Drawing.Point(11, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 270);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // dtg_subeler
            // 
            this.dtg_subeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_subeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_subeler.Location = new System.Drawing.Point(3, 21);
            this.dtg_subeler.Name = "dtg_subeler";
            this.dtg_subeler.Size = new System.Drawing.Size(680, 246);
            this.dtg_subeler.TabIndex = 0;
            this.dtg_subeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_subeler_CellClick);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(577, 162);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(122, 28);
            this.btn_guncelle.TabIndex = 14;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ileri
            // 
            this.btn_ileri.Location = new System.Drawing.Point(48, 3);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(25, 24);
            this.btn_ileri.TabIndex = 27;
            this.btn_ileri.Text = "↪";
            this.btn_ileri.UseVisualStyleBackColor = true;
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(14, 3);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(28, 23);
            this.btn_geri.TabIndex = 26;
            this.btn_geri.Text = "↩";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Şubeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(704, 476);
            this.Controls.Add(this.btn_ileri);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_subesil);
            this.Controls.Add(this.btn_subeekle);
            this.Controls.Add(this.rct_adresi);
            this.Controls.Add(this.txt_eposta);
            this.Controls.Add(this.txt_subetelefon2);
            this.Controls.Add(this.txt_subetelefon);
            this.Controls.Add(this.txt_subeadi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Şubeler";
            this.Text = "Şubeler";
            this.Load += new System.EventHandler(this.Şubeler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_subeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_subeadi;
        private System.Windows.Forms.TextBox txt_subetelefon;
        private System.Windows.Forms.TextBox txt_subetelefon2;
        private System.Windows.Forms.TextBox txt_eposta;
        private System.Windows.Forms.RichTextBox rct_adresi;
        private System.Windows.Forms.Button btn_subeekle;
        private System.Windows.Forms.Button btn_subesil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_subeler;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.Button btn_geri;
    }
}