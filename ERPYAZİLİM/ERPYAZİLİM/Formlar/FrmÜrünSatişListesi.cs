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
    public partial class FrmÜrünSatişListesi : Form
    {
        public FrmÜrünSatişListesi()
        {
            InitializeComponent();
        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        void metot1()
        {
            var degerler = from x in db.TBLURUNHAREKET
                           select new
                           {
                               x.HARAKET,
                               URUNAD = x.TBLURUN.AD,
                               MUSTERI = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                               x.TARIH,
                               x.ADET,
                               x.FIYAT,
                               x.URUNSERINO
                           };
            dataGridView1.DataSource = degerler.ToList();
        }
        private void FrmÜrünSatişListesi_Load(object sender, EventArgs e)
        {
           
            metot1();
          
            comboBox2.DisplayMember = "AD"; // Görüntülenen metin
            comboBox2.ValueMember = "ID"; // Arka planda tutulan değer

      
            comboBox3.DisplayMember = "AD"; 
            comboBox3.ValueMember = "ID";

       
            comboBox4.DisplayMember = "AD"; 
            comboBox4.ValueMember = "ID"; 

            comboBox2.DataSource = (from x in db.TBLURUN
                                    select new
                                    {
                                        x.ID,
                                        x.AD
                                    }).ToList();

            comboBox3.DataSource = (from x in db.TBLCARI
                                    select new
                                    {
                                        x.ID,
                                        AD = x.AD + " " + x.SOYAD
                                    }).ToList();

            comboBox4.DataSource = (from x in db.TBLPERSONEL
                                    select new
                                    {
                                        x.ID,
                                        AD = x.AD + " " + x.SOYAD
                                    }).ToList();

        }

        private void BtnSatışYap_Click(object sender, EventArgs e) 
        {
            try
            {
                // Giriş dizesinin doğruluğunu kontrol et
                if (comboBox2.SelectedItem == null || comboBox3.SelectedItem == null || comboBox4.SelectedItem == null ||
                    string.IsNullOrEmpty(TxtTarih.Text) || string.IsNullOrEmpty(TxtAdet.Text) || string.IsNullOrEmpty(TxtFiyat.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
 
                TBLURUNHAREKET t = new TBLURUNHAREKET();

                int urunId = (int)comboBox2.SelectedValue;
                int musteriId = (int)comboBox3.SelectedValue;
                short personelId = (short)comboBox4.SelectedValue;
                DateTime tarih = DateTime.Parse(TxtTarih.Text);
                short adet = short.Parse(TxtAdet.Text);
                decimal fiyat = decimal.Parse(TxtFiyat.Text);

                // Değerleri TBLURUNHAREKET nesnesine ata
                t.URUN = urunId;
                t.MUSTERI = musteriId;
                t.PERSONEL = personelId;
                t.TARIH = tarih;
                t.ADET = adet;
                t.FIYAT = fiyat;
                t.URUNSERINO = TxtSeriNo.Text;
                db.TBLURUNHAREKET.Add(t);
                db.SaveChanges();

                MessageBox.Show("Veri başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    int urunhareketId = (int)dataGridView1.Rows[rowIndex].Cells["HARAKET"].Value;
                    var urunhareket = db.TBLURUNHAREKET.Find(urunhareketId);

                    if (urunhareket != null)
                    {
                        db.TBLURUNHAREKET.Remove(urunhareket);
                        db.SaveChanges();

                        MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Seçilen kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Seçilen satırdaki verileri al
                string urunAdi = row.Cells["URUNAD"].Value.ToString();
                string musteri = row.Cells["Musteri"].Value.ToString();
                string personel = row.Cells["Personel"].Value.ToString();
                DateTime tarih = Convert.ToDateTime(row.Cells["TARIH"].Value);
                int adet = Convert.ToInt32(row.Cells["ADET"].Value);
                decimal fiyat = Convert.ToDecimal(row.Cells["FIYAT"].Value);
                string seriNo = row.Cells["URUNSERINO"].Value.ToString();

                // Formdaki kontrolleri güncelle
                comboBox2.Text = urunAdi;
                comboBox3.Text = musteri;
                comboBox4.Text = personel;
                TxtTarih.Text = tarih.ToShortDateString();
                TxtAdet.Text = adet.ToString();
                TxtFiyat.Text = fiyat.ToString();
                TxtSeriNo.Text = seriNo;
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            try
            {
                TxtTarih.Clear();
                TxtAdet.Clear();
                TxtFiyat.Clear();
                TxtSeriNo.Clear();

                // ComboBox'ların seçili değerini kaldır
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Seçilen satırın ID'sini al
                    int id = Convert.ToInt32(selectedRow.Cells["HARAKET"].Value);
                    var urunhareket = db.TBLURUNHAREKET.Find(id);
                    if (urunhareket != null)
                    {
                        // Formdaki alanlardan gerekli verileri al
                        int urunId = (int)comboBox2.SelectedValue;
                        int musteriId = (int)comboBox3.SelectedValue;
                        short personelId = (short)comboBox4.SelectedValue;
                        DateTime tarih = DateTime.Parse(TxtTarih.Text);
                        short adet = short.Parse(TxtAdet.Text);
                        decimal fiyat = decimal.Parse(TxtFiyat.Text);

                        // Güncelleme işlemi için yeni değerleri ata
                        urunhareket.URUN = urunId;
                        urunhareket.MUSTERI = musteriId;
                        urunhareket.PERSONEL = personelId;
                        urunhareket.TARIH = tarih;
                        urunhareket.ADET = adet;
                        urunhareket.FIYAT = fiyat;
                        urunhareket.URUNSERINO = TxtSeriNo.Text;

                        // Veritabanında güncelle
                        db.SaveChanges();

                        MessageBox.Show("Veri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen ID'ye sahip ürün hareketi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen güncellemek için bir ürün hareketi seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
    }
    }
    
    

