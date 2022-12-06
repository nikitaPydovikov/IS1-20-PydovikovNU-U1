using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iblioteka_4;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task5
{
    public partial class Task5y : Form
    {
        ConnectDB f2 = new ConnectDB();
        MySqlConnection conn;
        private BindingSource bSource = new BindingSource();
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        DataTable table = new DataTable();
        public Task5y()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f2.con();
            conn = new MySqlConnection(f2.connStr);
            data();
        }

        void data()// Метод для создание таблицы в грид
        {
            conn.Open();
            string com = "SELECT * FROM t_Uchebka_Lebedev";
            table.Clear();
            table.Columns.Clear();
            MyDA.SelectCommand = new MySqlCommand(com, conn);
            dataGridView1.DataSource = bSource;
            bSource.DataSource = table;
            MyDA.Fill(table);

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string com = $"INSERT t_Uchebka_Lebedev(fioStud,datetimStud) VALUES ('{textBox2.Text}','{textBox1.Text}');";
                MySqlCommand command = new MySqlCommand(com, conn);
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show($"у вас не правильно указана дата или не правильно написано \n Пример: 10.04.21");
            }
            finally
            {
                conn.Close();
            }

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
