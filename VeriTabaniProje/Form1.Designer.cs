namespace VeriTabaniProje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpRezervasyonEkrani = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnOnay = new System.Windows.Forms.Button();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpRezervasyonTarihi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRezervasyonTc = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.txtKrediKarti = new System.Windows.Forms.TextBox();
            this.dtpSonKullanmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpStandartRezervasyon = new System.Windows.Forms.GroupBox();
            this.grpRandevuIptal = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRandevuIptal = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.dgvIptal = new System.Windows.Forms.DataGridView();
            this.txtIptalTC = new System.Windows.Forms.TextBox();
            this.grpRezervasyonEkrani.SuspendLayout();
            this.grpStandartRezervasyon.SuspendLayout();
            this.grpRandevuIptal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIptal)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRezervasyonEkrani
            // 
            this.grpRezervasyonEkrani.Controls.Add(this.radioButton1);
            this.grpRezervasyonEkrani.Controls.Add(this.btnOnay);
            this.grpRezervasyonEkrani.Controls.Add(this.lblFiyat);
            this.grpRezervasyonEkrani.Controls.Add(this.label11);
            this.grpRezervasyonEkrani.Controls.Add(this.dtpCikisTarihi);
            this.grpRezervasyonEkrani.Controls.Add(this.dtpRezervasyonTarihi);
            this.grpRezervasyonEkrani.Controls.Add(this.label10);
            this.grpRezervasyonEkrani.Controls.Add(this.label9);
            this.grpRezervasyonEkrani.Controls.Add(this.txtTelefonNo);
            this.grpRezervasyonEkrani.Controls.Add(this.txtEmail);
            this.grpRezervasyonEkrani.Controls.Add(this.txtRezervasyonTc);
            this.grpRezervasyonEkrani.Controls.Add(this.txtSoyad);
            this.grpRezervasyonEkrani.Controls.Add(this.txtAd);
            this.grpRezervasyonEkrani.Controls.Add(this.label5);
            this.grpRezervasyonEkrani.Controls.Add(this.label4);
            this.grpRezervasyonEkrani.Controls.Add(this.label3);
            this.grpRezervasyonEkrani.Controls.Add(this.label2);
            this.grpRezervasyonEkrani.Controls.Add(this.label1);
            this.grpRezervasyonEkrani.Location = new System.Drawing.Point(25, 12);
            this.grpRezervasyonEkrani.Name = "grpRezervasyonEkrani";
            this.grpRezervasyonEkrani.Size = new System.Drawing.Size(848, 224);
            this.grpRezervasyonEkrani.TabIndex = 6;
            this.grpRezervasyonEkrani.TabStop = false;
            this.grpRezervasyonEkrani.Text = "Rezervasyon";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(491, 194);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(172, 24);
            this.radioButton1.TabIndex = 36;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Standart Rezervasyon";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnOnay
            // 
            this.btnOnay.Location = new System.Drawing.Point(679, 189);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(94, 29);
            this.btnOnay.TabIndex = 35;
            this.btnOnay.Text = "Onay";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(623, 151);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(40, 20);
            this.lblFiyat.TabIndex = 34;
            this.lblFiyat.Text = ".... TL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(554, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Fiyat :";
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Location = new System.Drawing.Point(623, 109);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(144, 27);
            this.dtpCikisTarihi.TabIndex = 32;
            // 
            // dtpRezervasyonTarihi
            // 
            this.dtpRezervasyonTarihi.Location = new System.Drawing.Point(623, 69);
            this.dtpRezervasyonTarihi.Name = "dtpRezervasyonTarihi";
            this.dtpRezervasyonTarihi.Size = new System.Drawing.Size(144, 27);
            this.dtpRezervasyonTarihi.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(516, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Çıkış Tarihi :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(464, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Rezervasyon Tarihi :";
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(166, 144);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(125, 27);
            this.txtTelefonNo.TabIndex = 28;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(166, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(125, 27);
            this.txtEmail.TabIndex = 27;
            // 
            // txtRezervasyonTc
            // 
            this.txtRezervasyonTc.Location = new System.Drawing.Point(166, 78);
            this.txtRezervasyonTc.Name = "txtRezervasyonTc";
            this.txtRezervasyonTc.Size = new System.Drawing.Size(125, 27);
            this.txtRezervasyonTc.TabIndex = 26;
            this.txtRezervasyonTc.TextChanged += new System.EventHandler(this.label10_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(166, 48);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(125, 27);
            this.txtSoyad.TabIndex = 25;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(166, 18);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(125, 27);
            this.txtAd.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "E-mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "TC :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Soyad :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ad :";
            // 
            // txtCvv
            // 
            this.txtCvv.Location = new System.Drawing.Point(178, 80);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(125, 27);
            this.txtCvv.TabIndex = 15;
            // 
            // txtKrediKarti
            // 
            this.txtKrediKarti.Location = new System.Drawing.Point(178, 37);
            this.txtKrediKarti.Name = "txtKrediKarti";
            this.txtKrediKarti.Size = new System.Drawing.Size(125, 27);
            this.txtKrediKarti.TabIndex = 12;
            // 
            // dtpSonKullanmaTarihi
            // 
            this.dtpSonKullanmaTarihi.Location = new System.Drawing.Point(178, 130);
            this.dtpSonKullanmaTarihi.Name = "dtpSonKullanmaTarihi";
            this.dtpSonKullanmaTarihi.Size = new System.Drawing.Size(140, 27);
            this.dtpSonKullanmaTarihi.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Son Kullanma Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "CVV :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kredi kart No:";
            // 
            // grpStandartRezervasyon
            // 
            this.grpStandartRezervasyon.Controls.Add(this.txtCvv);
            this.grpStandartRezervasyon.Controls.Add(this.label6);
            this.grpStandartRezervasyon.Controls.Add(this.txtKrediKarti);
            this.grpStandartRezervasyon.Controls.Add(this.label7);
            this.grpStandartRezervasyon.Controls.Add(this.dtpSonKullanmaTarihi);
            this.grpStandartRezervasyon.Controls.Add(this.label8);
            this.grpStandartRezervasyon.Location = new System.Drawing.Point(25, 244);
            this.grpStandartRezervasyon.Name = "grpStandartRezervasyon";
            this.grpStandartRezervasyon.Size = new System.Drawing.Size(403, 252);
            this.grpStandartRezervasyon.TabIndex = 24;
            this.grpStandartRezervasyon.TabStop = false;
            this.grpStandartRezervasyon.Text = "Standart Rezervasyon";
            // 
            // grpRandevuIptal
            // 
            this.grpRandevuIptal.Controls.Add(this.label13);
            this.grpRandevuIptal.Controls.Add(this.btnRandevuIptal);
            this.grpRandevuIptal.Controls.Add(this.btnAra);
            this.grpRandevuIptal.Controls.Add(this.dgvIptal);
            this.grpRandevuIptal.Controls.Add(this.txtIptalTC);
            this.grpRandevuIptal.Location = new System.Drawing.Point(453, 244);
            this.grpRandevuIptal.Name = "grpRandevuIptal";
            this.grpRandevuIptal.Size = new System.Drawing.Size(411, 252);
            this.grpRandevuIptal.TabIndex = 36;
            this.grpRandevuIptal.TabStop = false;
            this.grpRandevuIptal.Text = "Randevu İptal";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "TcNo:";
            // 
            // btnRandevuIptal
            // 
            this.btnRandevuIptal.Location = new System.Drawing.Point(251, 175);
            this.btnRandevuIptal.Name = "btnRandevuIptal";
            this.btnRandevuIptal.Size = new System.Drawing.Size(137, 32);
            this.btnRandevuIptal.TabIndex = 27;
            this.btnRandevuIptal.Text = "Randevu İptal";
            this.btnRandevuIptal.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(205, 20);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(42, 29);
            this.btnAra.TabIndex = 26;
            this.btnAra.Text = "Ara";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // dgvIptal
            // 
            this.dgvIptal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIptal.Location = new System.Drawing.Point(22, 58);
            this.dgvIptal.Name = "dgvIptal";
            this.dgvIptal.RowHeadersWidth = 51;
            this.dgvIptal.RowTemplate.Height = 29;
            this.dgvIptal.Size = new System.Drawing.Size(223, 149);
            this.dgvIptal.TabIndex = 25;
            // 
            // txtIptalTC
            // 
            this.txtIptalTC.Location = new System.Drawing.Point(74, 25);
            this.txtIptalTC.Name = "txtIptalTC";
            this.txtIptalTC.Size = new System.Drawing.Size(125, 27);
            this.txtIptalTC.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 496);
            this.Controls.Add(this.grpRandevuIptal);
            this.Controls.Add(this.grpStandartRezervasyon);
            this.Controls.Add(this.grpRezervasyonEkrani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpRezervasyonEkrani.ResumeLayout(false);
            this.grpRezervasyonEkrani.PerformLayout();
            this.grpStandartRezervasyon.ResumeLayout(false);
            this.grpStandartRezervasyon.PerformLayout();
            this.grpRandevuIptal.ResumeLayout(false);
            this.grpRandevuIptal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIptal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox grpRezervasyonEkrani;
        private TextBox txtCvv;
        private TextBox txtKrediKarti;
        private DateTimePicker dtpSonKullanmaTarihi;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnOnay;
        private Label lblFiyat;
        private Label label11;
        private DateTimePicker dtpCikisTarihi;
        private DateTimePicker dtpRezervasyonTarihi;
        private Label label10;
        private Label label9;
        private TextBox txtTelefonNo;
        private TextBox txtEmail;
        private TextBox txtRezervasyonTc;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grpStandartRezervasyon;
        private GroupBox grpRandevuIptal;
        private Label label13;
        private Button btnRandevuIptal;
        private Button btnAra;
        private DataGridView dgvIptal;
        private TextBox txtIptalTC;
        private RadioButton radioButton1;
    }
}