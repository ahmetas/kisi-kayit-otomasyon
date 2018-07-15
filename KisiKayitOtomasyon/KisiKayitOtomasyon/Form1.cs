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

namespace KisiKayitOtomasyon
{
    public partial class Form1 : Form
    {
        SqlConnection connect;
        public Form1()
        {
            InitializeComponent();
            connect = new SqlConnection("Data Source=localhost;Initial Catalog=local;Integrated Security=True");
        }

        private void EkleButton_click(object sender, EventArgs e)
        {
            if (HataliGiris(IsimText) || HataliGiris(SoyIsimText) || HataliGiris(KimlikNoText)) { return; }

            connect.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.kisiler (Isim, SoyIsim, KimlikNo, DogumYili) VALUES (@Isim, @SoyIsim, @KimlikNo, @DogumYili)", connect);

            cmd.Parameters.AddWithValue("@Isim", IsimText.Text);
            cmd.Parameters.AddWithValue("@SoyIsim", SoyIsimText.Text);
            cmd.Parameters.AddWithValue("@KimlikNo", KimlikNoText.Text);
            cmd.Parameters.AddWithValue("@DogumYili", DogumYili.Value);
            cmd.ExecuteNonQuery();

            connect.Close();
        }

        private void AraButton_Click(object sender, EventArgs e)
        {
            connect.Open();

            SqlCommand cmd = new SqlCommand("SELECT Isim from dbo.kisiler where KisiId=@Id", connect);

            cmd.Parameters.AddWithValue("@Id", SoyIsimText.Text);
            try
            {
                var sonuc = (string)cmd.ExecuteScalar();
                MessageBox.Show(sonuc.ToString());
            }
            catch
            {
                MessageBox.Show("Böyle bir kullanıcı mevcut değil.");
            }
            connect.Close();
        }

        private void ListeleButton_Click(object sender, EventArgs e)
        {
            if (KullaniciList.Items != null) { KullaniciList.Items.Clear(); };

            connect.Open();

            SqlCommand cmd = new SqlCommand("Select * from dbo.kisiler", connect);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                KullaniciList.Items.Add(reader.GetString(1) + " " + reader.GetString(2));
            }

            connect.Close();
        }

        private bool HataliGiris(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Gerekli alanlar boş bırakılmaz");
                return true;
            }
            return false;
        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            connect.Open();

            SqlCommand cmd = new SqlCommand("Select * from dbo.kullanicilar where UserName=@UserName", connect);
            cmd.Parameters.AddWithValue("@UserName", KullaniciAdiText.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() && reader.GetString(3) == SifreText.Text)
                durumLabel.Text = reader.GetInt32(1) == 0
                    ? "yönetici girişi başarılı."
                    : "kullanıcı girişi başarılı.";
            else
                MessageBox.Show("Kullanıcı adı ya da parola hatalı.");

            connect.Close();
        }
    }
}