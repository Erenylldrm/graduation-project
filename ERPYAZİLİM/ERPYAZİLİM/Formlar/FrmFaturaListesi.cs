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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        void liste()
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               CARI = u.TBLCARI.AD + " " + u.TBLCARI.SOYAD,
                               PERSONEL = u.TBLPERSONEL.AD +" "+ u.TBLPERSONEL.SOYAD

                            };
            dataGridView1.DataSource = degerler.ToList();
        }
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
          
            liste();
            /*comboBox1.DisplayMember = "CARI_ADI";
            comboBox1.ValueMember = "CARI_ID";
            comboBox1.DataSource = db.TBLCARI.ToList();

            comboBox2.DisplayMember = "PERSONEL_ADI";
            comboBox2.ValueMember = "PERSONEL_ID";
            comboBox2.DataSource = db.TBLPERSONEL.ToList();*/


            comboBox1.DisplayMember = "AD"; 
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = (from x in db.TBLCARI 
                                    select new
                                    {
                                        x.ID,
                                        AD = x.AD + " " + x.SOYAD
                                    }).ToList();

            comboBox2.DisplayMember = "AD"; 
            comboBox2.ValueMember = "ID";
            comboBox2.DataSource = (from x in db.TBLPERSONEL 
                                    select new
                                    {
                                        x.ID,
                                        AD = x.AD + " " + x.SOYAD
                                    }).ToList();
        }

     
        private void BtnSatışYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSeri.Text) || string.IsNullOrWhiteSpace(TxtSira.Text) || string.IsNullOrWhiteSpace(TxtTarih.Text) || string.IsNullOrWhiteSpace(TxtSaat.Text) || string.IsNullOrWhiteSpace(TxtVergiDairesi.Text) || comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime tarih;
            if (!DateTime.TryParse(TxtTarih.Text, out tarih))
            {
                MessageBox.Show("Lütfen geçerli bir tarih formatı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cariId;
            if (!int.TryParse(comboBox1.SelectedValue.ToString(), out cariId))
            {
                MessageBox.Show("Geçerli bir müşteri seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            short personelId;
            if (!short.TryParse(comboBox2.SelectedValue.ToString(), out personelId))
            {
                MessageBox.Show("Geçerli bir personel seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                TBLFATURABILGI t = new TBLFATURABILGI();
                t.SERI = TxtSeri.Text;
                t.SIRANO = TxtSira.Text;
                t.TARIH = tarih;
                t.SAAT = TxtSaat.Text;
                t.VERGIDAIRE = TxtVergiDairesi.Text;
                t.CARI = cariId;
                t.PERSONEL = personelId;
                db.TBLFATURABILGI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Fatura Sisteme Kaydedilmiştir, Kalem Girişi Yapabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /*{
            TBLFATURABILGI t = new TBLFATURABILGI();
            t.SERI = TxtSeri.Text;
            t.SIRANO = TxtSira.Text;
            t.TARIH = Convert.ToDateTime(TxtTarih.Text);
            t.SAAT = TxtSaat.Text;
            t.VERGIDAIRE = TxtVergiDairesi.Text;
            t.CARI = int.Parse(comboBox1.SelectedValue.ToString());
            t.PERSONEL = short.Parse(comboBox2.SelectedValue.ToString());
            db.TBLFATURABILGI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Sisteme Kaydedilmiştir,Kalem Girişi Yapabilirsiniz.");
        }*/

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["ID"].Value);
                var deger = db.TBLFATURABILGI.Find(id);
                if (deger != null)
                {
                    db.TBLFATURABILGI.Remove(deger);
                    db.SaveChanges();
                    MessageBox.Show("Seçili fatura başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Veritabanından verileri tekrar yükleyerek DataGridView'i güncelle
                    dataGridView1.DataSource = db.TBLFATURABILGI.ToList();
                }
                else
                {
                    MessageBox.Show("Seçili ID ile eşleşen bir fatura bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir fatura seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnGüncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TxtID.Text);
                var deger = db.TBLFATURABILGI.Find(id);
                deger.SERI = TxtSeri.Text;
                deger.SIRANO = TxtSira.Text; 
                deger.TARIH = Convert.ToDateTime(TxtTarih.Text);
                deger.SAAT = TxtSaat.Text; 
                deger.VERGIDAIRE = TxtVergiDairesi.Text;
                deger.CARI = (int)comboBox1.SelectedValue; 
                deger.PERSONEL = (short)comboBox2.SelectedValue; 

                db.SaveChanges();
                MessageBox.Show("Fatura başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            liste();
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0) // Eğer dataGridView1 üzerinde seçili bir satır varsa
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                FaturaBilgi fr = new FaturaBilgi();
                fr.id = id;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(Txtid2.Text, out id))
            {
                var degerler2 = (from u in db.TBLFATURADETAY
                                 select new
                                 {
                                     u.FATURADETAYID,
                                     u.URUN,
                                     u.ADET,
                                     u.FIYAT,
                                     u.TUTAR,
                                     u.FATURAID

                                 }).Where(x => x.FATURAID == id).ToList(); 

                dataGridView2.DataSource = degerler2; 
            }
            else
            {
                //MessageBox.Show("Geçersiz giriş.");
            }

            string seriNo = TxtSeriNo.Text;
            string siraNo = TxtSıraNo.Text;

            var degerler = from u in db.TBLFATURABILGI
                           where (string.IsNullOrEmpty(seriNo) || u.SERI.Contains(seriNo)) &&
                                 (string.IsNullOrEmpty(siraNo) || u.SIRANO.Contains(siraNo))
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               CARI = u.TBLCARI.AD + " " + u.TBLCARI.SOYAD,
                               PERSONEL = u.TBLPERSONEL.AD + " " + u.TBLPERSONEL.SOYAD
                           };
            dataGridView2.DataSource = degerler.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                TxtID.Text = selectedRow.Cells["ID"].Value.ToString();
                TxtSeri.Text = selectedRow.Cells["SERI"].Value.ToString();
                TxtSira.Text = selectedRow.Cells["SIRANO"].Value.ToString();
                TxtTarih.Text = selectedRow.Cells["TARIH"].Value.ToString();
                TxtSaat.Text = selectedRow.Cells["SAAT"].Value.ToString();
                TxtVergiDairesi.Text = selectedRow.Cells["VERGIDAIRE"].Value.ToString();
                comboBox1.Text = selectedRow.Cells["CARI"].Value.ToString();
                comboBox2.Text = selectedRow.Cells["PERSONEL"].Value.ToString();
            }
        }
    }
}
