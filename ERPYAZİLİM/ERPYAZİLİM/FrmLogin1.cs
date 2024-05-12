using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ERPYAZİLİM
{
    public partial class FrmLogin1 : Form
    {
        public FrmLogin1()
        {
            InitializeComponent();
        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           /* textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.Gainsboro;
            textBox2.BackColor = Color.Gainsboro;*/
         
        }

   
        private void textBox2_Click(object sender, EventArgs e)
        {
            /*textBox2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            textBox1.BackColor = Color.Gainsboro;
            panel3.BackColor = Color.Gainsboro;*/
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
