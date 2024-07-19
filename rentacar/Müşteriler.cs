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
    public partial class Müşteriler : Form
    {
        public Müşteriler()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void button4_Click(object sender, EventArgs e)
        {
            Araç_Kirala fr = new Araç_Kirala();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yeni_Müşteri_ekle fr = new Yeni_Müşteri_ekle();
            fr.Show();
        }

        private void btn_musteriduzenle_Click(object sender, EventArgs e)
        {
            Yeni_Müşteri_ekle fr = new Yeni_Müşteri_ekle();
            fr.Show();

        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From tbl_customers ", bgl.baglanti());
            da1.Fill(dt1);
            dtg_musteriler.DataSource = dt1;
        }

        private void btn_aracrezerveet_Click(object sender, EventArgs e)
        {
            Rezervasyon_ekle_düzenle fr = new Rezervasyon_ekle_düzenle();
            fr.Show();
        }

        private void btn_gecmiskiralamalari_Click(object sender, EventArgs e)
        {
            Müşteri_İstatistikleri fr = new Müşteri_İstatistikleri();
            fr.Show();
        }

        private void Müşteriler_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From tbl_customers ", bgl.baglanti());
            da1.Fill(dt1);
            dtg_musteriler.DataSource = dt1;
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
