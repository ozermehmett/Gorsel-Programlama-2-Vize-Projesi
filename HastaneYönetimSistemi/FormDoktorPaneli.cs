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
    public partial class FormDoktorPaneli : Form
    {
        public FormDoktorPaneli()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();
        
        private void FormDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Table_Doktorlar", baglan.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

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

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Table_Doktorlar (DoktorAd, DoktorSoyad, DoktorTC, DoktorSifre, DoktorBrans) values (@p1, @p2, @p3, @p4, @p5)", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", textAd.Text);
            komut.Parameters.AddWithValue("@p2", textSoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTc.Text);
            komut.Parameters.AddWithValue("@p4", textSifre.Text);
            komut.Parameters.AddWithValue("@p5", comboBrans.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Doktor başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            maskedTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            comboBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Table_Doktorlar Where DoktorTC=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTc.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Table_Doktorlar set DoktorAd=@p1, DoktorSoyad=@p2, DoktorBrans=@p3, DoktorSifre=@p5 Where DoktorTC=@p4", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", textAd.Text);
            komut.Parameters.AddWithValue("@p2", textSoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBrans.Text);
            komut.Parameters.AddWithValue("@p4", maskedTc.Text);
            komut.Parameters.AddWithValue("@p5", textSifre.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Doktor Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
