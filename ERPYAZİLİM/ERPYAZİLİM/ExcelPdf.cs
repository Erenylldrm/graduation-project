using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ERPYAZİLİM
{
    class ExcelPdf
    {
        public static void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = null;
            
            try
            {
                worksheet = workbook.ActiveSheet;

                // DataGridView verilerini Excel'e aktar
                for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                workbook.SaveAs(filePath);
                MessageBox.Show("Excel dosyası başarıyla oluşturuldu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel dosyası oluşturulurken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                excelApp.Quit();
                workbook = null;
                excelApp = null;
            }
        }

        public static void ExportToPDF(DataGridView dataGridView, string filePath)
        {
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            // Header
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }

            // Data rows
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            // Dosyaya yazma
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
            MessageBox.Show("PDF dosyası başarıyla oluşturuldu!");
        }
    }
    }

