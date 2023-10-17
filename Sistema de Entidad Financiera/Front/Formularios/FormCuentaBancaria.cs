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
    public partial class FormCuentaBancaria : Form
    {
        public FormCuentaBancaria()
        {
            InitializeComponent();
        }

        private void btnVolverCuentaBancaria_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            formInicio.Show();
            this.Hide();
        }

        private void ActualizarDataGridView()
        {
            dataGridViewCuentaBancaria.DataSource = null;
            dataGridViewCuentaBancaria.DataSource = Principal.ListaRetornarCuentas();
            dataGridViewCuentaBancaria.Columns["Titular"].Visible = false;
        }

        private void btnRealizarTransferenciaCuentaBancaria_Click(object sender, EventArgs e)
        {
            FormRealizarTransferencia formRealizarTransferencia = new FormRealizarTransferencia();
            formRealizarTransferencia.Show();
            this.Hide();
            ActualizarDataGridView();
        }

        private void btnAgregarCuentaBancaria_Click(object sender, EventArgs e)
        {
            if (CBClienteTitularCuentaBancaria.SelectedItem == null || CBTipoCuentaBancaria.SelectedItem == null)
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
            else
            {
                TipodeCuentaBancaria tipoCuenta = (CBTipoCuentaBancaria.SelectedIndex == 0) ? TipodeCuentaBancaria.Ahorro : TipodeCuentaBancaria.Corriente;

                Principal.CrearCuentaBancaria((Cliente)CBClienteTitularCuentaBancaria.SelectedItem, tipoCuenta);

                ActualizarDataGridView();

                CBClienteTitularCuentaBancaria.SelectedIndex = -1;
                CBTipoCuentaBancaria.SelectedIndex = -1;
            }
        }

        private void btnRealizarDepositoCuentaBancaria_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtMontoCuentaBancaria.Text) <= 0)
            {
                MessageBox.Show("El monto ingresado es invalido.");
            }
            else
            {
                if (dataGridViewCuentaBancaria.SelectedRows == null)
                {
                    MessageBox.Show("Seleccione una cuenta");
                }
                else
                {
                    int indexFila = dataGridViewCuentaBancaria.CurrentCellAddress.Y;
                    Principal.RealizarDeposito((double)double.Parse(txtMontoCuentaBancaria.Text), (int)dataGridViewCuentaBancaria[0, indexFila].Value);
                    ActualizarDataGridView();

                    txtMontoCuentaBancaria.Text = "";
                }
            }
        }

        private void btnRealizarExtraccionCuentaBancaria_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtMontoCuentaBancaria.Text) <= 0)
            {
                MessageBox.Show("El monto ingresado es invalido.");
            }
            else
            {
                if (dataGridViewCuentaBancaria.SelectedRows == null)
                {
                    MessageBox.Show("Seleccione una cuenta.");
                }
                else
                {
                    int indexFila = dataGridViewCuentaBancaria.CurrentCellAddress.Y;
                    Principal.RealizarExtraccion((double)double.Parse(txtMontoCuentaBancaria.Text), (int)dataGridViewCuentaBancaria[0, indexFila].Value);
                    ActualizarDataGridView();

                    txtMontoCuentaBancaria.Text = "";

                }
            }
        }

        private void btnEliminarCuentaBancaria_Click(object sender, EventArgs e)
        {
            if (dataGridViewCuentaBancaria == null)
            {
                MessageBox.Show("Seleccione el cliente a eliminar.");
            }
            else
            {
                if (dataGridViewCuentaBancaria.SelectedRows.Count > 0)
                {
                    CuentaBancaria? cuentaSeleccionada = dataGridViewCuentaBancaria.SelectedRows[0].DataBoundItem as CuentaBancaria;

                    if (cuentaSeleccionada != null)
                    {
                        Principal.EliminarCuentaBancaria(cuentaSeleccionada.NumeroCuenta);
                        ActualizarDataGridView();
                    }
                }
            }
        }

        private void FormCuentaBancaria_Load(object sender, EventArgs e)
        {
            Principal.Db_context.Clientes.Load();
            Principal.Db_context.CuentasBancarias.Load();

            dataGridViewCuentaBancaria.DataSource = null;
            dataGridViewCuentaBancaria.DataSource = Principal.ListaRetornarClientes();

            CBClienteTitularCuentaBancaria.DataSource = null;
            CBClienteTitularCuentaBancaria.DataSource = Principal.ListaRetornarClientes();
            CBClienteTitularCuentaBancaria.DisplayMember = "NCD";

            ActualizarDataGridView();
        }
    }
}
