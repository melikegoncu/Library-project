namespace Proje
{
    partial class YayinEvi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YayinEvi));
            this.txt_YEKodu = new System.Windows.Forms.TextBox();
            this.txt_İlKodu = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_TelNo = new System.Windows.Forms.TextBox();
            this.btn_e_islem = new System.Windows.Forms.Button();
            this.btn_e_sil = new System.Windows.Forms.Button();
            this.btn_e_ekle = new System.Windows.Forms.Button();
            this.btn_e_guncelle = new System.Windows.Forms.Button();
            this.data_yayinevi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_y_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_yayinevi)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_YEKodu
            // 
            this.txt_YEKodu.Location = new System.Drawing.Point(12, 40);
            this.txt_YEKodu.Name = "txt_YEKodu";
            this.txt_YEKodu.Size = new System.Drawing.Size(100, 20);
            this.txt_YEKodu.TabIndex = 0;
            // 
            // txt_İlKodu
            // 
            this.txt_İlKodu.Location = new System.Drawing.Point(199, 117);
            this.txt_İlKodu.Name = "txt_İlKodu";
            this.txt_İlKodu.Size = new System.Drawing.Size(100, 20);
            this.txt_İlKodu.TabIndex = 1;
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(199, 40);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(100, 20);
            this.txt_isim.TabIndex = 2;
            this.txt_isim.Text = " ";
            // 
            // txt_TelNo
            // 
            this.txt_TelNo.Location = new System.Drawing.Point(12, 117);
            this.txt_TelNo.Name = "txt_TelNo";
            this.txt_TelNo.Size = new System.Drawing.Size(100, 20);
            this.txt_TelNo.TabIndex = 3;
            // 
            // btn_e_islem
            // 
            this.btn_e_islem.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_e_islem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_e_islem.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_e_islem.Location = new System.Drawing.Point(359, 37);
            this.btn_e_islem.Name = "btn_e_islem";
            this.btn_e_islem.Size = new System.Drawing.Size(75, 23);
            this.btn_e_islem.TabIndex = 4;
            this.btn_e_islem.Text = "İşlem Yap";
            this.btn_e_islem.UseVisualStyleBackColor = false;
            this.btn_e_islem.Click += new System.EventHandler(this.btn_e_islem_Click);
            // 
            // btn_e_sil
            // 
            this.btn_e_sil.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_e_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_e_sil.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_e_sil.Location = new System.Drawing.Point(466, 130);
            this.btn_e_sil.Name = "btn_e_sil";
            this.btn_e_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_e_sil.TabIndex = 5;
            this.btn_e_sil.Text = "Sil";
            this.btn_e_sil.UseVisualStyleBackColor = false;
            this.btn_e_sil.Click += new System.EventHandler(this.btn_e_sil_Click);
            // 
            // btn_e_ekle
            // 
            this.btn_e_ekle.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_e_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_e_ekle.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_e_ekle.Location = new System.Drawing.Point(466, 40);
            this.btn_e_ekle.Name = "btn_e_ekle";
            this.btn_e_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_e_ekle.TabIndex = 6;
            this.btn_e_ekle.Text = "Ekle";
            this.btn_e_ekle.UseVisualStyleBackColor = false;
            this.btn_e_ekle.Click += new System.EventHandler(this.btn_e_ekle_Click);
            // 
            // btn_e_guncelle
            // 
            this.btn_e_guncelle.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_e_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_e_guncelle.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_e_guncelle.Location = new System.Drawing.Point(466, 84);
            this.btn_e_guncelle.Name = "btn_e_guncelle";
            this.btn_e_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_e_guncelle.TabIndex = 7;
            this.btn_e_guncelle.Text = "Güncelle";
            this.btn_e_guncelle.UseVisualStyleBackColor = false;
            this.btn_e_guncelle.Click += new System.EventHandler(this.btn_e_guncelle_Click);
            // 
            // data_yayinevi
            // 
            this.data_yayinevi.BackgroundColor = System.Drawing.Color.White;
            this.data_yayinevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_yayinevi.Location = new System.Drawing.Point(12, 229);
            this.data_yayinevi.Name = "data_yayinevi";
            this.data_yayinevi.Size = new System.Drawing.Size(580, 146);
            this.data_yayinevi.TabIndex = 8;
            this.data_yayinevi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_yayinevi_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yayınevi Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(196, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Yayınevi Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefon Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(196, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "İl Kodu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Tel degişikliği";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_y_geri
            // 
            this.btn_y_geri.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_y_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_y_geri.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_y_geri.Location = new System.Drawing.Point(359, 94);
            this.btn_y_geri.Name = "btn_y_geri";
            this.btn_y_geri.Size = new System.Drawing.Size(75, 23);
            this.btn_y_geri.TabIndex = 14;
            this.btn_y_geri.Text = "Geri";
            this.btn_y_geri.UseVisualStyleBackColor = false;
            this.btn_y_geri.Click += new System.EventHandler(this.btn_y_geri_Click);
            // 
            // YayinEvi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proje.Properties.Resources.library_room_interior_stack_book_bookshelf_flat_design_7081_829;
            this.ClientSize = new System.Drawing.Size(604, 387);
            this.Controls.Add(this.btn_y_geri);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_yayinevi);
            this.Controls.Add(this.btn_e_guncelle);
            this.Controls.Add(this.btn_e_ekle);
            this.Controls.Add(this.btn_e_sil);
            this.Controls.Add(this.btn_e_islem);
            this.Controls.Add(this.txt_TelNo);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.txt_İlKodu);
            this.Controls.Add(this.txt_YEKodu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YayinEvi";
            this.Text = "YAYIN EVİ";
            this.Load += new System.EventHandler(this.YayinEvi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_yayinevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_YEKodu;
        private System.Windows.Forms.TextBox txt_İlKodu;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_TelNo;
        private System.Windows.Forms.Button btn_e_islem;
        private System.Windows.Forms.Button btn_e_sil;
        private System.Windows.Forms.Button btn_e_ekle;
        private System.Windows.Forms.Button btn_e_guncelle;
        private System.Windows.Forms.DataGridView data_yayinevi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_y_geri;
    }
}