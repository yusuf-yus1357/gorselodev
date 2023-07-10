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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnÜrünler_Click(object sender, EventArgs e)
        {
            Urünler ürün = new Urünler();
            ürün.Show();
            
        }

        private void btnTamir_Click(object sender, EventArgs e)
        {
            Tamir tamir = new Tamir();
            tamir.Show();
        }

        private void btnKontör_Click(object sender, EventArgs e)
        {
            Kontör kontör = new Kontör();
            kontör.Show();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Urünler", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void btnPersonelGiriş_Click(object sender, EventArgs e)
        {
            PersonelGiris pg = new PersonelGiris();
            pg.Show();
        }
    }
}
