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
    public partial class FormHastaDetay : Form
    {
        public FormHastaDetay()
        {
            InitializeComponent();
        }

        public String TC;

        SqlBaglantisi baglan = new SqlBaglantisi();

        private void FormHastaDetay_Load(object sender, EventArgs e)
        {
            labelTc.Text = TC;

            //Ad Soyad çekme
            SqlCommand komut = new SqlCommand("Select HastaAd, HastaSoyad From Table_Hastalar Where HastaTC=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", labelTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelADSoyad.Text = dr[0] + " " + dr[1];
            }
            baglan.baglanti().Close();

            // Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Randevular Where HastaTC="+TC, baglan.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.baglanti().Close();

            //Branşları çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Table_Branslar", baglan.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBrans.Items.Add(dr2[0]);
            }
            baglan.baglanti().Close();


        }

        //Doktor seçimi
        private void comboBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDoktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select DoktorAd, DoktorSoyad From Table_Doktorlar Where DoktorBrans=@p1", baglan.baglanti());
            komut3.Parameters.AddWithValue("@p1", comboBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            baglan.baglanti().Close();
        }

        private void comboDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Table_Randevular Where RandevuBrans='" + comboBrans.Text + "'" + " and RandevuDoktor='" + comboDoktor.Text + "' and RandevuDurum=0", baglan.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            baglan.baglanti().Close();

        }

        private void linkBilgiGuncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBilgiGuncelle fr = new FormBilgiGuncelle();
            fr.TC = labelTc.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textRandevuId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();

        }

        private void buttonRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Table_Randevular set RandevuDurum=1, HastaTC=@p1, HastaSikayet=@p2 Where Randevuid=@p3", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", labelTc.Text);
            komut.Parameters.AddWithValue("@p2", richSikayet.Text);
            komut.Parameters.AddWithValue("@p3", textRandevuId.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Randevu Başarıyla Alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
