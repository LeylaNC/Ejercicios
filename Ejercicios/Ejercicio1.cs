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

        private void btnIngresarPersonajes_Click(object sender, EventArgs e)
        {
            IngresarPersonaje();
        }

        private void btnListarPersonajes_Click(object sender, EventArgs e)
        {
            ListarPersonajes();
            LimpiarTxtBoxs();
            DeshabilitarBtnModificar();
        }

        private void btnEliminarPersonajes_Click(object sender, EventArgs e)
        {
            EliminarPersonajes();
            DeshabilitarBtnModificar();
            LimpiarTxtBoxs();
            ListarPersonajes();
        }

        private void btnBuscarPersonajes_Click(object sender, EventArgs e)
        {
            BuscarPersonajes();
            CheckSeleccion();
        }
        private void btnModificarPersonajes_Click(object sender, EventArgs e)
        {
            ModificarPersonajes();
        }

        private void Ejercicio1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void IngresarPersonaje()
        {
            controladorPersonajes.IngresarPersonajes(txtBoxNombre.Text, txtBoxApellido.Text, txtBoxNovela.Text, txtBoxUniverso.Text);
        }
        private void ListarPersonajes()
        {
            controladorPersonajes.ListarTablaPersonajes();
            dataGridViewListaPersonajes.DataSource = controladorPersonajes.dataTable;
        }
        private void LimpiarTxtBoxs()
        {
            txtBoxNombre.Text = "";
            txtBoxNombre.ReadOnly = false;
            txtBoxApellido.Text = "";
            txtBoxApellido.ReadOnly = false;
            txtBoxNovela.Text = "";
            txtBoxNovela.ReadOnly = false;
            txtBoxUniverso.Text = "";
            txtBoxUniverso.ReadOnly = false;
        }
        private void DeshabilitarBtnModificar()
        {
            btnModificarPersonajes.Enabled = false;
        }
        private void BuscarPersonajes()
        {
            controladorPersonajes.BuscarPersonajes(txtBoxNombre.Text);
            dataGridViewListaPersonajes.DataSource = controladorPersonajes.dataTable;
        }
        private void CheckSeleccion()
        {
            if (controladorPersonajes.personajeSeleccionado == true)
            {
                LlenarTxtBoxs();
                HabilitarBtnModificar();
            }
            else
                DeshabilitarBtnModificar();
        }
        private void LlenarTxtBoxs()
        {
            txtBoxId.Text = controladorPersonajes.idPersonaje.ToString();
            txtBoxNombre.ReadOnly = true;
            txtBoxNombre.Text = controladorPersonajes.nombre;
            txtBoxApellido.ReadOnly = true;
            txtBoxApellido.Text = controladorPersonajes.apellido;
            txtBoxNovela.ReadOnly = true;
            txtBoxNovela.Text = controladorPersonajes.novela;
            txtBoxUniverso.ReadOnly = true;
            txtBoxUniverso.Text = controladorPersonajes.universo;
        }
        private void HabilitarBtnModificar()
        {
                btnModificarPersonajes.Enabled = true;
        }
        private void EliminarPersonajes()
        {
            //controladorPersonajes.EliminarPersonajes(txtBoxNombre.Text, txtBoxApellido.Text, txtBoxNovela.Text, txtBoxUniverso.Text);
        }
        private void ModificarPersonajes()
        {
            //controladorPersonajes.ModificarPersonajes(txtBoxNombre.Text, txtBoxApellido.Text, txtBoxNovela.Text, txtBoxUniverso.Text)
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            ListarPersonajes();
        }

    }
}
