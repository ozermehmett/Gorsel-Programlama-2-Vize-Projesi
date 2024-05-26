using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYönetimSistemi
{
    public partial class FormGirisler : Form
    {
        public FormGirisler()
        {
            InitializeComponent();
        }

        private void buttonHastaGiris_Click(object sender, EventArgs e)
        {
            FormFormHastaGiris fr= new FormFormHastaGiris();
            fr.Show();
            //this.Hide();
        }

        private void buttonDoktorGiris_Click(object sender, EventArgs e)
        {
            FormDoktorGiris fr= new FormDoktorGiris();
            fr.Show();
            //this.Hide();
        }

        private void buttonSekreterGiris_Click(object sender, EventArgs e)
        {
            FormSekreterGiris fr= new FormSekreterGiris();
            fr.Show();
            //this.Hide();
        }
    }
}
