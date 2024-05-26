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

namespace HastaneYönetimSistemi
{
    public partial class FormDoktorBilgiDuzenle : Form
    {
        public FormDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TC;

        SqlBaglantisi baglan = new SqlBaglantisi();

        private void FormDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            maskedTC.Text = TC;

            SqlCommand komut = new SqlCommand("Select * From Table_Doktorlar Where DoktorTC=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textAd.Text = dr[1].ToString();
                textSoyad.Text = dr[2].ToString();
                comboBrans.Text = dr[3].ToString();
                textSifre.Text = dr[5].ToString();
            }
            baglan.baglanti().Close();

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Table_Doktorlar set DoktorAd=@p1, DoktorSoyad=@p2, DoktorSifre=@p3, DoktorBrans=@p4 where DoktorTC=@p5", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", textAd.Text);
            komut.Parameters.AddWithValue("@p2", textSoyad.Text);
            komut.Parameters.AddWithValue("@p3", textSifre.Text);
            komut.Parameters.AddWithValue("@p4", comboBrans.Text);
            komut.Parameters.AddWithValue("@p5", maskedTC.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Doktor Bilgileri Güncellendi");
        }
    }
}
