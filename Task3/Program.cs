using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public class Connection             // Класс подключения
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
    }
}
