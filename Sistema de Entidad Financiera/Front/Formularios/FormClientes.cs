using Back;
using Back.Clases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front.Formularios
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            formInicio.Show();
            this.Hide();
        }

        private void ActualizarlaLista()
        {
            ListaClientes.DataSource = Principal.ListaRetornarClientes();
            ListaClientes.DisplayMember = "NCD";
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text == "" || txtApellidoCliente.Text == "" || txtDniCliente.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos solicitados.");
            }
            else
            {
                Principal.AgregarCliente(txtNombreCliente.Text, txtApellidoCliente.Text, int.Parse(txtDniCliente.Text));
                ActualizarlaLista();

                txtNombreCliente.Text = "";
                txtApellidoCliente.Text = "";
                txtDniCliente.Text = "";

                MessageBox.Show("Cliente agregado con exito.");
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (ListaClientes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un cliente a eliminar.");
            }
            else
            {
                Cliente clienteSeleccionado = (Cliente)ListaClientes.SelectedItem;
                Principal.EliminarCliente(clienteSeleccionado.Id);
                ActualizarlaLista();

                MessageBox.Show("Cliente eliminado con exito.");
            }
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            Principal.Db_context.Clientes.Load();
            ListaClientes.DataSource = null;
            ListaClientes.DataSource = Principal.Db_context.Clientes.ToList();
            ListaClientes.DisplayMember = "NCD";

            ActualizarlaLista();
        }
    }
}
