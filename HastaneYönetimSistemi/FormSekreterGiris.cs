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
    public partial class FormSekreterGiris : Form
    {
        public FormSekreterGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Table_Sekreter Where SekreterTC=@p1 and SekreterSifre=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTc.Text);
            komut.Parameters.AddWithValue("@p2", textSifre.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                FormSekreterDetay fr = new FormSekreterDetay();
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
