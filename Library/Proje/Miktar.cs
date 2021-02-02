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
    public partial class Miktar : Form
    {
        public Miktar()
        {
            InitializeComponent();
        }
        public string yazarNo;
        void Miktarsonuc()
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost; Port=5432; Database=Depo; User Id=postgres; Password=564592123;");
                DataSet dataset = new DataSet();
                con.Open();

                string sql = "SELECT * FROM \"depo\".\"miktarToplami\" (" + yazarNo + ")";

                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, con);
                add.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
            }
            catch (Exception)
            {

                MessageBox.Show("Bulundu!");

            }
        }


        private void Miktar_Load(object sender, EventArgs e)
        {
            btn_kayit.Visible = true;
            btn_topla.Visible = false;
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            yazarNo = txt_yazar.Text;

            btn_kayit.Visible = false;
            btn_topla.Visible = true;
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            Miktarsonuc();
            btn_kayit.Visible = true;
            btn_topla.Visible = false;
        }
    }
}
