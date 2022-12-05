using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS1_20_PydovikovNU_U
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        MySqlConnection conn;      // Объявление 
        Connect MySql;             // Подключение 
        class Connect              // Класс подключения
        {
            string host = "chuc.caseum.ru";     
            string port = "33333";             
            string user = "uchebka";            
            string db = "uchebka";        
            string pass = "uchebka";        
            public string connStr;
            public string Conect() // Взятие данных
            {
                return connStr = $"server={host};Port={port};" +
                    $"User={user};DataBase={db};Password={pass};";
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            try
            {
                MySql = new Connect();
                MySql.Conect();                             // Подключение
                conn = new MySqlConnection(MySql.connStr);
                conn.Open();                                // Открытие БД
                conn.Close();                               // Закрытие БД
                MessageBox.Show("Сделано!");                // при успехе
            }
            catch
            {
                MessageBox.Show("Не сделано");              // при провале
            }
        }

        private void Task2_Load(object sender, EventArgs e)
        {

        }
    }
}
