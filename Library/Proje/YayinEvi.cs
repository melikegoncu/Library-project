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
    public partial class YayinEvi : Form
    {
        public YayinEvi()
        {
            InitializeComponent();
        }

        public string YayinEviKodu;
        public string Ad;
        public string TelNo;
        public string İlKodu;
        

        void islem3()
        {
            NpgsqlConnection con = new NpgsqlConnection("Server=localhost; Port=5432; Database=Depo; User Id=postgres; Password=564592123;");
            DataSet dataset = new DataSet();
            con.Open();

            string sql = "SELECT * FROM \"depo\".\"yayinEvi\"";

            NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, con);
            add.Fill(dataset);


            data_yayinevi.DataSource = dataset.Tables[0];


            con.Close();
        }
        void ekle3()

        {

            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost; Port=5432; Database=Depo; User Id=postgres; Password=564592123;");
                DataSet dataset = new DataSet();
                con.Open();

                string sql = "INSERT INTO \"depo\".\"yayinEvi\" (\"yayinEviKodu\",\"isim\",\"telNo\",\"ilKodu\") VALUES('" + YayinEviKodu + "', '" + Ad + "','" + TelNo + "','" + İlKodu + "')";

                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, con);
                add.Fill(dataset);
                data_yayinevi.DataSource = dataset.Tables[0];
            }
            catch (Exception)
            {
                islem3();
                MessageBox.Show("Yayınevi Eklendi!");

            }

        }
        void sil3()
        {

            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost; Port=5432; Database=Depo; User Id=postgres; Password=564592123;");
                DataSet dataset = new DataSet();
                con.Open();

                string sql = "DELETE FROM \"depo\".\"yayinEvi\" WHERE \"yayinEviKodu\"='" + YayinEviKodu + "'";

                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, con);
                add.Fill(dataset);
                data_yayinevi.DataSource = dataset.Tables[0];
            }
            catch (Exception)
            {
                islem3();
                MessageBox.Show("Silindi!");

            }
        }
        void guncelle3()
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost; Port=5432; Database=Depo; User Id=postgres; Password=564592123;");
                DataSet dataset = new DataSet();
                con.Open();

                string sql = "UPDATE \"depo\".\"yayinEvi\" SET \"yayinEviKodu\"='" + YayinEviKodu + "',\"isim\"='"+Ad+ "',\"telNo\"='"+TelNo+ "',\"ilKodu\"='"+ İlKodu+"' WHERE \"yayinEviKodu\"='"+YayinEviKodu+"'";

                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, con);
                add.Fill(dataset);
                data_yayinevi.DataSource = dataset.Tables[0];
            }
            catch (Exception)
            {
                islem3();
                MessageBox.Show("Güncellendi!");


            }
          

        }

        private void YayinEvi_Load(object sender, EventArgs e)
        {
            islem3();
            btn_e_ekle.Visible = false;
            btn_e_guncelle.Visible = false;
            btn_e_sil.Visible = false;
            btn_y_geri.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_e_ekle_Click(object sender, EventArgs e)
        {
            ekle3();
            btn_e_ekle.Visible = false;
            btn_e_guncelle.Visible = false;
            btn_e_sil.Visible = false;
            btn_e_islem.Visible = true;
            btn_y_geri.Visible = false;
        }

        private void btn_e_guncelle_Click(object sender, EventArgs e)
        {
            guncelle3();
            btn_e_ekle.Visible = false;
            btn_e_guncelle.Visible = false;
            btn_e_sil.Visible = false;
            btn_e_islem.Visible = true;
            btn_y_geri.Visible = false;
        }

        private void btn_e_sil_Click(object sender, EventArgs e)
        {
            sil3();
            btn_e_ekle.Visible = false;
            btn_e_guncelle.Visible = false;
            btn_e_sil.Visible = false;
            btn_e_islem.Visible = true;
            btn_y_geri.Visible = false;
        }

        private void btn_e_islem_Click(object sender, EventArgs e)
        {
            YayinEviKodu = txt_YEKodu.Text;
            Ad = txt_isim.Text;
            TelNo = txt_TelNo.Text;
            İlKodu = txt_İlKodu.Text;
            
            btn_e_ekle.Visible = true;
            btn_e_guncelle.Visible = true;
            btn_e_sil.Visible = true;
            btn_e_islem.Visible = false;
            btn_y_geri.Visible = true;
        }

        private void data_yayinevi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = data_yayinevi.SelectedCells[0].RowIndex;
            YayinEviKodu = data_yayinevi.Rows[secim].Cells[0].Value.ToString();
            Ad = data_yayinevi.Rows[secim].Cells[1].Value.ToString();
            TelNo = data_yayinevi.Rows[secim].Cells[2].Value.ToString();
            İlKodu = data_yayinevi.Rows[secim].Cells[3].Value.ToString();
           



            txt_YEKodu.Text = YayinEviKodu;
            txt_isim.Text = Ad;
            txt_TelNo.Text = TelNo;
            txt_İlKodu.Text = İlKodu;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void btn_y_geri_Click(object sender, EventArgs e)
        {
            
            btn_e_islem.Visible = true;
            btn_e_ekle.Visible = false;
            btn_e_guncelle.Visible = false;
            btn_e_sil.Visible = false;
            btn_y_geri.Visible = false;
            
        }
    }
}
