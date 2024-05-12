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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
     
            label2.Text = db.TBLURUN.Count().ToString();
            label4.Text = db.TBLKATEGORI.Count().ToString();
            label6.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            //label8.Text = "10";
            
            label12.Text = (from x in db.TBLURUN
                                   orderby x.STOK descending
                                   select x.AD).FirstOrDefault();

            label14.Text = (from x in db.TBLURUN
                                   orderby x.STOK ascending
                                   select x.AD).FirstOrDefault();

            label16.Text = db.makskategoriurun().FirstOrDefault();

            label18.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT descending
                                   select x.AD).FirstOrDefault();

            label20.Text = (from x in db.TBLURUN
                            orderby x.SATISFIYAT descending
                            select x.AD).FirstOrDefault(); 
            
            label22.Text = (from x in db.TBLURUN
                                   select x.MARKA).Distinct().Count().ToString(); 
            
            label26.Text = db.TBLURUNKABUL.Count().ToString();
            label36.Text = db.TBLURUN.Count(x => x.KATEGORI == 4).ToString();
            label38.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            label40.Text = db.TBLURUN.Count(x => x.KATEGORI == 3).ToString();

            label24.Text = db.TBLURUN
                .GroupBy(x => x.MARKA)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();

            label8.Text = db.TBLURUN.Count(x => x.STOK < 30).ToString();

            var enDusukFiyatliUrun = db.TBLURUN.OrderBy(x => x.SATISFIYAT).FirstOrDefault();
            if (enDusukFiyatliUrun != null)
                label20.Text = enDusukFiyatliUrun.AD;

         
            label30.Text = db.TBLURUN.Count().ToString();

            DateTime baslangic = DateTime.Today;
            DateTime bitis = baslangic.AddDays(1); // Bugün 00:00:00 ile yarın 00:00:00 arasındaki verileri alır
            label10.Text = db.TBLURUNHAREKET.Count(x => x.TARIH >= baslangic && x.TARIH < bitis).ToString();

            label28.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Parça Bekliyor.").ToString();         
            label32.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Mesaj Bekliyor.").ToString();
            label34.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "İptal Bekliyor.").ToString();

           
        }
    }
}
