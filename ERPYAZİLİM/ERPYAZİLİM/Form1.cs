using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ERPYAZİLİM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "";

        }
             
        private void TumFormlariKapat()
        {
            List<Form> kopyaFormlar = new List<Form>(Application.OpenForms.Cast<Form>());

            foreach (Form acikForm in kopyaFormlar)
            {
                if (acikForm.GetType() != typeof(Form1) && acikForm.GetType() != typeof(FrmLogin1)) // Login formunu ve Form1'i kapatma
                {
                    acikForm.Close();
                }
            }
        }

        private void FormAc(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        public string kullanıcıyetki;
        private void Form1_Load(object sender, EventArgs e)
        {
          

            // Kullanıcı yetki kategorisi 1 ise belirli ribbontabları gizle
            if (kullanıcıyetki == "1")
            {
                ribbonTab3.Visible = false;
                ribbonTab4.Visible = false;
                ribbonTab5.Visible = false;
                ribbonTab7.Visible = false;
                
                
            }

            // Kullanıcı yetki kategorisi 1 ise belirli ribbontabları gizle
            if (kullanıcıyetki == "2")
            {
                ribbonTab2.Visible = false;
                ribbonTab4.Visible = false;
                ribbonTab5.Visible = false;
                ribbonTab7.Visible = false;
            }

            if (kullanıcıyetki == "3")
            {
                ribbonTab2.Visible = false;
                ribbonTab3.Visible = false;
                ribbonTab5.Visible = false;
                ribbonTab7.Visible = false;
            }

            if (kullanıcıyetki == "4")
            {
                ribbonTab2.Visible = false;
                ribbonTab3.Visible = false;
                ribbonTab4.Visible = false;
                ribbonTab7.Visible = false;
            }

            //TumFormlariKapat();
            FormAc(new Formlar.FrmAnasayfaa());

        }

        private void BtnAnaForm_ItemClick(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmAnasayfaa());
            
       
        }

      
        private void FrmArızalıÜrünListe_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmArizalıÜrünListesi());
            
        
        }

        private void FrmAnaSayfa_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmAnasayfaa());
         
        }

     
        private void BtnArizaliÜrünDetaylari_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmArızalıÜrünDetayları());
           
        }
     
        private void BtnMüşteriListesi_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmMüşteriListesi());
          
        }
      
        private void BtnFaturaListesi_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmFaturaListesi());
         
        }
      
        private void BtnPersonelListesi_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmPersonelListesi());
           
        }
     
        private void BtnDepartmanListesi_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmDeparmanListesi());
         
        }
    
        private void BtnÜrünİstatistikleri_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.Frmİstatistik());
        
        }
   
        private void BtnKategoriListesi_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmKategoriListesi());
        
        }
  
        private void BtnÜrünListesi_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmÜrünListesi());
      
        }
    
        private void BtnMarkaİstatistikleri_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmMarkaİstatistikleri());
      
        }
    
        private void BtnSatışListesi_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmÜrünSatişListesi());
        
        }
    
        private void BtnFaturaSatışİşlemi_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmFaturaSatışİşlemi());
          
        }

 
        private void BtnQRCode_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmQR1());
          
        }

        private void BtnRehber_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmRehber());
         
        }

 
        private void BtnGelenMesajlar_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmGelenMesajlar());
           
        }

   
        private void BtnYeniMail_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmYeniMail());
          
        }

        private void ribbon1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAjanda_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmAjanda());
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            TumFormlariKapat();
            FormAc(new Formlar.FrmBarcode());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
