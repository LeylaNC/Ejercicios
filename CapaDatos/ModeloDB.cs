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
        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();

        static string server = "localhost";
        static string database = "EjerciciosDB";
        static string user = "root";
        public static string connectionString = 
            "server=" + server +
            ";Database=" + database +
            ";User=" + user;

        MySqlDataReader dataReader;
        public DataTable dataTable = new DataTable();





        public void CrearConexion()
        {
            connection.ConnectionString = connectionString;
            connection.Open();
        }

        public void CrearComando()
        {
            command.Connection = connection;
        }

        public void CerrarConexion()
        {
            connection.Close();
        }



        public void ListarTablaPersonajes()
        {
            CrearConexion();
            CrearComando();
            command.CommandText = "Select * from Personajes";
            dataReader = command.ExecuteReader();

            dataTable.Load(dataReader);
            CerrarConexion();
        }

        public void CrearTablaPersonajes()
        {
            CrearConexion();
            CrearComando();
            command.CommandText = "DROP TABLE IF EXISTS Personajes;" + 
                "CREATE TABLE Personajes (" + 
                "id INT (10) AUTO_INCREMENT PRIMARY KEY," +
                "nombre VARCHAR (50)," +
                "apellido VARCHAR (50)," +
                "novela VARCHAR (50)," +
                "universo VARCHAR(100));";
            command.ExecuteNonQuery();
            Console.WriteLine("Personajes creada");
            CerrarConexion();
        }



    }
}
