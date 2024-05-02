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
    public partial class FrmGelenMesajlar : Form
    {
        public FrmGelenMesajlar()
        {
            InitializeComponent();
        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        private void FrmGelenMesajlar_Load(object sender, EventArgs e)
        {
            label2.Text = db.TBLILETISIM.Count().ToString();
            label4.Text = db.TBLILETISIM.Where(x => x.KONU == "Teşekkür").Count().ToString();
            label6.Text = db.TBLILETISIM.Where(x => x.KONU == "Rica").Count().ToString();
            label8.Text = db.TBLILETISIM.Where(x => x.KONU == "Şikayet").Count().ToString();
            label10.Text = db.TBLPERSONEL.Count().ToString();
            label12.Text = db.TBLCARI.Count().ToString();
            label14.Text = db.TBLKATEGORI.Count().ToString();
            label16.Text = db.TBLURUN.Count().ToString();

            dataGridView1.DataSource = (from x in db.TBLILETISIM
                                       select new
                                       {
                                           x.ID,
                                           x.ADSOYAD,
                                           x.KONU,
                                           x.MAIL,
                                           x.MESAJ
                                       }).ToList();
        }
    }
}
