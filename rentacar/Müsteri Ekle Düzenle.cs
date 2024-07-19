using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace rentacar
{
    public partial class Yeni_Müşteri_ekle : Form
    {
        public Yeni_Müşteri_ekle()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_customers (adi,soyadi,telefon,telefon2,adresi,email,tc,babaadi,anneadi,dogumyeri,dogumtarihi,nufusil,nufusilce,nufusmahallekoy,nufuscuzdanno,nufussongecerlilik,ehliyetbelgeno,ehliyetil,ehliyetilce,ehliyetverilistarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txt_adi.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyadi.Text);
            komut.Parameters.AddWithValue("@p3", txt_telefon.Text);
            komut.Parameters.AddWithValue("@p4", txt_telefon2.Text);
            komut.Parameters.AddWithValue("@p5", txt_adres.Text);
            komut.Parameters.AddWithValue("@p6", txt_email.Text);
            komut.Parameters.AddWithValue("@p7", msk_tc.Text);
            komut.Parameters.AddWithValue("@p8", txt_babaadi.Text);
            komut.Parameters.AddWithValue("@p9", txt_anneadi.Text);
            komut.Parameters.AddWithValue("@p10", cmb_dogumyeri.Text);
            komut.Parameters.AddWithValue("@p11", msk_dogumtarihi.Text);
            komut.Parameters.AddWithValue("@p12", cmb_il.Text);
            komut.Parameters.AddWithValue("@p13", cmb_ilce.Text);
            komut.Parameters.AddWithValue("@p14", cmb_mahalle.Text);
            komut.Parameters.AddWithValue("@p15", txt_nufuscuzdanno.Text);
            komut.Parameters.AddWithValue("@p16", msk_songecerlilik.Text);
            komut.Parameters.AddWithValue("@p17", txt_ehilyetbelgeno.Text);
            komut.Parameters.AddWithValue("@p18", txt_ehliyetil.Text);
            komut.Parameters.AddWithValue("@p19", txt_ehliyetilce.Text);
            komut.Parameters.AddWithValue("@p20", txt_ehliyetverilistarihi.Text);

            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Müşteri ekleme başarılı");
        }

        private void Yeni_Müşteri_ekle_Load(object sender, EventArgs e)
        {

        }

        private void arama()
        {/*
            string query = "Select * From tbl_araclar where plaka='" + msk_tc.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, bgl.baglanti());
            SqlCommandBuilder ba = new SqlCommandBuilder();
            var ds = new DataSet();
            da.Fill(ds);
            
            bgl.baglanti().Close();
            */
        }
        private void btn_ara_Click(object sender, EventArgs e)
        {
            arama();

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
