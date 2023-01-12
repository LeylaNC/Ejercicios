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

        public void IngresarPersonajes(string nombre, string apellido, string novela, string universo)
        {
            modeloPersonajes.IngresarPersonajes(nombre, apellido, novela, universo);
        }

        public void ListarTablaPersonajes()
        {
            modeloPersonajes.ListarTablaPersonajes();
            dataTable = modeloPersonajes.dataTable;

        }
    }
}
