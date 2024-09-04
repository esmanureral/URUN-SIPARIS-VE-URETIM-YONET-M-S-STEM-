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
    public partial class Form1 : Form
    {
       
       // *********************************************KULLANICI GİRİŞ SAYFASII***********************************************************



        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ESMANURERAL\\SQLEXPRESS06;Initial Catalog=UrunSatisE;Integrated Security=True;TrustServerCertificate=True");


        //KAYIT FORMUNU AÇMA
        private void button2_Click(object sender, EventArgs e)
        {
            KayıtForm frm =new KayıtForm();
            frm.Show(); //Giriş sayfasında kayıt ol a bastığımızda oraya yönlendirir.
        }


        //GİRİŞ YAP BUTONU
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            //SqlCommand komut = new SqlCommand("select *from Kayıt where kullaniciadi='" + kullaniciadi.Text+"'and şifre ='"+parola.Text+"'",baglanti);

  
            SqlCommand komut = new SqlCommand("select *from Kayıt where kullaniciadi=@kullaniciadi and şifre=@sifre", baglanti);
            komut.Parameters.AddWithValue("@kullaniciadi", kullaniciadi.Text);
            komut.Parameters.AddWithValue("@sifre", parola.Text);
            SqlDataReader dr = komut.ExecuteReader();//Sorguyu çalıştırıyor,sonuçları SqlDataReader ile okuyabiliyoruz.

            if (dr.Read()) //kayıt varsa if'e giriyor.
            {
                AnaSayfa frm = new AnaSayfa();
                frm.Show();
                



                kullaniciadi.Clear();
                parola.Clear();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                kullaniciadi.Clear();
                parola.Clear();
            }
            baglanti.Close();
        
        }
    }
}
