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
    public partial class FormHastaKayit : Form
    {
        public FormHastaKayit()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        private void buttonKayitOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Table_Hastalar (HastaAd, HastaSoyad, HastaTC, HastaSifre, HastaCinsiyet, HastaTelefon) values (@p1, @p2, @p3, @p4, @p5, @p6)", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", textAd.Text);
            komut.Parameters.AddWithValue("@p2", textSoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTC.Text);
            komut.Parameters.AddWithValue("@p4", textSifre.Text);
            komut.Parameters.AddWithValue("@p5", comboCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", maskedTelNo.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Kaydınız gerçekleşmiştir, Şifreniz: " + textSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
