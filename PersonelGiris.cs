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
using OBUZ_ILETISIM.DL;

namespace OBUZ_ILETISIM
{
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Personel Where PersonelIsimSoyisim=@p1 and PersonelSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Personel_UrünModülü fr = new Personel_UrünModülü();
                fr.Show();
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Hatalı giriş!");
            }
            bgl.baglanti().Close();
        }
    }
}
