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
    public partial class Personel_UrünModülü : Form
    {
        public Personel_UrünModülü()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtUrünID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtUrünKimlikNo.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtUrünIsim.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskUrünMarka.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtUrünÖzellikBilgi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            UrünFiyat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Personel_UrünModülü_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Urünler", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void btnUrünEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Urünler(UrünKimlik,UrünIsim,UrünMarka,UrünOzellik,UrünFiyat) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());


            komut.Parameters.AddWithValue("@p1", txtUrünKimlikNo.Text);
            komut.Parameters.AddWithValue("@p2", txtUrünIsim.Text);
            komut.Parameters.AddWithValue("@p3", mskUrünMarka.Text);
            komut.Parameters.AddWithValue("@p4", txtUrünÖzellikBilgi.Text);
            komut.Parameters.AddWithValue("@p5", UrünFiyat.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Ürün başarılı bir şekilde Eklenmiştir!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtUrünID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtUrünKimlikNo.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtUrünIsim.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskUrünMarka.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtUrünÖzellikBilgi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            UrünFiyat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnUrünGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Urünler set UrünKimlik=@p1,UrünIsim=@p2,UrünMarka=@p3, UrünOzellik=@p4,UrünFiyat=@p5 where UrünKimlik = @p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p5", txtUrünKimlikNo.Text);
            komut.Parameters.AddWithValue("@p1", txtUrünIsim.Text);
            komut.Parameters.AddWithValue("@p2", mskUrünMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtUrünÖzellikBilgi.Text);
            komut.Parameters.AddWithValue("@p4", UrünFiyat.Text);


            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Urün Güncelleme İşlemi Başarıyla Yapılmıştır.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Urünler where UrünID = @p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtUrünID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Urün Başarılı Bir Şekilde Silinmiştir.");
        }
    }
}
