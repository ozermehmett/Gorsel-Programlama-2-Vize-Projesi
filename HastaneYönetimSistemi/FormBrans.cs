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
    public partial class Branşlar : Form
    {
        public Branşlar()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        private void FormBrans_Load(object sender, EventArgs e)
        {
            //Branşı combobox'a aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Branslar", baglan.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Table_Branslar (BransAd) values(@p1)", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", textBransAd.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBransid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Table_Branslar Where Bransid=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", textBransid.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Branş Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Table_Branslar set BransAd=@p1 Where Bransid=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", textBransAd.Text);
            komut.Parameters.AddWithValue("@p2", textBransid.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Branş Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
