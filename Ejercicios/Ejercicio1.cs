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
            LimpiarPagina();
            ListarPersonajes();
        }

        private void btnListarPersonajes_Click(object sender, EventArgs e)
        {
            ListarPersonajes();
            LimpiarPagina();
        }

        private void btnEliminarPersonajes_Click(object sender, EventArgs e)
        {
            EliminarPersonajes();
            LimpiarPagina();
            ListarPersonajes();
        }

        private void btnBuscarPersonajes_Click(object sender, EventArgs e)
        {
            BuscarPersonajes();
            CheckSeleccion();
        }

        private void btnModificarPersonajes_Click(object sender, EventArgs e)
        {
            HabilitarTxtBoxs();
            DeshabilitarBtnModificar();
            OcultarBtnModificar();
            HabilitarBtnConfirmarCambios();
            DeshabilitarBtns();
        }

        private void btnConfirmarCambios_Click_1(object sender, EventArgs e)
        {
            ModificarPersonajes();
            LimpiarPagina();
            ListarPersonajes();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            LimpiarPagina();
        }

        private void Ejercicio1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void CheckSeleccion()
        {
            if (controladorPersonajes.personajeSeleccionado == true)
            {
                LlenarTxtBoxs();
                HabilitarBtnModificar();
                HabilitarBtnEliminar();
                DeshabilitarBtnIngresar();
            }
            else
                LimpiarPagina();

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
            txtBoxId.Text = "";
            txtBoxNombre.Text = "";
            txtBoxApellido.Text = "";
            txtBoxNovela.Text = "";
            txtBoxUniverso.Text = "";
        }
        private void HabilitarTxtBoxs()
        {
            txtBoxNombre.ReadOnly = false;
            txtBoxApellido.ReadOnly = false;
            txtBoxNovela.ReadOnly = false;
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
        private void MostrarBtnModificar()
        {
            btnModificarPersonajes.Visible = true;
        }
        private void HabilitarBtnConfirmarCambios()
        {
            btnConfirmarCambios.Enabled = true;
            btnConfirmarCambios.Visible = true;
        }
        private void DeshabilitarBtnConfirmarCambios()
        {
            btnConfirmarCambios.Enabled = false;
            btnConfirmarCambios.Visible = false;
        }

        private void OcultarBtnModificar()
        {
            btnModificarPersonajes.Visible = false;
        }

        private void EliminarPersonajes()
        {
            controladorPersonajes.EliminarPersonaje(Convert.ToInt32(txtBoxId.Text));
        }
        private void ModificarPersonajes()
        {
            controladorPersonajes.ModificarPersonajes(Convert.ToInt32(txtBoxId.Text), txtBoxNombre.Text, txtBoxApellido.Text, txtBoxNovela.Text, txtBoxUniverso.Text);
        }

        private void LimpiarPagina()
        {
            LimpiarTxtBoxs();
            HabilitarTxtBoxs();
            HabilitarBtns();
            DeshabilitarBtnConfirmarCambios();
            DeshabilitarBtnModificar();
            DeshabilitarBtnEliminar();
            MostrarBtnModificar();
        }


        private void HabilitarBtns()
        {
            btnIngresarPersonajes.Enabled = true;
            btnListarPersonajes.Enabled = true;
            btnBuscarPersonajes.Enabled = true;
        }
        private void DeshabilitarBtns()
        {
            DeshabilitarBtnIngresar();
            btnListarPersonajes.Enabled = false;
            btnBuscarPersonajes.Enabled = false;
        }

        private void DeshabilitarBtnIngresar()
        {
            btnIngresarPersonajes.Enabled = false;
        }

        private void DeshabilitarBtnEliminar()
        {
            btnEliminarPersonajes.Enabled = false;
        }

        private void HabilitarBtnEliminar()
        {
            btnEliminarPersonajes.Enabled = true;
        }

        private void btnLimpiarPagina_Click(object sender, EventArgs e)
        {
            ListarPersonajes();
            LimpiarPagina();
        }
    }
}
