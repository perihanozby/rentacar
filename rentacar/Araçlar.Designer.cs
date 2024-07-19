namespace rentacar
{
    partial class Araçlar
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
            this.cmb_sube = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_araclar = new System.Windows.Forms.DataGridView();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_kirala = new System.Windows.Forms.Button();
            this.btn_rezerveet = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_aracdüzenle = new System.Windows.Forms.Button();
            this.btn_aracekle = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_araclar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şube:";
            // 
            // cmb_sube
            // 
            this.cmb_sube.FormattingEnabled = true;
            this.cmb_sube.Location = new System.Drawing.Point(67, 40);
            this.cmb_sube.Name = "cmb_sube";
            this.cmb_sube.Size = new System.Drawing.Size(121, 26);
            this.cmb_sube.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_araclar);
            this.groupBox1.Location = new System.Drawing.Point(10, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 336);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dtg_araclar
            // 
            this.dtg_araclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_araclar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_araclar.Location = new System.Drawing.Point(3, 21);
            this.dtg_araclar.Name = "dtg_araclar";
            this.dtg_araclar.Size = new System.Drawing.Size(481, 312);
            this.dtg_araclar.TabIndex = 0;
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(10, 416);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(159, 29);
            this.btn_listele.TabIndex = 2;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_kirala
            // 
            this.btn_kirala.Location = new System.Drawing.Point(9, 451);
            this.btn_kirala.Name = "btn_kirala";
            this.btn_kirala.Size = new System.Drawing.Size(159, 29);
            this.btn_kirala.TabIndex = 9;
            this.btn_kirala.Text = "Kirala";
            this.btn_kirala.UseVisualStyleBackColor = true;
            this.btn_kirala.Click += new System.EventHandler(this.btn_kirala_Click);
            // 
            // btn_rezerveet
            // 
            this.btn_rezerveet.Location = new System.Drawing.Point(173, 451);
            this.btn_rezerveet.Name = "btn_rezerveet";
            this.btn_rezerveet.Size = new System.Drawing.Size(159, 29);
            this.btn_rezerveet.TabIndex = 10;
            this.btn_rezerveet.Text = "Rezerve Et";
            this.btn_rezerveet.UseVisualStyleBackColor = true;
            this.btn_rezerveet.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(338, 451);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(159, 29);
            this.btn_kapat.TabIndex = 12;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_aracdüzenle
            // 
            this.btn_aracdüzenle.Location = new System.Drawing.Point(338, 416);
            this.btn_aracdüzenle.Name = "btn_aracdüzenle";
            this.btn_aracdüzenle.Size = new System.Drawing.Size(159, 29);
            this.btn_aracdüzenle.TabIndex = 4;
            this.btn_aracdüzenle.Text = "Araç Düzenle";
            this.btn_aracdüzenle.UseVisualStyleBackColor = true;
            this.btn_aracdüzenle.Click += new System.EventHandler(this.btn_aracdüzenle_Click);
            // 
            // btn_aracekle
            // 
            this.btn_aracekle.Location = new System.Drawing.Point(173, 416);
            this.btn_aracekle.Name = "btn_aracekle";
            this.btn_aracekle.Size = new System.Drawing.Size(159, 29);
            this.btn_aracekle.TabIndex = 3;
            this.btn_aracekle.Text = "Araç Ekle";
            this.btn_aracekle.UseVisualStyleBackColor = true;
            this.btn_aracekle.Click += new System.EventHandler(this.btn_aracekle_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(194, 41);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(33, 23);
            this.btn_ara.TabIndex = 13;
            this.btn_ara.Text = "🔄";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_ileri
            // 
            this.btn_ileri.Location = new System.Drawing.Point(43, 4);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(25, 24);
            this.btn_ileri.TabIndex = 27;
            this.btn_ileri.Text = "↪";
            this.btn_ileri.UseVisualStyleBackColor = true;
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(9, 4);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(28, 23);
            this.btn_geri.TabIndex = 26;
            this.btn_geri.Text = "↩";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Araçlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(520, 502);
            this.Controls.Add(this.btn_ileri);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_rezerveet);
            this.Controls.Add(this.btn_kirala);
            this.Controls.Add(this.btn_aracdüzenle);
            this.Controls.Add(this.btn_aracekle);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_sube);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Araçlar";
            this.Text = "Araçlar";
            this.Load += new System.EventHandler(this.Araçlar_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_araclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_sube;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_araclar;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_kirala;
        private System.Windows.Forms.Button btn_rezerveet;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_aracdüzenle;
        private System.Windows.Forms.Button btn_aracekle;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.Button btn_geri;
    }
}