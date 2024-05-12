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
    public partial class FrmDeparmanListesi : Form
    {
        public FrmDeparmanListesi()
        {
            InitializeComponent();
        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        private void FrmDeparmanListesi_Load(object sender, EventArgs e)
        {
           
            {
                var degerler = from u in db.TBLDEPARTMAN
                               select new
                               {
                                   u.ID,
                                   u.AD,

                               };
                dataGridView1.DataSource = degerler.ToList();

                label4.Text = db.TBLDEPARTMAN.Count().ToString();
                label7.Text = db.TBLPERSONEL.Count().ToString();
                label9.Text = (from x in db.TBLPERSONEL
                                       orderby x.AD ascending
                                       select x.TBLDEPARTMAN.AD).FirstOrDefault();

                label11.Text = (from x in db.TBLPERSONEL
                                       orderby x.AD descending
                                       select x.TBLDEPARTMAN.AD).FirstOrDefault();
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN t = new TBLDEPARTMAN();
            if (TxtAd.Text.Length <= 50 && TxtAd.Text != "" && TxtAcıklama.Text.Length >= 1)
            {
                t.AD = TxtAd.Text;
                t.ACIKLAMA = TxtAcıklama.Text;
                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.ID,
                               u.AD                             
                           };
            dataGridView1.DataSource = degerler.ToList();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                    var departman = db.TBLDEPARTMAN.Find(id);

                    if (departman != null)
                    {
                        departman.AD = TxtAd.Text; 
                        db.SaveChanges();
                        MessageBox.Show("Departman başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Seçilen ID ile eşleşen bir departman bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz departmanı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                    var departman = db.TBLDEPARTMAN.Find(id);

                    if (departman != null)
                    {
                        db.TBLDEPARTMAN.Remove(departman);
                        db.SaveChanges();
                        MessageBox.Show("Departman başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Seçilen ID ile eşleşen bir departman bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz departmanı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            try
            {
                TxtID.Clear();
                TxtAd.Clear();
                TxtAcıklama.Clear();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int departmanID = Convert.ToInt32(row.Cells["ID"].Value);
                string departmanAd = row.Cells["AD"].Value.ToString();
                TxtID.Text = departmanID.ToString();
                TxtAd.Text = departmanAd;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
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
