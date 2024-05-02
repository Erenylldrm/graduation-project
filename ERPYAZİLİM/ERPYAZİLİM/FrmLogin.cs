using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPYAZİLİM
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        private void button1_Click(object sender, EventArgs e)
        {
            var kullaniciAdi = textBox1.Text;
            var sifre = textBox2.Text;
            var sorgu = from x in db.TBLADMIN where x.KULLANICIAD == kullaniciAdi && x.SIFRE == sifre select x;

            if (sorgu.Any())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kullaniciAdi = textBox1.Text;
            var sifre = textBox2.Text;
            var sorgu = from x in db.YETKİLENDİRME where x.KullaniciAdi == kullaniciAdi && x.Sifre == sifre select x;

            if (sorgu.Any()) 
            {
                var kullanici = sorgu.First();

                if (kullanici.YetkiKategori != null)
                {
                    Form1 frm = new Form1();
                    frm.kullanıcıyetki = kullanici.YetkiKategori.ToString();
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }
     }
}

