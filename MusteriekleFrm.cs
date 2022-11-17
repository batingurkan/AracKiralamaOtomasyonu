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

namespace AracKiralama
{
    public partial class MusteriekleFrm : Form
    {
        public MusteriekleFrm()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=BATIN-PC\SQLEXPRESS;Initial Catalog = arackirala; Integrated Security = True";
        private void MusteriekleFrm_Load(object sender, EventArgs e)
        {

        }

        private void musteriEkleBtn_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Into musteri values (@tcno,@adı,@soyadı,@eposta,@telefonno,@cinsiyet)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.Parameters.AddWithValue("@tcno", tcTb.Text);
            komut.Parameters.AddWithValue("@adı", adTb.Text);
            komut.Parameters.AddWithValue("@soyadı", soyTb.Text);
            komut.Parameters.AddWithValue("@eposta", epostTb.Text);
            komut.Parameters.AddWithValue("@telefonno", telTb.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cinsiyetCb.SelectedItem);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Müşteri Kayıdı Yapılmıştır");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
