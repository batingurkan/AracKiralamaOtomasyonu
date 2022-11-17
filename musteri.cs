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

namespace AracKiralama
{
    public partial class musteriFrm : Form
    {
        public musteriFrm()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=BATIN-PC\SQLEXPRESS;Initial Catalog = arackirala; Integrated Security = True";
        private void musteriEkleBtn_Click(object sender, EventArgs e)
        {

        }
        public void Musteri_Listele()
        {

            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * From musteri";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void soyTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void musteriFrm_Load(object sender, EventArgs e)
        {
            Musteri_Listele();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
