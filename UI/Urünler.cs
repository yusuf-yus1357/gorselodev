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
using System.Data.SqlClient;

namespace OBUZ_ILETISIM
{
    public partial class Urünler : Form
    {
        public Urünler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Urünler_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Urünler", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Urünler where UrünID = @p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Satın Alma İşlemi Başarılı Bir Şekilde Gerçekleşmiştir. Güle Güle Kullanın!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
