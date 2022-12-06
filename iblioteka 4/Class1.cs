using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace iblioteka_4
{
    public class ConnectDB
    {
        //public string host = "10.90.12.110";// делал это в чюки поэтому и две строки подключения 
        public string host = "chuc.caseum.ru";
        public string port = "33333";
        public string user = "st_1_20_25";
        public string data = "is_1_20_st25_KURS";
        public string passwprd = "77162854";
        public string connStr;
        public string con()// строка подключения
        {
            return connStr = $"server={host};port={port};user={user};database={data};password={passwprd};";
        }
    }
}
