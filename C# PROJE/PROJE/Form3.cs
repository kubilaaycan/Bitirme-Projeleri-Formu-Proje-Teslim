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
    public partial class BaskentAkadm : Form
    {
        private MySqlConnection mySqlConnection;

        public BaskentAkadm()
        {
            InitializeComponent();
            string mysqlCon = "server=localhost; user=root; database=bitirme_projeleri_formu; ";
            mySqlConnection = new MySqlConnection(mysqlCon);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM akademisyenler", mySqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            BPYS form2 = new BPYS();
            form2.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
