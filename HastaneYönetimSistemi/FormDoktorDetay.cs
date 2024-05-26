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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneYönetimSistemi
{
    public partial class FormDoktorDetay : Form
    {
        public FormDoktorDetay()
        {
            InitializeComponent();
        }

        public string TC;
        SqlBaglantisi baglan = new SqlBaglantisi();

        private void FormDoktorDetay_Load(object sender, EventArgs e)
        {
            labelTc.Text = TC;

            //Doktor Ad Soyad
            SqlCommand komut = new SqlCommand("Select DoktorAd, DoktorSoyad From Table_Doktorlar where DoktorTC='" + labelTc.Text + "'", baglan.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelADSoyad.Text = dr[0] + " " + dr[1];
            }
            baglan.baglanti().Close();


            //Randevu listesi getirme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Randevular Where RandevuDoktor='" + labelADSoyad.Text + "'", baglan.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void buttonBilgiGuncelle_Click(object sender, EventArgs e)
        {
            FormDoktorBilgiDuzenle fr = new FormDoktorBilgiDuzenle();
            fr.TC = labelTc.Text;
            fr.Show();
        }

        private void buttonDuyurular_Click(object sender, EventArgs e)
        {
            FormDuyurular fr = new FormDuyurular();
            fr.Show();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
