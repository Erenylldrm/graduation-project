﻿
namespace ERPYAZİLİM.Formlar
{
    partial class FrmAjanda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjanda));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TxtID = new System.Windows.Forms.MaskedTextBox();
            this.TxtBaslik = new System.Windows.Forms.MaskedTextBox();
            this.TxtTarih = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtİcerik = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "Okunmayan Notlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(588, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1324, 363);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = "Okunan Notlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(588, 456);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1324, 363);
            this.dataGridView2.TabIndex = 54;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.BtnTemizle);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.BtnListele);
            this.groupBox1.Controls.Add(this.BtnGüncelle);
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.TxtID);
            this.groupBox1.Controls.Add(this.TxtBaslik);
            this.groupBox1.Controls.Add(this.TxtTarih);
            this.groupBox1.Controls.Add(this.pictureBox11);
            this.groupBox1.Controls.Add(this.pictureBox10);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txtİcerik);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 776);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AJANDA İŞLEMLERİ :";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.Image")));
            this.BtnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTemizle.Location = new System.Drawing.Point(183, 507);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(139, 49);
            this.BtnTemizle.TabIndex = 103;
            this.BtnTemizle.Text = "TEMİZLE";
            this.BtnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(188, 413);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(185, 23);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Okundu Olarak İşaretle";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 102;
            this.label3.Text = "DURUM :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(513, -19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 101;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.Image")));
            this.BtnListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListele.Location = new System.Drawing.Point(359, 474);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(116, 53);
            this.BtnListele.TabIndex = 8;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Image = ((System.Drawing.Image)(resources.GetObject("BtnGüncelle.Image")));
            this.BtnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGüncelle.Location = new System.Drawing.Point(359, 546);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(116, 53);
            this.BtnGüncelle.TabIndex = 9;
            this.BtnGüncelle.Text = "GÜNCELLE";
            this.BtnGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.Image")));
            this.BtnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSil.Location = new System.Drawing.Point(48, 546);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(116, 53);
            this.BtnSil.TabIndex = 7;
            this.BtnSil.Text = "SİL";
            this.BtnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.Image")));
            this.BtnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKaydet.Location = new System.Drawing.Point(48, 474);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(116, 53);
            this.BtnKaydet.TabIndex = 6;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(183, 152);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(216, 25);
            this.TxtID.TabIndex = 1;
            // 
            // TxtBaslik
            // 
            this.TxtBaslik.Location = new System.Drawing.Point(183, 220);
            this.TxtBaslik.Name = "TxtBaslik";
            this.TxtBaslik.Size = new System.Drawing.Size(216, 25);
            this.TxtBaslik.TabIndex = 2;
            // 
            // TxtTarih
            // 
            this.TxtTarih.Location = new System.Drawing.Point(183, 359);
            this.TxtTarih.Mask = "00/00/0000";
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Size = new System.Drawing.Size(216, 25);
            this.TxtTarih.TabIndex = 4;
            this.TxtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(117, 335);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(47, 49);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 77;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(117, 266);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(47, 49);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 76;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(117, 196);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(47, 49);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 75;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(117, 128);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(47, 49);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 74;
            this.pictureBox8.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 71;
            this.label5.Text = "TARİH :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 70;
            this.label4.Text = "İÇERİK :";
            // 
            // Txtİcerik
            // 
            this.Txtİcerik.Location = new System.Drawing.Point(183, 290);
            this.Txtİcerik.Name = "Txtİcerik";
            this.Txtİcerik.Size = new System.Drawing.Size(216, 25);
            this.Txtİcerik.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 68;
            this.label6.Text = "BAŞLIK :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 67;
            this.label8.Text = "NOT ID:";
            // 
            // FrmAjanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAjanda";
            this.Text = "FrmAjanda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAjanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.MaskedTextBox TxtID;
        private System.Windows.Forms.MaskedTextBox TxtBaslik;
        private System.Windows.Forms.MaskedTextBox TxtTarih;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Txtİcerik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnTemizle;
    }
}