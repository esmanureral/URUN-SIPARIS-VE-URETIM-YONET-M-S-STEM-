using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace proje1
{
    public partial class KayıtForm : Form
    {
        public KayıtForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ESMANURERAL\\SQLEXPRESS06;Initial Catalog=UrunSatisE;Integrated Security=True;TrustServerCertificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Kayıt(KullaniciAdi,Şifre,Ad,Soyad,Telefon)values(@kullaniciadi,@sifre,@ad,@soyad,@telefon)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kullaniciadi", kullaniciadi.Text);
            komut.Parameters.AddWithValue("@sifre", parola.Text);
            komut.Parameters.AddWithValue("@ad", adi.Text);
            komut.Parameters.AddWithValue("@soyad", soyad.Text);
            komut.Parameters.AddWithValue("@telefon", tel.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Oluşturuldu");
            kullaniciadi.Clear();
            parola.Clear();
            adi.Clear();
            soyad.Clear();
            tel.Clear();
            baglanti.Close();
            KayıtForm form1 = new KayıtForm();
            form1.Show();

            this.Hide();

        }
    }
}
