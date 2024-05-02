
namespace ERPYAZİLİM.Formlar
{
    partial class FrmQR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQR));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnQR = new System.Windows.Forms.Button();
            this.BtnVazgeç = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnOku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERİ NO İÇİN QR KOD OLUŞTURMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "SERİ NO :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(127, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 1);
            this.panel1.TabIndex = 72;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(127, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // BtnQR
            // 
            this.BtnQR.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.BtnQR.Image = ((System.Drawing.Image)(resources.GetObject("BtnQR.Image")));
            this.BtnQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQR.Location = new System.Drawing.Point(127, 133);
            this.BtnQR.Name = "BtnQR";
            this.BtnQR.Size = new System.Drawing.Size(150, 47);
            this.BtnQR.TabIndex = 74;
            this.BtnQR.Text = "QR OLUŞTUR";
            this.BtnQR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnQR.UseVisualStyleBackColor = true;
            this.BtnQR.Click += new System.EventHandler(this.BtnQR_Click);
            // 
            // BtnVazgeç
            // 
            this.BtnVazgeç.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.BtnVazgeç.Image = ((System.Drawing.Image)(resources.GetObject("BtnVazgeç.Image")));
            this.BtnVazgeç.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVazgeç.Location = new System.Drawing.Point(283, 133);
            this.BtnVazgeç.Name = "BtnVazgeç";
            this.BtnVazgeç.Size = new System.Drawing.Size(127, 47);
            this.BtnVazgeç.TabIndex = 75;
            this.BtnVazgeç.Text = "VAZGEÇ";
            this.BtnVazgeç.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVazgeç.UseVisualStyleBackColor = true;
            this.BtnVazgeç.Click += new System.EventHandler(this.BtnVazgeç_Click_1);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.maskedTextBox1.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox1.Location = new System.Drawing.Point(127, 83);
            this.maskedTextBox1.Mask = "AAAAA";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(283, 22);
            this.maskedTextBox1.TabIndex = 76;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(461, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // BtnOku
            // 
            this.BtnOku.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.BtnOku.Image = ((System.Drawing.Image)(resources.GetObject("BtnOku.Image")));
            this.BtnOku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOku.Location = new System.Drawing.Point(22, 151);
            this.BtnOku.Name = "BtnOku";
            this.BtnOku.Size = new System.Drawing.Size(93, 47);
            this.BtnOku.TabIndex = 78;
            this.BtnOku.Text = "OKU";
            this.BtnOku.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOku.UseVisualStyleBackColor = true;
            this.BtnOku.Click += new System.EventHandler(this.BtnOku_Click_1);
            // 
            // FrmQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(500, 371);
            this.Controls.Add(this.BtnOku);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.BtnVazgeç);
            this.Controls.Add(this.BtnQR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR CODE";
            this.Load += new System.EventHandler(this.FrmQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnQR;
        private System.Windows.Forms.Button BtnVazgeç;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnOku;
    }
}