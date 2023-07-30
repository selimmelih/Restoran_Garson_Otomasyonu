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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=localhost;database=TurhanRestoran;integrated security=true;");

        public void Listele(string prosedur)
        {
            SqlDataAdapter dr = new SqlDataAdapter(prosedur, conn);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt;
        }


        private void BtnSiparisKaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SKaydet", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MasaNo", TxtMasaNo.Text);
            cmd.Parameters.AddWithValue("Yiyecek", TxtYiyecek.Text);
            cmd.Parameters.AddWithValue("YiyecekAdet", comboBox1.GetItemText(comboBox1.SelectedItem));
            cmd.Parameters.AddWithValue("Icecek", TxtIcecek.Text);
            cmd.Parameters.AddWithValue("IcecekAdet", comboBox2.GetItemText(comboBox2.SelectedItem));
            cmd.ExecuteNonQuery();
            Listele("SListele");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele("SListele");
            for (int i = 1; i <= 10; i++)
            {
                comboBox1.Items.Add(i);
                comboBox2.Items.Add(i);
            }
        }

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
            Listele("SListele");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView2.CurrentRow;
            if (e.ColumnIndex == 0)
            {
                Duzenleme duzenle = new Duzenleme();
                duzenle.Show();
                duzenle.TxtMasaNo.Tag = satir.Cells["SiparisID"].Value.ToString();
                duzenle.TxtMasaNo.Text = satir.Cells["MasaNo"].Value.ToString();
                duzenle.TxtYiyecek.Text = satir.Cells["Yiyecek"].Value.ToString();
                duzenle.comboBox1.SelectedItem = satir.Cells["YiyecekAdet"].Value.ToString();
                duzenle.TxtIcecek.Text = satir.Cells["Icecek"].Value.ToString();
                duzenle.comboBox2.SelectedItem = satir.Cells["IcecekAdet"].Value.ToString();
                this.Close();
                
            }
            if (e.ColumnIndex == 1)
            {
                Silme sil1 = new Silme();
                sil1.Show();
                sil1.label1.Tag = satir.Cells["SiparisID"].Value.ToString();
                sil1.label1.Text = satir.Cells["MasaNo"].Value.ToString();
                this.Close();
            }
        }
    }
}
