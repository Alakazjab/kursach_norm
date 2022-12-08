using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class Register : Form
    {
        MainForm childForm;
        public Register(string data)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new EmailAddressAttribute().IsValid(textBox1.Text))
            {
                if (textBox3.Text == textBox2.Text)
                {
                    NpgsqlConnection con = new NpgsqlConnection();
                    con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText =
                        "Select * from kursach.users where email=\'"
                        + textBox1.Text + "\';";
                    con.Open();
                    NpgsqlDataReader rdr = cmd.ExecuteReader();
                    ArrayList records = new ArrayList();
                    if (!rdr.HasRows)
                    {
                        con.Close();                       
                        cmd.Connection = con;
                        cmd.CommandText = "call kursach.register_user('" + textBox1.Text + "'::character varying,'" + BCrypt.Net.BCrypt.HashPassword(textBox2.Text) + "'::character varying)";
                        con.Open();
                        cmd.ExecuteReader();
                        childForm = new MainForm(textBox1.Text);
                        childForm.Show();
                        con.Close();
                    }
                    else
                    {
                        string message = "Пользователь с данным адресом уже существует";
                        string caption = "Ошибка регистрации";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        // Displays the MessageBox.
                        result = MessageBox.Show(message, caption, buttons);
                        con.Close();
                    }
                }
                else
                {
                    string message = "пароли не совпадают";
                    string caption = "Ошибка регистрации";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                }
            }
            else
            {
                string message = "поле email заполнено неверно";
                string caption = "Ошибка регистрации";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }
    }
}
