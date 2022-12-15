
namespace kursach
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сортировкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.отсортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дипломToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.факультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кафедраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоЧасовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учебнаяНагрузкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учебныйПланToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.защитаКатегорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.применитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 411);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаToolStripMenuItem1,
            this.таблицаToolStripMenuItem,
            this.удалениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сортировкаToolStripMenuItem1
            // 
            this.сортировкаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.отсортироватьToolStripMenuItem,
            this.поУбываниюToolStripMenuItem});
            this.сортировкаToolStripMenuItem1.Name = "сортировкаToolStripMenuItem1";
            this.сортировкаToolStripMenuItem1.Size = new System.Drawing.Size(85, 20);
            this.сортировкаToolStripMenuItem1.Text = "Сортировка";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // отсортироватьToolStripMenuItem
            // 
            this.отсортироватьToolStripMenuItem.Name = "отсортироватьToolStripMenuItem";
            this.отсортироватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отсортироватьToolStripMenuItem.Text = "По возростанию";
            this.отсортироватьToolStripMenuItem.Click += new System.EventHandler(this.сортировкаToolStripMenuItem1_Click);
            // 
            // таблицаToolStripMenuItem
            // 
            this.таблицаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дипломToolStripMenuItem,
            this.факультетToolStripMenuItem,
            this.группаToolStripMenuItem,
            this.кафедраToolStripMenuItem,
            this.количествоЧасовToolStripMenuItem,
            this.оценкиToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.студентыToolStripMenuItem,
            this.учебнаяНагрузкаToolStripMenuItem,
            this.учебныйПланToolStripMenuItem,
            this.защитаКатегорииToolStripMenuItem});
            this.таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            this.таблицаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.таблицаToolStripMenuItem.Text = "Таблица";
            // 
            // дипломToolStripMenuItem
            // 
            this.дипломToolStripMenuItem.Name = "дипломToolStripMenuItem";
            this.дипломToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.дипломToolStripMenuItem.Text = "Диплом";
            this.дипломToolStripMenuItem.Click += new System.EventHandler(this.дипломToolStripMenuItem_Click);
            // 
            // факультетToolStripMenuItem
            // 
            this.факультетToolStripMenuItem.Name = "факультетToolStripMenuItem";
            this.факультетToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.факультетToolStripMenuItem.Text = "Факультет";
            this.факультетToolStripMenuItem.Click += new System.EventHandler(this.факультетToolStripMenuItem_Click);
            // 
            // группаToolStripMenuItem
            // 
            this.группаToolStripMenuItem.Name = "группаToolStripMenuItem";
            this.группаToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.группаToolStripMenuItem.Text = "Группа";
            this.группаToolStripMenuItem.Click += new System.EventHandler(this.группаToolStripMenuItem_Click);
            // 
            // кафедраToolStripMenuItem
            // 
            this.кафедраToolStripMenuItem.Name = "кафедраToolStripMenuItem";
            this.кафедраToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.кафедраToolStripMenuItem.Text = "Кафедра";
            this.кафедраToolStripMenuItem.Click += new System.EventHandler(this.кафедраToolStripMenuItem_Click);
            // 
            // количествоЧасовToolStripMenuItem
            // 
            this.количествоЧасовToolStripMenuItem.Name = "количествоЧасовToolStripMenuItem";
            this.количествоЧасовToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.количествоЧасовToolStripMenuItem.Text = "Количество часов";
            this.количествоЧасовToolStripMenuItem.Click += new System.EventHandler(this.количествоЧасовToolStripMenuItem_Click);
            // 
            // оценкиToolStripMenuItem
            // 
            this.оценкиToolStripMenuItem.Name = "оценкиToolStripMenuItem";
            this.оценкиToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.оценкиToolStripMenuItem.Text = "Оценки";
            this.оценкиToolStripMenuItem.Click += new System.EventHandler(this.оценкиToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.студентыToolStripMenuItem.Text = "Студенты";
            this.студентыToolStripMenuItem.Click += new System.EventHandler(this.студентыToolStripMenuItem_Click);
            // 
            // учебнаяНагрузкаToolStripMenuItem
            // 
            this.учебнаяНагрузкаToolStripMenuItem.Name = "учебнаяНагрузкаToolStripMenuItem";
            this.учебнаяНагрузкаToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.учебнаяНагрузкаToolStripMenuItem.Text = "Учебная нагрузка";
            this.учебнаяНагрузкаToolStripMenuItem.Click += new System.EventHandler(this.учебнаяНагрузкаToolStripMenuItem_Click);
            // 
            // учебныйПланToolStripMenuItem
            // 
            this.учебныйПланToolStripMenuItem.Name = "учебныйПланToolStripMenuItem";
            this.учебныйПланToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.учебныйПланToolStripMenuItem.Text = "Учебный план";
            this.учебныйПланToolStripMenuItem.Click += new System.EventHandler(this.учебныйПланToolStripMenuItem_Click);
            // 
            // защитаКатегорииToolStripMenuItem
            // 
            this.защитаКатегорииToolStripMenuItem.Name = "защитаКатегорииToolStripMenuItem";
            this.защитаКатегорииToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.защитаКатегорииToolStripMenuItem.Text = "Защита категории";
            this.защитаКатегорииToolStripMenuItem.Click += new System.EventHandler(this.защитаКатегорииToolStripMenuItem_Click);
            // 
            // удалениеToolStripMenuItem
            // 
            this.удалениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2,
            this.toolStripTextBox3,
            this.удалитьToolStripMenuItem});
            this.удалениеToolStripMenuItem.Name = "удалениеToolStripMenuItem";
            this.удалениеToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.удалениеToolStripMenuItem.Text = "Удаление";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.ToolTipText = "Колонка";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox3.ToolTipText = "Значение";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox4,
            this.применитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 51);
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(100, 23);
            // 
            // применитьToolStripMenuItem
            // 
            this.применитьToolStripMenuItem.Name = "применитьToolStripMenuItem";
            this.применитьToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.применитьToolStripMenuItem.Text = "Применить";
            this.применитьToolStripMenuItem.Click += new System.EventHandler(this.применитьToolStripMenuItem_Click);
            // 
            // поУбываниюToolStripMenuItem
            // 
            this.поУбываниюToolStripMenuItem.Name = "поУбываниюToolStripMenuItem";
            this.поУбываниюToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поУбываниюToolStripMenuItem.Text = "По убыванию";
            this.поУбываниюToolStripMenuItem.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem отсортироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дипломToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem факультетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кафедраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоЧасовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учебнаяНагрузкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учебныйПланToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem защитаКатегорииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripMenuItem применитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem;
    }
}