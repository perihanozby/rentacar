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
    public partial class Teslimata_Göre_Araçlar : Form
    {
        public Teslimata_Göre_Araçlar()
        {
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void btn_listele_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From tbl_rezervasyonlar ",bgl.baglanti());
            da1.Fill(dt1);
            dtg_teslimatagorearaclar.DataSource = dt1;

        }

        private void arama()
        {
            string query = "Select * From tbl_rezervasyonlar where baslangictarihi='" + dateTimePicker_ilk.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, bgl.baglanti());
            SqlCommandBuilder ba = new SqlCommandBuilder();
            var ds = new DataSet();
            da.Fill(ds);
            dtg_teslimatagorearaclar.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }
        private void dateTimePicker_ilk_ValueChanged(object sender, EventArgs e)
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
