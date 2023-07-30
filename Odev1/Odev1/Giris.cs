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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=localhost;database=TurhanRestoran;integrated security=true;");

        public void Listele(string prosedur)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(prosedur, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            CbKullanici.DataSource = dt;
            CbKullanici.DisplayMember = "KullaniciAdi";
            conn.Close();
        }
        private void Giris_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("PListele", conn);
            Listele("PListele");

        }
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Personeller where KullaniciAdi=@KullaniciAdi and Sifre = @Sifre", conn);
            cmd.Parameters.AddWithValue("@KullaniciAdi", CbKullanici.GetItemText(CbKullanici.SelectedItem));
            // üstteki kod combobox un icinde secili olan text i alıyor. gayet başarılı bir olay.! SelectedValue de olabilir.
            cmd.Parameters.AddWithValue("@Sifre", TxtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form1 form1 = new Form1();
                MessageBox.Show("Kullanıcı adı ve şifre doğru. Giriş Başarılı, İyi Çalışmalar!");
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız. ");
                TxtSifre.Clear();
            }
            conn.Close();
        }
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama Kapatılıyor.");
            Application.Exit();
        }

    }
}
