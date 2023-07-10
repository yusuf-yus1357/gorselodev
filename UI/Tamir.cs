using OBUZ_ILETISIM.DL;
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

namespace OBUZ_ILETISIM
{
    public partial class Tamir : Form
    {
        public Tamir()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Tamir_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from UrünTamir", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void btnTamirEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO UrünTamir(UrünKimlik,UrünIsim,UrünMarka,TamirSebep,MüşteriTel) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtUrünKimlikNo.Text);
            komut.Parameters.AddWithValue("@p2", txtUrünIsim.Text);
            komut.Parameters.AddWithValue("@p3", txtUrünMarka.Text);
            komut.Parameters.AddWithValue("@p4", txtTamirSebep.Text);
            komut.Parameters.AddWithValue("@p5", txtMüşteriTel.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Sıranız alınmıştır! \n Lütfen beklemeye geçiniz..");
        }
    }
}
