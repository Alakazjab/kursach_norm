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
        Register childForm;
        MainForm childForm1;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (new EmailAddressAttribute().IsValid(textBox1.Text))
             {
                if (textBox2.Text != "")
                {
                    NpgsqlConnection con = new NpgsqlConnection();
                    con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = 
                        "Select * from kursach.users where email=\'"
                        + textBox1.Text +"\' and password =\'" + BCrypt.Net.BCrypt.HashPassword(textBox2.Text) + "\';";
                    con.Open();
                    NpgsqlDataReader rdr = cmd.ExecuteReader();
                    ArrayList records = new ArrayList();
                    if (rdr.HasRows)
                    {
                        childForm1 = new MainForm(textBox1.Text);
                        childForm1.Show();
                    }
                    else
                    {
                        string message = BCrypt.Net.BCrypt.HashPassword(textBox2.Text);
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
                    string message = "Поля логин и пароль должны быть заполнены";
                    string caption = "Ошибка входа";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
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
            childForm = new Register(textBox1.Text);
            childForm.Show();
        }
    }
}
