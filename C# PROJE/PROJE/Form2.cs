using MySql.Data.MySqlClient;
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
    public partial class BPYS : Form
    {
        
        public BPYS()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAkadm_Click(object sender, EventArgs e)
        {
            BaskentAkadm form3 = new BaskentAkadm();
            form3.Show();
            this.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hesabınızdan çıkmak istiyor musunuz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                AkademisyenGirisFormu form1 = new AkademisyenGirisFormu();
                form1.Show();


                this.Close();
            }

        }

        private void btnOgr_Click(object sender, EventArgs e)
        {
            Ogrenciler form4 = new Ogrenciler();
            form4.Show();
            this.Close();
        }

        private void btnBtrPrj_Click(object sender, EventArgs e)
        {
            BitirmeProjeleriFormu form5 = new BitirmeProjeleriFormu();
            form5.Show();
            this.Close();
        }

        private void btnGnlLst_Click(object sender, EventArgs e)
        {
            GenelListe form7 = new GenelListe();
            form7.Show();
            this.Close();
        }
    }

    }




