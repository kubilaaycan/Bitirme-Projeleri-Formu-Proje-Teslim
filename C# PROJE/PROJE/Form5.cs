using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace PROJE
{
    public partial class BitirmeProjeleriFormu : Form
    {
        public BitirmeProjeleriFormu()
        {
            InitializeComponent();
        }

        public void SetData(string id, string projeAdi, string projeDanismani, string juri1, string juri2, string juri3, string juri4, string projeSuresi, string yariYil)
        {
            txtID.Text = id;
            txtPAdi.Text = projeAdi;
            cbDan.Text = projeDanismani;
            cb1J.Text = juri1;
            cb2J.Text = juri2;
            cb3J.Text = juri3;
            cb4J.Text = juri4;
            cbPSüre.Text = projeSuresi;
            cbPKYari.Text = yariYil;
        }

        private void BitirmeProjeleriFormu_Load(object sender, EventArgs e)
        {

        }

        private void cbDan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGeri2_Click(object sender, EventArgs e)
        {
            BPYS form2 = new BPYS();
            form2.Show();
            this.Close();
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtPAdi.Text) ||
                string.IsNullOrWhiteSpace(cbDan.Text) ||
                string.IsNullOrWhiteSpace(cb1J.Text) ||
                string.IsNullOrWhiteSpace(cb2J.Text) ||
                string.IsNullOrWhiteSpace(cb3J.Text) ||
                string.IsNullOrWhiteSpace(cb4J.Text) ||
                string.IsNullOrWhiteSpace(cbPSüre.Text) ||
                string.IsNullOrWhiteSpace(cbPKYari.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            AkPrAkNoGiFo form5 = new AkPrAkNoGiFo();
            form5.VerileriAl(txtID.Text, txtPAdi.Text, cbDan.Text, cb1J.Text, cb2J.Text, cb3J.Text, cb4J.Text);
            form5.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtPAdi.Text) ||
                string.IsNullOrWhiteSpace(cbDan.Text) ||
                string.IsNullOrWhiteSpace(cb1J.Text) ||
                string.IsNullOrWhiteSpace(cb2J.Text) ||
                string.IsNullOrWhiteSpace(cb3J.Text) ||
                string.IsNullOrWhiteSpace(cb4J.Text) ||
                string.IsNullOrWhiteSpace(cbPSüre.Text) ||
                string.IsNullOrWhiteSpace(cbPKYari.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return; 
            }

            string id = txtID.Text;
            string ad = txtPAdi.Text;
            string danisman = cbDan.Text;
            string juri1 = cb1J.Text;
            string juri2 = cb2J.Text;
            string juri3 = cb3J.Text;
            string juri4 = cb4J.Text;
            string projeSure = cbPSüre.Text;
            string projeYariYil = cbPKYari.Text;

            string server = "localhost";
            string database = "bitirme_projeleri_formu";
            string uid = "root";
            string password = "";
            string connectionString = $"Server={server}; database={database}; UID={uid}; password={password}";

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = $"INSERT INTO bpf (ID, ProjeAdi, ProjeDanismani, 1Jüri, 2Jüri, 3Jüri, 4Jüri, ProjeSüresi, ProjeYariyili) " +
                               $"VALUES ('{id}', '{ad}', '{danisman}', '{juri1}', '{juri2}', '{juri3}', '{juri4}', '{projeSure}', '{projeYariYil}')";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Veri başarıyla eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
