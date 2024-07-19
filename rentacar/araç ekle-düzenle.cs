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
    public partial class araç_ekle_düzenle : Form
    {
        public araç_ekle_düzenle()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_araclar (subeid,marka,model,yil,plaka,kasa,renk,silindirhacmi,motorgucu,yakit,ucret,bakimperiyodu,sigortabitistarihi,muayenebitistarihi,kaskobitistarihi,emisyonbitistarihi,kayittarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", cmb_subeid.Text);
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
            komut.Parameters.AddWithValue("@p13", txt_sigortabitistarihi.Text);
            komut.Parameters.AddWithValue("@p14", txt_muayenebitistarihi.Text);
            komut.Parameters.AddWithValue("@p15", txt_kaskobitistarihi.Text);
            komut.Parameters.AddWithValue("@p16", txt_emisyonbitistarihi.Text);
            komut.Parameters.AddWithValue("@p17", txt_kayittarihi.Text);
            
            

            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Araç ekleme başarılı");
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_araclar set subeid=@p1,marka=@p2,model=@p3,yil=@p4,plaka=@p5,kasa=@p6,renk=@p7,silindirhacmi=@p8,motorgucu=@p9,yakit=@p10,ucret=@p11,bakimperiyodu=@p12,sigortabitistarihi=@p13,muayenebitistarihi=@p14,kaskobitistarihi=@p15,emisyonbitistarihi=@p16,kayittarihi=@p17", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", cmb_subeid.Text);
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
            komut.Parameters.AddWithValue("@p13", txt_sigortabitistarihi.Text);
            komut.Parameters.AddWithValue("@p14", txt_muayenebitistarihi.Text);
            komut.Parameters.AddWithValue("@p15", txt_kaskobitistarihi.Text);
            komut.Parameters.AddWithValue("@p16", txt_emisyonbitistarihi.Text);
            komut.Parameters.AddWithValue("@p17", txt_kayittarihi.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void araç_ekle_düzenle_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From tbl_araclar ", bgl.baglanti());
            da1.Fill(dt1);
            dtg_aracekleduzenle.DataSource = dt1;


        }

        private void dtg_aracekleduzenle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtg_aracekleduzenle.SelectedCells[0].RowIndex;
            cmb_subeid.Text = dtg_aracekleduzenle.Rows[secilen].Cells[1].Value.ToString();
            cmb_marka.Text = dtg_aracekleduzenle.Rows[secilen].Cells[2].Value.ToString();
            msk_model.Text = dtg_aracekleduzenle.Rows[secilen].Cells[3].Value.ToString();
            msk_plaka.Text = dtg_aracekleduzenle.Rows[secilen].Cells[4].Value.ToString();
            cmb_kasa.Text = dtg_aracekleduzenle.Rows[secilen].Cells[5].Value.ToString();
            cmb_renk.Text = dtg_aracekleduzenle.Rows[secilen].Cells[6].Value.ToString();
            cmb_yakit.Text = dtg_aracekleduzenle.Rows[secilen].Cells[7].Value.ToString();
            numeric_silindirhacim.Text = dtg_aracekleduzenle.Rows[secilen].Cells[8].Value.ToString();
            numeric_motorgucu.Text = dtg_aracekleduzenle.Rows[secilen].Cells[9].Value.ToString();
            numeric_ucret.Text = dtg_aracekleduzenle.Rows[secilen].Cells[10].Value.ToString();
            numeric_bakimperiyodu.Text = dtg_aracekleduzenle.Rows[secilen].Cells[11].Value.ToString();
            numeric_yil.Text = dtg_aracekleduzenle.Rows[secilen].Cells[12].Value.ToString();
            txt_sigortabitistarihi.Text = dtg_aracekleduzenle.Rows[secilen].Cells[13].Value.ToString();
            txt_muayenebitistarihi.Text = dtg_aracekleduzenle.Rows[secilen].Cells[14].Value.ToString();
            txt_kaskobitistarihi.Text = dtg_aracekleduzenle.Rows[secilen].Cells[15].Value.ToString();
            txt_emisyonbitistarihi.Text = dtg_aracekleduzenle.Rows[secilen].Cells[16].Value.ToString();
            txt_kayittarihi.Text = dtg_aracekleduzenle.Rows[secilen].Cells[17].Value.ToString();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
