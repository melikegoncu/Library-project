namespace Proje
{
    partial class Miktar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Miktar));
            this.txt_yazar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.btn_topla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_yazar
            // 
            this.txt_yazar.Location = new System.Drawing.Point(13, 33);
            this.txt_yazar.Name = "txt_yazar";
            this.txt_yazar.Size = new System.Drawing.Size(100, 20);
            this.txt_yazar.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(142, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(306, 179);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yazar No";
            // 
            // btn_kayit
            // 
            this.btn_kayit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_kayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kayit.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kayit.Location = new System.Drawing.Point(3, 89);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(75, 26);
            this.btn_kayit.TabIndex = 3;
            this.btn_kayit.Text = "Kayıt Al";
            this.btn_kayit.UseVisualStyleBackColor = false;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // btn_topla
            // 
            this.btn_topla.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_topla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_topla.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_topla.Location = new System.Drawing.Point(3, 131);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(75, 26);
            this.btn_topla.TabIndex = 4;
            this.btn_topla.Text = "Topla";
            this.btn_topla.UseVisualStyleBackColor = false;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // Miktar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proje.Properties.Resources.public_library_interior_stack_book_bookshelf_flat_7081_8401;
            this.ClientSize = new System.Drawing.Size(460, 294);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_yazar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Miktar";
            this.Text = "ADET TOPLAMI";
            this.Load += new System.EventHandler(this.Miktar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_yazar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.Button btn_topla;
    }
}