﻿using System;
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
    public partial class Dolanım : Form
    {
        public Dolanım()
        {
            InitializeComponent();
        }

        void Dolanim()
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost; Port=5432; Database=Depo; User Id=postgres; Password=564592123;");
                DataSet dataset = new DataSet();
                con.Open();

                string sql = "SELECT * FROM \"depo\".\"kayitDolanimi\"()";

                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, con);
                add.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
            }
            catch (Exception)
            {

                MessageBox.Show("Listelendi!");

            }
        }

        private void Dolanım_Load(object sender, EventArgs e)
        {
            Dolanim();
        }
    }
}
