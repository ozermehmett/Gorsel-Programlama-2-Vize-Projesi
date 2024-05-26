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
    public partial class FormBilgiGuncelle : Form
    {
        public FormBilgiGuncelle()
        {
            InitializeComponent();
        }

        public String TC;
        SqlBaglantisi baglan = new SqlBaglantisi();

        private void FormBilgiGuncelle_Load(object sender, EventArgs e)
        {
            maskedTC.Text = TC;
            SqlCommand komut = new SqlCommand("Select * From Table_Hastalar Where HastaTC='" + TC + "'", baglan.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textAd.Text = dr[1].ToString();
                textSoyad.Text = dr[2].ToString();
                textSifre.Text = dr[4].ToString();
                comboCinsiyet.Text = dr[5].ToString();
                maskedTelNo.Text = dr[6].ToString();
            }
            baglan.baglanti().Close();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Table_Hastalar set HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3, HastaSifre=@p4, HastaCinsiyet=@p5 Where HastaTC=@p6", baglan.baglanti());
            komut2.Parameters.AddWithValue("@p1", textAd.Text);
            komut2.Parameters.AddWithValue("@p2", textSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", maskedTelNo.Text);
            komut2.Parameters.AddWithValue("@p4", textSifre.Text);
            komut2.Parameters.AddWithValue("@p5", comboCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", maskedTC.Text);
            komut2.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellendi", "Bilgi", MessageBoxButtons.OK);
        }
    }
}
