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
    public partial class Şubeler : Form
    {
        public Şubeler()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void button4_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btn_subeekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_subeler(subeadi,subeadresi,subetelefonu,subetelefon2,email) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txt_subeadi.Text);
            komut.Parameters.AddWithValue("@p2", rct_adresi.Text);
            komut.Parameters.AddWithValue("@p3", txt_subetelefon.Text);
            komut.Parameters.AddWithValue("@p4", txt_subetelefon2.Text);
            komut.Parameters.AddWithValue("@p5", txt_eposta.Text);
            
            

            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Şube ekleme başarılı");




        }

        private void btn_subesil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_subeler where subeadi=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_subeadi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şube Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

           


        }

        private void Şubeler_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From tbl_subeler ", bgl.baglanti());
            da1.Fill(dt1);
            dtg_subeler.DataSource = dt1;


           
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_subeler set subeadresi=@d1,subetelefonu=@d2,subetelefon2=@d3,email=@d4 where subeadi=@d5", bgl.baglanti());
            komut.Parameters.AddWithValue("@d5", txt_subeadi.Text);
            komut.Parameters.AddWithValue("@d2", txt_subetelefon.Text);
            komut.Parameters.AddWithValue("@d3", txt_subetelefon2.Text);
            komut.Parameters.AddWithValue("@d4", txt_eposta.Text);
            komut.Parameters.AddWithValue("@d1", rct_adresi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtg_subeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtg_subeler.SelectedCells[0].RowIndex;
            txt_subeadi.Text = dtg_subeler.Rows[secilen].Cells[1].Value.ToString();
            txt_subetelefon.Text = dtg_subeler.Rows[secilen].Cells[2].Value.ToString();
            txt_subetelefon2.Text = dtg_subeler.Rows[secilen].Cells[3].Value.ToString();
            txt_eposta.Text = dtg_subeler.Rows[secilen].Cells[4].Value.ToString();
            rct_adresi.Text = dtg_subeler.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
