using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPYAZİLİM.Formlar
{
    public partial class FrmAnasayfaa : Form
    {
        public FrmAnasayfaa()
        {
            InitializeComponent();
        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();

        private void button1_Click(object sender, EventArgs e)
        {
            // Anasayfa formunun MDI Parent'ı alınır
            Form mdiParent = this.MdiParent;

            // Anasayfa formunun MDI Parent'ı null değilse (MDI formu içinde ise)
            if (mdiParent != null)
            {
                // Yeni formun oluşturulması ve MDI Parent olarak atanması
                FrmKategoriListesi frm = new FrmKategoriListesi();
                frm.MdiParent = mdiParent;

                // Yeni formun gösterilmesi
                frm.Show();
            }
            else
            {
                // MDI formu içinde değilse, hata mesajı gösterilebilir veya isteğe göre farklı bir işlem yapılabilir
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Anasayfa formunun MDI Parent'ı alınır
            Form mdiParent = this.MdiParent;

            // Anasayfa formunun MDI Parent'ı null değilse (MDI formu içinde ise)
            if (mdiParent != null)
            {
                // Yeni formun oluşturulması ve MDI Parent olarak atanması
                FrmÜrünListesi frm = new FrmÜrünListesi();
                frm.MdiParent = mdiParent;

                // Yeni formun gösterilmesi
                frm.Show();
            }
            else
            {
                // MDI formu içinde değilse, hata mesajı gösterilebilir veya isteğe göre farklı bir işlem yapılabilir
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Anasayfa formunun MDI Parent'ı alınır
            Form mdiParent = this.MdiParent;

            // Anasayfa formunun MDI Parent'ı null değilse (MDI formu içinde ise)
            if (mdiParent != null)
            {
                // Yeni formun oluşturulması ve MDI Parent olarak atanması
                Frmİstatistik frm = new Frmİstatistik();
                frm.MdiParent = mdiParent;

                // Yeni formun gösterilmesi
                frm.Show();
            }
            else
            {
                // MDI formu içinde değilse, hata mesajı gösterilebilir veya isteğe göre farklı bir işlem yapılabilir
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Anasayfa formunun MDI Parent'ı alınır
            Form mdiParent = this.MdiParent;

            // Anasayfa formunun MDI Parent'ı null değilse (MDI formu içinde ise)
            if (mdiParent != null)
            {
                // Yeni formun oluşturulması ve MDI Parent olarak atanması
                FrmMarkaİstatistikleri frm = new FrmMarkaİstatistikleri();
                frm.MdiParent = mdiParent;

                // Yeni formun gösterilmesi
                frm.Show();
            }
            else
            {
                // MDI formu içinde değilse, hata mesajı gösterilebilir veya isteğe göre farklı bir işlem yapılabilir
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Anasayfa formunun MDI Parent'ı alınır
            Form mdiParent = this.MdiParent;

            // Anasayfa formunun MDI Parent'ı null değilse (MDI formu içinde ise)
            if (mdiParent != null)
            {
                // Yeni formun oluşturulması ve MDI Parent olarak atanması
                FrmArizalıÜrünListesi frm = new FrmArizalıÜrünListesi();
                frm.MdiParent = mdiParent;

                // Yeni formun gösterilmesi
                frm.Show();
            }
            else
            {
                // MDI formu içinde değilse, hata mesajı gösterilebilir veya isteğe göre farklı bir işlem yapılabilir
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Anasayfa formunun MDI Parent'ı alınır
            Form mdiParent = this.MdiParent;

            // Anasayfa formunun MDI Parent'ı null değilse (MDI formu içinde ise)
            if (mdiParent != null)
            {
                // Yeni formun oluşturulması ve MDI Parent olarak atanması
                FrmArızalıÜrünDetayları frm = new FrmArızalıÜrünDetayları();
                frm.MdiParent = mdiParent;

                // Yeni formun gösterilmesi
                frm.Show();
            }
            else
            {
                // MDI formu içinde değilse, hata mesajı gösterilebilir veya isteğe göre farklı bir işlem yapılabilir
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Anasayfa formunun MDI Parent'ı alınır
            Form mdiParent = this.MdiParent;

            // Anasayfa formunun MDI Parent'ı null değilse (MDI formu içinde ise)
            if (mdiParent != null)
            {
                // Yeni formun oluşturulması ve MDI Parent olarak atanması
                FrmQR1 frm = new FrmQR1();
                frm.MdiParent = mdiParent;

                // Yeni formun gösterilmesi
                frm.Show();
            }
            else
            {
                // MDI formu içinde değilse, hata mesajı gösterilebilir veya isteğe göre farklı bir işlem yapılabilir
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Anasayfa formunun MDI Parent'ı alınır
            Form mdiParent = this.MdiParent;

            // Anasayfa formunun MDI Parent'ı null değilse (MDI formu içinde ise)
            if (mdiParent != null)
            {
                // Yeni formun oluşturulması ve MDI Parent olarak atanması
                FrmMüşteriListesi frm = new FrmMüşteriListesi();
                frm.MdiParent = mdiParent;

                // Yeni formun gösterilmesi
                frm.Show();
            }
            else
            {
                // MDI formu içinde değilse, hata mesajı gösterilebilir veya isteğe göre farklı bir işlem yapılabilir
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Anasayfa formunun MDI Parent'ı alınır
            Form mdiParent = this.MdiParent;

            // Anasayfa formunun MDI Parent'ı null değilse (MDI formu içinde ise)
            if (mdiParent != null)
            {
                // Yeni formun oluşturulması ve MDI Parent olarak atanması
                FrmÜrünSatişListesi frm = new FrmÜrünSatişListesi();
                frm.MdiParent = mdiParent;

                // Yeni formun gösterilmesi
                frm.Show();
            }
            else
            {
                // MDI formu içinde değilse, hata mesajı gösterilebilir veya isteğe göre farklı bir işlem yapılabilir
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Anasayfa formunun MDI Parent'ı alınır
            Form mdiParent = this.MdiParent;

            // Anasayfa formunun MDI Parent'ı null değilse (MDI formu içinde ise)
            if (mdiParent != null)
            {
                // Yeni formun oluşturulması ve MDI Parent olarak atanması
                FrmFaturaListesi frm = new FrmFaturaListesi();
                frm.MdiParent = mdiParent;

                // Yeni formun gösterilmesi
                frm.Show();
            }
            else
            {
                // MDI formu içinde değilse, hata mesajı gösterilebilir veya isteğe göre farklı bir işlem yapılabilir
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Anasayfa formunun MDI Parent'ı alınır
            Form mdiParent = this.MdiParent;

            // Anasayfa formunun MDI Parent'ı null değilse (MDI formu içinde ise)
            if (mdiParent != null)
            {
                // Yeni formun oluşturulması ve MDI Parent olarak atanması
                FrmFaturaSatışİşlemi frm = new FrmFaturaSatışİşlemi();
                frm.MdiParent = mdiParent;

                // Yeni formun gösterilmesi
                frm.Show();
            }
            else
            {
                // MDI formu içinde değilse, hata mesajı gösterilebilir veya isteğe göre farklı bir işlem yapılabilir
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Anasayfa formunun MDI Parent'ı alınır
            Form mdiParent = this.MdiParent;

            // Anasayfa formunun MDI Parent'ı null değilse (MDI formu içinde ise)
            if (mdiParent != null)
            {
                // Yeni formun oluşturulması ve MDI Parent olarak atanması
                FrmBarcode frm = new FrmBarcode();
                frm.MdiParent = mdiParent;

                // Yeni formun gösterilmesi
                frm.Show();
            }
            else
            {
                // MDI formu içinde değilse, hata mesajı gösterilebilir veya isteğe göre farklı bir işlem yapılabilir
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Anasayfa formunun MDI Parent'ı alınır
            Form mdiParent = this.MdiParent;

            // Anasayfa formunun MDI Parent'ı null değilse (MDI formu içinde ise)
            if (mdiParent != null)
            {
                // Yeni formun oluşturulması ve MDI Parent olarak atanması
                FrmPersonelListesi frm = new FrmPersonelListesi();
                frm.MdiParent = mdiParent;

                // Yeni formun gösterilmesi
                frm.Show();
            }
            else
            {
                // MDI formu içinde değilse, hata mesajı gösterilebilir veya isteğe göre farklı bir işlem yapılabilir
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Anasayfa formunun MDI Parent'ı alınır
            Form mdiParent = this.MdiParent;

            // Anasayfa formunun MDI Parent'ı null değilse (MDI formu içinde ise)
            if (mdiParent != null)
            {
                // Yeni formun oluşturulması ve MDI Parent olarak atanması
                FrmDeparmanListesi frm = new FrmDeparmanListesi();
                frm.MdiParent = mdiParent;

                // Yeni formun gösterilmesi
                frm.Show();
            }
            else
            {
                // MDI formu içinde değilse, hata mesajı gösterilebilir veya isteğe göre farklı bir işlem yapılabilir
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Anasayfa formunun MDI Parent'ı alınır
            Form mdiParent = this.MdiParent;

            // Anasayfa formunun MDI Parent'ı null değilse (MDI formu içinde ise)
            if (mdiParent != null)
            {
                // Yeni formun oluşturulması ve MDI Parent olarak atanması
                FrmAjanda frm = new FrmAjanda();
                frm.MdiParent = mdiParent;

                // Yeni formun gösterilmesi
                frm.Show();
            }
            else
            {
                // MDI formu içinde değilse, hata mesajı gösterilebilir veya isteğe göre farklı bir işlem yapılabilir
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Anasayfa formunun MDI Parent'ı alınır
            Form mdiParent = this.MdiParent;

            // Anasayfa formunun MDI Parent'ı null değilse (MDI formu içinde ise)
            if (mdiParent != null)
            {
                // Yeni formun oluşturulması ve MDI Parent olarak atanması
                FrmYeniMail frm = new FrmYeniMail();
                frm.MdiParent = mdiParent;

                // Yeni formun gösterilmesi
                frm.Show();
            }
            else
            {
                // MDI formu içinde değilse, hata mesajı gösterilebilir veya isteğe göre farklı bir işlem yapılabilir
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void FrmAnasayfaa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        where x.STOK < 30 // Yalnızca stok sayısı 30'dan küçük olanları seç
                                        select new
                                        {
                                            x.AD,
                                            x.MARKA,
                                            x.STOK,
                                        }).ToList();

            DateTime bugun = DateTime.Today;
            var deger = (from x in db.TBLNOTLARIM.OrderBy(y => y.ID)
                         where (x.TARIH == bugun)
                         select new
                         {
                             x.BASLIK,
                             x.ICERIK
                         });
            dataGridView4.DataSource = deger.ToList();
        }
    
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Seçili hücrenin satır indeksini al
            int rowIndex = e.RowIndex;

            // Satır indeksi geçerliyse devam et
            if (rowIndex >= 0)
            {
                // STOK değerini al
                int stok = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["STOK"].Value);

                // Stok sayısı 30'dan küçükse
                if (stok <= 30)
                {
                    // İstenmeyen renk biçimini kaldırmak için varsayılan renge dön
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                }
            }

        }
    }
}
