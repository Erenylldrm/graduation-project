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
    public partial class FrmBarcode : Form
    {
        public FrmBarcode()
        {
            InitializeComponent();
        }
        private void FrmBarcode_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw brc = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = brc.Draw(textBox1.Text, 35);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmQR2 frmQR2 = new FrmQR2();
            frmQR2.Show();
        }

  

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Image Files (*.png, *.jpg, *.jpeg, *.bmp)|*.png;*.jpg;*.jpeg;*.bmp|All files (*.*)|*.*";
                saveFileDialog.FileName = "barcode"; // Varsayılan dosya adı
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    pictureBox1.Image.Save(fileName); // Resmi kaydet
                    MessageBox.Show("Barkod başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Kaydedilecek barkod bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
