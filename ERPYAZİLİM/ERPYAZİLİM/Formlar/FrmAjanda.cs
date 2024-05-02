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
    public partial class FrmAjanda : Form
    {
        public FrmAjanda()
        {
            InitializeComponent();
        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        private void FrmAjanda_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
            dataGridView2.DataSource = db.TBLNOTLARIM.Where(y => y.DURUM == true).ToList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satır varsa işlemleri gerçekleştir
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                TxtID.Text = selectedRow.Cells["ID"].Value.ToString();
            }
            else
            {
                // Herhangi bir satır seçili değilse, metin kutusunu temizle veya başka bir işlem yap
                TxtID.Text = "";
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLNOTLARIM t = new TBLNOTLARIM();
            t.BASLIK = TxtBaslik.Text;
            t.ICERIK = Txtİcerik.Text;
            t.DURUM = false;
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            db.TBLNOTLARIM.Add(t);
            db.SaveChanges();
            MessageBox.Show("Not başarıyla kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(TxtID.Text, out id))
            {
                var deger = db.TBLNOTLARIM.Find(id);
                if (deger != null)
                {
                    db.TBLNOTLARIM.Remove(deger);
                    db.SaveChanges();
                    MessageBox.Show("Not başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dataGridView1.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
                    //dataGridView2.DataSource = db.TBLNOTLARIM.Where(y => y.DURUM == true).ToList();
                }
                else
                {
                    MessageBox.Show("Belirtilen ID ile eşleşen bir not bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                int id = int.Parse(TxtID.Text);
                var deger = db.TBLNOTLARIM.Find(id);
                deger.DURUM = true;
                db.SaveChanges();
                MessageBox.Show("Not durumu değiştirildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Her iki DataGridView'i de güncelle
                dataGridView1.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
                dataGridView2.DataSource = db.TBLNOTLARIM.Where(y => y.DURUM == true).ToList();
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
            dataGridView2.DataSource = db.TBLNOTLARIM.Where(y => y.DURUM == true).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                TxtID.Text = selectedRow.Cells["ID"].Value.ToString();
                TxtBaslik.Text = selectedRow.Cells["BASLIK"].Value.ToString();
                Txtİcerik.Text = selectedRow.Cells["ICERIK"].Value.ToString();
                TxtTarih.Text = selectedRow.Cells["TARIH"].Value.ToString();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtID.Clear();
            TxtBaslik.Clear();
            Txtİcerik.Clear();
            TxtTarih.Clear();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                TxtID.Text = selectedRow.Cells["ID"].Value.ToString();
                TxtBaslik.Text = selectedRow.Cells["BASLIK"].Value.ToString();
                Txtİcerik.Text = selectedRow.Cells["ICERIK"].Value.ToString();
                TxtTarih.Text = selectedRow.Cells["TARIH"].Value.ToString();
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
                    ExcelPdf.ExportToPDF(dataGridView2, pdfFilePath);
                  

                    // Excel dosyasını kaydet
                    SaveFileDialog saveExcelDialog = new SaveFileDialog();
                    saveExcelDialog.Filter = "Excel Dosyaları|*.xlsx";
                    saveExcelDialog.Title = "Excel Olarak Kaydet";

                    if (saveExcelDialog.ShowDialog() == DialogResult.OK)
                    {
                        string excelFilePath = saveExcelDialog.FileName;

                        // Excel dosyası oluşturma
                        ExcelPdf.ExportToExcel(dataGridView2, excelFilePath);
                     
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
