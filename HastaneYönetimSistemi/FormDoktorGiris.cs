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
    public partial class FormDoktorGiris : Form
    {
        public FormDoktorGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Table_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTc.Text);
            komut.Parameters.AddWithValue("@p2", textSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FormDoktorDetay fr = new FormDoktorDetay();
                fr.TC = maskedTc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
            baglan.baglanti().Close();

        }
    }
}
