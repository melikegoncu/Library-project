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
    public partial class Ara : Form
    {
        public Ara()
        {
            InitializeComponent();
        }
        public static string KitapKodu;
        public string İsim;
        public string BasimYili;
        public string SayfaSayisi;
        public string Adet;
        public string Fiyat;
        public string Dil;
        public string Kategori;
        public string KapakTuru;
        public string YayinEviNo;
        public string YazarNo;

        

        void ara()
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost; Port=5432; Database=Depo; User Id=postgres; Password=564592123;");
                DataSet dataset = new DataSet();
                con.Open();

                string sql = "SELECT * FROM \"depo\".\"kitapAra\" (" + KitapKodu + ")";

                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, con);
                add.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
            }
            catch (Exception)
            {

                MessageBox.Show("Bulundu!");

            }
        }

        private void Ara_Load(object sender, EventArgs e)
        {
            btn_kayıt.Visible = true;
            btn_Ara.Visible = false;
        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            KitapKodu=textBox1.Text;
            btn_kayıt.Visible = false;
            btn_Ara.Visible = true;
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            ara();
            btn_kayıt.Visible = true;
            btn_Ara.Visible = false;
        }
    }
}
