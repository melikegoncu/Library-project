namespace Proje
{
    partial class Degisim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Degisim));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_YazarKod = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_ilkodu = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.txt_d_yer = new System.Windows.Forms.TextBox();
            this.txt_d_tarih = new System.Windows.Forms.TextBox();
            this.btn_y_ekle = new System.Windows.Forms.Button();
            this.btn_y_guncelle = new System.Windows.Forms.Button();
            this.btn_y_sil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_d_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 201);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_YazarKod
            // 
            this.txt_YazarKod.Location = new System.Drawing.Point(26, 44);
            this.txt_YazarKod.Name = "txt_YazarKod";
            this.txt_YazarKod.Size = new System.Drawing.Size(100, 20);
            this.txt_YazarKod.TabIndex = 1;
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(186, 115);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(100, 20);
            this.txt_isim.TabIndex = 2;
            // 
            // txt_ilkodu
            // 
            this.txt_ilkodu.Location = new System.Drawing.Point(186, 44);
            this.txt_ilkodu.Name = "txt_ilkodu";
            this.txt_ilkodu.Size = new System.Drawing.Size(100, 20);
            this.txt_ilkodu.TabIndex = 3;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(186, 181);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(100, 20);
            this.txt_soyisim.TabIndex = 4;
            // 
            // txt_d_yer
            // 
            this.txt_d_yer.Location = new System.Drawing.Point(26, 181);
            this.txt_d_yer.Name = "txt_d_yer";
            this.txt_d_yer.Size = new System.Drawing.Size(100, 20);
            this.txt_d_yer.TabIndex = 4;
            // 
            // txt_d_tarih
            // 
            this.txt_d_tarih.Location = new System.Drawing.Point(26, 115);
            this.txt_d_tarih.Name = "txt_d_tarih";
            this.txt_d_tarih.Size = new System.Drawing.Size(100, 20);
            this.txt_d_tarih.TabIndex = 5;
            this.txt_d_tarih.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btn_y_ekle
            // 
            this.btn_y_ekle.BackColor = System.Drawing.Color.OldLace;
            this.btn_y_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_y_ekle.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_y_ekle.Location = new System.Drawing.Point(458, 44);
            this.btn_y_ekle.Name = "btn_y_ekle";
            this.btn_y_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_y_ekle.TabIndex = 6;
            this.btn_y_ekle.Text = "Ekle";
            this.btn_y_ekle.UseVisualStyleBackColor = false;
            this.btn_y_ekle.Click += new System.EventHandler(this.btn_y_ekle_Click);
            // 
            // btn_y_guncelle
            // 
            this.btn_y_guncelle.BackColor = System.Drawing.Color.OldLace;
            this.btn_y_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_y_guncelle.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_y_guncelle.Location = new System.Drawing.Point(458, 85);
            this.btn_y_guncelle.Name = "btn_y_guncelle";
            this.btn_y_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_y_guncelle.TabIndex = 7;
            this.btn_y_guncelle.Text = "Guncelle";
            this.btn_y_guncelle.UseVisualStyleBackColor = false;
            this.btn_y_guncelle.Click += new System.EventHandler(this.btn_y_guncelle_Click);
            // 
            // btn_y_sil
            // 
            this.btn_y_sil.BackColor = System.Drawing.Color.OldLace;
            this.btn_y_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_y_sil.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_y_sil.Location = new System.Drawing.Point(458, 126);
            this.btn_y_sil.Name = "btn_y_sil";
            this.btn_y_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_y_sil.TabIndex = 8;
            this.btn_y_sil.Text = "Sil";
            this.btn_y_sil.UseVisualStyleBackColor = false;
            this.btn_y_sil.Click += new System.EventHandler(this.btn_y_sil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yazar Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(183, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "İsim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(183, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Soyisim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(183, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "İl Kodu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(23, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "Doğum Yeri";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OldLace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(345, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "İşlem Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_d_geri
            // 
            this.btn_d_geri.BackColor = System.Drawing.Color.OldLace;
            this.btn_d_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_d_geri.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_d_geri.Location = new System.Drawing.Point(345, 95);
            this.btn_d_geri.Name = "btn_d_geri";
            this.btn_d_geri.Size = new System.Drawing.Size(75, 23);
            this.btn_d_geri.TabIndex = 16;
            this.btn_d_geri.Text = "Geri";
            this.btn_d_geri.UseVisualStyleBackColor = false;
            this.btn_d_geri.Click += new System.EventHandler(this.btn_d_geri_Click);
            // 
            // Degisim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proje.Properties.Resources.public_library_interior_stack_book_bookshelf_flat_7081_844;
            this.ClientSize = new System.Drawing.Size(589, 463);
            this.Controls.Add(this.btn_d_geri);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_y_sil);
            this.Controls.Add(this.btn_y_guncelle);
            this.Controls.Add(this.btn_y_ekle);
            this.Controls.Add(this.txt_d_tarih);
            this.Controls.Add(this.txt_d_yer);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.txt_ilkodu);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.txt_YazarKod);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Degisim";
            this.Text = "YAZAR";
            this.Load += new System.EventHandler(this.Degisim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_YazarKod;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_ilkodu;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.TextBox txt_d_yer;
        private System.Windows.Forms.TextBox txt_d_tarih;
        private System.Windows.Forms.Button btn_y_ekle;
        private System.Windows.Forms.Button btn_y_guncelle;
        private System.Windows.Forms.Button btn_y_sil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_d_geri;
    }
}