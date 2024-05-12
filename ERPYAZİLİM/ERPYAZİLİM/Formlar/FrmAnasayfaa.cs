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
    public partial class FrmAnasayfaa : Form
    {
        private Dictionary<Button, Rectangle> originalButtonBounds = new Dictionary<Button, Rectangle>();

        public FrmAnasayfaa()
        {
            InitializeComponent();          

            // Tüm düğmeleri kontrol edin ve olayları atayın
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.MouseEnter += button_MouseEnter;
                    button.MouseLeave += button_MouseLeave;
                }
            }


        }

        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;

            // Butonun orijinal boyutunu ve konumunu kaydetme
            if (!originalButtonBounds.ContainsKey(button))
                originalButtonBounds[button] = button.Bounds;

            // Butonun boyutunu ve konumunu büyütme
            button.Bounds = new Rectangle(
                button.Bounds.X - (int)(button.Width * 0.05),
                button.Bounds.Y - (int)(button.Height * 0.05),
                (int)(button.Width * 1.1),
                (int)(button.Height * 1.1)
            );

            // Butonun kenarlarına dolgu ekleyerek çizgi görünümünü engelleme
            button.Padding = new Padding(3);

            // İmleci el simgesi olarak değiştirme
            Cursor = Cursors.Hand;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;

            // Butonun boyutunu ve konumunu orijinal hale getirme
            button.Bounds = originalButtonBounds[button];

            // Dolgu (padding) sıfırlama
            button.Padding = new Padding(0);

            // İmleci varsayılan olarak geri getirme
            Cursor = Cursors.Default;
        }


        private void button1_Click(object sender, EventArgs e)
        {
        
            Form mdiParent = this.MdiParent;

            // Anasayfa formunun MDI Parent'ı null değilse (MDI formu içinde ise)
            if (mdiParent != null)
            {
                // Yeni formun oluşturulması ve MDI Parent olarak atanması
                FrmKategoriListesi frm = new FrmKategoriListesi();
                frm.MdiParent = mdiParent;

                // Yeni formun gösterilmesi
                frm.Show();
            }
            else
            {
                // MDI formu içinde değilse, hata mesajı gösterilebilir veya isteğe göre farklı bir işlem yapılabilir
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form mdiParent = this.MdiParent;
          
            if (mdiParent != null)
            {              
                FrmÜrünListesi frm = new FrmÜrünListesi();
                frm.MdiParent = mdiParent;
                frm.Show();
            }
            else
            {             
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form mdiParent = this.MdiParent;

            if (mdiParent != null)
            {
         
                Frmİstatistik frm = new Frmİstatistik();
                frm.MdiParent = mdiParent;
                frm.Show();
            }
            else
            {             
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mdiParent = this.MdiParent;

            if (mdiParent != null)
            {
                FrmMarkaİstatistikleri frm = new FrmMarkaİstatistikleri();
                frm.MdiParent = mdiParent;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form mdiParent = this.MdiParent;

            if (mdiParent != null)
            {
                FrmArizalıÜrünListesi frm = new FrmArizalıÜrünListesi();
                frm.MdiParent = mdiParent;
                frm.Show();
            }
            else
            {  
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        { 
            Form mdiParent = this.MdiParent;

            if (mdiParent != null)
            {
                FrmArızalıÜrünDetayları frm = new FrmArızalıÜrünDetayları();
                frm.MdiParent = mdiParent;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmQR1 frm = new FrmQR1();
            frm.StartPosition = FormStartPosition.CenterScreen; // Formun merkezi ekranda açılması için StartPosition özelliğini ayarla
            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form mdiParent = this.MdiParent;

            if (mdiParent != null)
            {
                FrmMüşteriListesi frm = new FrmMüşteriListesi();
                frm.MdiParent = mdiParent;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        { 
            Form mdiParent = this.MdiParent;

            if (mdiParent != null)
            {
                FrmÜrünSatişListesi frm = new FrmÜrünSatişListesi();
                frm.MdiParent = mdiParent;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {  
            Form mdiParent = this.MdiParent;

            if (mdiParent != null)
            {
                FrmFaturaListesi frm = new FrmFaturaListesi();
                frm.MdiParent = mdiParent;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {     
            Form mdiParent = this.MdiParent;

            if (mdiParent != null)
            {            
                FrmFaturaSatışİşlemi frm = new FrmFaturaSatışİşlemi();
                frm.MdiParent = mdiParent;          
                frm.Show();
            }
            else
            {              
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

            FrmBarcode frm = new FrmBarcode();
            frm.StartPosition = FormStartPosition.CenterScreen; // Formun merkezi ekranda açılması için StartPosition özelliğini ayarla
            frm.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {   
            Form mdiParent = this.MdiParent;
         
            if (mdiParent != null)
            {     
                FrmPersonelListesi frm = new FrmPersonelListesi();
                frm.MdiParent = mdiParent;             
                frm.Show();
            }
            else
            {                
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {        
            Form mdiParent = this.MdiParent;
      
            if (mdiParent != null)
            {            
                FrmDeparmanListesi frm = new FrmDeparmanListesi();
                frm.MdiParent = mdiParent;           
                frm.Show();
            }
            else
            {             
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {    
            Form mdiParent = this.MdiParent;
          
            if (mdiParent != null)
            {          
                FrmAjanda frm = new FrmAjanda();
                frm.MdiParent = mdiParent;    
                frm.Show();
            }
            else
            {           
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmYeniMail frm = new FrmYeniMail();
            frm.StartPosition = FormStartPosition.CenterScreen; // Formun merkezi ekranda açılması için StartPosition özelliğini ayarla
            frm.Show();
        }

        private void FrmAnasayfaa_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        where x.STOK < 30 // Yalnızca stok sayısı 30'dan küçük olanları seç
                                        select new
                                        {
                                            x.AD,
                                            x.MARKA,
                                            x.STOK,
                                        }).ToList();

            DateTime bugun = DateTime.Today;
            var deger = (from x in db.TBLNOTLARIM.OrderBy(y => y.ID)
                         where (x.TARIH == bugun)
                         select new
                         {
                             x.BASLIK,
                             x.ICERIK
                         });
            dataGridView4.DataSource = deger.ToList();
        }
    
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Seçili hücrenin satır indeksini al
            int rowIndex = e.RowIndex;

            // Satır indeksi geçerliyse devam et
            if (rowIndex >= 0)
            {
                // STOK değerini al
                int stok = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["STOK"].Value);

                // Stok sayısı 30'dan küçükse
                if (stok <= 30)
                {
                    // İstenmeyen renk biçimini kaldırmak için varsayılan renge dön
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form mdiParent = this.MdiParent;

            if (mdiParent != null)
            {
                FrmRehber frm = new FrmRehber();
                frm.MdiParent = mdiParent;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bu form MDI çerçevesi içinde değil.");
            }
        }
    }
}
