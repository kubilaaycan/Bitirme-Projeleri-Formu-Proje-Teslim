using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROJE
{
    public partial class GenelListe : Form
    {
        private MySqlConnection mySqlConnection;

        public GenelListe()
        {
            InitializeComponent();
            string mysqlCon = "server=localhost; user=root; database=bitirme_projeleri_formu; ";
            mySqlConnection = new MySqlConnection(mysqlCon);
        }

        private void GenelListe_Load(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM bpf", mySqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView3.DataSource = dt;

                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnGeri5_Click(object sender, EventArgs e)
        {
            BPYS form2 = new BPYS();
            form2.Show();
            this.Close();
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView3.Rows[e.RowIndex];
                string id = selectedRow.Cells["ID"].Value.ToString();
                string projeAdi = selectedRow.Cells["ProjeAdi"].Value.ToString();
                string projeDanismani = selectedRow.Cells["ProjeDanismani"].Value.ToString();
                string juri1 = selectedRow.Cells["1Jüri"].Value.ToString();
                string juri2 = selectedRow.Cells["2Jüri"].Value.ToString();
                string juri3 = selectedRow.Cells["3Jüri"].Value.ToString();
                string juri4 = selectedRow.Cells["4Jüri"].Value.ToString();
                string projeSuresi = selectedRow.Cells["ProjeSüresi"].Value.ToString();
                string yariYil = selectedRow.Cells["ProjeYariyili"].Value.ToString();

                
                BitirmeProjeleriFormu bitirmeProjeleriFormu = new BitirmeProjeleriFormu();
                bitirmeProjeleriFormu.SetData(id, projeAdi, projeDanismani, juri1, juri2, juri3, juri4, projeSuresi, yariYil);
                bitirmeProjeleriFormu.Show();
                this.Close();
            }
        }
    }
}
