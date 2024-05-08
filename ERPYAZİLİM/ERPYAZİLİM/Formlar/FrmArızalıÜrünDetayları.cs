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
    public partial class FrmArızalıÜrünDetayları : Form
    {
        public FrmArızalıÜrünDetayları()
        {
            InitializeComponent();
        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        public string id, serino;
        void listele()
        {
            dataGridView1.DataSource = (from x in db.TBLURUNTAKIP
                                        select new
                                        {
                                            x.TAKIPID,
                                            x.SERINO,
                                            x.TARIH,
                                            x.ACIKLAMA
                                        }).ToList();
        }

        private void FrmArızalıÜrünDetayları_Load(object sender, EventArgs e)
        {
            TxtSeriNo.Text = serino;
            dataGridView1.DataSource = (from x in db.TBLURUNTAKIP
                                       select new
                                       {
                                           x.TAKIPID,
                                           x.SERINO,
                                           x.TARIH,
                                           x.ACIKLAMA
                                       }).ToList();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void TxtSeriNo_Click(object sender, EventArgs e)
        {
            TxtSeriNo.Text = "";
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtTakıpId.Text))
            {
                int takipId = int.Parse(TxtTakıpId.Text);
                // Güncellenecek ürün takip nesnesini bul
                var urunTakip = db.TBLURUNTAKIP.FirstOrDefault(t => t.TAKIPID == takipId);

                if (urunTakip != null)
                {
                    urunTakip.ACIKLAMA = richTextBox1.Text;
                    urunTakip.SERINO = TxtSeriNo.Text;
                    urunTakip.TARIH = DateTime.Parse(TxtTarih.Text);
                    db.SaveChanges();
                    MessageBox.Show("Ürün arıza detayları güncellendi");

                    // DataGridView'i güncelle
                    //listele();
                   
                }
                else
                {
                    MessageBox.Show("Belirtilen ID ile ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnListele_Click(object sender, EventArgs e) // BU SAYFAYA TEKRAR BAK YAPAMADİM.
        {
            listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUNTAKIP yeniUrun = new TBLURUNTAKIP();

            yeniUrun.ACIKLAMA = richTextBox1.Text;
            yeniUrun.SERINO = TxtSeriNo.Text;

            DateTime tarih;
            if (!DateTime.TryParse(TxtTarih.Text, out tarih))
            {
                MessageBox.Show("Lütfen geçerli bir tarih formatı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            yeniUrun.TARIH = tarih;

            db.TBLURUNTAKIP.Add(yeniUrun);
            db.SaveChanges();

            MessageBox.Show("Yeni ürün takip kaydedildi");

            BtnListele_Click(sender, e); // Listeleme işlemini çağırarak DataGridView'i güncelle
        }
        /*{

            TBLURUNTAKIP yeniUrun = new TBLURUNTAKIP();

            yeniUrun.ACIKLAMA = richTextBox1.Text;
            yeniUrun.SERINO = TxtSeriNo.Text;
            yeniUrun.TARIH = DateTime.Parse(TxtTarih.Text);

            db.TBLURUNTAKIP.Add(yeniUrun);
            db.SaveChanges();

            MessageBox.Show("Yeni ürün takip kaydedildi");

            BtnListele_Click(sender, e); // Listeleme işlemini çağırarak DataGridView'i güncelle

        }*/

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtTakıpId.Text))
            {
                int takipId = int.Parse(TxtTakıpId.Text);

                // Silinecek ürünü bul
                var silinecekUrun = db.TBLURUNTAKIP.FirstOrDefault(t => t.TAKIPID == takipId);

                if (silinecekUrun != null)
                {

                    db.TBLURUNTAKIP.Remove(silinecekUrun);
                    db.SaveChanges();

                    MessageBox.Show("Ürün takip kaydı silindi");

                    BtnListele_Click(sender, e); 
                }
                else
                {
                    MessageBox.Show("Belirtilen ID ile ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                // PDF dosyasını kaydet
                SaveFileDialog savePdfDialog = new SaveFileDialog();
                savePdfDialog.Filter = "PDF Dosyaları|*.pdf";
                savePdfDialog.Title = "PDF Olarak Kaydet";

                if (savePdfDialog.ShowDialog() == DialogResult.OK)
                {
                    string pdfFilePath = savePdfDialog.FileName;

                    // PDF dosyası oluşturma
                    ExcelPdf.ExportToPDF(dataGridView1, pdfFilePath);

                    // Excel dosyasını kaydet
                    SaveFileDialog saveExcelDialog = new SaveFileDialog();
                    saveExcelDialog.Filter = "Excel Dosyaları|*.xlsx";
                    saveExcelDialog.Title = "Excel Olarak Kaydet";

                    if (saveExcelDialog.ShowDialog() == DialogResult.OK)
                    {
                        string excelFilePath = saveExcelDialog.FileName;

                        // Excel dosyası oluşturma
                        ExcelPdf.ExportToExcel(dataGridView1, excelFilePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView'de bir hücreye tıklandığında
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // DataGridView'deki seçili satırın verilerini TextBox ve diğer kontrollere yükleme
                TxtTakıpId.Text = row.Cells["TAKIPID"].Value.ToString();
                richTextBox1.Text = row.Cells["ACIKLAMA"].Value.ToString();
                TxtSeriNo.Text = row.Cells["SERINO"].Value.ToString();
                TxtTarih.Text = row.Cells["TARIH"].Value.ToString();
            }
        }

      
     
    }
}
