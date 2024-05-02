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
    public partial class FrmKategoriListesi : Form
    {
        public FrmKategoriListesi()
        {
            InitializeComponent();
        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        private void FrmKategoriListesi_Load(object sender, EventArgs e)
        {
            var degerler = from k in db.TBLKATEGORI
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            dataGridView1.DataSource = degerler.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text != "" && TxtAd.Text.Length <= 30)
            {
                TBLKATEGORI t = new TBLKATEGORI();
                t.AD = TxtAd.Text;
                db.TBLKATEGORI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Kaydedildi");
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez ve Kategori adı 30 karakterden uzun olamaz");
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLKATEGORI.Find(id);

            DialogResult result = MessageBox.Show("Kategoriyi gerçekten silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                db.TBLKATEGORI.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Kategori başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Silme işlemi iptal edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLKATEGORI.Find(id);
            deger.AD = TxtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from k in db.TBLKATEGORI
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            dataGridView1.DataSource = degerler.ToList();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Text = "";
            TxtID.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                TxtID.Text = selectedRow.Cells["ID"].Value.ToString();
                TxtAd.Text = selectedRow.Cells["AD"].Value.ToString();
            }
            else
            {
                TxtID.Text = "";
                TxtAd.Text = "";
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
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
    }
}
