using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERPYAZİLİM.Formlar
{
    public partial class FrmMarkaİstatistikleri : Form
    {
        public FrmMarkaİstatistikleri()
        {
            InitializeComponent();
        }
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();
        private void FrmMarkaİstatistikleri_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLURUN.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });

            dataGridView1.DataSource = degerler.ToList();
            label2.Text = db.TBLURUN.Count().ToString();
            label4.Text = db.maksurunmarka().FirstOrDefault();
            label6.Text = (from x in db.TBLURUN
                                  select x.MARKA).Distinct().Count().ToString();
            label8.Text = (from x in db.TBLURUN
                                  orderby x.SATISFIYAT descending
                                  select x.MARKA).FirstOrDefault();

            chart1.Series.Clear(); 
            chart1.Series.Add("Series 1");
            chart1.Series["Series 1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            SqlConnection baglanti = new SqlConnection(@"Data Source=Acer\SQLEXPRESS;Initial Catalog=Db TıcarıOtomasyon;Integrated Security=True");
            SqlCommand komut;
            SqlDataReader dr;

            baglanti.Open();
            komut = new SqlCommand("SELECT MARKA,COUNT(*) FROM TBLURUN GROUP BY MARKA", baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Series 1"].Points.AddXY(dr.GetString(0), dr.GetInt32(1));
            }
            baglanti.Close();

            // Dilimlerin yüzdelik değerlerini hesaplama
            double toplamUrunSayisi = chart1.Series["Series 1"].Points.Sum(p => p.YValues[0]); // Toplam ürün sayısı
            foreach (var point in chart1.Series["Series 1"].Points)
            {
                double yuzde = (point.YValues[0] / toplamUrunSayisi) * 100; // Yüzdelik değer hesapla
                point.Label = $"{point.AxisLabel} - {yuzde:F2}%"; // Dilim etiketi olarak kategori adını ve yüzdeyi göster
            }

            // chart2 normal grafik
            chart2.Series.Clear(); 
            chart2.Series.Add("Kategoriler");

            baglanti.Open();
            komut = new SqlCommand("SELECT TBLKATEGORI.AD,COUNT(*) FROM TBLURUN INNER JOIN TBLKATEGORI ON TBLKATEGORI.ID=TBLURUN.KATEGORI GROUP BY TBLKATEGORI.AD ", baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chart2.Series["Kategoriler"].Points.AddXY(dr.GetString(0), dr.GetInt32(1));
            }
            baglanti.Close();


        }
    }
}
