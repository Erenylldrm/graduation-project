using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;



namespace ERPYAZİLİM.Formlar
{
    public partial class FaturaBilgi : Form
    {
        public FaturaBilgi()
        {
            InitializeComponent();
        }
        
        Db_TıcarıOtomasyonEntities1 db = new Db_TıcarıOtomasyonEntities1();

        public int id;

        private void FaturaBilgi_Load(object sender, EventArgs e)
        {

           /*dataGridView1.DataSource = db.TBLFATURADETAY.Where(x => x.FATURAID == id).ToList();*/
            dataGridView1.DataSource = db.TBLFATURADETAY
                                   .Where(x => x.FATURAID == id)
                                   .Select(x => new
                                   {
                                       x.FATURADETAYID,
                                       x.URUN,
                                       x.ADET,
                                       x.FIYAT,
                                       x.TUTAR,
                                       x.FATURAID
                                   })
                                   .ToList();

            /*dataGridView2.DataSource = db.TBLFATURABILGI.Where(x => x.ID == id).ToList();*/
            dataGridView2.DataSource = db.TBLFATURABILGI
                                .Where(x => x.ID == id)
                                .Select(x => new
                                {
                                    x.ID,
                                    x.SERI,
                                    x.SIRANO,
                                    x.TARIH,
                                    x.SAAT,
                                    x.VERGIDAIRE,
                                    x.CARI,
                                    x.PERSONEL
                                })
                                .ToList();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            saveDialog1.Filter = "PDF dosyaları (*.pdf)|*.pdf";
            saveDialog1.FileName = "FaturaBilgileri_DataGridView1.pdf";

            if (saveDialog1.ShowDialog() == DialogResult.OK)
            {
                Document doc1 = new Document();
                PdfWriter.GetInstance(doc1, new FileStream(saveDialog1.FileName, FileMode.Create));
                doc1.Open();

                PdfPTable table1 = new PdfPTable(dataGridView1.Columns.Count);

                // Sütun başlıklarını ekleyelim
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    table1.AddCell(new Phrase(dataGridView1.Columns[i].HeaderText));
                }

                // Satırları ekleyelim
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            table1.AddCell(new Phrase(dataGridView1.Rows[i].Cells[j].Value.ToString()));
                        }
                    }
                }

                doc1.Add(table1);
                MessageBox.Show("DataGrid1 PDF dosyası başarıyla oluşturuldu.");
                doc1.Close();
            }

            SaveFileDialog saveDialog2 = new SaveFileDialog();
            saveDialog2.Filter = "PDF dosyaları (*.pdf)|*.pdf";
            saveDialog2.FileName = "FaturaBilgileri_DataGridView2.pdf";

            if (saveDialog2.ShowDialog() == DialogResult.OK)
            {
                Document doc2 = new Document();
                PdfWriter.GetInstance(doc2, new FileStream(saveDialog2.FileName, FileMode.Create));
                doc2.Open();

                PdfPTable table2 = new PdfPTable(dataGridView2.Columns.Count);

                // Sütun başlıklarını ekleyelim
                for (int i = 0; i < dataGridView2.Columns.Count; i++)
                {
                    table2.AddCell(new Phrase(dataGridView2.Columns[i].HeaderText));
                }

                // Satırları ekleyelim
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            table2.AddCell(new Phrase(dataGridView2.Rows[i].Cells[j].Value.ToString()));
                        }
                    }
                }

                doc2.Add(table2);
                MessageBox.Show("DataGrid2 PDF dosyası başarıyla oluşturuldu.");
                doc2.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            saveDialog1.Filter = "Excel dosyaları (*.xls)|*.xls";
            saveDialog1.FileName = "FaturaBilgileri_DataGridView1.xls";

            if (saveDialog1.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application excelApp1 = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook1 = excelApp1.Workbooks.Add(Type.Missing);
                Worksheet worksheet1 = null;

                try
                {
                    worksheet1 = workbook1.ActiveSheet;

                    // Sütun başlıklarını ekleyelim
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        worksheet1.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                    }

                    // Verileri ekleyelim
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            worksheet1.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    workbook1.SaveAs(saveDialog1.FileName);
                    MessageBox.Show("DataGrid1 Excel dosyası başarıyla oluşturuldu.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DataGrid1 Excel dosyası oluşturulurken bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    excelApp1.Quit();
                    workbook1 = null;
                    excelApp1 = null;
                }
            }

            SaveFileDialog saveDialog2 = new SaveFileDialog();
            saveDialog2.Filter = "Excel dosyaları (*.xls)|*.xls";
            saveDialog2.FileName = "FaturaBilgileri_DataGridView2.xls";

            if (saveDialog2.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application excelApp2 = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook2 = excelApp2.Workbooks.Add(Type.Missing);
                Worksheet worksheet2 = null;

                try
                {
                    worksheet2 = workbook2.ActiveSheet;

                    // Sütun başlıklarını ekleyelim
                    for (int i = 0; i < dataGridView2.Columns.Count; i++)
                    {
                        worksheet2.Cells[1, i + 1] = dataGridView2.Columns[i].HeaderText;
                    }

                    // Verileri ekleyelim
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView2.Columns.Count; j++)
                        {
                            worksheet2.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    workbook2.SaveAs(saveDialog2.FileName);
                    MessageBox.Show("DataGrid2 Excel dosyası başarıyla oluşturuldu.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DataGrid2 Excel dosyası oluşturulurken bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    excelApp2.Quit();
                    workbook2 = null;
                    excelApp2 = null;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
