using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Library_Tracking_Program
{
    class Database
    {
        public readonly static string user_name = "root";
        public readonly static string password = "";
        public readonly static string db_name = "library";
        public readonly static string host = "localhost";
        public readonly static int port = 3306;

        public MySqlConnection conn;

        public static string strProvider = $"Data Source={host};port={port};" +
            $"Initial Catalog={db_name};User Id={user_name};password={password};Convert Zero DateTime=True";
        public bool Open()
        {
            try
            {
                conn = new MySqlConnection(strProvider);
                conn.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Connection Error!" + e.Message);
                return false;
            }

        }
        public void Close()
        {
            conn.Close();
            conn.Dispose();
            MySqlConnection.ClearPool(conn);
        }
    }
}
