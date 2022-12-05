using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Task3.Program;

namespace IS1_20_PydovikovNU_U
{
    public partial class Task3 : Form
    {
        Connection f2 = new Connection();
        MySqlConnection conn; 
        private BindingSource bSource = new BindingSource();
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        DataTable table = new DataTable();// создание таблицы
        public Task3()
        {
            InitializeComponent();

        }

        private void Task3_Load(object sender, EventArgs e)
        {
            // подключение к БД
            f2.Conect();
            conn = new MySqlConnection(f2.connStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Создание таблицы
            conn.Open();
            table.Clear();// удаление всех данных
            table.Columns.Clear();// удаление всех столбцов
            string coooom = "SELECT Orders.id_Or,Client.id_cl,Orders.id_cl,Orders.id_ta,Orders.date_or FROM Orders INNER JOIN Client ON Client.id_cl = Orders.id_cl ORDER BY Client.id_cl; ";// это команда с INNER JOIN 
            MyDA.SelectCommand = new MySqlCommand(coooom);// добовляем комманду 
            dataGridView1.DataSource = bSource;//к гриду присваваем bSource
            bSource.DataSource = table;// к bSource присваеваем table
            MyDA.Fill(table);//выводим в гриде таблицу

            dataGridView1.Columns[2].Visible = false;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.ColumnHeadersVisible = true;
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                conn.Open();
                int rowIndex = e.RowIndex;      // Индекс строки
                int conIndex = e.ColumnIndex;   // Индекс колонки
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                if (conIndex == 1)              //Вывод при нажатие на 2 столбец
                {
                    string comm = $"SELECT * FROM Client WHERE id_cl = {row.Cells[conIndex].Value.ToString()};";// Команда для вызова строки в клиенте
                    MySqlCommand command = new MySqlCommand(comm);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        MessageBox.Show($"id Клиента {reader[0].ToString()} ФИО {reader[1].ToString()} Телефон {reader[2].ToString()} ");
                    }

                }
                else if (conIndex == 0)
                {
                    MessageBox.Show($"id покупки {row.Cells[conIndex].Value.ToString()}");
                }
                else if (conIndex == 3)// Вывод при нажатие на 3 столбец
                {
                    string comm = $"SELECT * FROM tariff WHERE id_ta = {row.Cells[conIndex].Value.ToString()};";// Команда для вызова строки в тарифе
                    MySqlCommand command = new MySqlCommand(comm);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        MessageBox.Show($"id билета {reader[0].ToString()} Наименование билета {reader[1].ToString()} цена билета {reader[2].ToString()} \n Описание билета: {reader[3].ToString()}");
                    }
                }
                else if (conIndex == 4)// Вывод при нажатие на 4 столбец 
                {
                    MessageBox.Show($"Время {row.Cells[conIndex].Value.ToString()} \n Теперь вы знаете точное время :)");
                }
            }
            catch
            { }
            finally
            {
                conn.Close();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Создание таблицы
            conn.Open();
            table.Clear();        // Удаление всех данных
            table.Columns.Clear();// Удаление всех столбцов
            string coooom = "SELECT Orders.id_Or,Client.id_cl,Orders.id_cl,Orders.id_ta,Orders.date_or FROM Orders INNER JOIN Client ON Client.id_cl = Orders.id_cl ORDER BY Client.id_cl; ";// это команда с INNER JOIN 
            MyDA.SelectCommand = new MySqlCommand(coooom);// Добовляем комманду 
            dataGridView1.DataSource = bSource; //К гриду присваваем bSource
            bSource.DataSource = table;         // К bSource присваеваем table
            MyDA.Fill(table);                   //Выводим в гриде таблицу

            dataGridView1.Columns[2].Visible = false;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.ColumnHeadersVisible = true;
            conn.Close();
        }
    }
}