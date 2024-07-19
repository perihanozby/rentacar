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
    public partial class arac_istatistikleri : Form
    {
        public arac_istatistikleri()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void arac_istatistikleri_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from tbl_aracistatistikleri", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                lbl_toparacsayisi.Text = dr[0].ToString();
                lbl_topmusterisayisi.Text = dr[1].ToString();
                lbl_topkiralamasayisi.Text = dr[2].ToString();
            }

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from tbl_aracistatistikleri ", bgl.baglanti());
            da1.Fill(dt1);
            dtg_aracistatistikleri.DataSource = dt1;

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
