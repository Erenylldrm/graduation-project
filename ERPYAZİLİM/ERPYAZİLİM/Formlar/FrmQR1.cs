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
    public partial class FrmQR1 : Form
    {
        public FrmQR1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enc = new QRCodeEncoder();
            pictureBox1.Image = enc.Encode(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QRCodeDecoder dnc = new QRCodeDecoder();
            textBox1.Text = dnc.Decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmQR2 frmQR2 = new FrmQR2(); 
            frmQR2.Show(); 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmQR1_Load(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog dosyaKaydetDialog = new SaveFileDialog();
                dosyaKaydetDialog.Filter = "Resim Dosyaları (*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
                dosyaKaydetDialog.Title = "QR Kod Resmini Kaydet";
                dosyaKaydetDialog.FileName = "QRKodResmi";
                if (dosyaKaydetDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(dosyaKaydetDialog.FileName);
                    MessageBox.Show("QR kod resmi başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Kaydedilecek QR kod resmi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
