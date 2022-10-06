namespace otoYikama
{
    partial class otoYikama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(otoYikama));
            this.gbox_musteri = new System.Windows.Forms.GroupBox();
            this.cbox_aracTuru = new System.Windows.Forms.ComboBox();
            this.btn_cikar = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.lbl_plaka = new System.Windows.Forms.Label();
            this.lbl_aracTuru = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.txt_plaka = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.dtg_arac = new System.Windows.Forms.DataGridView();
            this.gbox_fiyatList = new System.Windows.Forms.GroupBox();
            this.lbl_loginPannel = new System.Windows.Forms.Label();
            this.btn_fiyatList = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtg_fiyatList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gbox_musteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_arac)).BeginInit();
            this.gbox_fiyatList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_fiyatList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox_musteri
            // 
            this.gbox_musteri.BackColor = System.Drawing.Color.Transparent;
            this.gbox_musteri.Controls.Add(this.cbox_aracTuru);
            this.gbox_musteri.Controls.Add(this.btn_cikar);
            this.gbox_musteri.Controls.Add(this.btn_ekle);
            this.gbox_musteri.Controls.Add(this.lbl_plaka);
            this.gbox_musteri.Controls.Add(this.lbl_aracTuru);
            this.gbox_musteri.Controls.Add(this.lbl_tel);
            this.gbox_musteri.Controls.Add(this.lbl_soyad);
            this.gbox_musteri.Controls.Add(this.lbl_ad);
            this.gbox_musteri.Controls.Add(this.txt_plaka);
            this.gbox_musteri.Controls.Add(this.txt_tel);
            this.gbox_musteri.Controls.Add(this.txt_soyad);
            this.gbox_musteri.Controls.Add(this.txt_ad);
            this.gbox_musteri.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbox_musteri.Location = new System.Drawing.Point(24, 100);
            this.gbox_musteri.Name = "gbox_musteri";
            this.gbox_musteri.Size = new System.Drawing.Size(287, 432);
            this.gbox_musteri.TabIndex = 0;
            this.gbox_musteri.TabStop = false;
            this.gbox_musteri.Text = "Müşteri Bilgileri";
            // 
            // cbox_aracTuru
            // 
            this.cbox_aracTuru.FormattingEnabled = true;
            this.cbox_aracTuru.Items.AddRange(new object[] {
            "Otomobil",
            "Minibüs",
            "Otobüs",
            "Motorsiklet",
            "Karavan"});
            this.cbox_aracTuru.Location = new System.Drawing.Point(128, 261);
            this.cbox_aracTuru.Name = "cbox_aracTuru";
            this.cbox_aracTuru.Size = new System.Drawing.Size(140, 28);
            this.cbox_aracTuru.TabIndex = 12;
            // 
            // btn_cikar
            // 
            this.btn_cikar.BackColor = System.Drawing.Color.Salmon;
            this.btn_cikar.Location = new System.Drawing.Point(146, 326);
            this.btn_cikar.Name = "btn_cikar";
            this.btn_cikar.Size = new System.Drawing.Size(120, 48);
            this.btn_cikar.TabIndex = 11;
            this.btn_cikar.Text = "Çıkar";
            this.btn_cikar.UseVisualStyleBackColor = false;
            this.btn_cikar.Click += new System.EventHandler(this.btn_cikar_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ekle.Location = new System.Drawing.Point(19, 326);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(120, 48);
            this.btn_ekle.TabIndex = 10;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // lbl_plaka
            // 
            this.lbl_plaka.AutoSize = true;
            this.lbl_plaka.Location = new System.Drawing.Point(16, 213);
            this.lbl_plaka.Name = "lbl_plaka";
            this.lbl_plaka.Size = new System.Drawing.Size(85, 20);
            this.lbl_plaka.TabIndex = 9;
            this.lbl_plaka.Text = "Araç Plaka:";
            // 
            // lbl_aracTuru
            // 
            this.lbl_aracTuru.AutoSize = true;
            this.lbl_aracTuru.Location = new System.Drawing.Point(16, 264);
            this.lbl_aracTuru.Name = "lbl_aracTuru";
            this.lbl_aracTuru.Size = new System.Drawing.Size(79, 20);
            this.lbl_aracTuru.TabIndex = 8;
            this.lbl_aracTuru.Text = "Araç Türü:";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Location = new System.Drawing.Point(12, 161);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(63, 20);
            this.lbl_tel.TabIndex = 7;
            this.lbl_tel.Text = "Telefon:";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(12, 107);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(55, 20);
            this.lbl_soyad.TabIndex = 6;
            this.lbl_soyad.Text = "Soyad:";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(12, 55);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(32, 20);
            this.lbl_ad.TabIndex = 1;
            this.lbl_ad.Text = "Ad:";
            // 
            // txt_plaka
            // 
            this.txt_plaka.Location = new System.Drawing.Point(128, 210);
            this.txt_plaka.Name = "txt_plaka";
            this.txt_plaka.Size = new System.Drawing.Size(140, 27);
            this.txt_plaka.TabIndex = 3;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(128, 158);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(140, 27);
            this.txt_tel.TabIndex = 2;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(128, 104);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(140, 27);
            this.txt_soyad.TabIndex = 1;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(128, 52);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(140, 27);
            this.txt_ad.TabIndex = 0;
            // 
            // dtg_arac
            // 
            this.dtg_arac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_arac.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_arac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_arac.Location = new System.Drawing.Point(331, 325);
            this.dtg_arac.Name = "dtg_arac";
            this.dtg_arac.RowHeadersWidth = 51;
            this.dtg_arac.RowTemplate.Height = 29;
            this.dtg_arac.Size = new System.Drawing.Size(798, 207);
            this.dtg_arac.TabIndex = 1;
            // 
            // gbox_fiyatList
            // 
            this.gbox_fiyatList.BackColor = System.Drawing.Color.Transparent;
            this.gbox_fiyatList.Controls.Add(this.lbl_loginPannel);
            this.gbox_fiyatList.Controls.Add(this.btn_fiyatList);
            this.gbox_fiyatList.Controls.Add(this.pictureBox1);
            this.gbox_fiyatList.Controls.Add(this.dtg_fiyatList);
            this.gbox_fiyatList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbox_fiyatList.Location = new System.Drawing.Point(331, 100);
            this.gbox_fiyatList.Name = "gbox_fiyatList";
            this.gbox_fiyatList.Size = new System.Drawing.Size(798, 219);
            this.gbox_fiyatList.TabIndex = 2;
            this.gbox_fiyatList.TabStop = false;
            this.gbox_fiyatList.Text = "Fiyat Listesi";
            // 
            // lbl_loginPannel
            // 
            this.lbl_loginPannel.AutoSize = true;
            this.lbl_loginPannel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_loginPannel.ForeColor = System.Drawing.Color.Khaki;
            this.lbl_loginPannel.Location = new System.Drawing.Point(25, 129);
            this.lbl_loginPannel.Name = "lbl_loginPannel";
            this.lbl_loginPannel.Size = new System.Drawing.Size(247, 20);
            this.lbl_loginPannel.TabIndex = 14;
            this.lbl_loginPannel.Text = "L   O   G   I   N         P   A   N   E   L   İ";
            // 
            // btn_fiyatList
            // 
            this.btn_fiyatList.BackColor = System.Drawing.Color.Khaki;
            this.btn_fiyatList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fiyatList.Location = new System.Drawing.Point(21, 158);
            this.btn_fiyatList.Name = "btn_fiyatList";
            this.btn_fiyatList.Size = new System.Drawing.Size(251, 46);
            this.btn_fiyatList.TabIndex = 13;
            this.btn_fiyatList.Text = "Fiyat Listesi";
            this.btn_fiyatList.UseVisualStyleBackColor = false;
            this.btn_fiyatList.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "";
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dtg_fiyatList
            // 
            this.dtg_fiyatList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_fiyatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_fiyatList.Location = new System.Drawing.Point(295, 26);
            this.dtg_fiyatList.Name = "dtg_fiyatList";
            this.dtg_fiyatList.RowHeadersWidth = 51;
            this.dtg_fiyatList.RowTemplate.Height = 29;
            this.dtg_fiyatList.Size = new System.Drawing.Size(479, 178);
            this.dtg_fiyatList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 57);
            this.label1.TabIndex = 13;
            this.label1.Text = "O T O  Y I K A M A  M E R K E Z İ";
            // 
            // otoYikama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1153, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbox_fiyatList);
            this.Controls.Add(this.dtg_arac);
            this.Controls.Add(this.gbox_musteri);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "otoYikama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oto Yıkama";
            this.Load += new System.EventHandler(this.otoYikama_Load);
            this.gbox_musteri.ResumeLayout(false);
            this.gbox_musteri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_arac)).EndInit();
            this.gbox_fiyatList.ResumeLayout(false);
            this.gbox_fiyatList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_fiyatList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_musteri;
        private System.Windows.Forms.Button btn_cikar;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label lbl_plaka;
        private System.Windows.Forms.Label lbl_aracTuru;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.TextBox txt_plaka;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.DataGridView dtg_arac;
        private System.Windows.Forms.ComboBox cbox_aracTuru;
        private System.Windows.Forms.GroupBox gbox_fiyatList;
        private System.Windows.Forms.DataGridView dtg_fiyatList;
        private System.Windows.Forms.Button btn_fiyatList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_loginPannel;
    }
}
