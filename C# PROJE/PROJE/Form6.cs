using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE
{
    public partial class AkPrAkNoGiFo : Form
    {
        public AkPrAkNoGiFo()
        {
            InitializeComponent();
        }

        private void AkPrAkNoGiFo_Load(object sender, EventArgs e)
        {

        }
        public void VerileriAl(string id, string projeAdi, string danisman, string juri1, string juri2, string juri3, string juri4)
        {
            txtOgrID.Text = id;
            txtPDan.Text = danisman;
            txt1J.Text = juri1;
            txt2J.Text = juri2;
            txt3J.Text = juri3;
            txt4J.Text = juri4;
            txtProAd.Text = projeAdi;
        }

        private void btnGeri4_Click(object sender, EventArgs e)
        {
            BitirmeProjeleriFormu form5 = new BitirmeProjeleriFormu();
            form5.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] puanlarJuri1 = new double[2];
            double[] puanlarJuri2 = new double[2];
            double[] puanlarJuri3 = new double[2];
            double[] puanlarJuri4 = new double[2];

            puanlarJuri1[0] = Convert.ToDouble(txtbPuan11.Text);
            puanlarJuri1[1] = Convert.ToDouble(txtbPuan21.Text);

            puanlarJuri2[0] = Convert.ToDouble(txtbPuan12.Text);
            puanlarJuri2[1] = Convert.ToDouble(txtbPuan22.Text);

            puanlarJuri3[0] = Convert.ToDouble(txtbPuan13.Text);
            puanlarJuri3[1] = Convert.ToDouble(txtbPuan23.Text);

            puanlarJuri4[0] = Convert.ToDouble(txtbPuan14.Text);
            puanlarJuri4[1] = Convert.ToDouble(txtbPuan24.Text);

            double ortalamaJuri1 = (puanlarJuri1[0] + puanlarJuri1[1]) / 2.0;
            double ortalamaJuri2 = (puanlarJuri2[0] + puanlarJuri2[1]) / 2.0;
            double ortalamaJuri3 = (puanlarJuri3[0] + puanlarJuri3[1]) / 2.0;
            double ortalamaJuri4 = (puanlarJuri4[0] + puanlarJuri4[1]) / 2.0;

            double toplamOrtalama = ortalamaJuri1 + ortalamaJuri2 + ortalamaJuri3 + ortalamaJuri4;

            double ortalamaPuan = toplamOrtalama / 4.0;

            txtbNot.Text = ortalamaPuan.ToString();
        }
    }
}
