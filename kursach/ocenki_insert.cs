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
    public partial class ocenki_insert : Form
    {
        public ocenki_insert()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ocenki_insert_Load(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection();
            con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"select * from kursach.student_fio;";
            con.Open();
            NpgsqlDataReader rdr = cmd.ExecuteReader();
            ArrayList records = new ArrayList();
            if (rdr.HasRows)
                foreach (DbDataRecord rec in rdr)
                    //dataSet1.Tables.(rec);
                    comboBox1.Items.Add(rec.GetString(0));
            rdr.Close();
            cmd.CommandText = $"select * from kursach.sotrudnic_fio;";
            rdr = cmd.ExecuteReader();
            records.Clear();
            if (rdr.HasRows)
                foreach (DbDataRecord rec in rdr)
                    //dataSet1.Tables.(rec);
                    comboBox2.Items.Add(rec.GetString(0));
            rdr.Close();
            cmd.CommandText = $"select * from kursach.ychplan_nazv;";
            rdr = cmd.ExecuteReader();
            records.Clear();
            if (rdr.HasRows)
                foreach (DbDataRecord rec in rdr)
                    //dataSet1.Tables.(rec);
                    comboBox3.Items.Add(rec.GetString(0));
            con.Close();
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Class1.insert(
                    $"call kursach.ocenki_insert(" +
                    $"{comboBox1.SelectedIndex + 1}," +
                    $"'{dateTimePicker1.Text}'::date," +
                    $"{textBox1.Text}," +
                    $"{comboBox2.SelectedIndex + 1}," +
                    $"{comboBox3.SelectedIndex + 1}," +
                    $"'{textBox2.Text}'::character varying);");
                this.Close();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Ошибка добавления";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }
    }
}
