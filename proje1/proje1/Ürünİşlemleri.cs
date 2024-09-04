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
    public partial class Ürünİşlemleri : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        public void listele()
        {
            // SqlConnection nesnemizi oluşturduk ve bağlantıyı tanımladık.
            SqlConnection con = new SqlConnection("Data Source=ESMANURERAL\\SQLEXPRESS06;Initial Catalog=UrunSatisE;Integrated Security=True;TrustServerCertificate=True");

            string urun = ("select urunID,urunAd,Stok,alisFiyat,satisFiyat from tblUrunler where durum=1");

            // SqlDataAdapter nesnesini oluşturduk.con bağlantı için
            da = new SqlDataAdapter(urun, con);

            DataTable tablo = new DataTable();

            // sorgusunun sonucunu tablo nesnesine doldurur.
            da.Fill(tablo);

            dataGridView1.DataSource = tablo;


            //Her durumda temizlensin diye
            txtID.Text = "";
            txtAd.Text = "";
            txtalış.Text = "";
            satış.Text = "";
            txtbul.Text = "";


        }
        public Ürünİşlemleri()
        {
            InitializeComponent();
        }

        private void Ürünİşlemleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        //KAYDET BUTONU 
        private void button2_Click(object sender, EventArgs e)
        {

            if (txtAd.Text == "" || txtalış.Text == "" || satış.Text == "")
            {
                MessageBox.Show("Lütfen gerekli alanları giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (var db = new UrunSatisEEntities())
                {
                    var x = new tblUrunler();

                    x.urunAd = txtAd.Text;
                    x.Stok = int.Parse(txtstok.Value.ToString());
                    x.alisFiyat = int.Parse(txtalış.Text);
                    x.satisFiyat = int.Parse(satış.Text);
                    x.durum = true;
                    db.tblUrunler.Add(x);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt eklendi");
                }
                listele();
            }
        }
        //SİLME İŞLEMİ 
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz kaydı seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(txtID.Text);

                using (var db = new UrunSatisEEntities())
                {
                    int urunıd = int.Parse(txtID.Text);
                    var x = db.tblUrunler.Find(urunıd);
                    x.durum = false;
                    db.SaveChanges();
                    MessageBox.Show("KAYIT SİLİNDİ");
                }
            }
            listele();

        }

        //silmek için seçtiğimiz satırın bilgileri gelsin istiyoruz:
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txtstok.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            //txtalış.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //satış.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            //kullanıcı herhangi yere tıklafıgında hata vermicek,tablonun x,y değerleri alınır
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtstok.Value = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            txtalış.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            satış.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }
        //GÜNCELLEMEK İÇİN
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtalış.Text == "" || satış.Text == "")
            {
                MessageBox.Show("Lütfen güncellenecek satırı seçiniz ve alanları giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (var db = new UrunSatisEEntities ())
                {

                    int urunıd = int.Parse(txtID.Text);
                    var x = db.tblUrunler.Find(urunıd);

                    x.urunAd = txtAd.Text;
                    x.Stok = int.Parse(txtstok.Value.ToString());
                    x.alisFiyat = int.Parse(txtalış.Text);
                    x.satisFiyat = int.Parse(satış.Text);
                    x.durum = true;
                    db.SaveChanges();

                    MessageBox.Show("Güncelleme yapıldı.");
                }
                listele();
            }
        }

        //ARAMA İŞLMEİİ
        private void button5_Click(object sender, EventArgs e)
        {

            if (txtbul.Text == "")
            {
                MessageBox.Show("Lütfen aradığınız kelimeyi giriniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                using (var db = new UrunSatisEEntities())
                {
                    var urunler = db.tblUrunler.Where(u => u.durum == true && u.urunAd.Contains(txtbul.Text))
                        .Select(u => new
                        {
                            u.urunID,
                            u.urunAd,
                            u.Stok,
                            u.alisFiyat,
                            u.satisFiyat,
                           
                        })
                        .ToList();

                    dataGridView1.DataSource = urunler;
                }
            }
        }
    }

}
    
