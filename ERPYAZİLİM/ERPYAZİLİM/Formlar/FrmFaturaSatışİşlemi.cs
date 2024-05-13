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
    public partial class FrmFaturaSatışİşlemi : Form
    {
        public FrmFaturaSatışİşlemi()
        {
            InitializeComponent();
        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();

        void listele()
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID

                           };
            dataGridView1.DataSource = degerler.ToList();
        }
        private void FrmFaturaSatışİşlemi_Load(object sender, EventArgs e)
        {
           
            listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUrun.Text) || string.IsNullOrWhiteSpace(TxtAdet.Text) || string.IsNullOrWhiteSpace(TxtFiyat.Text) || string.IsNullOrWhiteSpace(TxtTutar.Text) || string.IsNullOrWhiteSpace(TxtFatura.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            short adet;
            if (!short.TryParse(TxtAdet.Text, out adet) || adet <= 0)
            {
                MessageBox.Show("Geçerli bir adet giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal fiyat;
            if (!decimal.TryParse(TxtFiyat.Text, out fiyat) || fiyat <= 0)
            {
                MessageBox.Show("Geçerli bir fiyat giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tutar;
            if (!decimal.TryParse(TxtTutar.Text, out tutar) || tutar <= 0)
            {
                MessageBox.Show("Geçerli bir tutar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int faturaId;
            if (!int.TryParse(TxtFatura.Text, out faturaId) || faturaId <= 0)
            {
                MessageBox.Show("Geçerli bir fatura ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                TBLFATURADETAY detay = new TBLFATURADETAY();
                detay.URUN = TxtUrun.Text;
                detay.ADET = adet;
                detay.FIYAT = fiyat;
                detay.TUTAR = tutar;
                detay.FATURAID = faturaId;

                db.TBLFATURADETAY.Add(detay);
                db.SaveChanges();
                MessageBox.Show("Faturaya ait kalem girişi başarı ile yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /*{
            TBLFATURADETAY detay = new TBLFATURADETAY();
            detay.URUN = TxtUrun.Text;
            detay.ADET = short.Parse(TxtAdet.Text);
            detay.FIYAT = decimal.Parse(TxtFiyat.Text);
            detay.TUTAR = decimal.Parse(TxtTutar.Text);
            detay.FATURAID = int.Parse(TxtFatura.Text);

            db.TBLFATURADETAY.Add(detay);
            db.SaveChanges();
            MessageBox.Show("Faturaya ait kalem girişi başarı ile yapıldı.");
        }*/

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                int detayID = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["FATURADETAYID"].Value); 
                var detay = db.TBLFATURADETAY.Find(detayID);
                if (detay != null)
                {
                    db.TBLFATURADETAY.Remove(detay);
                    db.SaveChanges();
                    MessageBox.Show("Seçili fatura detayı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //listele();
                }
                else
                {
                    MessageBox.Show("Seçili ID ile eşleşen bir fatura detayı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TxtID.Text);
                var deger = db.TBLFATURADETAY.Find(id);
                if (deger != null)
                {
                    deger.URUN = TxtUrun.Text;
                    deger.ADET = short.Parse(TxtAdet.Text);
                    deger.FIYAT = decimal.Parse(TxtFiyat.Text);
                    deger.TUTAR = decimal.Parse(TxtTutar.Text);
                    deger.FATURAID = int.Parse(TxtFatura.Text);

                    db.SaveChanges();
                    MessageBox.Show("Fatura detayı başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Güncellenecek fatura detayı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                TxtID.Text = selectedRow.Cells["FATURADETAYID"].Value.ToString(); // FATURADETAYID olması gerektiği varsayımıyla
                TxtUrun.Text = selectedRow.Cells["URUN"].Value.ToString();
                TxtAdet.Text = selectedRow.Cells["ADET"].Value.ToString();
                TxtFiyat.Text = selectedRow.Cells["FIYAT"].Value.ToString();
                TxtTutar.Text = selectedRow.Cells["TUTAR"].Value.ToString();
                TxtFatura.Text = selectedRow.Cells["FATURAID"].Value.ToString();
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
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
