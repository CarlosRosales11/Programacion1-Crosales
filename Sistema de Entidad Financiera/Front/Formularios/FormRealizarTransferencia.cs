using Back.Clases;
using Back;
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
    public partial class FormRealizarTransferencia : Form
    {
        public FormRealizarTransferencia()
        {
            InitializeComponent();
        }

        private void btnVolverTransferencia_Click(object sender, EventArgs e)
        {
            FormCuentaBancaria formCuentaBancaria = new FormCuentaBancaria();
            formCuentaBancaria.Show();
            this.Hide();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            if (CBRealizarTransferenciaDe.SelectedItem == null || CBRealizarTransferenciaA.SelectedItem == null || double.Parse(txtMontoTransferencia.Text) <= 0)
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
            else
            {
                Principal.RealizarTransferencia((double)double.Parse(txtMontoTransferencia.Text), ((CuentaBancaria)CBRealizarTransferenciaDe.SelectedItem).NumeroCuenta, ((CuentaBancaria)CBRealizarTransferenciaA.SelectedItem).NumeroCuenta);

                txtMontoTransferencia.Text = "";
                CBRealizarTransferenciaDe.Text = "";
                CBRealizarTransferenciaA.Text = "";

                MessageBox.Show("Transferencia realizada con exito.");
            }
        }

        private void FormRealizarTransferencia_Load(object sender, EventArgs e)
        {
            CBRealizarTransferenciaDe.DataSource = Principal.ListaRetornarCuentas();
            CBRealizarTransferenciaDe.DisplayMember = "NombreTitular";
            CBRealizarTransferenciaA.DataSource = Principal.ListaRetornarCuentas();
            CBRealizarTransferenciaA.DisplayMember = "NombreTitular";
        }
    }
}
