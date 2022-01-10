using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Simply
{
    class DataBase
    {
        MySqlConnection Login = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=simply;");

        //open function
        public void openConnection()
        {
            if (Login.State == System.Data.ConnectionState.Closed)
            {
                Login.Open();
            }
        }

        //close function
        public void closeConnection()
        {
            if (Login.State == System.Data.ConnectionState.Open)
            {
                Login.Close();
            }
        }

        //return function
        public MySqlConnection getConnection()
        {
            return Login;
        }
    }
}
