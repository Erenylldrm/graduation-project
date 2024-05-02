using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace ERPYAZİLİM.Formlar
{
    public partial class FrmQR : Form
    {
        private Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1(); // Entity Framework bağlantısı

        public FrmQR()
        {
            InitializeComponent();
        }

        private void FrmQR_Load(object sender, EventArgs e)
        {
            // FrmQR yüklendiğinde burada yapılacak işlemleri ekleyebilirsiniz.
        }

        private void BtnQR_Click(object sender, EventArgs e)
        {
            string seriNumarasi = maskedTextBox1.Text; // QR kodunun içeriği olarak kullanılacak seri numarası

            // Seri numarasına ait tarih ve açıklama bilgilerini al
            string tarihVeAciklamalar = GetTarihVeAciklamalar(seriNumarasi);

            if (!string.IsNullOrEmpty(tarihVeAciklamalar))
            {
                // Hata kontrol seviyesi belirleyin
                QRCodeEncoder.ERROR_CORRECTION errorCorrection = QRCodeEncoder.ERROR_CORRECTION.M;

                // QR kod oluşturucu
                QRCodeEncoder enc = new QRCodeEncoder();
                enc.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                enc.QRCodeErrorCorrect = errorCorrection;

                // QR kodunu oluştur
                byte[] qrCodeBytes = Encoding.UTF8.GetBytes(tarihVeAciklamalar); // Byte dizisine dönüştür

                // QR kodunu farklı bir klasöre kaydetmek için bir dosya iletişim kutusu göster
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG (*.png)|*.png";
                saveFileDialog.FileName = $"QRCode_{seriNumarasi}.png";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var qrCodeBitmap = new Bitmap(new System.IO.MemoryStream(qrCodeBytes)))
                    {
                        qrCodeBitmap.Save(saveFileDialog.FileName);
                    }
                    MessageBox.Show("QR kodu başarıyla kaydedildi.");
                }
            }
            else
            {
                MessageBox.Show("Belirtilen seri numarasına ait veri bulunamadı.");
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


        private void BtnVazgeç_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOku_Click_1(object sender, EventArgs e)
        {
            // QR kodu okuma işlemi
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "QR Code|*.png;*.jpg;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // QR kodunu oku
                    QRCodeDecoder decoder = new QRCodeDecoder();
                    Bitmap bitmap = new Bitmap(filePath);
                    QRCodeImage qrCodeImage = new QRCodeBitmapImage(bitmap);
                    string decodedText = decoder.Decode(qrCodeImage);

                    // Okunan metni kullanarak yeni bir form aç
                    FrmQRDetay frmQRDetay = new FrmQRDetay();
                    frmQRDetay.Serino = decodedText;
                    frmQRDetay.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("QR kodu okuma hatası: " + ex.Message);
            }
        }
    }
}
