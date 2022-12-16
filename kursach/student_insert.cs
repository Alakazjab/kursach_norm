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
    public partial class student_insert : Form
    {
        public student_insert()
        {
            InitializeComponent();
        }

        private void student_insert_Load(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection();
            con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"select shifr from kursach.gruppa;";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Class1.insert(
                    $"call kursach.diplom_insert(" +
                    $"'{textBox1.Text}'," +
                    $"'{textBox2.Text}'," +
                    $"'{textBox3.Text}'," +
                    $"{comboBox1.SelectedIndex + 1}," +
                    $"'{(radioButton1.Checked == true ? radioButton1.Text : radioButton2.Text)}'" +
                    $"'{dateTimePicker1.Value}'," +
                    $"{textBox4.Text}," +
                    $"'{(radioButton4.Checked == true ? '0' : '1')}'" +
                    $"'{textBox6.Text}');");
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
