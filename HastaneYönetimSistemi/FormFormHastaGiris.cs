using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYönetimSistemi
{
    public partial class FormFormHastaGiris : Form
    {
        public FormFormHastaGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        private void linkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHastaKayit fr=new FormHastaKayit();
            fr.Show();
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Table_Hastalar Where HastaTC=@p1 and HastaSifre=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTc.Text);
            komut.Parameters.AddWithValue("@p2", textSifre.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                FormHastaDetay fr = new FormHastaDetay();
                fr.TC = maskedTc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Denemesi");
            }
            baglan.baglanti().Close();
        }
    }
}
