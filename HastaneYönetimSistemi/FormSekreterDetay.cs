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
    public partial class FormSekreterDetay : Form
    {
        public FormSekreterDetay()
        {
            InitializeComponent();
        }

        public String TC;

        SqlBaglantisi baglan = new SqlBaglantisi();

        private void FormSekreterDetay_Load(object sender, EventArgs e)
        {
            labelTc.Text = TC;

            // Ad Soyad
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Table_Sekreter Where SekreterTC=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", TC);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelADSoyad.Text = dr[0].ToString();
            }
            baglan.baglanti().Close();


            //Branşları DataGrid'e aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Branslar", baglan.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            //Doktorları DataGrid'e aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'DoktorAdSoyad', DoktorBrans From Table_Doktorlar", baglan.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;


            //Branşı combobox'a aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Table_Branslar", baglan.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            comboBrans.Items.Clear();
            while (dr2.Read())
            {
                comboBrans.Items.Add(dr2[0].ToString());
            }
            baglan.baglanti().Close();
            

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutKaydet = new SqlCommand("insert into Table_Randevular(RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) values (@p1, @p2, @p3, @p4)", baglan.baglanti());
            komutKaydet.Parameters.AddWithValue("@p1", maskedTarih.Text);
            komutKaydet.Parameters.AddWithValue("@p2", maskedSaat.Text);
            komutKaydet.Parameters.AddWithValue("@p3", comboBrans.Text);
            komutKaydet.Parameters.AddWithValue("@p4", comboDoktor.Text);
            komutKaydet.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Randevu oluşturuldu", "Bilgi", MessageBoxButtons.OK);
        }

        private void comboBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd, DoktorSoyad From Table_Doktorlar Where DoktorBrans=@p1", baglan.baglanti());
            komut3.Parameters.AddWithValue("@p1", comboBrans.Text);
            SqlDataReader dr = komut3.ExecuteReader();
            while (dr.Read())
            {
                comboDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            baglan.baglanti().Close();
        }

        private void buttonYayinla_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Table_Duyurular (Duyuru) values (@p1)", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", richDuyuru.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu", "Bilgi", MessageBoxButtons.OK);
        }

        private void buttonDoktorPaneli_Click(object sender, EventArgs e)
        {
            FormDoktorPaneli fr = new FormDoktorPaneli();
            fr.Show();
        }

        private void buttonBransPaneli_Click(object sender, EventArgs e)
        {
            Branşlar fr = new Branşlar();
            fr.Show();
        }

        private void buttonRandevuListesi_Click(object sender, EventArgs e)
        {
            FormRandevuListesi fr = new FormRandevuListesi();
            fr.Show();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void buttonDuyurular_Click(object sender, EventArgs e)
        {
            FormDuyurular fr = new FormDuyurular();
            fr.Show();
        }
    }
}
