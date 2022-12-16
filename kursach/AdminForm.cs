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
            table = "student_1";
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
            sort_asc(toolStripTextBox1.Text);
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
            select_table("diplom_1");
        }
        private void факультетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select_table("facultet_1");
        }
        private void группаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select_table("gruppa_1");
        }
        private void кафедраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select_table("kafedra_1");
        }
        private void количествоЧасовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select_table("kolichestvo_chasov_1");
        }
        private void оценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select_table("ocenki_1");
        }
        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select_table("sotrudnik_1");
        }
        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select_table("student_1");
        }
        private void учебнаяНагрузкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select_table("ychebnaya_nagruzka_1");
        }
        private void учебныйПланToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select_table("ychebniy_plan_1");
        }
        private void защитаКатегорииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select_table("zashita_kategorii_1");
        }
        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select_table("users_1");
        }
        private void применитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"update  kursach." + table + " set " + update_header + " = '" + toolStripTextBox4.Text + "' where "+ Convert.ToString(dataGridView1.Columns[0].HeaderCell.Value) + " = "+update_id+";";
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
            sort_desc(toolStripTextBox1.Text);
        }

        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*var hit = dataGridView1.HitTest(e.X, e.Y);
            dataGridView1.ClearSelection();
            string message = hit.ColumnX.ToString();
            string caption = "Ошибка удаления";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            //sort_asc(Convert.ToString(dataGridView1.Columns[hit.ColumnIndex].HeaderCell.Value));*/
        }
        public void select_table(string tbl)
        {
            try
            {
                table = tbl;
                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from kursach."+tbl+";";
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
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Ошибка выборки";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }
        public void sort_asc(string header)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from kursach." + table + " order by \"" + header + "\";";
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
        public void sort_desc(string header)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from kursach." + table + " order by \"" + header + "\" desc;";
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

        private void добавитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (table)
            {
                case "diplom_1":
                    diplom_insert diplom_Insert = new diplom_insert();
                    diplom_Insert.ShowDialog();
                    select_table("diplom_1");
                    break;

                case "facultet_1":
                    facultet_ins facultet_Ins = new facultet_ins();
                    facultet_Ins.ShowDialog();
                    select_table("facultet_1");
                    break;

                case "gruppa_1":
                    gruppa_insert gruppa_Insert = new gruppa_insert();
                    gruppa_Insert.ShowDialog();
                    select_table("gruppa_1");
                    break;

                case "kafedra_1":
                    kafedra_insert kafedra_Insert = new kafedra_insert();
                    kafedra_Insert.ShowDialog();
                    select_table("kafedra_1");
                    break;

                case "kolichestvo_chasov_1":
                    kolichestvo_chasov_insert kolichestvo_Chasov_Insert = new kolichestvo_chasov_insert();
                    kolichestvo_Chasov_Insert.ShowDialog();
                    select_table("kolichestvo_chasov_1");
                    break;

                case "ocenki_1":
                    ocenki_insert ocenki_Insert = new ocenki_insert();
                    ocenki_Insert.ShowDialog();
                    select_table("ocenki_1");
                    break;

                case "sotrudnik_1":
                    sotrudnik_insert sotrudnik_Insert = new sotrudnik_insert();
                    sotrudnik_Insert.ShowDialog();
                    select_table("sotrudnik_1");
                    break;

                case "student_1":
                    student_insert student_Insert = new student_insert();
                    student_Insert.ShowDialog();
                    select_table("student_1");
                    break;

                case "ychebnaya_nagruzka_1":
                    ychebnaya_nagruzka_insert ychebnaya_Nagruzka_Insert = new ychebnaya_nagruzka_insert();
                    ychebnaya_Nagruzka_Insert.ShowDialog();
                    select_table("ychebnaya_nagruzka_1");
                    break;

                case "ychebniy_plan_1":
                    ychebniy_plan_insert ychebniy_Plan_Insert = new ychebniy_plan_insert();
                    ychebniy_Plan_Insert.ShowDialog();
                    select_table("ychebniy_plan_1");
                    break;

                case "zashita_kategorii_1":
                    zashita_kategorii_insert zashita_Kategorii_Insert = new zashita_kategorii_insert();
                    zashita_Kategorii_Insert.ShowDialog();
                    select_table("zashita_kategorii_1");
                    break;

                default:
                break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void удалитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                NpgsqlConnection con = new NpgsqlConnection();
                con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"delete from kursach." + table + " where " + table + ".\"" + Convert.ToString(dataGridView1.Columns[0].HeaderCell.Value) + "\" = '" + update_id + "';";
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
    }
    
}
