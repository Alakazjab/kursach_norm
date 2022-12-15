using kursach.Properties;
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
    public partial class AdminForm : Form
    {
        public string a;
        public string table;
        public string update_header;
        public string update_id;

        public AdminForm(string data)
        {
            InitializeComponent();
            a = data;
            table = "student";
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            NpgsqlConnection con = new NpgsqlConnection();
            con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"select * from kursach."+table+";";
            con.Open();
            NpgsqlDataReader rdr = cmd.ExecuteReader();
            ArrayList records = new ArrayList();
            if (rdr.HasRows)
                foreach (DbDataRecord rec in rdr)
                    //dataSet1.Tables.(rec);
                    records.Add(rec);
            con.Close();
            dataGridView1.DataSource = records;
            
        }
        private void сортировкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
               NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from kursach." + table + " order by " + toolStripTextBox1.Text + ";";
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                    foreach (DbDataRecord rec in rdr)
                        //dataSet1.Tables.(rec);
                        records.Add(rec);
                con.Close();
                dataGridView1.DataSource = records;
                toolStripTextBox1.Clear();
            }
            catch
            {
                string message = "Неверно введено название колонки";
                string caption = "Ошибка сортировки";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
            finally
            {
                toolStripTextBox1.Clear();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"delete from kursach." + table + " where " + table + ".\"" + toolStripTextBox2.Text + "\" = '" + toolStripTextBox3.Text + "';";
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                rdr.Close();
                cmd.CommandText = $"select * from kursach." + table + ";";
                rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                    foreach (DbDataRecord rec in rdr)
                        records.Add(rec);
                con.Close();
                dataGridView1.DataSource = records;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Ошибка удаления";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void дипломToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                table = "diplom";
                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from kursach.diplom;";
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                    foreach (DbDataRecord rec in rdr)
                        //dataSet1.Tables.(rec);
                        records.Add(rec);
                con.Close();
                dataGridView1.DataSource = records;
            }
            catch
            {
                string message = "Ошибка выборки";
                string caption = "Ошибка выборки";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void факультетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                table = "facultet";
                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from kursach.facultet;";
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                    foreach (DbDataRecord rec in rdr)
                        //dataSet1.Tables.(rec);
                        records.Add(rec);
                con.Close();
                dataGridView1.DataSource = records;
            }
            catch
            {
                string message = "Ошибка выборки";
                string caption = "Ошибка выборки";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void группаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                table = "gruppa";
                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from kursach.gruppa;";
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                    foreach (DbDataRecord rec in rdr)
                        //dataSet1.Tables.(rec);
                        records.Add(rec);
                con.Close();
                dataGridView1.DataSource = records;
            }
            catch
            {
                string message = "Ошибка выборки";
                string caption = "Ошибка выборки";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void кафедраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                table = "kafedra";
                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from kursach.kafedra;";
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                    foreach (DbDataRecord rec in rdr)
                        //dataSet1.Tables.(rec);
                        records.Add(rec);
                con.Close();
                dataGridView1.DataSource = records;
            }
            catch
            {
                string message = "Ошибка выборки";
                string caption = "Ошибка выборки";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void количествоЧасовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                table = "kolichestvo_chasov";
                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from kursach.kolichestvo_chasov;";
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                    foreach (DbDataRecord rec in rdr)
                        //dataSet1.Tables.(rec);
                        records.Add(rec);
                con.Close();
                dataGridView1.DataSource = records;
            }
            catch
            {
                string message = "Ошибка выборки";
                string caption = "Ошибка выборки";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void оценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                table = "ocenki";
                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from kursach.ocenki;";
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                    foreach (DbDataRecord rec in rdr)
                        //dataSet1.Tables.(rec);
                        records.Add(rec);
                con.Close();
                dataGridView1.DataSource = records;
            }
            catch
            {
                string message = "Ошибка выборки";
                string caption = "Ошибка выборки";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                table = "sotrudnik";
                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from kursach.sotrudnik;";
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                    foreach (DbDataRecord rec in rdr)
                        //dataSet1.Tables.(rec);
                        records.Add(rec);
                con.Close();
                dataGridView1.DataSource = records;
            }
            catch
            {
                string message = "Ошибка выборки";
                string caption = "Ошибка выборки";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                table = "student";
                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from kursach.student;";
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                    foreach (DbDataRecord rec in rdr)
                        //dataSet1.Tables.(rec);
                        records.Add(rec);
                con.Close();
                dataGridView1.DataSource = records;
            }
            catch
            {
                string message = "Ошибка выборки";
                string caption = "Ошибка выборки";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void учебнаяНагрузкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                table = "ychebnaya_nagruzka";
                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from kursach.ychebnaya_nagruzka;";
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                    foreach (DbDataRecord rec in rdr)
                        //dataSet1.Tables.(rec);
                        records.Add(rec);
                con.Close();
                dataGridView1.DataSource = records;
            }
            catch
            {
                string message = "Ошибка выборки";
                string caption = "Ошибка выборки";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void учебныйПланToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                table = "ychebniy_plan";
                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from kursach.ychebniy_plan;";
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                    foreach (DbDataRecord rec in rdr)
                        //dataSet1.Tables.(rec);
                        records.Add(rec);
                con.Close();
                dataGridView1.DataSource = records;
            }
            catch
            {
                string message = "Ошибка выборки";
                string caption = "Ошибка выборки";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void защитаКатегорииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                table = "zashita_kategorii";
                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from kursach.zashita_kategorii;";
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                    foreach (DbDataRecord rec in rdr)
                        //dataSet1.Tables.(rec);
                        records.Add(rec);
                con.Close();
                dataGridView1.DataSource = records;
            }
            catch
            {
                string message = "Ошибка выборки";
                string caption = "Ошибка выборки";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           // contextMenuStrip1.Show();
        }

        private void применитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"update  kursach." + table + " set " + update_header + " = '" + toolStripTextBox4.Text + "' where id = "+update_id+";";
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                rdr.Close();
                cmd.CommandText = $"select * from kursach." + table + ";";
                rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                    foreach (DbDataRecord rec in rdr)
                        //dataSet1.Tables.(rec);
                        records.Add(rec);
                con.Close();
                dataGridView1.DataSource = records;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Ошибка удаления";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.Select();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    DataGridViewCell cell = dataGridView1.Rows[hit.RowIndex].Cells[hit.ColumnIndex];
                    cell.Selected = true;
                    contextMenuStrip1.Show(dataGridView1, e.Location);
                    update_header = Convert.ToString(dataGridView1.Columns[hit.ColumnIndex].HeaderCell.Value);
                    update_id = Convert.ToString(dataGridView1.Rows[hit.RowIndex].Cells[0].Value);
                }
            }
        } 
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from kursach." + table + " order by " + toolStripTextBox1.Text + " desc;";
                con.Open();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                ArrayList records = new ArrayList();
                if (rdr.HasRows)
                    foreach (DbDataRecord rec in rdr)
                        //dataSet1.Tables.(rec);
                        records.Add(rec);
                con.Close();
                dataGridView1.DataSource = records;
                toolStripTextBox1.Clear();
            }
            catch
            {
                string message = "Неверно введено название колонки";
                string caption = "Ошибка сортировки";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
            finally
            {
                toolStripTextBox1.Clear();
            }
        }
    }
    
}
