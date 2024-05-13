using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPYAZİLİM.Formlar
{
    public partial class FrmArizalıÜrünListesi : Form
    {
        public FrmArizalıÜrünListesi()
        {
            InitializeComponent();
        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        public class Cari
        {
            public int CarID { get; set; }
            public string Model { get; set; }
        }

        public class Personel
        {
            public int PersonelID { get; set; }
            public string Name { get; set; }
        }
        private void FrmArizalıÜrünListesi_Load(object sender, EventArgs e)
        {
           
            //MÜŞTERİ

            comboBox1.DisplayMember = "AD"; // Görüntülenen metin
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = (from x in db.TBLCARI
                                    select new
                                    {
                                        x.ID,
                                        AD = x.AD + " " + x.SOYAD
                                    }).ToList();

            //PERSONEL
            comboBox2.DisplayMember = "AD"; // Görüntülenen metin
            comboBox2.ValueMember = "ID";
            comboBox2.DataSource = (from x in db.TBLPERSONEL
                                    select new
                                    {
                                        x.ID,
                                        AD = x.AD + " " + x.SOYAD
                                    }).ToList();

            panel1.AutoScroll = true;
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.ISLEMID,
                               CARİ = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                               x.GELISTARIH,
                               x.CIKISTARIHI,
                               x.URUNSERINO,
                               x.URUNDURUMDETAY
                           };
            dataGridView1.DataSource = degerler.ToList();

            label2.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == true).ToString();
            label4.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == false).ToString();
            label10.Text = db.TBLURUN.Count().ToString();
            label6.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Parça Bekliyor.").ToString();
            label8.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Mesaj Bekliyor.").ToString();
            label12.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "İptal Bekliyor.").ToString();


            //SqlConnection baglanti = new SqlConnection(@"Data Source=Acer\SQLEXPRESS;Initial Catalog=Db TıcarıOtomasyon;Integrated Security=True");
            SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Db TıcarıOtomasyon;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT URUNDURUMDETAY,COUNT(*) FROM TBLURUNKABUL GROUP BY URUNDURUMDETAY", baglanti);
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


        }


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUNKABUL t = new TBLURUNKABUL();
            var selectedCari = comboBox1.SelectedItem as dynamic;
            var selectedPersonel = comboBox2.SelectedItem as dynamic;

            if (selectedCari == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçin");
                return;
            }

            if (selectedPersonel == null)
            {
                MessageBox.Show("Lütfen bir personel seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime gelisTarih;
            if (!DateTime.TryParse(TxtTarih.Text, out gelisTarih))
            {
                MessageBox.Show("Lütfen geçerli bir tarih formatı girin (GG.AA.YYYY)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            t.CARI = (byte)selectedCari.ID;
            t.PERSONEL = (short)selectedPersonel.ID;
            t.GELISTARIH = gelisTarih;
            t.URUNSERINO = TxtSeriNo.Text;
            t.URUNDURUMDETAY = "Ürün Kaydoldu";
            db.TBLURUNKABUL.Add(t);
            db.SaveChanges();

            MessageBox.Show("Ürün Arıza Girişi Yapıldı");
        }
        /*{
            TBLURUNKABUL t = new TBLURUNKABUL();
            var selectedCari = comboBox1.SelectedItem;
            var selectedPersonel = comboBox2.SelectedItem;

            if (selectedCari == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçin");
                return;
            }

            if (selectedPersonel == null)
            {
                MessageBox.Show("Lütfen bir personel seçin");
                return;
            }

            t.CARI = (byte)((dynamic)selectedCari).ID;
            t.PERSONEL = (short)((dynamic)selectedPersonel).ID;
            t.GELISTARIH = DateTime.Parse(TxtTarih.Text);
            t.URUNSERINO = TxtSeriNo.Text;
            t.URUNDURUMDETAY = "Ürün Kaydoldu";
            db.TBLURUNKABUL.Add(t);
            db.SaveChanges();

            MessageBox.Show("Ürün Arıza Girişi Yapıldı");
        }*/

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLURUNKABUL
                           join c in db.TBLCARI on u.CARI equals c.ID
                           join p in db.TBLPERSONEL on u.PERSONEL equals p.ID
                           select new
                           {
                               ISLEMID = u.ISLEMID,
                               CARİ = c.AD + " " + c.SOYAD,
                               PERSONEL = p.AD + " " + p.SOYAD,
                               u.GELISTARIH,
                               u.CIKISTARIHI,
                               u.URUNSERINO,
                               u.URUNDURUMDETAY
                           };

            dataGridView1.DataSource = degerler.ToList();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
            TxtSeriNo.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int selectedISLEMID = (int)selectedRow.Cells["ISLEMID"].Value;
                var entity = db.TBLURUNKABUL.FirstOrDefault(x => x.ISLEMID == selectedISLEMID);

                if (entity != null)
                {
                    var selectedCari = comboBox1.SelectedItem;
                    var selectedPersonel = comboBox2.SelectedItem;

                    if (selectedCari == null)
                    {
                        MessageBox.Show("Lütfen bir müşteri seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (selectedPersonel == null)
                    {
                        MessageBox.Show("Lütfen bir personel seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    entity.CARI = (byte)((dynamic)selectedCari).ID;
                    entity.PERSONEL = (short)((dynamic)selectedPersonel).ID;
                    entity.GELISTARIH = DateTime.Parse(TxtTarih.Text);
                    entity.URUNSERINO = TxtSeriNo.Text;

                    db.SaveChanges();

                    MessageBox.Show("Ürün Arıza Güncellendi");
                    BtnListele_Click(sender, e); // Listeleme işlemini çağırarak DataGridView'i güncelle
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi gerçekleştirilemedi: Seçili öğe bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi için bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedISLEMID = (int)dataGridView1.SelectedRows[0].Cells["ISLEMID"].Value;
                var entity = db.TBLURUNKABUL.FirstOrDefault(x => x.ISLEMID == selectedISLEMID);

                if (entity != null)
                {
                    db.TBLURUNKABUL.Remove(entity);
                    db.SaveChanges();
                    MessageBox.Show("Seçili öğe başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnListele_Click(sender, e); // Listeleme işlemini çağırarak DataGridView'i güncelle
                }
                else
                {
                    MessageBox.Show("Silme işlemi gerçekleştirilemedi: Seçili öğe bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Silme işlemi için bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {


            /* string searchText = comboBox1.Text.ToLower(); // Kullanıcının girdiği metni küçük harfe dönüştürüyoruz.

            // ComboBox'un DataSource özelliğini temizliyoruz
            comboBox1.DataSource = null;

            // DataSource özelliğini yeniden dolduruyoruz
            comboBox1.DataSource = (
                from x in db.TBLCARI
                where x.AD.ToLower().Contains(searchText) || x.SOYAD.ToLower().Contains(searchText)
                select new
                {
                    x.ID,
                    AD = x.AD + " " + x.SOYAD
                }).ToList();

            comboBox1.DisplayMember = "AD"; // Görüntülenen metni yeniden ayarlıyoruz.
            comboBox1.ValueMember = "ID";
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DroppedDown = true; // ComboBox'ı açık konuma getiriyoruz, böylece filtrelenmiş sonuçları görebiliriz. */

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // DataGridView'deki seçili satırın verilerini TextBox ve diğer kontrollere yükleme
                comboBox1.Text = row.Cells["CARİ"].Value.ToString();
                comboBox2.Text = row.Cells["PERSONEL"].Value.ToString();
                TxtSeriNo.Text = row.Cells["URUNSERINO"].Value.ToString();
                TxtTarih.Text = row.Cells["GELISTARIH"].Value.ToString();
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
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
