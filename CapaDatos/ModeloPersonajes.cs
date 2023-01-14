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
        public int idPersonaje;
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
            CrearConexion();
            CrearComando();
            CrearParametros();
            command.CommandText = "INSERT INTO Personajes (nombre, apellido, novela, universo)" + 
                " VALUES(@nombre, @apellido, @novela, @universo);";

            command.Parameters["@nombre"].Value = nombre;
            command.Parameters["@apellido"].Value = apellido;
            command.Parameters["@novela"].Value = novela;
            command.Parameters["@universo"].Value = universo;


            command.ExecuteNonQuery();
            Console.WriteLine("Personaje ingresado");
            CerrarConexion();
        }

        public void ListarTablaPersonajes()
        {
            CrearConexion();
            CrearComando();
            LimpiarTabla();
            command.CommandText = "Select * from Personajes;";
            dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            CerrarConexion();
        }

        public void BuscarPersonajes(string nombre)
        {
            CrearConexion();
            CrearComando();
            LimpiarTabla();
            CrearParametros();
            command.CommandText = "SELECT * FROM Personajes WHERE nombre = @nombre;";
            command.Parameters["@nombre"].Value = nombre;
            dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            CerrarConexion();
        }

        public void ModificarPersonaje(int id, string nombre, string apellido, string novela, string universo)
        {
            CrearConexion();
            CrearComando();
            CrearParametros();
            command.CommandText = "UPDATE Personajes " +
                "SET nombre = @nombre, " +
                "apellido = @apellido, " +
                "novela = @novela, " +
                "universo = @universo " +
                "WHERE id = @id;";
            command.Parameters["@id"].Value = id;
            command.Parameters["@nombre"].Value = nombre;
            command.Parameters["@apellido"].Value = apellido;
            command.Parameters["@novela"].Value = novela;
            command.Parameters["@universo"].Value = universo;
            command.ExecuteNonQuery();
            CerrarConexion();
        }

        public void EliminarPersonaje(int id)
        {
            CrearConexion();
            CrearComando();
            CrearParametros();
            command.CommandText = "DELETE from Personajes WHERE id = @id";
            command.Parameters["@id"].Value = id;
            command.ExecuteNonQuery();
            CerrarConexion();
        }

        private void LimpiarTabla()
        {
            dataTable.Clear();

        }

        private void CrearParametros()
        {
            command.Parameters.Clear();
            command.Parameters.Add("@id", MySqlDbType.Int32);
            command.Parameters.Add("@nombre", MySqlDbType.String);
            command.Parameters.Add("@apellido", MySqlDbType.String);
            command.Parameters.Add("@novela", MySqlDbType.String);
            command.Parameters.Add("@universo", MySqlDbType.String);
        }

    }
}
