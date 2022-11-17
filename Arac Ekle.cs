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
    public partial class aracekleFrm : Form
    {
        public aracekleFrm()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=BATIN-PC\SQLEXPRESS;Initial Catalog = arackirala; Integrated Security = True";
        

        private void Arac_Ekle_Load(object sender, EventArgs e)
        {
           
        }

        private void markaCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (markaCb.SelectedIndex == 0)

            {
                modelCmb.Items.Clear();
                modelCmb.Text = "";

                modelCmb.Items.Add("1.16 i");
                modelCmb.Items.Add("1.16 d");
                modelCmb.Items.Add("320 i");
                modelCmb.Items.Add("320 d");
                modelCmb.Items.Add("520 i");
                modelCmb.Items.Add("520 d");
            }
            else if (markaCb.SelectedIndex == 1)
            {
                modelCmb.Items.Clear();
                modelCmb.Text = "";

                modelCmb.Items.Add("a180 i");
                modelCmb.Items.Add("a180 d");
                modelCmb.Items.Add("cla200 i");
                modelCmb.Items.Add("cla200 d");
                modelCmb.Items.Add("e300 i");
                modelCmb.Items.Add("e300 d");
            }
            else if (markaCb.SelectedIndex == 2)
            {
                modelCmb.Items.Clear();
                modelCmb.Text = "";

                modelCmb.Items.Add("206");
                modelCmb.Items.Add("207");
                modelCmb.Items.Add("301");
                modelCmb.Items.Add("508");
                modelCmb.Items.Add("3008");
                modelCmb.Items.Add("5008");
            }
            else if (markaCb.SelectedIndex == 3)
            {
                modelCmb.Items.Clear();
                modelCmb.Text = "";

                modelCmb.Items.Add("c1");
                modelCmb.Items.Add("c3");
                modelCmb.Items.Add("c4");
                modelCmb.Items.Add("c5");
                modelCmb.Items.Add("berlingo");
                modelCmb.Items.Add("c elysee");
            }

        }

        private void aracEkleBtn_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Into araclar values (@plaka,@marka,@model,@yakıt,@vites,@kilometre,@durumu,@ücret)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.Parameters.AddWithValue("@plaka", plakaTb.Text);
            komut.Parameters.AddWithValue("@marka", markaCb.SelectedItem);
            komut.Parameters.AddWithValue("@model", modelCmb.SelectedItem);
            komut.Parameters.AddWithValue("@yakıt", yakıtCb.SelectedItem);
            komut.Parameters.AddWithValue("@vites", vitesCb.SelectedItem);
            komut.Parameters.AddWithValue("@kilometre",kmTb.Text);
            komut.Parameters.AddWithValue("@durumu", durumCb.SelectedItem);
            komut.Parameters.AddWithValue("@ücret", ucretTb.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Araç Kaydı Başarılı");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
