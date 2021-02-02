namespace Proje
{
    partial class Fiyat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fiyat));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Yayin = new System.Windows.Forms.TextBox();
            this.btn_f_kayit = new System.Windows.Forms.Button();
            this.btn_f_topla = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yayınevi No";
            // 
            // txt_Yayin
            // 
            this.txt_Yayin.Location = new System.Drawing.Point(13, 30);
            this.txt_Yayin.Name = "txt_Yayin";
            this.txt_Yayin.Size = new System.Drawing.Size(100, 20);
            this.txt_Yayin.TabIndex = 1;
            // 
            // btn_f_kayit
            // 
            this.btn_f_kayit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_f_kayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_f_kayit.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_f_kayit.Location = new System.Drawing.Point(173, 29);
            this.btn_f_kayit.Name = "btn_f_kayit";
            this.btn_f_kayit.Size = new System.Drawing.Size(75, 23);
            this.btn_f_kayit.TabIndex = 2;
            this.btn_f_kayit.Text = "Kayıt Al";
            this.btn_f_kayit.UseVisualStyleBackColor = false;
            this.btn_f_kayit.Click += new System.EventHandler(this.btn_f_kayit_Click);
            // 
            // btn_f_topla
            // 
            this.btn_f_topla.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_f_topla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_f_topla.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_f_topla.Location = new System.Drawing.Point(281, 30);
            this.btn_f_topla.Name = "btn_f_topla";
            this.btn_f_topla.Size = new System.Drawing.Size(75, 23);
            this.btn_f_topla.TabIndex = 3;
            this.btn_f_topla.Text = "Fİyat Topla";
            this.btn_f_topla.UseVisualStyleBackColor = false;
            this.btn_f_topla.Click += new System.EventHandler(this.btn_f_topla_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.No;
            this.dataGridView1.Location = new System.Drawing.Point(13, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(385, 189);
            this.dataGridView1.TabIndex = 4;
            // 
            // Fiyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proje.Properties.Resources.library_room_interior_stack_book_bookshelf_flat_design_7081_831;
            this.ClientSize = new System.Drawing.Size(459, 327);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_f_topla);
            this.Controls.Add(this.btn_f_kayit);
            this.Controls.Add(this.txt_Yayin);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fiyat";
            this.Text = "FİYAT TOPLAMI";
            this.Load += new System.EventHandler(this.Fiyat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Yayin;
        private System.Windows.Forms.Button btn_f_kayit;
        private System.Windows.Forms.Button btn_f_topla;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}