using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace Ejercicios
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        ControladorPersonajes controladorPersonajes = new ControladorPersonajes();

        private void btnCrearPersonajes_Click(object sender, EventArgs e)
        {
            controladorPersonajes.CrearTablaPersonajes();

        }

        private void btnListarPersonajes_Click(object sender, EventArgs e)
        {
            controladorPersonajes.ListarTablaPersonajes();
            dataGridViewListaPersonajes.DataSource = controladorPersonajes.dataTable;

        }


        private void Ejercicio1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
