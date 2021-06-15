using System;
using System.Data.SQLite;
using System.Data;

namespace SimpleMVC.Base
{
    class Database
    {
        private string DBName;
        public SQLiteConnection link = null;

        public Database()
        {
            DBName = Configuracion.Nombre_base_datos;
        }

        public DataSet Query(string command_string)
        {
            DataSet table = new DataSet();
            try
            {
                Connect();
                SQLiteCommand command = new SQLiteCommand(command_string, link);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(table);
                Close();
                return table;
            }
            catch(SQLiteException)
            {

            }
            return null;
        }

        public int NoQuery(string command_string)
        {
            try
            {
                Connect();
                SQLiteCommand command = new SQLiteCommand(command_string, link);
                int res = command.ExecuteNonQuery();
                Close();
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
            }
            return -1;
        }

        private void Connect()
        {
            try
            {
                link = new SQLiteConnection(string.Format("Data Source={0};Version=3;", DBName), true);
                link.Open();
            }
            catch (SQLiteException)
            {
            }
        }

        private void Close()
        {
            try
            {
                if (link != null)
                {
                    if (link.State == System.Data.ConnectionState.Open)
                    {
                        link.Close();
                        link = null;
                    }
                }
            }
            catch(SQLiteException)
            {

            }
        }
    }
}
