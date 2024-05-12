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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        select new
                                        {
                                            x.AD,
                                            x.STOK,
                                        }).ToList();



            dataGridView2.DataSource = (from y in db.TBLCARI
                                        select new
                                        {
                                            y.AD,
                                            y.SOYAD,
                                            y.IL
                                        }).ToList();

            dataGridView3.DataSource = db.urunkategori().ToList();
        

            DateTime bugun = DateTime.Today;
            var deger = (from x in db.TBLNOTLARIM.OrderBy(y => y.ID)
                         where (x.TARIH == bugun)
                         select new
                         {
                             x.BASLIK,
                             x.ICERIK
                         }
                );
            dataGridView4.DataSource = deger.ToList();

            var son10Mesaj = db.TBLILETISIM.OrderByDescending(x => x.ID).Take(10).ToList();

            for (int i = 0; i < son10Mesaj.Count; i++)
            {
                var ileti = son10Mesaj[i];
                string konu = ileti.KONU;
                string ad = ileti.ADSOYAD;
                string labelText = konu + " - " + ad;

                switch (i)
                {
                    case 0:
                        label1.Text = labelText;
                        break;
                    case 1:
                        label2.Text = labelText;
                        break;
                    case 2:
                        label3.Text = labelText;
                        break;
                    case 3:
                        label4.Text = labelText;
                        break;
                    case 4:
                        label5.Text = labelText;
                        break;
                    case 5:
                        label6.Text = labelText;
                        break;
                    case 6:
                        label7.Text = labelText;
                        break;
                    case 7:
                        label8.Text = labelText;
                        break;
                    case 8:
                        label9.Text = labelText;
                        break;
                    case 9:
                        label10.Text = labelText;
                        break;


                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["STOK"].Index)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int stok;
                if (cell.Value != null && int.TryParse(cell.Value.ToString(), out stok))
                {
                    // En düşük stok sayısını al
                    int enDusukStok = (from DataGridViewRow row in dataGridView1.Rows
                                       where row.Cells["STOK"].Value != null
                                       select Convert.ToInt32(row.Cells["STOK"].Value)).Min();
                   
                    if (stok == enDusukStok)
                    {
                        cell.Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }
