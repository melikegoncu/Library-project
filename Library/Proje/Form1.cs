using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public  static string KitapKodu;
        public string İsim;
        public string BasimYili ;
        public string SayfaSayisi;
        public string Adet;
        public string Fiyat;
        public string Dil;
        public string Kategori;
        public string KapakTuru;
        public string YayinEviNo;
        public string YazarNo;
        void islem()
        {
            NpgsqlConnection con = new NpgsqlConnection("Server=localhost; Port=5432; Database=Depo; User Id=postgres; Password=564592123;");
            DataSet dataset = new DataSet();
            con.Open();

            string sql = "SELECT * FROM \"depo\".\"kitap\"";

            NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, con);
            add.Fill(dataset);


            data_grid.DataSource = dataset.Tables[0];


            con.Close();
        }
        void ekle()

        {
        
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost; Port=5432; Database=Depo; User Id=postgres; Password=564592123;");
                DataSet dataset = new DataSet();
                con.Open();

                string sql = "INSERT INTO \"depo\".\"kitap\" (\"kitapKodu\",\"isim\",\"fiyat\",\"basimYiliKitap\",\"sayfaSayisi\",\"yayinEviNo\",\"yazarNo\",\"dilNo\",\"adet\") VALUES('" + KitapKodu + "', '" + İsim + "','" + Fiyat + "','" + BasimYili + "','" + SayfaSayisi + "','" + YayinEviNo + "','" + YazarNo + "', '" + Dil + "', '" + Adet + "')";

                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, con);
                add.Fill(dataset);
                data_grid.DataSource = dataset.Tables[0];
            }
            catch (Exception)
            {
                islem();
                MessageBox.Show("Kitap Eklendi!");
                   
            }

            
        }
        void sil()
        {
            
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost; Port=5432; Database=Depo; User Id=postgres; Password=564592123;");
                DataSet dataset = new DataSet();
                con.Open();

                string sql = "DELETE FROM \"depo\".\"kitap\" WHERE \"kitapKodu\"='"+KitapKodu+"'";

                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, con);
                add.Fill(dataset);
                data_grid.DataSource = dataset.Tables[0];
            }
            catch (Exception)
            {
                islem();
                MessageBox.Show("Silindi!");
                    
            }
        }
        void guncelle()
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost; Port=5432; Database=Depo; User Id=postgres; Password=564592123;");
                DataSet dataset = new DataSet();
                con.Open();

               string sql = "UPDATE  \"depo\".\"kitap\" SET \"kitapKodu\"= '"+KitapKodu+ "',\"isim\"= '" + İsim + "',\"fiyat\"= '" + Fiyat + "',\"basimYiliKitap\"= '" + BasimYili + "',\"sayfaSayisi\"= '" + SayfaSayisi + "',\"yayinEviNo\"= '" + YayinEviNo + "',\"yazarNo\"= '" + YazarNo + "',\"dilNo\"= '" + Dil + "',\"adet\"= '" + Adet + "' WHERE \"kitapKodu\"= '" + KitapKodu + "'";

                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, con);
                add.Fill(dataset);
                data_grid.DataSource = dataset.Tables[0];
            }
            catch (Exception)
            {
                

                islem();
                MessageBox.Show("Güncellendi!");
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_kategori.SelectedIndex==0)
            {
                konu_lbl.Visible = true;
                konu_lbl.Text = "Tür";
                txt_konu.Visible = true;
                kt_lbl.Visible = true;
                txt_kapak.Visible = true;
            }
            if (cmb_kategori.SelectedIndex == 1)
            {
                konu_lbl.Visible = true;
                konu_lbl.Text = "Konu";
                txt_konu.Visible = true;
                kt_lbl.Visible = true;
                txt_kapak.Visible = true;
            }
            if (cmb_kategori.SelectedIndex == 2)
            {
                konu_lbl.Visible = true;
                konu_lbl.Text = "İçerik";
                txt_konu.Visible = true;
                kt_lbl.Visible = true;
                txt_kapak.Visible = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            islem();
            konu_lbl.Visible = false;
            txt_konu.Visible = false;
            kt_lbl.Visible = false;
            txt_kapak.Visible = false;
            btn_Ekle.Visible = false;
            btn_guncelle.Visible = false;
            btn_Sil.Visible = false;
            btn_geri.Visible = false;
        }

        private void btn_islem_Click(object sender, EventArgs e)
        {
            btn_geri.Visible = true;
            btn_Ekle.Visible = true;
            btn_guncelle.Visible = true;
            btn_Sil.Visible = true;

            txt_kapak.Visible = false;
            kt_lbl.Visible = false;
            konu_lbl.Visible = false;
            txt_konu.Visible = false;
            btn_islem.Visible = false;

            KitapKodu = txt_kitapKodu.Text;
             İsim = txt_k_isim.Text;
             BasimYili = txt_b_yili.Text;
             SayfaSayisi = txt_s_sayisi.Text;
             Adet = txt_adet.Text;
             Fiyat = txt_fiyat.Text;
             Dil = txt_dil.Text;
             Kategori = cmb_kategori.Text;
             KapakTuru = txt_kapak.Text;
             YayinEviNo= txt_yayinEviNo.Text;
             YazarNo = txt_yazarNo.Text;

            
            
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            guncelle();
            btn_Ekle.Visible = false;
            btn_guncelle.Visible = false;
            btn_Sil.Visible = false;
            btn_islem.Visible = true;
            btn_geri.Visible = false;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            sil();
            btn_Ekle.Visible = false;
            btn_guncelle.Visible = false;
            btn_Sil.Visible = false;
            btn_islem.Visible = true;
            btn_geri.Visible = false;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            ekle();
            btn_Ekle.Visible = false;
            btn_guncelle.Visible = false;
            btn_Sil.Visible = false;
            btn_islem.Visible = true;
            btn_geri.Visible = false;
        }

        private void data_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = data_grid.SelectedCells[0].RowIndex;
            string KitapKodu = data_grid.Rows[secim].Cells[0].Value.ToString();
            string İsim = data_grid.Rows[secim].Cells[1].Value.ToString();
            string BasimYili = data_grid.Rows[secim].Cells[2].Value.ToString();
            string SayfaSayisi = data_grid.Rows[secim].Cells[3].Value.ToString();            
            string YayinEviNo = data_grid.Rows[secim].Cells[4].Value.ToString();
            string YazarNo = data_grid.Rows[secim].Cells[5].Value.ToString();
            string Fiyat = data_grid.Rows[secim].Cells[6].Value.ToString();
            string Adet = data_grid.Rows[secim].Cells[7].Value.ToString();
            string Dil = data_grid.Rows[secim].Cells[8].Value.ToString();


            txt_kitapKodu.Text = KitapKodu;
            txt_k_isim.Text = İsim;
            txt_b_yili.Text = BasimYili;
            txt_s_sayisi.Text = SayfaSayisi;
            txt_adet.Text = Adet;
            txt_fiyat.Text = Fiyat;
            txt_yayinEviNo.Text = YayinEviNo;
            txt_yazarNo.Text = YazarNo;
            txt_dil.Text = Dil;
        }

        private void txt_YazarEkle_Click(object sender, EventArgs e)
        {
            Degisim d = new Degisim();
            d.ShowDialog();
        }

        private void btn_YEEkle_Click(object sender, EventArgs e)
        {
            YayinEvi y = new YayinEvi();
            y.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            Ara ara = new Ara();
            ara.ShowDialog();
        }

        private void btn_Topla_Click(object sender, EventArgs e)
        {
            Miktar miktar = new Miktar();
            miktar.ShowDialog();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            Dolanım dol = new Dolanım();
            dol.ShowDialog();
        }

        private void btn_fiyatTopla_Click(object sender, EventArgs e)
        {
            Fiyat fiy = new Fiyat();
            fiy.ShowDialog();

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            txt_kapak.Visible = true;
            kt_lbl.Visible = true;
            konu_lbl.Visible = true;
            txt_konu.Visible = true;
            btn_islem.Visible = true;
            btn_Ekle.Visible = false;
            btn_guncelle.Visible = false;
            btn_Sil.Visible = false;
            btn_geri.Visible = false;
            txt_kapak.Visible = false;
            kt_lbl.Visible = false;
            konu_lbl.Visible = false;
            txt_konu.Visible = false;

        }
    }
}
