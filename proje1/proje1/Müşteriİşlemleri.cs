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

namespace proje1
{
    public partial class Müşteriİşlemleri : Form
    {
        public Müşteriİşlemleri()
        {
            InitializeComponent();
        }


        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        public void listele()
        {
            // SqlConnection nesnemizi oluşturduk ve bağlantıyı tanımladık.
            SqlConnection con = new SqlConnection("Data Source=ESMANURERAL\\SQLEXPRESS06;Initial Catalog=UrunSatisE;Integrated Security=True;TrustServerCertificate=True");

            string musteriler = ("select musteriID,Ad,Soyad,Adres,Telefon from tblMusteriler where durum=1");

            // SqlDataAdapter nesnesini oluşturduk.con bağlantı için
            da = new SqlDataAdapter(musteriler, con);

            DataTable tablo = new DataTable();

            // sorgusunun sonucunu tablo nesnesine doldurur.
            da.Fill(tablo);

            dataGridView2.DataSource = tablo;


            //Her durumda temizlensin diye
            txtID.Text = "";
            txtAd.Text = "";
            textsoyad.Text = "";
            textadress.Text = "";
            txttel.Text = "";
        }

        private void Müşteriİşlemleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //silmek için seçtiğimiz satırın bilgileri gelsin istiyoruz:


            //txtID.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txtAd.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            //textsoyad.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            //textadress.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            //txttel.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();

            txtID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textsoyad.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textadress.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txttel.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        //KAYDETMEK İÇİN
        private void button2_Click(object sender, EventArgs e)
        {

            if (txtAd.Text == "" || textsoyad.Text == "" || textadress.Text == "" || txttel.Text == "")
            {
                MessageBox.Show("Lütfen gerekli alanları giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                using (var db1 = new UrunSatisEEntities())
                {
                    var y = new tblMusteriler();

                    y.Ad = txtAd.Text;
                    y.Soyad = textsoyad.Text;
                    y.Adres = textadress.Text;
                    y.Telefon = txttel.Text;
                    y.durum = true;
                    db1.tblMusteriler.Add(y);
                    db1.SaveChanges();



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
                    int musteriID = int.Parse(txtID.Text);
                    var x = db.tblMusteriler.Find(musteriID);
                    x.durum = false;
                    db.SaveChanges();
                    MessageBox.Show("KAYIT SİLİNDİ");
                }
            }
            listele();
        }

        //GÜNCELLEME İŞLEMİ
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || textsoyad.Text == "" || textadress.Text == "" || txttel.Text == "")
            {
                MessageBox.Show("Lütfen güncellenecek satırı seçiniz ve alanları giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (var db = new UrunSatisEEntities())
                {

                    int musteriID = int.Parse(txtID.Text);
                    var x = db.tblMusteriler.Find(musteriID);

                    x.Ad = txtAd.Text;
                    x.Soyad = textsoyad.Text;
                    x.Adres = textadress.Text;
                    x.Telefon = txttel.Text;
                    x.durum = true;
                    db.SaveChanges();

                    MessageBox.Show("Güncelleme yapıldı.");
                }
                listele();
            }
        }

        //ARAMA İŞLEMİ
        private void button6_Click(object sender, EventArgs e)
        {
            if (textara.Text == "")
            {
                MessageBox.Show("Lütfen aradığınız kelimeyi giriniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                using (var db = new UrunSatisEEntities())
                {
                    var musteriler = db.tblMusteriler.Where(u => u.durum == true && u.Ad.Contains(textara.Text))
                        .Select(u => new
                        {
                            u.musteriID,
                            u.Ad,
                            u.Soyad,
                            u.Adres,
                            u.Telefon,

                        })
                        .ToList();

                    dataGridView2.DataSource = musteriler;
                }
            }
        }
    }
}
