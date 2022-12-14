using Npgsql;
using System;
using System.Collections;
using System.Data.Common;
using System.Windows.Forms;

namespace kursach
{
    public partial class zashita_kategorii_insert : Form
    {
        public zashita_kategorii_insert()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Class1.insert($"call kursach.zashita_kategorii_insert('{dateTimePicker1.Text}'::date,{comboBox1.SelectedIndex + 1},'{textBox4.Text}'::character varying,'{textBox1.Text}'::character varying);");
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

        private void zashita_kategorii_insert_Load(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection();
            con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"select * from kursach.sortudnic_fio;";
            con.Open();
            NpgsqlDataReader rdr = cmd.ExecuteReader();
            ArrayList records = new ArrayList();
            if (rdr.HasRows)
                foreach (DbDataRecord rec in rdr)
                    //dataSet1.Tables.(rec);
                    comboBox1.Items.Add(rec.GetString(0));
            con.Close();
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }
    }
}
