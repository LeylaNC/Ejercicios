using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;


namespace CapaLogica
{
    public class ControladorPersonajes
    {

        ModeloPersonajes modeloPersonajes = new ModeloPersonajes();
        public DataTable dataTable = new DataTable();
        public int idPersonaje;
        public bool personajeSeleccionado = false;
        public string nombre, apellido, novela, universo;

        public void IngresarPersonajes(string nombre, string apellido, string novela, string universo)
        {
            modeloPersonajes.IngresarPersonajes(nombre, apellido, novela, universo);
        }

        public void ListarTablaPersonajes()
        {
            modeloPersonajes.ListarTablaPersonajes();
            dataTable = modeloPersonajes.dataTable;
            personajeSeleccionado = false;
        }

        public void BuscarPersonajes(string nombre)
        {
            modeloPersonajes.BuscarPersonajes(nombre);
            dataTable = modeloPersonajes.dataTable;

            if (dataTable.Rows.Count == 1)
            {
                idPersonaje = dataTable.Rows[0].Field<int>("id");
                this.nombre = dataTable.Rows[0].Field<string>("nombre");
                apellido = dataTable.Rows[0].Field<string>("apellido");
                novela = dataTable.Rows[0].Field<string>("novela");
                universo = dataTable.Rows[0].Field<string>("universo");

                personajeSeleccionado = true;
            }
        }
    }
}
