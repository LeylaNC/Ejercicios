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

        ModeloDB modeloDB = new ModeloDB();
        public DataTable dataTable = new DataTable();

        public void CrearTablaPersonajes()
        {
            modeloDB.CrearTablaPersonajes();
        }

        public void ListarTablaPersonajes()
        {
            modeloDB.ListarTablaPersonajes();
            dataTable = modeloDB.dataTable;

        }
    }
}
