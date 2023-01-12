using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class ModeloPersonajes : ModeloDB
    {
        public DataTable dataTable = new DataTable();
        public string nombre, apellido, novela, universo;

        public void TablaPersonajes()
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


        public void IngresarPersonajes(string nombre, string apellido, string novela, string universo)
        {
            //nombre = nombre;
            CrearConexion();
            CrearComando();
            //command.CommandText = "INSERT INTO Personajes VALUES (@nombre. @apellido, @novela, @universo);";
            command.CommandText = "INSERT INTO Personajes VALUES (nombre);";
            //command.Prepare.AddWithValue("@nombre" = nombre);
            //command.Prepare();
            command.ExecuteNonQuery();
            Console.WriteLine("Personajes creada");
            CerrarConexion();
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

    }
}
