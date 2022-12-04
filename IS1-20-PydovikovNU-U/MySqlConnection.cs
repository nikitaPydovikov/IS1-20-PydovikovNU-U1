using System;

namespace IS1_20_PydovikovNU_U
{
    internal class MySqlConnection
    {
        private string connStr;

        public MySqlConnection(string connStr)
        {
            this.connStr = connStr;
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal object Open()
        {
            throw new NotImplementedException();
        }
    }
}