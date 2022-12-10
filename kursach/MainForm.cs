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
        AdminForm childForm;
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
            cmd.CommandText = $"select role from kursach.users where email = '" + a + "';";
            con.Open();
            NpgsqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr.GetString(0) == "admin")
            {
                childForm = new AdminForm(a);
                childForm.Show();
                con.Close();
                this.Close();
            }
            else
            {
                con.Close();
                cmd.CommandText = $"select date, disciplina, forma_controlya, ocenka, prepod from kursach.student_info where email = '" + a + "';";
                con.Open();
                rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                {
                    foreach (DbDataRecord rec in rdr)
                        records.Add(rec);
                    rdr.Close();
                    cmd.CommandText = $"select stipendia from kursach.student_info where email = '" + a + "';";
                    rdr = cmd.ExecuteReader();
                    rdr.Read();
                    label1.Text += Convert.ToString(rdr.GetInt32(0));
                    con.Close();
                    dataGridView1.DataSource = records;
                }

                else
                {
                    string message = "необходимо привязать запись студента";
                    string caption = "Ошибка входа";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        // Closes the parent form.
                        this.Close();
                    }
                }
            }

        }
    }
}