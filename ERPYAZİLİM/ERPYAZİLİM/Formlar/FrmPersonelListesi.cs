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
    public partial class FrmPersonelListesi : Form
    {
        public FrmPersonelListesi()
        {
            InitializeComponent();
        }

        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        SqlConnection baglanti = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=Db TıcarıOtomasyon;Integrated Security=True");
        private int toplamPersonelSayisi; // Toplam personel sayısı
        private int mevcutPersonelIndeksi = 0; // Şu an görüntülenen personelin dizini
        private int panelSayisi = 4; // Ekranda gösterilecek panel sayısı
        void Liste()
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.DEPARTMAN,
                               u.MAIL,
                               u.TELEFON

                           };
            dataGridView1.DataSource = degerler.ToList();
        }
        private void FrmPersonelListesi_Load(object sender, EventArgs e)
        {
            Liste();

            comboBox1.DataSource = db.TBLDEPARTMAN.ToList().Select(x => new
            {
                ID = x.ID,
                AD = x.AD,
                COMBO_TEXT = $"{x.ID,-5} {x.AD}"
            }).ToList();

            comboBox1.DisplayMember = "COMBO_TEXT";
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "COMBO_TEXT";
            comboBox1.ValueMember = "ID";

            ToplamPersonelSayisiniYukle(); // Toplam personel sayısını yükle
            SonrakiPanelGrubunuGoster(); // İlk grup panelleri göster
        }

        private void ToplamPersonelSayisiniYukle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM TBLPERSONEL", baglanti);
            toplamPersonelSayisi = (int)komut.ExecuteScalar();
            baglanti.Close();
        }

        private void SonrakiPanelGrubunuGoster()
        {
            for (int i = 1; i <= panelSayisi; i++)
            {
                Panel panel = this.Controls.Find("panel" + i, true).FirstOrDefault() as Panel;
                panel.Controls.Clear(); // Önceki panelleri temizle

                if (mevcutPersonelIndeksi < toplamPersonelSayisi)
                {
                    baglanti.Open();
                    string sorgu = $"SELECT AD, SOYAD, DEPARTMAN, MAIL, TELEFON FROM TBLPERSONEL ORDER BY ID OFFSET {mevcutPersonelIndeksi} ROWS FETCH NEXT 1 ROWS ONLY";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    SqlDataReader dr = komut.ExecuteReader();

                    if (dr.Read())
                    {
                        string ad = dr["AD"].ToString();
                        string soyad = dr["SOYAD"].ToString();
                        string departman = dr["DEPARTMAN"].ToString();
                        string email = dr["MAIL"].ToString();
                        string telefon = dr["TELEFON"].ToString();

                        Label adLabel = new Label();
                        adLabel.Text = $"Ad: {ad}";
                        adLabel.Location = new System.Drawing.Point(80, 150);
                        adLabel.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold);
                        adLabel.ForeColor = Color.Black;
                        panel.Controls.Add(adLabel);

                        Label soyadLabel = new Label();
                        soyadLabel.Text = $"Soyad: {soyad}";
                        soyadLabel.Location = new System.Drawing.Point(80, 180);
                        soyadLabel.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold);
                        soyadLabel.ForeColor = Color.Black;
                        panel.Controls.Add(soyadLabel);

                        Label departmanLabel = new Label();
                        departmanLabel.Text = $"Departman: {departman}";
                        departmanLabel.Location = new System.Drawing.Point(80, 210);
                        departmanLabel.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold);
                        departmanLabel.ForeColor = Color.Black;
                        panel.Controls.Add(departmanLabel);

                        Label emailLabel = new Label();
                        emailLabel.Text = $"Email: {email}";
                        emailLabel.Location = new System.Drawing.Point(80, 240);
                        emailLabel.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold);
                        emailLabel.ForeColor = Color.Black;
                        panel.Controls.Add(emailLabel);

                        Label telefonLabel = new Label();
                        telefonLabel.Text = $"Telefon: {telefon}";
                        telefonLabel.Location = new System.Drawing.Point(80, 270);
                        telefonLabel.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold);
                        telefonLabel.ForeColor = Color.Black;
                        panel.Controls.Add(telefonLabel);

                        // PictureBox ekleme
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.ImageLocation = @"C:\Users\engineer\Desktop\Resimler\Male User.png"; 
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Size = new Size(100, 100); 
                        pictureBox.Location = new Point(80, 20);
                        panel.Controls.Add(pictureBox);
                    }

                    dr.Close();
                    baglanti.Close();

                    mevcutPersonelIndeksi++;
                }
            }

            if (mevcutPersonelIndeksi >= toplamPersonelSayisi)
                mevcutPersonelIndeksi = 0; // Son kişiye ulaşıldığında başa dön


        }


        private void btnNext_Click_1(object sender, EventArgs e)
        {
            // Her butona basıldığında, mevcut paneldeki verileri temizle
            foreach (Control kontrol in this.Controls)
            {
                if (kontrol is Panel)
                {
                    Panel panel = (Panel)kontrol;
                    panel.Controls.Clear();
                }
            }

            // Bir sonraki grup panelleri göster
            SonrakiPanelGrubunuGoster();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtAd.Text) || string.IsNullOrWhiteSpace(TxtSoyad.Text) || string.IsNullOrWhiteSpace(TxtMail.Text) || string.IsNullOrWhiteSpace(TxtTelefon.Text) || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                TBLPERSONEL t = new TBLPERSONEL();
                t.AD = TxtAd.Text;
                t.SOYAD = TxtSoyad.Text;
                t.DEPARTMAN = Convert.ToByte(comboBox1.SelectedValue);
                t.MAIL = TxtMail.Text;
                t.TELEFON = TxtTelefon.Text;
                db.TBLPERSONEL.Add(t);
                db.SaveChanges();
                MessageBox.Show("Personel sisteme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*{
            TBLPERSONEL t = new TBLPERSONEL();
            t.AD = TxtAd.Text;
            t.SOYAD = TxtSoyad.Text;
            t.DEPARTMAN = Convert.ToByte(comboBox1.SelectedValue);
            t.MAIL = TxtMail.Text;
            t.TELEFON = TxtTelefon.Text;
            db.TBLPERSONEL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Personel sisteme eklendi.");
        }*/

        private void BtnSil_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0) // En az bir satır seçildiğinden emin olunur
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index; // Seçilen satırın indeksi alınır
                int id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value); // Seçilen satırdaki ID değeri alınır

                var silinecekPersonel = db.TBLPERSONEL.Find(id); // ID'ye göre veritabanından ilgili personel bulunur

                if (silinecekPersonel != null)
                {
                    db.TBLPERSONEL.Remove(silinecekPersonel); // Personel veritabanından kaldırılır
                    db.SaveChanges();
                    MessageBox.Show("Seçilen personel başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Seçilen ID ile eşleşen bir personel bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz personeli seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtID.Text) || string.IsNullOrWhiteSpace(TxtAd.Text) || string.IsNullOrWhiteSpace(TxtSoyad.Text) || string.IsNullOrWhiteSpace(TxtMail.Text) || string.IsNullOrWhiteSpace(TxtTelefon.Text) || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int id;
                if (!int.TryParse(TxtID.Text, out id))
                {
                    MessageBox.Show("Geçerli bir personel ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var deger = db.TBLPERSONEL.Find(id);
                if (deger == null)
                {
                    MessageBox.Show("Belirtilen ID'ye sahip personel bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                deger.AD = TxtAd.Text;
                deger.SOYAD = TxtSoyad.Text;
                deger.DEPARTMAN = Convert.ToByte(comboBox1.SelectedValue);
                deger.MAIL = TxtMail.Text;
                deger.TELEFON = TxtTelefon.Text;
                db.SaveChanges();
                MessageBox.Show("Personel başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*{
            try
            {
                int id = int.Parse(TxtID.Text);
                var deger = db.TBLPERSONEL.Find(id);
                deger.AD = TxtAd.Text;
                deger.SOYAD = TxtSoyad.Text;
                deger.DEPARTMAN = Convert.ToByte(comboBox1.SelectedValue);
                deger.MAIL = TxtMail.Text;
                deger.TELEFON = TxtTelefon.Text;
                db.SaveChanges();
                MessageBox.Show("Personel başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            try
            {
                TxtID.Clear();
                TxtAd.Clear();
                TxtSoyad.Clear();
                TxtMail.Clear();
                TxtTelefon.Clear();

                // ComboBox'ların seçili değerini kaldır
                comboBox1.SelectedIndex = -1;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Seçilen satırdaki verileri al
                int personelID = Convert.ToInt32(row.Cells["ID"].Value);
                string ad = row.Cells["AD"].Value.ToString();
                string soyad = row.Cells["SOYAD"].Value.ToString();
                string departman = row.Cells["DEPARTMAN"].Value.ToString();
                string mail = row.Cells["MAIL"].Value.ToString();
                string telefon = row.Cells["TELEFON"].Value != null ? row.Cells["TELEFON"].Value.ToString() : "";

                // Formdaki kontrolleri güncelle
                TxtID.Text = personelID.ToString();
                TxtAd.Text = ad;
                TxtSoyad.Text = soyad;
                comboBox1.Text = departman;
                TxtMail.Text = mail;
                TxtTelefon.Text = telefon;

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

