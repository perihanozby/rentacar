namespace rentacar
{
    partial class Teslimata_Göre_Araçlar
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
            this.dateTimePicker_ilk = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_son = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_teslimatagorearaclar = new System.Windows.Forms.DataGridView();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_teslimatagorearaclar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teslim Tarihi:";
            // 
            // dateTimePicker_ilk
            // 
            this.dateTimePicker_ilk.Location = new System.Drawing.Point(125, 31);
            this.dateTimePicker_ilk.Name = "dateTimePicker_ilk";
            this.dateTimePicker_ilk.Size = new System.Drawing.Size(159, 25);
            this.dateTimePicker_ilk.TabIndex = 1;
            this.dateTimePicker_ilk.ValueChanged += new System.EventHandler(this.dateTimePicker_ilk_ValueChanged);
            // 
            // dateTimePicker_son
            // 
            this.dateTimePicker_son.Location = new System.Drawing.Point(307, 31);
            this.dateTimePicker_son.Name = "dateTimePicker_son";
            this.dateTimePicker_son.Size = new System.Drawing.Size(164, 25);
            this.dateTimePicker_son.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_teslimatagorearaclar);
            this.groupBox1.Location = new System.Drawing.Point(5, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 377);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // dtg_teslimatagorearaclar
            // 
            this.dtg_teslimatagorearaclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_teslimatagorearaclar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_teslimatagorearaclar.Location = new System.Drawing.Point(3, 21);
            this.dtg_teslimatagorearaclar.Name = "dtg_teslimatagorearaclar";
            this.dtg_teslimatagorearaclar.Size = new System.Drawing.Size(855, 353);
            this.dtg_teslimatagorearaclar.TabIndex = 0;
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(682, 436);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(93, 37);
            this.btn_listele.TabIndex = 3;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(781, 436);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(85, 37);
            this.btn_kapat.TabIndex = 4;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_ileri
            // 
            this.btn_ileri.Location = new System.Drawing.Point(53, 9);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(25, 24);
            this.btn_ileri.TabIndex = 29;
            this.btn_ileri.Text = "↪";
            this.btn_ileri.UseVisualStyleBackColor = true;
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(19, 9);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(28, 23);
            this.btn_geri.TabIndex = 28;
            this.btn_geri.Text = "↩";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Teslimata_Göre_Araçlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(879, 485);
            this.Controls.Add(this.btn_ileri);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker_son);
            this.Controls.Add(this.dateTimePicker_ilk);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Teslimata_Göre_Araçlar";
            this.Text = "Teslimata_Göre_Araçlar";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_teslimatagorearaclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ilk;
        private System.Windows.Forms.DateTimePicker dateTimePicker_son;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_teslimatagorearaclar;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.Button btn_geri;
    }
}