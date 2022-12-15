using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using Npgsql;
using System.Collections;
using System.Data.Common;
using System.Security.Cryptography;

namespace kursach
{
    public partial class Login : Form
    {
        AdminForm childForm;
        MainForm childForm1;
        bool connection;
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            connection = false;
            while (connection == false) 
            { 
                try
                {
                    NpgsqlConnection con = new NpgsqlConnection();
                    con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    connection = true;
                }
                catch
                {
                    string message = "Ошибка подключения к базе данных";
                    string caption = "Ошибка подключения";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.OK)
                    {
                        connection = false;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
             if (new EmailAddressAttribute().IsValid(textBox1.Text))
             {
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(textBox2.Text);
                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * from kursach.users where email=\'" + textBox1.Text + "\';";
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows && BCrypt.Net.BCrypt.Verify(textBox2.Text, rdr.GetString(1)))
                {
                    rdr.Close();
                    cmd.CommandText = $"select role from kursach.users where email = '" + textBox1.Text + "';";
                    rdr = cmd.ExecuteReader();
                    rdr.Read();
                    if (rdr.GetString(0) == "admin")
                    {
                        this.Visible = false;
                        childForm = new AdminForm(textBox1.Text);
                        childForm.Show();
                        con.Close();
                    }
                    else
                    {
                        childForm1 = new MainForm(textBox1.Text);
                        childForm1.Show();
                        this.Visible = false;
                        con.Close();
                    }
                }
                else
                {
                    string message = "Логин или пароль неверны";
                    string caption = "Ошибка входа";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    con.Close();
                }         
                                                  
             }
             else
            {
                string message = "поле email заполнено неверно";
                string caption = "Ошибка входа";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register childForm = new Register();
            childForm.Show();
            this.Visible=false;
        }
    }
}
