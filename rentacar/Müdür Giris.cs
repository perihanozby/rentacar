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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String tc;
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut=new SqlCommand("Select * from tbl_mudurgiris Where tc=@p1 and sifre=@p2",bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txt_TC.Text);
            komut.Parameters.AddWithValue("@p2", txt_sifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 fr = new Form2();
                fr.tc = txt_TC.Text;
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre");
            }
            bgl.baglanti().Close();
        }

        
        }
    }

