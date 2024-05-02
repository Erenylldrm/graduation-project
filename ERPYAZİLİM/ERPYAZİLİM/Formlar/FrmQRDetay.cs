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
    public partial class FrmQRDetay : Form
    {
        public string Serino { get; set; }

        public FrmQRDetay()
        {
            InitializeComponent();
        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        private void FrmQRDetay_Load(object sender, EventArgs e)
        {
            // Serino ile ilgili tarih ve açıklamaları göster
            string tarihVeAciklamalar = GetTarihVeAciklamalar(Serino);
            if (!string.IsNullOrEmpty(tarihVeAciklamalar))
            {
                richTextBox1.Text = tarihVeAciklamalar;
            }
            else
            {
                richTextBox1.Text = "Belirtilen seri numarasına ait veri bulunamadı.";
            }
        }

        private string GetTarihVeAciklamalar(string seriNumarasi)
        {
            // Seri numarasına ait tarih ve açıklama bilgilerini veritabanından al
            var urunler = db.TBLURUNTAKIP.Where(x => x.SERINO == seriNumarasi).ToList();

            if (urunler.Any())
            {
                // Her bir ürün için tarih ve açıklamayı birleştir
                string tarihVeAciklamalar = string.Join("\n", urunler.Select(x => $"{x.TARIH?.ToShortDateString()} - {x.ACIKLAMA}"));

                return tarihVeAciklamalar;
            }
            else
            {
                return null; // Belirtilen seri numarasına ait veri bulunamadı
            }
        }

       
    }
}