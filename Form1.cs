using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class anasayfaFrm : Form
    {
        public anasayfaFrm()
        {
            InitializeComponent();
        }

        private void aracBtn_Click(object sender, EventArgs e)
        {
            aracFrm arac = new aracFrm();
                arac.ShowDialog();
        }
       

        private void musteriBtn_Click(object sender, EventArgs e)
        {

            musteriFrm musteri = new musteriFrm();
            musteri.ShowDialog();
        }

      
        private void sozBtn_Click(object sender, EventArgs e)
        
        {
            sozlesme sozlesme = new sozlesme();
                sozlesme.ShowDialog();
        }

        private void aracekleBtn_Click_1(object sender, EventArgs e)
        {
            aracekleFrm aracekle = new aracekleFrm();
            aracekle.ShowDialog();
        }

        private void musteriekleBtn_Click(object sender, EventArgs e)
        {
            MusteriekleFrm musteriekle = new MusteriekleFrm();
            musteriekle.ShowDialog();
        }
    }
}
