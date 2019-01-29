namespace arayüz2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMisafirGiris = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSifreGiris = new System.Windows.Forms.TextBox();
            this.btnKullanıcıKayıt = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbxUzmanlıkAlanı = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKullanıcıAdıGiris = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnKullanıcıGiris = new System.Windows.Forms.Button();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdminSifre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAdminKullAdı = new System.Windows.Forms.TextBox();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnMisafirGiris);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(286, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 405);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(70, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "MİSAFİR GİRİŞİ";
            // 
            // btnMisafirGiris
            // 
            this.btnMisafirGiris.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMisafirGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMisafirGiris.BackgroundImage")));
            this.btnMisafirGiris.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMisafirGiris.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMisafirGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnMisafirGiris.Image")));
            this.btnMisafirGiris.Location = new System.Drawing.Point(20, 61);
            this.btnMisafirGiris.Name = "btnMisafirGiris";
            this.btnMisafirGiris.Size = new System.Drawing.Size(225, 297);
            this.btnMisafirGiris.TabIndex = 2;
            this.btnMisafirGiris.Text = "GİRİŞ YAP";
            this.btnMisafirGiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMisafirGiris.UseVisualStyleBackColor = false;
            this.btnMisafirGiris.Click += new System.EventHandler(this.btnMisafirGiris_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.txtSifreGiris);
            this.groupBox3.Controls.Add(this.btnKullanıcıKayıt);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.cmbxUzmanlıkAlanı);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtKullanıcıAdıGiris);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.btnKullanıcıGiris);
            this.groupBox3.Controls.Add(this.txtAdSoyad);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtSifre);
            this.groupBox3.Controls.Add(this.txtKullanıcıAdı);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(564, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 406);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // txtSifreGiris
            // 
            this.txtSifreGiris.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreGiris.Location = new System.Drawing.Point(53, 302);
            this.txtSifreGiris.Multiline = true;
            this.txtSifreGiris.Name = "txtSifreGiris";
            this.txtSifreGiris.PasswordChar = '*';
            this.txtSifreGiris.Size = new System.Drawing.Size(197, 31);
            this.txtSifreGiris.TabIndex = 13;
            this.txtSifreGiris.Text = "Şifre";
            this.txtSifreGiris.TextChanged += new System.EventHandler(this.txtSifreGiris_TextChanged);
            // 
            // btnKullanıcıKayıt
            // 
            this.btnKullanıcıKayıt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKullanıcıKayıt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKullanıcıKayıt.BackgroundImage")));
            this.btnKullanıcıKayıt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanıcıKayıt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKullanıcıKayıt.Image = ((System.Drawing.Image)(resources.GetObject("btnKullanıcıKayıt.Image")));
            this.btnKullanıcıKayıt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKullanıcıKayıt.Location = new System.Drawing.Point(16, 207);
            this.btnKullanıcıKayıt.Name = "btnKullanıcıKayıt";
            this.btnKullanıcıKayıt.Size = new System.Drawing.Size(234, 45);
            this.btnKullanıcıKayıt.TabIndex = 21;
            this.btnKullanıcıKayıt.Text = "KAYIT OL";
            this.btnKullanıcıKayıt.UseVisualStyleBackColor = false;
            this.btnKullanıcıKayıt.Click += new System.EventHandler(this.btnKullanıcıKayıt_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(15, 302);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 31);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // cmbxUzmanlıkAlanı
            // 
            this.cmbxUzmanlıkAlanı.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxUzmanlıkAlanı.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbxUzmanlıkAlanı.FormattingEnabled = true;
            this.cmbxUzmanlıkAlanı.Items.AddRange(new object[] {
            "Bilişim - Teknoloji",
            "Çevre - Şehir",
            "Denizcilik",
            "Dilbilim",
            "Diş Hekimliği",
            "Eczacılık",
            "Edebiyat",
            "Eğitim",
            "Enerji",
            "Fen Bilimleri",
            "Gıda - Beslenme",
            "Havacılık",
            "Hemşirelik - Ebelik",
            "Hukuk",
            "İktisat - Ekonomi - İdari Bilimler",
            "İletişim",
            "İstatistik",
            "İnşaat Yapı",
            "Jeoloji",
            "Kalite",
            "Kimya",
            "Kültür ve Tarih",
            "Maden - Petrol",
            "Mimarlık",
            "Multidisipliner",
            "Mühendislik",
            "Öğrenci Kongreleri",
            "Psikoloji",
            "Radyoloji",
            "Sağlık",
            "Sanat",
            "Sanayi",
            "Siyaset Bilimi ve Uluslararası İlişkiler",
            "Sosyal Bilimler",
            "Sosyal Konular",
            "Spor",
            "Su ve Su Ürünleri",
            "Tarım ve Ziraat",
            "Tıp Kongreleri",
            "Turizm",
            "Ulaştırma - Taşımacılık",
            "Veterinerlik ve Hayvancılık",
            "Yönetim",
            "Diğer"});
            this.cmbxUzmanlıkAlanı.Location = new System.Drawing.Point(129, 176);
            this.cmbxUzmanlıkAlanı.Name = "cmbxUzmanlıkAlanı";
            this.cmbxUzmanlıkAlanı.Size = new System.Drawing.Size(121, 27);
            this.cmbxUzmanlıkAlanı.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(49, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "KULLANICI GİRİŞİ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(15, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(39, 31);
            this.panel2.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(13, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "Uzmanlık Alanınız";
            // 
            // txtKullanıcıAdıGiris
            // 
            this.txtKullanıcıAdıGiris.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcıAdıGiris.Location = new System.Drawing.Point(53, 265);
            this.txtKullanıcıAdıGiris.Multiline = true;
            this.txtKullanıcıAdıGiris.Name = "txtKullanıcıAdıGiris";
            this.txtKullanıcıAdıGiris.Size = new System.Drawing.Size(197, 31);
            this.txtKullanıcıAdıGiris.TabIndex = 10;
            this.txtKullanıcıAdıGiris.Text = "Kullanıcı Adı";
            this.txtKullanıcıAdıGiris.TextChanged += new System.EventHandler(this.txtKullanıcıAdıGiris_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(129, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 26);
            this.txtEmail.TabIndex = 18;
            // 
            // btnKullanıcıGiris
            // 
            this.btnKullanıcıGiris.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKullanıcıGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKullanıcıGiris.BackgroundImage")));
            this.btnKullanıcıGiris.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanıcıGiris.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKullanıcıGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnKullanıcıGiris.Image")));
            this.btnKullanıcıGiris.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKullanıcıGiris.Location = new System.Drawing.Point(16, 338);
            this.btnKullanıcıGiris.Name = "btnKullanıcıGiris";
            this.btnKullanıcıGiris.Size = new System.Drawing.Size(234, 46);
            this.btnKullanıcıGiris.TabIndex = 3;
            this.btnKullanıcıGiris.Text = "GİRİŞ YAP";
            this.btnKullanıcıGiris.UseVisualStyleBackColor = false;
            this.btnKullanıcıGiris.Click += new System.EventHandler(this.btnKullanıcıGiris_Click);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(129, 117);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(121, 26);
            this.txtAdSoyad.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(13, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Ad Soyad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(13, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Şifre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(13, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "E Mail Adresiniz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(13, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Kullanıcı Adı ";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(129, 88);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(121, 26);
            this.txtSifre.TabIndex = 14;
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(129, 58);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(121, 26);
            this.txtKullanıcıAdı.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.txtAdminSifre);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtAdminKullAdı);
            this.groupBox1.Controls.Add(this.btnAdminGiris);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(10, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 405);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminSifre.Location = new System.Drawing.Point(56, 183);
            this.txtAdminSifre.Multiline = true;
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.PasswordChar = '*';
            this.txtAdminSifre.Size = new System.Drawing.Size(188, 31);
            this.txtAdminSifre.TabIndex = 9;
            this.txtAdminSifre.Text = "Admin Şifre";
            this.txtAdminSifre.Click += new System.EventHandler(this.txtAdminSifre_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(18, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 31);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(18, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 31);
            this.panel1.TabIndex = 7;
            // 
            // txtAdminKullAdı
            // 
            this.txtAdminKullAdı.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminKullAdı.Location = new System.Drawing.Point(56, 141);
            this.txtAdminKullAdı.Multiline = true;
            this.txtAdminKullAdı.Name = "txtAdminKullAdı";
            this.txtAdminKullAdı.Size = new System.Drawing.Size(188, 31);
            this.txtAdminKullAdı.TabIndex = 5;
            this.txtAdminKullAdı.Text = "Admin Kullanıcı Adı";
            this.txtAdminKullAdı.Click += new System.EventHandler(this.txtAdminKullAdı_Click);
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdminGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdminGiris.BackgroundImage")));
            this.btnAdminGiris.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminGiris.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdminGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminGiris.Image")));
            this.btnAdminGiris.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminGiris.Location = new System.Drawing.Point(18, 225);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(226, 42);
            this.btnAdminGiris.TabIndex = 1;
            this.btnAdminGiris.Text = "GİRİŞ YAP";
            this.btnAdminGiris.UseVisualStyleBackColor = false;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(69, 15);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "ADMİN GİRİŞİ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Türkiye Geneli Sempozyum Takvimi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMisafirGiris;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSifreGiris;
        private System.Windows.Forms.Button btnKullanıcıKayıt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbxUzmanlıkAlanı;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtKullanıcıAdıGiris;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnKullanıcıGiris;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdminSifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAdminKullAdı;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

