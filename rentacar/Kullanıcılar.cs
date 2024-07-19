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
    public partial class Kullanıcılar : Form
    {
        public Kullanıcılar()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void btn_kullaniciekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_kullanicilar (subeid,kullaniciİd,parola,adi,soyadi,telefonu,telefonu2,adresi,isegiristarihi,dogumtarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", cmb_sube.Text);
            komut.Parameters.AddWithValue("@p2", txt_kullaniciid.Text);
            komut.Parameters.AddWithValue("@p3", txt_parola.Text);
            komut.Parameters.AddWithValue("@p4", txt_adi.Text);
            komut.Parameters.AddWithValue("@p5", txt_soyadi.Text);
            komut.Parameters.AddWithValue("@p6", txt_telefonu.Text);
            komut.Parameters.AddWithValue("@p7", txt_telefonu2.Text);
            komut.Parameters.AddWithValue("@p8", rct_adresi.Text);
            komut.Parameters.AddWithValue("@p9", dateTimePicker_isegiristarihi.Text);
            komut.Parameters.AddWithValue("@p10", dateTimePicker_dogumtarihi.Text);

            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Kullanıcı ekleme başarılı");
        }

        private void btn_kullanicisil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete tbl_kullanicilar where kullaniciİd=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_kullaniciid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_bilgigüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_kullanicilar set subeid=@p1,kullaniciİd=@p2,parola=@p3,adi=@p4,soyadi=@p5,telefonu=@p6,telefonu2=@p7,adresi=@p8,isegiristarihi=@p9,dogumtarihi=@p10", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", cmb_sube.Text);
            komut.Parameters.AddWithValue("@p2", txt_kullaniciid.Text);
            komut.Parameters.AddWithValue("@p3", txt_parola.Text);
            komut.Parameters.AddWithValue("@p4", txt_adi.Text);
            komut.Parameters.AddWithValue("@p5", txt_soyadi.Text);
            komut.Parameters.AddWithValue("@p6", txt_telefonu.Text);
            komut.Parameters.AddWithValue("@p7", txt_telefonu2.Text);
            komut.Parameters.AddWithValue("@p8", rct_adresi.Text);
            komut.Parameters.AddWithValue("@p9", dateTimePicker_isegiristarihi.Text);
            komut.Parameters.AddWithValue("@p10", dateTimePicker_dogumtarihi.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void Kullanıcılar_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From tbl_kullanicilar ", bgl.baglanti());
            da1.Fill(dt1);
            dtg_kullanicilar.DataSource = dt1;
        }

        private void dtg_kullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtg_kullanicilar.SelectedCells[0].RowIndex;
            txt_kullaniciid.Text = dtg_kullanicilar.Rows[secilen].Cells[1].Value.ToString();
            txt_parola.Text = dtg_kullanicilar.Rows[secilen].Cells[2].Value.ToString();
            txt_adi.Text = dtg_kullanicilar.Rows[secilen].Cells[3].Value.ToString();
            txt_soyadi.Text = dtg_kullanicilar.Rows[secilen].Cells[4].Value.ToString();
            txt_telefonu.Text = dtg_kullanicilar.Rows[secilen].Cells[5].Value.ToString();
            txt_telefonu2.Text = dtg_kullanicilar.Rows[secilen].Cells[6].Value.ToString();
            dateTimePicker_dogumtarihi.Text = dtg_kullanicilar.Rows[secilen].Cells[7].Value.ToString();
            dateTimePicker_isegiristarihi.Text = dtg_kullanicilar.Rows[secilen].Cells[8].Value.ToString();
            cmb_sube.Text = dtg_kullanicilar.Rows[secilen].Cells[9].Value.ToString();
            rct_adresi.Text = dtg_kullanicilar.Rows[secilen].Cells[10].Value.ToString();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            
        }
    }
}
