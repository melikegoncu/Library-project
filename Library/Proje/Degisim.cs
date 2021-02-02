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
    public partial class Degisim : Form
    {
        public Degisim()
        {
            InitializeComponent();
        }

        public string YazarKodu;
        public string İsim;
        public string Soyisim;
        public string DogumTarih;
        public string DogumYer;
        public string İlKodu;

        void islem()
        {
            NpgsqlConnection con = new NpgsqlConnection("Server=localhost; Port=5432; Database=Depo; User Id=postgres; Password=564592123;");
            DataSet dataset = new DataSet();
            con.Open();

            string sql = "SELECT * FROM \"depo\".\"yazar\"";

            NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, con);
            add.Fill(dataset);


            dataGridView1.DataSource = dataset.Tables[0];


            con.Close();
        }
        void ekle()

        {

            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost; Port=5432; Database=Depo; User Id=postgres; Password=564592123;");
                DataSet dataset = new DataSet();
                con.Open();

                string sql = "INSERT INTO \"depo\".\"yazar\" (\"yazarKodu\",\"isim\",\"soyisim\",\"dogumTarihi\",\"dogumYeri\",\"ilKodu\") VALUES('" + YazarKodu + "', '" + İsim + "','" + Soyisim + "','" + DogumTarih + "','" + DogumYer + "','" + İlKodu + "')";

                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, con);
                add.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
            }
            catch (Exception)
            {
                islem();
                MessageBox.Show("Yazar Eklendi!");

            }

        }
        void sil()
        {

            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost; Port=5432; Database=Depo; User Id=postgres; Password=564592123;");
                DataSet dataset = new DataSet();
                con.Open();

                string sql = "DELETE FROM \"depo\".\"yazar\" WHERE \"yazarKodu\"='" + YazarKodu + "'";

                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, con);
                add.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
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

                string sql = "UPDATE \"depo\".\"yazar\" SET \"yazarKodu\"='" + YazarKodu + "',\"isim\"='" + İsim + "',\"soyisim\"='" + Soyisim + "',\"dogumTarihi\"='" + DogumTarih + "',\"dogumYeri\"='" + DogumYer + "',\"ilKodu\"='" + İlKodu + "'  WHERE \"yazarKodu\"='" + YazarKodu + "'"; 
                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, con);
                add.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
            }
            catch (Exception)
            {
                islem();
                MessageBox.Show("Güncellendi!");


            }
           

        }


        private void Degisim_Load(object sender, EventArgs e)
        {
            islem();
            btn_y_ekle.Visible = false;
            btn_y_guncelle.Visible = false;
            btn_y_sil.Visible = false;
            btn_d_geri.Visible = false;
        }

        private void btn_y_ekle_Click(object sender, EventArgs e)
        {
            ekle();
            btn_y_ekle.Visible = false;
            btn_y_guncelle.Visible = false;
            btn_y_sil.Visible = false;
            button1.Visible = true;
            btn_d_geri.Visible = false;
        }

        private void btn_y_guncelle_Click(object sender, EventArgs e)
        {
            guncelle();
            btn_y_ekle.Visible = false;
            btn_y_guncelle.Visible = false;
            btn_y_sil.Visible = false;
            button1.Visible = true;
            btn_d_geri.Visible = false;
        }

        private void btn_y_sil_Click(object sender, EventArgs e)
        {
            sil();
            btn_y_ekle.Visible = false;
            btn_y_guncelle.Visible = false;
            btn_y_sil.Visible = false;
            button1.Visible = true;
            btn_d_geri.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YazarKodu = txt_YazarKod.Text;
            İsim = txt_isim.Text;
            Soyisim = txt_soyisim.Text;
            DogumTarih = txt_d_tarih.Text;
            DogumYer = txt_d_yer.Text;
            İlKodu = txt_ilkodu.Text;
            btn_y_ekle.Visible = true;
            btn_y_guncelle.Visible = true;
            btn_y_sil.Visible = true;
            button1.Visible = false;
            btn_d_geri.Visible = true;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
             YazarKodu = dataGridView1.Rows[secim].Cells[0].Value.ToString();
             İsim = dataGridView1.Rows[secim].Cells[1].Value.ToString();
             Soyisim = dataGridView1.Rows[secim].Cells[2].Value.ToString();
             DogumTarih = dataGridView1.Rows[secim].Cells[3].Value.ToString();
             DogumYer = dataGridView1.Rows[secim].Cells[4].Value.ToString();
             İlKodu = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            


            txt_YazarKod.Text = YazarKodu;
            txt_isim.Text = İsim;
            txt_soyisim.Text = Soyisim;
            txt_d_tarih.Text = DogumTarih;
            txt_d_yer.Text = DogumYer;
            txt_ilkodu.Text = İlKodu;
            
        }

        private void btn_d_geri_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            btn_y_ekle.Visible = false;
            btn_y_guncelle.Visible = false;
            btn_y_sil.Visible = false;
            btn_d_geri.Visible = false;
        }
    }
}
