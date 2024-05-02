
namespace ERPYAZİLİM
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.FrmAnaSayfa = new System.Windows.Forms.RibbonButton();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.BtnKategoriListesi = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.BtnÜrünListesi = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.BtnÜrünİstatistikleri = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.BtnMarkaİstatistikleri = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.FrmArızalıÜrünListe = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel7 = new System.Windows.Forms.RibbonPanel();
            this.BtnArizaliÜrünDetaylari = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel8 = new System.Windows.Forms.RibbonPanel();
            this.BtnQRCode = new System.Windows.Forms.RibbonButton();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel9 = new System.Windows.Forms.RibbonPanel();
            this.BtnMüşteriListesi = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel10 = new System.Windows.Forms.RibbonPanel();
            this.BtnSatışListesi = new System.Windows.Forms.RibbonButton();
            this.ribbonTab4 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel12 = new System.Windows.Forms.RibbonPanel();
            this.BtnFaturaListesi = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel13 = new System.Windows.Forms.RibbonPanel();
            this.BtnFaturaSatışİşlemi = new System.Windows.Forms.RibbonButton();
            this.ribbonTab5 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel15 = new System.Windows.Forms.RibbonPanel();
            this.BtnPersonelListesi = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel16 = new System.Windows.Forms.RibbonPanel();
            this.BtnDepartmanListesi = new System.Windows.Forms.RibbonButton();
            this.ribbonTab7 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel23 = new System.Windows.Forms.RibbonPanel();
            this.BtnRehber = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel24 = new System.Windows.Forms.RibbonPanel();
            this.BtnGelenMesajlar = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel25 = new System.Windows.Forms.RibbonPanel();
            this.BtnYeniMail = new System.Windows.Forms.RibbonButton();
            this.ribbonTab6 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel11 = new System.Windows.Forms.RibbonPanel();
            this.BtnAjanda = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel14 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            // 
            // 
            // 
            this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButton1);
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1924, 176);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.Tabs.Add(this.ribbonTab3);
            this.ribbon1.Tabs.Add(this.ribbonTab4);
            this.ribbon1.Tabs.Add(this.ribbonTab5);
            this.ribbon1.Tabs.Add(this.ribbonTab7);
            this.ribbon1.Tabs.Add(this.ribbonTab6);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.Click += new System.EventHandler(this.ribbon1_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Text = "ANA SAYFA";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.FrmAnaSayfa);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "--------------------";
            // 
            // FrmAnaSayfa
            // 
            this.FrmAnaSayfa.Image = ((System.Drawing.Image)(resources.GetObject("FrmAnaSayfa.Image")));
            this.FrmAnaSayfa.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmAnaSayfa.LargeImage")));
            this.FrmAnaSayfa.Name = "FrmAnaSayfa";
            this.FrmAnaSayfa.SmallImage = ((System.Drawing.Image)(resources.GetObject("FrmAnaSayfa.SmallImage")));
            this.FrmAnaSayfa.Text = "Ana Sayfa";
            this.FrmAnaSayfa.Click += new System.EventHandler(this.FrmAnaSayfa_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Panels.Add(this.ribbonPanel2);
            this.ribbonTab2.Panels.Add(this.ribbonPanel3);
            this.ribbonTab2.Panels.Add(this.ribbonPanel4);
            this.ribbonTab2.Panels.Add(this.ribbonPanel5);
            this.ribbonTab2.Panels.Add(this.ribbonPanel6);
            this.ribbonTab2.Panels.Add(this.ribbonPanel7);
            this.ribbonTab2.Panels.Add(this.ribbonPanel8);
            this.ribbonTab2.Text = "ÜRÜNLER";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.BtnKategoriListesi);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "--------------------";
            // 
            // BtnKategoriListesi
            // 
            this.BtnKategoriListesi.Image = ((System.Drawing.Image)(resources.GetObject("BtnKategoriListesi.Image")));
            this.BtnKategoriListesi.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnKategoriListesi.LargeImage")));
            this.BtnKategoriListesi.Name = "BtnKategoriListesi";
            this.BtnKategoriListesi.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnKategoriListesi.SmallImage")));
            this.BtnKategoriListesi.Text = "Kategori Listesi";
            this.BtnKategoriListesi.Click += new System.EventHandler(this.BtnKategoriListesi_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.BtnÜrünListesi);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "      --------------------                      ";
            // 
            // BtnÜrünListesi
            // 
            this.BtnÜrünListesi.Image = ((System.Drawing.Image)(resources.GetObject("BtnÜrünListesi.Image")));
            this.BtnÜrünListesi.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnÜrünListesi.LargeImage")));
            this.BtnÜrünListesi.Name = "BtnÜrünListesi";
            this.BtnÜrünListesi.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnÜrünListesi.SmallImage")));
            this.BtnÜrünListesi.Text = "Ürün Listesi";
            this.BtnÜrünListesi.Click += new System.EventHandler(this.BtnÜrünListesi_Click);
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.BtnÜrünİstatistikleri);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Text = "--------------------";
            // 
            // BtnÜrünİstatistikleri
            // 
            this.BtnÜrünİstatistikleri.Image = ((System.Drawing.Image)(resources.GetObject("BtnÜrünİstatistikleri.Image")));
            this.BtnÜrünİstatistikleri.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnÜrünİstatistikleri.LargeImage")));
            this.BtnÜrünİstatistikleri.Name = "BtnÜrünİstatistikleri";
            this.BtnÜrünİstatistikleri.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnÜrünİstatistikleri.SmallImage")));
            this.BtnÜrünİstatistikleri.Text = "Ürün İstatistikleri";
            this.BtnÜrünİstatistikleri.Click += new System.EventHandler(this.BtnÜrünİstatistikleri_Click);
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.BtnMarkaİstatistikleri);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Text = "--------------------";
            // 
            // BtnMarkaİstatistikleri
            // 
            this.BtnMarkaİstatistikleri.Image = ((System.Drawing.Image)(resources.GetObject("BtnMarkaİstatistikleri.Image")));
            this.BtnMarkaİstatistikleri.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnMarkaİstatistikleri.LargeImage")));
            this.BtnMarkaİstatistikleri.Name = "BtnMarkaİstatistikleri";
            this.BtnMarkaİstatistikleri.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnMarkaİstatistikleri.SmallImage")));
            this.BtnMarkaİstatistikleri.Text = "Marka İstatistikleri";
            this.BtnMarkaİstatistikleri.Click += new System.EventHandler(this.BtnMarkaİstatistikleri_Click);
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Items.Add(this.FrmArızalıÜrünListe);
            this.ribbonPanel6.Name = "ribbonPanel6";
            this.ribbonPanel6.Text = "--------------------";
            // 
            // FrmArızalıÜrünListe
            // 
            this.FrmArızalıÜrünListe.Image = ((System.Drawing.Image)(resources.GetObject("FrmArızalıÜrünListe.Image")));
            this.FrmArızalıÜrünListe.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmArızalıÜrünListe.LargeImage")));
            this.FrmArızalıÜrünListe.Name = "FrmArızalıÜrünListe";
            this.FrmArızalıÜrünListe.SmallImage = ((System.Drawing.Image)(resources.GetObject("FrmArızalıÜrünListe.SmallImage")));
            this.FrmArızalıÜrünListe.Text = "Arızalı Ürün Listesi";
            this.FrmArızalıÜrünListe.Click += new System.EventHandler(this.FrmArızalıÜrünListe_Click);
            // 
            // ribbonPanel7
            // 
            this.ribbonPanel7.Items.Add(this.BtnArizaliÜrünDetaylari);
            this.ribbonPanel7.Name = "ribbonPanel7";
            this.ribbonPanel7.Text = "--------------------";
            // 
            // BtnArizaliÜrünDetaylari
            // 
            this.BtnArizaliÜrünDetaylari.Image = ((System.Drawing.Image)(resources.GetObject("BtnArizaliÜrünDetaylari.Image")));
            this.BtnArizaliÜrünDetaylari.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnArizaliÜrünDetaylari.LargeImage")));
            this.BtnArizaliÜrünDetaylari.Name = "BtnArizaliÜrünDetaylari";
            this.BtnArizaliÜrünDetaylari.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnArizaliÜrünDetaylari.SmallImage")));
            this.BtnArizaliÜrünDetaylari.Text = "Arızalı Ürün Detayları";
            this.BtnArizaliÜrünDetaylari.Click += new System.EventHandler(this.BtnArizaliÜrünDetaylari_Click);
            // 
            // ribbonPanel8
            // 
            this.ribbonPanel8.Items.Add(this.BtnQRCode);
            this.ribbonPanel8.Name = "ribbonPanel8";
            this.ribbonPanel8.Text = "--------------------";
            // 
            // BtnQRCode
            // 
            this.BtnQRCode.Image = ((System.Drawing.Image)(resources.GetObject("BtnQRCode.Image")));
            this.BtnQRCode.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnQRCode.LargeImage")));
            this.BtnQRCode.Name = "BtnQRCode";
            this.BtnQRCode.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnQRCode.SmallImage")));
            this.BtnQRCode.Text = "QR Code";
            this.BtnQRCode.Click += new System.EventHandler(this.BtnQRCode_Click);
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Panels.Add(this.ribbonPanel9);
            this.ribbonTab3.Panels.Add(this.ribbonPanel10);
            this.ribbonTab3.Text = "MÜŞTERİLER";
            // 
            // ribbonPanel9
            // 
            this.ribbonPanel9.Items.Add(this.BtnMüşteriListesi);
            this.ribbonPanel9.Name = "ribbonPanel9";
            this.ribbonPanel9.Text = "--------------------";
            // 
            // BtnMüşteriListesi
            // 
            this.BtnMüşteriListesi.Image = ((System.Drawing.Image)(resources.GetObject("BtnMüşteriListesi.Image")));
            this.BtnMüşteriListesi.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnMüşteriListesi.LargeImage")));
            this.BtnMüşteriListesi.Name = "BtnMüşteriListesi";
            this.BtnMüşteriListesi.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnMüşteriListesi.SmallImage")));
            this.BtnMüşteriListesi.Text = "Müşteri Listesi";
            this.BtnMüşteriListesi.Click += new System.EventHandler(this.BtnMüşteriListesi_Click);
            // 
            // ribbonPanel10
            // 
            this.ribbonPanel10.Items.Add(this.BtnSatışListesi);
            this.ribbonPanel10.Name = "ribbonPanel10";
            this.ribbonPanel10.Text = "--------------------";
            // 
            // BtnSatışListesi
            // 
            this.BtnSatışListesi.Image = ((System.Drawing.Image)(resources.GetObject("BtnSatışListesi.Image")));
            this.BtnSatışListesi.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnSatışListesi.LargeImage")));
            this.BtnSatışListesi.Name = "BtnSatışListesi";
            this.BtnSatışListesi.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnSatışListesi.SmallImage")));
            this.BtnSatışListesi.Text = "Satış Listesi";
            this.BtnSatışListesi.Click += new System.EventHandler(this.BtnSatışListesi_Click);
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Panels.Add(this.ribbonPanel12);
            this.ribbonTab4.Panels.Add(this.ribbonPanel13);
            this.ribbonTab4.Panels.Add(this.ribbonPanel14);
            this.ribbonTab4.Text = "FATURALAR";
            // 
            // ribbonPanel12
            // 
            this.ribbonPanel12.Items.Add(this.BtnFaturaListesi);
            this.ribbonPanel12.Name = "ribbonPanel12";
            this.ribbonPanel12.Text = "--------------------";
            // 
            // BtnFaturaListesi
            // 
            this.BtnFaturaListesi.Image = ((System.Drawing.Image)(resources.GetObject("BtnFaturaListesi.Image")));
            this.BtnFaturaListesi.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnFaturaListesi.LargeImage")));
            this.BtnFaturaListesi.Name = "BtnFaturaListesi";
            this.BtnFaturaListesi.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnFaturaListesi.SmallImage")));
            this.BtnFaturaListesi.Text = "Fatura Listesi";
            this.BtnFaturaListesi.Click += new System.EventHandler(this.BtnFaturaListesi_Click);
            // 
            // ribbonPanel13
            // 
            this.ribbonPanel13.Items.Add(this.BtnFaturaSatışİşlemi);
            this.ribbonPanel13.Name = "ribbonPanel13";
            this.ribbonPanel13.Text = "--------------------";
            // 
            // BtnFaturaSatışİşlemi
            // 
            this.BtnFaturaSatışİşlemi.Image = ((System.Drawing.Image)(resources.GetObject("BtnFaturaSatışİşlemi.Image")));
            this.BtnFaturaSatışİşlemi.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnFaturaSatışİşlemi.LargeImage")));
            this.BtnFaturaSatışİşlemi.Name = "BtnFaturaSatışİşlemi";
            this.BtnFaturaSatışİşlemi.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnFaturaSatışİşlemi.SmallImage")));
            this.BtnFaturaSatışİşlemi.Tag = "";
            this.BtnFaturaSatışİşlemi.Text = "Fatura Satış İşlemi";
            this.BtnFaturaSatışİşlemi.Click += new System.EventHandler(this.BtnFaturaSatışİşlemi_Click);
            // 
            // ribbonTab5
            // 
            this.ribbonTab5.Name = "ribbonTab5";
            this.ribbonTab5.Panels.Add(this.ribbonPanel15);
            this.ribbonTab5.Panels.Add(this.ribbonPanel16);
            this.ribbonTab5.Text = "PERSONELLER";
            // 
            // ribbonPanel15
            // 
            this.ribbonPanel15.Items.Add(this.BtnPersonelListesi);
            this.ribbonPanel15.Name = "ribbonPanel15";
            this.ribbonPanel15.Text = "--------------------";
            // 
            // BtnPersonelListesi
            // 
            this.BtnPersonelListesi.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonelListesi.Image")));
            this.BtnPersonelListesi.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPersonelListesi.LargeImage")));
            this.BtnPersonelListesi.Name = "BtnPersonelListesi";
            this.BtnPersonelListesi.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnPersonelListesi.SmallImage")));
            this.BtnPersonelListesi.Text = "Personel Listesi";
            this.BtnPersonelListesi.Click += new System.EventHandler(this.BtnPersonelListesi_Click);
            // 
            // ribbonPanel16
            // 
            this.ribbonPanel16.Items.Add(this.BtnDepartmanListesi);
            this.ribbonPanel16.Name = "ribbonPanel16";
            this.ribbonPanel16.Text = "--------------------";
            // 
            // BtnDepartmanListesi
            // 
            this.BtnDepartmanListesi.Image = ((System.Drawing.Image)(resources.GetObject("BtnDepartmanListesi.Image")));
            this.BtnDepartmanListesi.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnDepartmanListesi.LargeImage")));
            this.BtnDepartmanListesi.Name = "BtnDepartmanListesi";
            this.BtnDepartmanListesi.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnDepartmanListesi.SmallImage")));
            this.BtnDepartmanListesi.Text = "Departman Listesi";
            this.BtnDepartmanListesi.Click += new System.EventHandler(this.BtnDepartmanListesi_Click);
            // 
            // ribbonTab7
            // 
            this.ribbonTab7.Name = "ribbonTab7";
            this.ribbonTab7.Panels.Add(this.ribbonPanel23);
            this.ribbonTab7.Panels.Add(this.ribbonPanel24);
            this.ribbonTab7.Panels.Add(this.ribbonPanel25);
            this.ribbonTab7.Text = "İLETİŞİM";
            // 
            // ribbonPanel23
            // 
            this.ribbonPanel23.Items.Add(this.BtnRehber);
            this.ribbonPanel23.Name = "ribbonPanel23";
            this.ribbonPanel23.Text = "--------------------";
            // 
            // BtnRehber
            // 
            this.BtnRehber.Image = ((System.Drawing.Image)(resources.GetObject("BtnRehber.Image")));
            this.BtnRehber.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnRehber.LargeImage")));
            this.BtnRehber.Name = "BtnRehber";
            this.BtnRehber.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnRehber.SmallImage")));
            this.BtnRehber.Text = "Rehber";
            this.BtnRehber.Click += new System.EventHandler(this.BtnRehber_Click);
            // 
            // ribbonPanel24
            // 
            this.ribbonPanel24.Items.Add(this.BtnGelenMesajlar);
            this.ribbonPanel24.Name = "ribbonPanel24";
            this.ribbonPanel24.Text = "--------------------";
            // 
            // BtnGelenMesajlar
            // 
            this.BtnGelenMesajlar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGelenMesajlar.Image")));
            this.BtnGelenMesajlar.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnGelenMesajlar.LargeImage")));
            this.BtnGelenMesajlar.Name = "BtnGelenMesajlar";
            this.BtnGelenMesajlar.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnGelenMesajlar.SmallImage")));
            this.BtnGelenMesajlar.Text = "Gelen Mesajlar";
            this.BtnGelenMesajlar.Click += new System.EventHandler(this.BtnGelenMesajlar_Click);
            // 
            // ribbonPanel25
            // 
            this.ribbonPanel25.Items.Add(this.BtnYeniMail);
            this.ribbonPanel25.Name = "ribbonPanel25";
            this.ribbonPanel25.Text = "--------------------";
            // 
            // BtnYeniMail
            // 
            this.BtnYeniMail.Image = ((System.Drawing.Image)(resources.GetObject("BtnYeniMail.Image")));
            this.BtnYeniMail.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnYeniMail.LargeImage")));
            this.BtnYeniMail.Name = "BtnYeniMail";
            this.BtnYeniMail.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnYeniMail.SmallImage")));
            this.BtnYeniMail.Text = "Yeni Mail";
            this.BtnYeniMail.Click += new System.EventHandler(this.BtnYeniMail_Click);
            // 
            // ribbonTab6
            // 
            this.ribbonTab6.Name = "ribbonTab6";
            this.ribbonTab6.Panels.Add(this.ribbonPanel11);
            this.ribbonTab6.Text = "AJANDA";
            // 
            // ribbonPanel11
            // 
            this.ribbonPanel11.Items.Add(this.BtnAjanda);
            this.ribbonPanel11.Name = "ribbonPanel11";
            this.ribbonPanel11.Text = "--------------------";
            // 
            // BtnAjanda
            // 
            this.BtnAjanda.Image = ((System.Drawing.Image)(resources.GetObject("BtnAjanda.Image")));
            this.BtnAjanda.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAjanda.LargeImage")));
            this.BtnAjanda.Name = "BtnAjanda";
            this.BtnAjanda.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnAjanda.SmallImage")));
            this.BtnAjanda.Text = "AJANDA";
            this.BtnAjanda.Click += new System.EventHandler(this.BtnAjanda_Click);
            // 
            // ribbonPanel14
            // 
            this.ribbonPanel14.Items.Add(this.ribbonButton2);
            this.ribbonPanel14.Name = "ribbonPanel14";
            this.ribbonPanel14.Text = "--------------------";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.Text = "Barcode";
            this.ribbonButton2.Click += new System.EventHandler(this.ribbonButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.ribbon1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private System.Windows.Forms.RibbonPanel ribbonPanel7;
        private System.Windows.Forms.RibbonPanel ribbonPanel8;
        private System.Windows.Forms.RibbonTab ribbonTab3;
        private System.Windows.Forms.RibbonPanel ribbonPanel9;
        private System.Windows.Forms.RibbonPanel ribbonPanel10;
        private System.Windows.Forms.RibbonTab ribbonTab4;
        private System.Windows.Forms.RibbonPanel ribbonPanel12;
        private System.Windows.Forms.RibbonPanel ribbonPanel13;
        private System.Windows.Forms.RibbonTab ribbonTab5;
        private System.Windows.Forms.RibbonPanel ribbonPanel15;
        private System.Windows.Forms.RibbonPanel ribbonPanel16;
        //private System.Windows.Forms.RibbonTab ribbonTab6;
        //private System.Windows.Forms.RibbonPanel ribbonPanel17;
        //private System.Windows.Forms.RibbonPanel ribbonPanel18;
        //private System.Windows.Forms.RibbonPanel ribbonPanel19;
        //private System.Windows.Forms.RibbonPanel ribbonPanel20;
        //private System.Windows.Forms.RibbonPanel ribbonPanel21;
        //private System.Windows.Forms.RibbonPanel ribbonPanel22;
        private System.Windows.Forms.RibbonTab ribbonTab7;
        private System.Windows.Forms.RibbonPanel ribbonPanel23;
        private System.Windows.Forms.RibbonPanel ribbonPanel24;
        private System.Windows.Forms.RibbonPanel ribbonPanel25;
        private System.Windows.Forms.RibbonButton FrmAnaSayfa;
        private System.Windows.Forms.RibbonButton BtnKategoriListesi;
        private System.Windows.Forms.RibbonButton BtnÜrünListesi;
        private System.Windows.Forms.RibbonButton BtnÜrünİstatistikleri;
        private System.Windows.Forms.RibbonButton BtnMarkaİstatistikleri;
        private System.Windows.Forms.RibbonButton FrmArızalıÜrünListe;
        private System.Windows.Forms.RibbonButton BtnArizaliÜrünDetaylari;
        private System.Windows.Forms.RibbonButton BtnQRCode;
        private System.Windows.Forms.RibbonButton BtnMüşteriListesi;
        private System.Windows.Forms.RibbonButton BtnSatışListesi;
        private System.Windows.Forms.RibbonButton BtnPersonelListesi;
        private System.Windows.Forms.RibbonButton BtnDepartmanListesi;
        private System.Windows.Forms.RibbonButton BtnRehber;
        private System.Windows.Forms.RibbonButton BtnGelenMesajlar;
        private System.Windows.Forms.RibbonButton BtnYeniMail;
        private System.Windows.Forms.RibbonButton BtnFaturaListesi;
        private System.Windows.Forms.RibbonButton BtnFaturaSatışİşlemi;
        private System.Windows.Forms.RibbonTab ribbonTab6;
        private System.Windows.Forms.RibbonPanel ribbonPanel11;
        private System.Windows.Forms.RibbonButton BtnAjanda;
        private System.Windows.Forms.RibbonPanel ribbonPanel14;
        private System.Windows.Forms.RibbonButton ribbonButton2;
    }
}

