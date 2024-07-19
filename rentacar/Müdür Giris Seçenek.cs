using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace rentacar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string tc;
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void button2_Click(object sender, EventArgs e)
        {
            Müşteriler fr = new Müşteriler();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araçlar fr = new Araçlar();
            fr.Show();
        }

        private void şubeTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Şubeler fr = new Şubeler();
            fr.Show();
            this.Hide();
        }

        private void kuullanıcıTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullanıcılar fr = new Kullanıcılar();
            fr.Show();
            this.Hide();
        }

        private void araçTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            araç_ekle_düzenle fr = new araç_ekle_düzenle();
            fr.Show();
            this.Hide();
        }

        private void müşteriTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Müşteriler fr = new Müşteriler();
            fr.Show();
            this.Hide();
        }

        private void araçRezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezervasyon_ekle_düzenle fr = new Rezervasyon_ekle_düzenle();
            fr.Show();
            this.Hide();
        }

        private void araçKiralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Araç_Kirala fr = new Araç_Kirala();
            fr.Show();
            this.Hide();
        }

        private void araçBakımaAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aracı_Bakıma_Al fr = new Aracı_Bakıma_Al();
            fr.Show();
            this.Hide();
        }

        private void araçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Araçlar fr = new Araçlar();
            fr.Show();
            this.Hide();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Müşteriler fr = new Müşteriler();
            fr.Show();
            this.Hide();
        }

        private void rezervasyonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezervasyon_ekle_düzenle fr = new Rezervasyon_ekle_düzenle();
            fr.Show();
            this.Hide();
        }

        private void müşteriİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Müşteri_İstatistikleri fr = new Müşteri_İstatistikleri();
            fr.Show();
            this.Hide();
        }

        private void araçİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arac_istatistikleri fr = new arac_istatistikleri();
            fr.Show();
            this.Hide();
        }

        private void bakımiİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bakım_İstatistikleri fr = new Bakım_İstatistikleri();
            fr.Show();
            this.Hide();
        }

        private void teslimataGöreAraçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teslimata_Göre_Araçlar fr = new Teslimata_Göre_Araçlar();
            fr.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btn_adsoyad.Text = tc;
            SqlCommand komut = new SqlCommand("select adi,soyadi from tbl_mudurgiris where tc=@p1" + "", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", btn_adsoyad.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                btn_adsoyad.Text = dr[0] + " " + dr[1];

            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                //MessageBox.Show("");// hiçbir işlem yaptırmıyorum
            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

       
    }
}
