using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ürün İşlemlerine tıkladığımızda açılacak olan yeni form sayfası:

            Ürünİşlemleri frm = new Ürünİşlemleri();
            frm.Show();
        }

        //Müşteri İşlemlerine tıkladığımızda açılacak olan yeni form sayfası:

        private void button2_Click(object sender, EventArgs e)
        {
            Müşteriİşlemleri frm = new Müşteriİşlemleri();
            frm.Show();
        }

        //Satış İşlemlerine tıkladığımızda açılacak olan yeni form sayfası:

        private void button3_Click(object sender, EventArgs e)
        {
            Satisİslemleri frm =new Satisİslemleri();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
