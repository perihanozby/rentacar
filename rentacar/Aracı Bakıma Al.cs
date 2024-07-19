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
    public partial class Aracı_Bakıma_Al : Form
    {
        public Aracı_Bakıma_Al()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aracı_Bakıma_Al_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From tbl_araclar ", bgl.baglanti());
            da1.Fill(dt1);
            dtg_degisenparcalar.DataSource = dt1;

            //marka ve model Combobox'a Aktarma

            SqlCommand komut2 = new SqlCommand("Select marka,model From tbl_araclar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_marka.Items.Add(dr2[0]);
                cmb_model.Items.Add(dr2[1]);

            }
            bgl.baglanti().Close();






        }
        private void arama()
        {
            string query = "Select * From tbl_araclar where plaka='" + txt_plaka.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, bgl.baglanti());
            SqlCommandBuilder ba = new SqlCommandBuilder();
            var ds = new DataSet();
            da.Fill(ds);
            dtg_degisenparcalar.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }


        private void btn_ara_Click(object sender, EventArgs e)
        {
            arama();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("insert into tbl_degisenparcalar (bakimid,aciklama,tutar) Where bakimid=@p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", dtg_degisenparcalar.Text);
            

            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("ekleme başarılı");
            
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            if

                (dtg_degisenparcalar.SelectedRows.Count > 0)

            {
                //seçili satırı siliyoruz.
                dtg_degisenparcalar.Rows.RemoveAt(dtg_degisenparcalar.SelectedRows[0].Index);
            }

            else

            {

                MessageBox.Show("“Lüffen Silinecek Satırı Seçin!”");

            }




            /*
            SqlCommand komut = new SqlCommand("delete tbl_degisenparcalar where bakimid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", dtg_degisenparcalar.Text.ToString());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Seçilen Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
