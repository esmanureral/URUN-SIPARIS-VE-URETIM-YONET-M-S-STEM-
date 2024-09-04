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
using System.Data.Sql;
using System.Data.SqlClient;

namespace proje1
{
    public partial class Satisİslemleri : Form
    {
        public Satisİslemleri()
        {
            InitializeComponent();
        }

        SqlConnection con;




        public void listele()
        {
            using (var db1 = new UrunSatisEEntities())
            {

                // Satışların listesini DataGridView'e bağlama
                dataGridView1.DataSource = db1.satislarinListesi().ToList();

                // Ürün adlarını ve ID'lerini ürünad ComboBox'ına bağlama
                ürünad.ValueMember = "urunID";
                ürünad.DisplayMember = "urunAd";
                ürünad.DataSource = db1.tblUrunler
                                        .Where(x => x.durum == true && x.Stok > 0)
                                        .ToList();

                // Müşteri adlarını ve ID'lerini mad ComboBox'ına bağlama
                var musteriler = db1.tblMusteriler
                                   .Where(x => x.durum == true)
                                   .Select(x => new
                                   {
                                       x.musteriID,
                                       adSoyad = x.Ad + " " + x.Soyad
                                   })
                                   .ToList();

                mad.DisplayMember = "adSoyad";
                mad.ValueMember = "musteriID";
                mad.DataSource = musteriler;



                //Her durumda temizlensin diye
                txtID.Text = "";
                txtbirim.Text = "";
                txttplm.Text = "";
                txtstok.Value = 1;


            }
        }

        private void Satisİslemleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        tblUrunler u;
        tblSatislar s;


        //HESAPLA BUTONU
        private void btnhesapla_Click(object sender, EventArgs e)
        {
            s = new tblSatislar();
            s.urun = int.Parse(ürünad.SelectedValue.ToString());
            s.musteri = int.Parse(mad.SelectedValue.ToString());
            s.adet = int.Parse(txtstok.Value.ToString());
            s.tarih = DateTime.Today;

            using (var db = new UrunSatisEEntities())
            {
                u = db.tblUrunler.Find(s.urun);

                if (u.Stok < s.adet)
                {
                    MessageBox.Show("Stoktaki ürün yetersiz..", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    s.toplamFiyat = s.adet * u.satisFiyat;
                    txtbirim.Text = u.satisFiyat.ToString();
                    txttplm.Text = s.toplamFiyat.ToString();
                }


            }
        }

        //SATIŞYAP BUTONU
        private void btnsatis_Click(object sender, EventArgs e)
        {
            if (txttplm.Text == "")
            {
                MessageBox.Show("Önce hesaplama işlemi yapınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var db = new UrunSatisEEntities())
                {
                    db.tblSatislar.Add(s);
                    u.Stok = u.Stok - s.adet;
                    db.tblSatislar.Add(s);
                    db.SaveChanges();
                    MessageBox.Show("Satış Yapıldı");
                }
                listele();

            }
        }
    }
}