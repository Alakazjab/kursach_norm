using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class MainForm : Form
    {
        public string a;
        public MainForm(string data)
        {
            InitializeComponent();
            a = data;
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection();
            con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from kursach.student_info where email = {a}";

            con.Open();
            NpgsqlDataReader rdr = cmd.ExecuteReader();
            ArrayList records = new ArrayList();
            if (rdr.HasRows)
                foreach (DbDataRecord rec in rdr)
                    records.Add(rec);
            con.Close();
            dataGridView1.DataSource = records;
        }
    }
}
