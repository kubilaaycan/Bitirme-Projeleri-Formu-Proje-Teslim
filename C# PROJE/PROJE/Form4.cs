using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROJE
{
    public partial class Ogrenciler : Form
    {
        private MySqlConnection mySqlConnection;
        public Ogrenciler()
        {
            InitializeComponent();
            string mysqlCon = "server=localhost; user=root; database=bitirme_projeleri_formu; ";
            mySqlConnection = new MySqlConnection(mysqlCon);
        }

        private void Ogrenciler_Load(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM ögrenciler", mySqlConnection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView2.DataSource = dt;

                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnGeri2_Click(object sender, EventArgs e)
        {
            BPYS form2 = new BPYS();
            form2.Show();
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
