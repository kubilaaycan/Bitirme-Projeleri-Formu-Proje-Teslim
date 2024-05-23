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





using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJE
{
    public partial class AkademisyenGirisFormu : Form
    {
        private MySqlConnection mySqlConnection; 

        public AkademisyenGirisFormu()
        {
            InitializeComponent();
            string mysqlCon = "server=localhost; user=root; database=bitirme_projeleri_formu;";
            mySqlConnection = new MySqlConnection(mysqlCon); 
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullanici.Text;
            string sifre = txtSifre.Text;


            string query = "SELECT COUNT(*) FROM kullanicilar WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre";





            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);

            try
            {
                
                mySqlConnection.Open();

                
                int result = Convert.ToInt32(cmd.ExecuteScalar());

                
                if (result == 1)
                {
                    MessageBox.Show("Giriş başarılı!");
                    BPYS form2 = new BPYS();
                    form2.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                
                mySqlConnection.Close();
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}






