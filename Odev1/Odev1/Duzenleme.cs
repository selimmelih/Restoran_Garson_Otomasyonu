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
    public partial class Duzenleme : Form
    {
        public Duzenleme()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=localhost;database=TurhanRestoran;integrated security=true;");

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("SGuncelle", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("SiparisID", TxtMasaNo.Tag);
            cmd.Parameters.AddWithValue("MasaNo", TxtMasaNo.Text);
            cmd.Parameters.AddWithValue("Yiyecek", TxtYiyecek.Text);
            cmd.Parameters.AddWithValue("YiyecekAdet", comboBox1.GetItemText(comboBox1.SelectedItem));
            cmd.Parameters.AddWithValue("Icecek", TxtIcecek.Text);
            cmd.Parameters.AddWithValue("IcecekAdet", comboBox2.GetItemText(comboBox2.SelectedItem));
            cmd.ExecuteNonQuery();
            
            conn.Close();
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Duzenleme_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                comboBox1.Items.Add(i);
                comboBox2.Items.Add(i);
            }
        }
    }
}
