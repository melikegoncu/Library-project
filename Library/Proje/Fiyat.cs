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
    public partial class Fiyat : Form
    {
        public Fiyat()
        {
            InitializeComponent();
        }
        public string YayinEviNo;
        void FiyatSonuc()
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost; Port=5432; Database=Depo; User Id=postgres; Password=564592123;");
                DataSet dataset = new DataSet();
                con.Open();

                string sql = "SELECT * FROM \"depo\".\"fiyatToplami\" (" + YayinEviNo + ")";

                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, con);
                add.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
            }
            catch (Exception)
            {

                MessageBox.Show("Toplandı!");

            }
        }
        private void Fiyat_Load(object sender, EventArgs e)
        {
            btn_f_kayit.Visible = true;
            btn_f_topla.Visible = false;
        
    }

        private void btn_f_kayit_Click(object sender, EventArgs e)
        {
            YayinEviNo = txt_Yayin.Text;
            btn_f_kayit.Visible = false;
            btn_f_topla.Visible = true;
        }

        private void btn_f_topla_Click(object sender, EventArgs e)
        {
            FiyatSonuc();
            btn_f_kayit.Visible = true;
            btn_f_topla.Visible = false;
        }
    }
}
