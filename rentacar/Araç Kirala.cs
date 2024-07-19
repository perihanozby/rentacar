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
    public partial class Araç_Kirala : Form
    {
        public Araç_Kirala()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void arama()
        {
            
        }
       

       

       

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }

        private void Araç_Kirala_Load(object sender, EventArgs e)
        {

        }

        private void btn_arackirala_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_arackiraları(musteriid,aracid,alislokasyonuid,teslimatlokasyonuid,baslangictarihi,bitistarihi,cikisKM,teslimatKM,kiralamasuresi,kiralamatutari,masraftoplamlari,bakiye) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txt.Text);
            komut.Parameters.AddWithValue("@p2", cmb_marka.Text);
            komut.Parameters.AddWithValue("@p3", msk_model.Text);
            komut.Parameters.AddWithValue("@p4", numeric_yil.Text);
            komut.Parameters.AddWithValue("@p5", msk_plaka.Text);
            komut.Parameters.AddWithValue("@p6", cmb_kasa.Text);
            komut.Parameters.AddWithValue("@p7", cmb_renk.Text);
            komut.Parameters.AddWithValue("@p8", numeric_silindirhacim.Text);
            komut.Parameters.AddWithValue("@p9", numeric_motorgucu.Text);
            komut.Parameters.AddWithValue("@p10", cmb_yakit.Text);
            komut.Parameters.AddWithValue("@p11", numeric_ucret.Text);
            komut.Parameters.AddWithValue("@p12", numeric_bakimperiyodu.Text);
            



            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Araç ekleme başarılı");
        }
    }
}
