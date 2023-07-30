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

namespace Odev1
{
    public partial class Silme : Form
    {
        public Silme()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=localhost;database=TurhanRestoran;integrated security=true;");
        private void BtnEvet_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SSil", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("SiparisID", label1.Tag);
            cmd.ExecuteNonQuery();
            conn.Close();
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void BtnHayir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
