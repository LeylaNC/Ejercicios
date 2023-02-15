using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class ModeloDB
    {
        protected MySqlConnection connection = new MySqlConnection();
        protected MySqlCommand command = new MySqlCommand();
        protected MySqlDataReader dataReader;

        static string server = "localhost";
        static string database = "EjerciciosDB";
        static string user = "root";
        public static string connectionString =  
            "server=" + server +
            ";Database=" + database +
            ";User=" + user + ";";

        public void CrearConexion()
        {
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
            }
            //Throw (MySqlException mySqlEx)
            //{
                //MessageBox.Show("")
                //Console.WriteLine("MySql error" + mySqlEx.Message);
            //}
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }

        }

        public void CrearComando()
        {
            command.Connection = connection;
        }

        public void CerrarConexion()
        {
            connection.Close();
        }

    }
}
