using MySql.Data.MySqlClient;
using System.Data;

namespace TableShop
{
    public class DB
    {
        private static MySqlConnection connection = new MySqlConnection("server = localhost; userid = root; password = ; database = table_shop");
        private static DataSet ds;
        private static MySqlDataAdapter adapter;

        public static void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public static void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private static MySqlConnection GetConnection()
        {
            return connection;
        }

        public static DataSet LoadData(string str)
        {
            adapter = new MySqlDataAdapter(str, GetConnection());
            ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
    }
}