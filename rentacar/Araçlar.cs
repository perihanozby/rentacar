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
    public partial class Araçlar : Form
    {
        public Araçlar()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void button9_Click(object sender, EventArgs e)
        {
            Rezervasyon_ekle_düzenle fr = new Rezervasyon_ekle_düzenle();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Aracı_Bakıma_Al fr = new Aracı_Bakıma_Al();
            fr.Show();
        }

        private void btn_aracekle_Click(object sender, EventArgs e)
        {
            araç_ekle_düzenle fr = new araç_ekle_düzenle();
            fr.Show();

        }

        private void btn_aracdüzenle_Click(object sender, EventArgs e)
        {
            araç_ekle_düzenle fr = new araç_ekle_düzenle();
            fr.Show();
        }

        private void btn_kirala_Click(object sender, EventArgs e)
        {
            Araç_Kirala fr = new Araç_Kirala();
            fr.Show();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From tbl_subeler ", bgl.baglanti());
            da1.Fill(dt1);
            dtg_araclar.DataSource = dt1;

        }

        private void Araçlar_Load(object sender, EventArgs e)
        {

        }

        private void arama()
        {
            string query = "Select * From tbl_subeler where subeadi='" + cmb_sube.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, bgl.baglanti());
            SqlCommandBuilder ba = new SqlCommandBuilder();
            var ds = new DataSet();
            da.Fill(ds);
            dtg_araclar.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            arama();
        }

        private void btn_bakimbitisi_Click(object sender, EventArgs e)
        {
            Aracı_Bakıma_Al fr = new Aracı_Bakıma_Al();
            fr.Show();
            this.Hide();
        }

        private void btn_gecmiskiralamalari_Click(object sender, EventArgs e)
        {

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
