using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ERPYAZİLİM.Formlar
{
    public partial class FrmMüşteriListesi : Form
    {
        public FrmMüşteriListesi()
        {
            InitializeComponent();
        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        SqlConnection baglanti = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=Db TıcarıOtomasyon;Integrated Security=True");

    
        void liste()
        {
            var degerler = from x in db.TBLCARI
                           select new
                           {
                               x.ID,
                               x.AD,
                               x.SOYAD,
                               x.IL,
                               x.ILCE,
                               x.TELEFON,
                               x.MAIL
                           };
            dataGridView1.DataSource = degerler.ToList();
        }
 
        private void FrmMüşteriListesi_Load(object sender, EventArgs e)

        {
           

            dataGridView2.DataSource = db.TBLCARI.OrderBy(x => x.IL).
              GroupBy(y => y.IL).
              Select(z => new { İL = z.Key, TOPLAM = z.Count() }).ToList();

           
            SqlConnection baglanti = new SqlConnection(@"Data Source=Acer\SQLEXPRESS;Initial Catalog=Db TıcarıOtomasyon;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT IL, COUNT(*) FROM TBLCARI GROUP BY IL", baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            chart1.Series.Clear(); 
            chart1.Series.Add("Series 1");
            chart1.Series["Series 1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            int toplam = 0;

            while (dr.Read())
            {
                toplam += dr.GetInt32(1);
            }

            dr.Close();
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                double yuzde = (double)dr.GetInt32(1) / toplam * 100;
                chart1.Series["Series 1"].Points.AddXY(dr.GetString(0) + " (%" + yuzde.ToString("0.##") + ")", yuzde);
            }

            baglanti.Close();

            liste();

            comboBox1.DisplayMember = "sehir"; // Görünen metin sehir adı olacak
            comboBox1.ValueMember = "id"; // Seçilen değer olarak il ID'si kullanılacak
            comboBox1.DataSource = (from x in db.TBLILLER
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehir
                                                 }).ToList();

            label8.Text = db.TBLCARI.Count().ToString();
            label12.Text = (from x in db.TBLCARI orderby x.AD ascending select x.IL).FirstOrDefault();
            label16.Text = db.TBLCARI.Select(x => x.IL).Distinct().Count().ToString();
            label18.Text = db.TBLCARI.Select(x => x.ILCE).Distinct().Count().ToString();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                // Seçilen değeri kontrol et ve dönüştür
                if (int.TryParse(comboBox1.SelectedValue.ToString(), out int secilen))
                {
                    comboBox2.DisplayMember = "ilce"; // Görünen metin ilce adı olacak
                    comboBox2.ValueMember = "id"; // Seçilen değer olarak ilçe ID'si kullanılacak
                    comboBox2.DataSource = db.TBLILCELER.Where(ilce => ilce.sehir == secilen).ToList();
                }           
            }
        }


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtAd.Text) || string.IsNullOrWhiteSpace(TxtSoyad.Text) || string.IsNullOrWhiteSpace(TxtTelefon.Text) || string.IsNullOrWhiteSpace(TxtMail.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                TBLCARI t = new TBLCARI();
                t.AD = TxtAd.Text;
                t.SOYAD = TxtSoyad.Text;
                t.IL = comboBox1.Text;
                t.ILCE = comboBox2.Text;
                t.TELEFON = TxtTelefon.Text;
                t.MAIL = TxtMail.Text;
                db.TBLCARI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Yeni Müşteri Sisteme Başarılı Bir Şekilde Eklendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*{
            try
            {
                TBLCARI t = new TBLCARI();
                t.AD = TxtAd.Text;
                t.SOYAD = TxtSoyad.Text;
                t.IL = comboBox1.Text;
                t.ILCE = comboBox2.Text;
                t.TELEFON = TxtTelefon.Text;
                t.MAIL = TxtMail.Text;
                db.TBLCARI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Yeni Müşteri Sisteme Başarılı Bir Şekilde Eklendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception)
            {
                MessageBox.Show("Hata");
            }
        }*/

        private void BtnListele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırın ilgili hücresinden ID değerini al
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                var deger = db.TBLCARI.Find(id);
                if (deger != null)
                {
                    db.TBLCARI.Remove(deger);
                    db.SaveChanges();
                    MessageBox.Show("Müşteri başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Belirtilen ID'ye sahip müşteri bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Seçilen satırın ID'sini al
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                var deger = db.TBLCARI.Find(id);
                if (deger != null)
                {
                    // DataGridView'deki güncellenmiş verileri kullanarak müşteri bilgilerini güncelle
                    deger.AD = TxtAd.Text;
                    deger.SOYAD = TxtSoyad.Text;
                    deger.IL = comboBox1.Text;
                    deger.ILCE = comboBox2.Text;
                    deger.TELEFON = TxtTelefon.Text;
                    deger.MAIL = TxtMail.Text;
                    db.SaveChanges();

                    MessageBox.Show("Müşteri başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Belirtilen ID'ye sahip müşteri bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir müşteri seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                int secilenId = (int)comboBox1.SelectedValue;
                var filtrelenmisListe = db.TBLILLER.Where(il => il.id == secilenId).ToList();
                comboBox2.DataSource = filtrelenmisListe;
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Clear();
            TxtSoyad.Clear();
            comboBox1.SelectedIndex = -1; // İlk öğeyi seçili olmayacak şekilde ayarla
            comboBox2.DataSource = null;
            TxtMail.Clear();
            TxtTelefon.Clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Seçilen satırdan ilgili hücrelerin değerlerini al ve ilgili kontrollere doldur
                TxtAd.Text = selectedRow.Cells["AD"].Value.ToString();
                TxtSoyad.Text = selectedRow.Cells["SOYAD"].Value.ToString();
                comboBox1.Text = selectedRow.Cells["IL"].Value.ToString();
                comboBox2.Text = selectedRow.Cells["ILCE"].Value.ToString();
                TxtTelefon.Text = selectedRow.Cells["TELEFON"].Value.ToString(); // TxtTelefon TextBox'ına değeri ekle
                TxtMail.Text = selectedRow.Cells["MAIL"].Value.ToString(); // TxtMail TextBox'ına değeri ekle
            }
            else
            {
                TxtAd.Text = "";
                TxtSoyad.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                TxtTelefon.Text = "";
                TxtMail.Text = "";
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
    }
    }

