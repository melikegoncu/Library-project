namespace Proje
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
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.txt_kitapKodu = new System.Windows.Forms.TextBox();
            this.txt_dil = new System.Windows.Forms.TextBox();
            this.txt_k_isim = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_konu = new System.Windows.Forms.TextBox();
            this.txt_b_yili = new System.Windows.Forms.TextBox();
            this.txt_s_sayisi = new System.Windows.Forms.TextBox();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.cmb_kategori = new System.Windows.Forms.ComboBox();
            this.txt_kapak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kt_lbl = new System.Windows.Forms.Label();
            this.konu_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_islem = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.txt_yazarNo = new System.Windows.Forms.TextBox();
            this.txt_yayinEviNo = new System.Windows.Forms.TextBox();
            this.txt_YazarEkle = new System.Windows.Forms.Button();
            this.btn_YEEkle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Yayın = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_Topla = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_fiyatTopla = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid
            // 
            this.data_grid.BackgroundColor = System.Drawing.Color.White;
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_grid.Location = new System.Drawing.Point(0, 300);
            this.data_grid.Name = "data_grid";
            this.data_grid.Size = new System.Drawing.Size(800, 150);
            this.data_grid.TabIndex = 0;
            this.data_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_CellContentClick);
            // 
            // txt_kitapKodu
            // 
            this.txt_kitapKodu.Location = new System.Drawing.Point(32, 65);
            this.txt_kitapKodu.Name = "txt_kitapKodu";
            this.txt_kitapKodu.Size = new System.Drawing.Size(100, 20);
            this.txt_kitapKodu.TabIndex = 1;
            // 
            // txt_dil
            // 
            this.txt_dil.Location = new System.Drawing.Point(177, 126);
            this.txt_dil.Name = "txt_dil";
            this.txt_dil.Size = new System.Drawing.Size(100, 20);
            this.txt_dil.TabIndex = 2;
            // 
            // txt_k_isim
            // 
            this.txt_k_isim.Location = new System.Drawing.Point(177, 65);
            this.txt_k_isim.Name = "txt_k_isim";
            this.txt_k_isim.Size = new System.Drawing.Size(100, 20);
            this.txt_k_isim.TabIndex = 3;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(32, 126);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(100, 20);
            this.txt_fiyat.TabIndex = 4;
            // 
            // txt_konu
            // 
            this.txt_konu.Location = new System.Drawing.Point(450, 126);
            this.txt_konu.Name = "txt_konu";
            this.txt_konu.Size = new System.Drawing.Size(100, 20);
            this.txt_konu.TabIndex = 5;
            // 
            // txt_b_yili
            // 
            this.txt_b_yili.Location = new System.Drawing.Point(316, 65);
            this.txt_b_yili.Name = "txt_b_yili";
            this.txt_b_yili.Size = new System.Drawing.Size(100, 20);
            this.txt_b_yili.TabIndex = 6;
            // 
            // txt_s_sayisi
            // 
            this.txt_s_sayisi.Location = new System.Drawing.Point(450, 65);
            this.txt_s_sayisi.Name = "txt_s_sayisi";
            this.txt_s_sayisi.Size = new System.Drawing.Size(100, 20);
            this.txt_s_sayisi.TabIndex = 7;
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(584, 65);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(100, 20);
            this.txt_adet.TabIndex = 9;
            // 
            // cmb_kategori
            // 
            this.cmb_kategori.FormattingEnabled = true;
            this.cmb_kategori.Items.AddRange(new object[] {
            "Şiir",
            "Roman",
            "Dergi"});
            this.cmb_kategori.Location = new System.Drawing.Point(316, 124);
            this.cmb_kategori.Name = "cmb_kategori";
            this.cmb_kategori.Size = new System.Drawing.Size(100, 21);
            this.cmb_kategori.TabIndex = 10;
            this.cmb_kategori.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_kapak
            // 
            this.txt_kapak.Location = new System.Drawing.Point(584, 125);
            this.txt_kapak.Name = "txt_kapak";
            this.txt_kapak.Size = new System.Drawing.Size(100, 20);
            this.txt_kapak.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kitap kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "İsim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sayfa sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "Basım yılı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(174, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 14);
            this.label6.TabIndex = 16;
            this.label6.Text = "Yazım dili";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(316, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kategori";
            // 
            // kt_lbl
            // 
            this.kt_lbl.AutoSize = true;
            this.kt_lbl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kt_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kt_lbl.Location = new System.Drawing.Point(581, 110);
            this.kt_lbl.Name = "kt_lbl";
            this.kt_lbl.Size = new System.Drawing.Size(71, 14);
            this.kt_lbl.TabIndex = 18;
            this.kt_lbl.Text = "Kapak türü";
            // 
            // konu_lbl
            // 
            this.konu_lbl.AutoSize = true;
            this.konu_lbl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.konu_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konu_lbl.Location = new System.Drawing.Point(447, 110);
            this.konu_lbl.Name = "konu_lbl";
            this.konu_lbl.Size = new System.Drawing.Size(37, 14);
            this.konu_lbl.TabIndex = 19;
            this.konu_lbl.Text = "Konu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 14);
            this.label10.TabIndex = 20;
            this.label10.Text = "Fiyat";
            // 
            // btn_islem
            // 
            this.btn_islem.BackColor = System.Drawing.Color.MintCream;
            this.btn_islem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_islem.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_islem.Location = new System.Drawing.Point(177, 181);
            this.btn_islem.Name = "btn_islem";
            this.btn_islem.Size = new System.Drawing.Size(75, 23);
            this.btn_islem.TabIndex = 21;
            this.btn_islem.Text = "İşlem Yap";
            this.btn_islem.UseVisualStyleBackColor = false;
            this.btn_islem.Click += new System.EventHandler(this.btn_islem_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.MintCream;
            this.btn_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guncelle.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(316, 219);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(86, 23);
            this.btn_guncelle.TabIndex = 23;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.MintCream;
            this.btn_Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sil.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(316, 260);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(86, 23);
            this.btn_Sil.TabIndex = 24;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.MintCream;
            this.btn_Ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ekle.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(316, 181);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(86, 23);
            this.btn_Ekle.TabIndex = 25;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txt_yazarNo
            // 
            this.txt_yazarNo.Location = new System.Drawing.Point(32, 184);
            this.txt_yazarNo.Name = "txt_yazarNo";
            this.txt_yazarNo.Size = new System.Drawing.Size(100, 20);
            this.txt_yazarNo.TabIndex = 26;
            // 
            // txt_yayinEviNo
            // 
            this.txt_yayinEviNo.Location = new System.Drawing.Point(32, 245);
            this.txt_yayinEviNo.Name = "txt_yayinEviNo";
            this.txt_yayinEviNo.Size = new System.Drawing.Size(100, 20);
            this.txt_yayinEviNo.TabIndex = 27;
            // 
            // txt_YazarEkle
            // 
            this.txt_YazarEkle.BackColor = System.Drawing.Color.MintCream;
            this.txt_YazarEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_YazarEkle.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_YazarEkle.Location = new System.Drawing.Point(450, 219);
            this.txt_YazarEkle.Name = "txt_YazarEkle";
            this.txt_YazarEkle.Size = new System.Drawing.Size(124, 23);
            this.txt_YazarEkle.TabIndex = 28;
            this.txt_YazarEkle.Text = "Yazar Ekle";
            this.txt_YazarEkle.UseVisualStyleBackColor = false;
            this.txt_YazarEkle.Click += new System.EventHandler(this.txt_YazarEkle_Click);
            // 
            // btn_YEEkle
            // 
            this.btn_YEEkle.BackColor = System.Drawing.Color.MintCream;
            this.btn_YEEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_YEEkle.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_YEEkle.Location = new System.Drawing.Point(450, 260);
            this.btn_YEEkle.Name = "btn_YEEkle";
            this.btn_YEEkle.Size = new System.Drawing.Size(124, 23);
            this.btn_YEEkle.TabIndex = 29;
            this.btn_YEEkle.Text = "Yayınevi Ekle";
            this.btn_YEEkle.UseVisualStyleBackColor = false;
            this.btn_YEEkle.Click += new System.EventHandler(this.btn_YEEkle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 14);
            this.label8.TabIndex = 30;
            this.label8.Text = "Yazar No";
            // 
            // Yayın
            // 
            this.Yayın.AutoSize = true;
            this.Yayın.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Yayın.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yayın.Location = new System.Drawing.Point(32, 229);
            this.Yayın.Name = "Yayın";
            this.Yayın.Size = new System.Drawing.Size(75, 14);
            this.Yayın.TabIndex = 31;
            this.Yayın.Text = "Yayınevi No";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(450, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Değişim Kaydı";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.BackColor = System.Drawing.Color.MintCream;
            this.btn_ara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ara.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.Location = new System.Drawing.Point(713, 62);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 33;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_Topla
            // 
            this.btn_Topla.BackColor = System.Drawing.Color.MintCream;
            this.btn_Topla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Topla.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Topla.Location = new System.Drawing.Point(603, 219);
            this.btn_Topla.Name = "btn_Topla";
            this.btn_Topla.Size = new System.Drawing.Size(125, 23);
            this.btn_Topla.TabIndex = 34;
            this.btn_Topla.Text = "Adet Toplamı";
            this.btn_Topla.UseVisualStyleBackColor = false;
            this.btn_Topla.Click += new System.EventHandler(this.btn_Topla_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.MintCream;
            this.btn_listele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listele.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listele.Location = new System.Drawing.Point(713, 110);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(75, 23);
            this.btn_listele.TabIndex = 35;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_fiyatTopla
            // 
            this.btn_fiyatTopla.BackColor = System.Drawing.Color.MintCream;
            this.btn_fiyatTopla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fiyatTopla.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_fiyatTopla.Location = new System.Drawing.Point(603, 181);
            this.btn_fiyatTopla.Name = "btn_fiyatTopla";
            this.btn_fiyatTopla.Size = new System.Drawing.Size(125, 23);
            this.btn_fiyatTopla.TabIndex = 36;
            this.btn_fiyatTopla.Text = "Fiyat Toplamı";
            this.btn_fiyatTopla.UseVisualStyleBackColor = false;
            this.btn_fiyatTopla.Click += new System.EventHandler(this.btn_fiyatTopla_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.MintCream;
            this.btn_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_geri.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(177, 229);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(75, 23);
            this.btn_geri.TabIndex = 37;
            this.btn_geri.Text = "Geri ";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Proje.Properties.Resources.public_library_interior_stack_book_bookshelf_flat_7081_838;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_fiyatTopla);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_Topla);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Yayın);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_YEEkle);
            this.Controls.Add(this.txt_YazarEkle);
            this.Controls.Add(this.txt_yayinEviNo);
            this.Controls.Add(this.txt_yazarNo);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_islem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.konu_lbl);
            this.Controls.Add(this.kt_lbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kapak);
            this.Controls.Add(this.cmb_kategori);
            this.Controls.Add(this.txt_adet);
            this.Controls.Add(this.txt_s_sayisi);
            this.Controls.Add(this.txt_b_yili);
            this.Controls.Add(this.txt_konu);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.txt_k_isim);
            this.Controls.Add(this.txt_dil);
            this.Controls.Add(this.txt_kitapKodu);
            this.Controls.Add(this.data_grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DEPO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid;
        private System.Windows.Forms.TextBox txt_kitapKodu;
        private System.Windows.Forms.TextBox txt_dil;
        private System.Windows.Forms.TextBox txt_k_isim;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_konu;
        private System.Windows.Forms.TextBox txt_b_yili;
        private System.Windows.Forms.TextBox txt_s_sayisi;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.ComboBox cmb_kategori;
        private System.Windows.Forms.TextBox txt_kapak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label kt_lbl;
        private System.Windows.Forms.Label konu_lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_islem;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox txt_yazarNo;
        private System.Windows.Forms.TextBox txt_yayinEviNo;
        private System.Windows.Forms.Button txt_YazarEkle;
        private System.Windows.Forms.Button btn_YEEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Yayın;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_Topla;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_fiyatTopla;
        private System.Windows.Forms.Button btn_geri;
    }
}

