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
    public partial class FrmKullanıcıEkle : Form
    {
        public FrmKullanıcıEkle()
        {
            InitializeComponent();
        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();

        void Liste()
        {
            var degerler = from u in db.YETKİLENDİRME
                           select new
                           {
                               u.KullaniciID,
                               u.KullaniciAdi,
                               u.Sifre,
                               u.YetkiKategori,

                           };
            dataGridView1.DataSource = degerler.ToList();
        }
        private void FrmKullanıcıEkle_Load(object sender, EventArgs e)
        {
            Liste();

            comboBox4.DisplayMember = "YetkiKategori"; // Görüntülenen metin
            comboBox4.ValueMember = "YetkiKategori";
            comboBox4.DataSource = (from x in db.YETKİLENDİRME
                                    select new
                                    {
                                        x.YetkiKategori,
                                        
                                    }).ToList();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtKullaniciAdi.Text) || string.IsNullOrEmpty(TxtSifre.Text) || comboBox4.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                YETKİLENDİRME y = new YETKİLENDİRME();
                y.KullaniciAdi = TxtKullaniciAdi.Text;
                y.Sifre = TxtSifre.Text;
                y.YetkiKategori = Convert.ToByte(comboBox4.SelectedValue);
                db.YETKİLENDİRME.Add(y);
                db.SaveChanges();
                MessageBox.Show("Kullanıcı başarıyla kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Liste(); // Listeyi güncelle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen silmek için bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value); // Seçili kullanıcının ID'sini al
                var deger = db.YETKİLENDİRME.Find(id); // ID'ye göre kullanıcıyı bul
                db.YETKİLENDİRME.Remove(deger); // Kullanıcıyı veritabanından kaldır
                db.SaveChanges(); // Değişiklikleri kaydet
                MessageBox.Show("Kullanıcı başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Liste(); // Listeyi güncelle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtID.Text) || string.IsNullOrEmpty(TxtKullaniciAdi.Text) || string.IsNullOrEmpty(TxtSifre.Text) || comboBox4.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen bir kullanıcı seçin ve tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var deger = db.YETKİLENDİRME.Find(id);
                deger.KullaniciAdi = TxtKullaniciAdi.Text;
                deger.Sifre = TxtSifre.Text;
                deger.YetkiKategori = Convert.ToByte(comboBox4.SelectedValue);
                db.SaveChanges();
                MessageBox.Show("Kullanıcı başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Liste(); // Listeyi güncelle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtID.Text = "";
            TxtKullaniciAdi.Text= "";
            TxtSifre.Text = "";
            comboBox4.Text = "";
       
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                TxtID.Text = selectedRow.Cells["KullaniciID"].Value.ToString();
                TxtKullaniciAdi.Text = selectedRow.Cells["KullaniciAdi"].Value.ToString();
                TxtSifre.Text = selectedRow.Cells["Sifre"].Value.ToString();
                comboBox4.SelectedValue = selectedRow.Cells["YetkiKategori"].Value;
            }
        }
    }
    }

    
