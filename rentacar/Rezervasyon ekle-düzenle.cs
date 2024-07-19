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
    public partial class Rezervasyon_ekle_düzenle : Form
    {
        public Rezervasyon_ekle_düzenle()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutKaydet = new SqlCommand("insert into tbl_rezervasyonlar (musteriadisoyadi,aracplakano,alislokasyonuid,teslimatlkasyonuid,baslangictarihi,bitistarihi,rezervasyonnotu) values (@r1,@r2,@r3,@r4,@r5,@r6,@r7)", bgl.baglanti());
            komutKaydet.Parameters.AddWithValue("@r1", txt_musteriadisoyadi.Text);
            komutKaydet.Parameters.AddWithValue("@r2", txt_plakano.Text);
            komutKaydet.Parameters.AddWithValue("@r3", cmb_alislokasyonu.Text);
            komutKaydet.Parameters.AddWithValue("@r4", cmb_teslimatlokasyonu.Text);
            komutKaydet.Parameters.AddWithValue("@r5", msk_rezervasyonbaslangic.Text);
            komutKaydet.Parameters.AddWithValue("@r6", msk_rezervasyonbitis.Text);
            komutKaydet.Parameters.AddWithValue("@r7", rct_rezervasyonnot.Text);

            komutKaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Rezervasyon Oluşturuldu");
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
