using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ERPYAZİLİM.Formlar // GÜNCELLEME BUTONUNDA SORUN VAR ÇÖZ. 
{
    public partial class FrmÜrünListesi : Form
    {
        public FrmÜrünListesi()
        {
            InitializeComponent();
        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        void metot1()
        {

            var degerler = from u in db.TBLURUN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.MARKA,
                               kategori = u.TBLKATEGORI.AD,
                               u.STOK,
                               u.ALISFIYAT,
                               u.SATISFIYAT

                           };
            dataGridView1.DataSource = degerler.ToList();
        }
        private void FrmÜrünListesi_Load(object sender, EventArgs e)
        {
          
            metot1();

            comboBox1.DisplayMember = "AD"; // Görüntülenen metin
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = (from x in db.TBLKATEGORI 
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLURUN t = new TBLURUN();
                t.AD = TxtUrunAd.Text;
                t.MARKA = TxtMarka.Text;
                t.ALISFIYAT = decimal.Parse(TxtAlisFiyat.Text);
                t.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
                t.STOK = short.Parse(TxtStok.Text);
                t.DURUM = false;
                t.KATEGORI = Convert.ToByte(comboBox1.SelectedValue);
                db.TBLURUN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Ürün başarıyla kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(TxtID.Text); // Seçili ürünün ID'sini al
                var deger = db.TBLURUN.Find(id); // ID'ye göre ürünü bul
                db.TBLURUN.Remove(deger); // Ürünü veritabanından kaldır
                db.SaveChanges(); // Değişiklikleri kaydet
                MessageBox.Show("Ürün başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
             try
             {
                 int id = int.Parse(TxtID.Text);
                 var deger = db.TBLURUN.Find(id);
                 deger.AD = TxtUrunAd.Text;
                 deger.STOK = short.Parse(TxtStok.Text);
                 deger.MARKA = TxtMarka.Text;
                 deger.ALISFIYAT = decimal.Parse(TxtAlisFiyat.Text);
                 deger.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
                 deger.KATEGORI = Convert.ToByte(comboBox1.SelectedValue);
                 db.SaveChanges();
                 MessageBox.Show("Ürün başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

                TxtID.Text = selectedRow.Cells["ID"].Value.ToString();
                TxtUrunAd.Text = selectedRow.Cells["AD"].Value.ToString();
                TxtMarka.Text = selectedRow.Cells["MARKA"].Value.ToString();
                TxtAlisFiyat.Text = selectedRow.Cells["ALISFIYAT"].Value.ToString();
                TxtSatisFiyat.Text = selectedRow.Cells["SATISFIYAT"].Value.ToString();
                TxtStok.Text = selectedRow.Cells["STOK"].Value.ToString();
                comboBox1.Text = selectedRow.Cells["KATEGORI"].Value.ToString();

            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAlisFiyat.Text = "";
            TxtID.Text = "";
            TxtMarka.Text = "";
            TxtSatisFiyat.Text = "";
            TxtStok.Text = "";
            TxtUrunAd.Text = "";
            comboBox1.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
         
            /*comboBox1.DataSource = db.TBLKATEGORI.ToList().Select(x => new
            {
                ID = x.ID,
                AD = x.AD,
                COMBO_TEXT = $"{x.ID,-5} {x.AD}"
            }).ToList();

            comboBox1.DisplayMember = "COMBO_TEXT";
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "COMBO_TEXT";
            comboBox1.ValueMember = "ID";     */   
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
