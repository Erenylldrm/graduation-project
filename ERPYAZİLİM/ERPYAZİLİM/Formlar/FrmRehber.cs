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
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        private void FrmRehber_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLCARI
                                       select new
                                       {
                                           x.AD,
                                           x.SOYAD,
                                           x.IL,
                                           x.ILCE,
                                           x.TELEFON,
                                           x.MAIL
                                       }).ToList();
        }
    }
}
