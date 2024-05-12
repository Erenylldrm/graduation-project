using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace ERPYAZİLİM.Formlar
{
    public partial class FrmYeniMail : Form
    {
        public FrmYeniMail()
        {
            InitializeComponent();
        }

        private void FrmYeniMail_Load(object sender, EventArgs e)
        {
         
        }
       // MailMessage eposta = new MailMessage();
       /* void MailGonder() //2
        {
            eposta.From = new MailAddress("erpyazilim3@outlook.com");
            eposta.To.Add(TxtAlici.Text.ToString());
            eposta.Subject = TxtKonu.Text.ToString();
            eposta.Body = Txtİcerik.Text.ToString();

            SmtpClient smtp = new SmtpClient();

            smtp.Credentials = new System.Net.NetworkCredential("erpyazilim3@outlook.com", "erpyazilim1234");
            smtp.Host = "smtp.live.com"; // gmail host adresi = "smtp.gmail.com";  "smtp.live.com"
            smtp.EnableSsl = true;
            smtp.Port = 587;

            smtp.Send(eposta);
            MessageBox.Show("Mail Gönderildi");
            
        }*/
        string dosyaYolu;
        private void BtnDosyaEkle_Click(object sender, EventArgs e)
        {
            //#1
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Title = "Merhaba";
            dosya.ShowDialog();
            dosyaYolu = dosya.FileName;
            label2.Text = "Dosya eklendi...";
            label2.Visible = true;
        }

        private void BtnGönder_Click(object sender, EventArgs e)
        {
                //#1
               SmtpClient sc = new SmtpClient();
               sc.Port = 587;
               sc.Host = "smtp.gmail.com";
               sc.EnableSsl = true;


               string Alici = TxtAlici.Text;
               string Konu = TxtKonu.Text;
               string İcerik = Txtİcerik.Text;

               sc.Credentials = new NetworkCredential("erpyazilim3@gmail.com", "vrpfmholjcivdxqt");
               MailMessage mail = new MailMessage();
               mail.From = new MailAddress("erpyazilim3@gmail.com", " ERP YAZİLİM TİCARİ OTOMASYON ");
               mail.To.Add(Alici);
               mail.Subject = Konu;
               mail.IsBodyHtml = true;
               mail.Body = İcerik;
               if(dosyaYolu != null)
               {
                   mail.Attachments.Add(new Attachment(dosyaYolu));

               }
               sc.Send(mail); // Gmail izin vermek gerekiyor
               MessageBox.Show("Mail Gönderildi");


            /* MailMessage mail = new MailMessage();
             string frommail = "erpyazilim3@gmail.com";
             string sifre = "erpyazilim1234";
             string alici = TxtAlici.Text;
             string konu = TxtKonu.Text;
             string icerik = Txtİcerik.Text;

             mail.From = new MailAddress(frommail);
             mail.To.Add(alici);
             mail.Subject = konu;
             mail.Body = icerik;
             mail.IsBodyHtml = true;

             SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
             smtp.Credentials = new NetworkCredential(frommail, sifre);
             smtp.EnableSsl = true;
             smtp.Send(mail);
             MessageBox.Show("Mail Gönderildi");*/

            //MailGonder(); //2

        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
   
    }
}
