using Back.Clases;
using System.Text;

namespace Back
{
    public class Principal
    {
        ApplicationDbContext Db_context = new ApplicationDbContext();

        public void AgregarCliente(string NombreCliente, string ApellidoCliente, int DNICliente)
        {
            Cliente nuevoCliente = new Cliente(NombreCliente, ApellidoCliente, DNICliente);

            Db_context.Clientes.Add(nuevoCliente);
            Db_context.SaveChanges();
        }

        public void EliminarCliente(int idCliente)
        {
            Cliente clienteEncontrado = Db_context.Clientes.Find(idCliente);

            if (clienteEncontrado != null)
            {
                Db_context.Clientes.Remove(clienteEncontrado);
                Db_context.SaveChanges();
            }
        }

        public List<Cliente> ListaRetornarClientes()
        {
            return Db_context.Clientes.ToList();
        }

        public void CrearCuentaBancaria(Cliente Titular, TipodeCuentaBancaria Tipo)
        {
            CuentaBancaria nuevaCuenta = new CuentaBancaria();
            nuevaCuenta.Titular = Titular;
            nuevaCuenta.NombreTitular = Titular.NombreCompleto;
            nuevaCuenta.Saldo = 0;
            nuevaCuenta.Tipo = Tipo;

            Db_context.CuentasBancarias.Add(nuevaCuenta);
            Db_context.SaveChanges();
        }

        public List<CuentaBancaria> ListaRetornarCuentas()
        {
            return Db_context.CuentasBancarias.ToList();
        }

        public void RealizarDeposito(double Monto, int NroCuenta)
        {
            var cuentaEncontrada = Db_context.CuentasBancarias.Find(NroCuenta);

            if (Monto > 0)
            {
                if (cuentaEncontrada != null)
                {
                    cuentaEncontrada.Saldo += Monto;
                    Db_context.SaveChanges();
                }
            }
        }

        public void RealizarExtraccion(double Monto, int NroCuenta)
        {
            var cuentaEncontrada = Db_context.CuentasBancarias.Find(NroCuenta);

            if (cuentaEncontrada != null)
            {
                if (Monto > 0 && Monto <= cuentaEncontrada.Saldo)
                {
                    cuentaEncontrada.Saldo -= Monto;
                    Db_context.SaveChanges();
                }
            }
        }

        public void RealizarTransferencia(double Monto, int IdCuentaOrigen, int IdCuentaDestinatario)
        {
            if (Monto > 0)
            {
                var cuentaOrigen = Db_context.CuentasBancarias.Find(IdCuentaOrigen);
                var cuentaDestinatario = Db_context.CuentasBancarias.Find(IdCuentaDestinatario);

                if (cuentaOrigen != null && cuentaDestinatario != null && cuentaOrigen.Saldo >= Monto)
                {
                    cuentaOrigen.Saldo -= Monto;
                    cuentaDestinatario.Saldo += Monto;
                    Db_context.SaveChanges();
                }
            }
        }

        public void EmitirTarjetaCredito(Cliente Titular_, double LimiteCredito, double Saldo)
        {
            TarjetadeCredito nuevaTarjeta = new TarjetadeCredito(LimiteCredito, Saldo);
            nuevaTarjeta.Titular = Titular_;
            nuevaTarjeta.NombreTitular = Titular_.Nombre;

            Db_context.TarjetasDeCredito.Add(nuevaTarjeta);
            Db_context.SaveChanges();
        }

        public void CambiarEstadoTarjeta(int IdTarjeta, EstadosTarjetaCredito Estado)
        {
            var tarjetaEncontrada = Db_context.TarjetasDeCredito.Find(IdTarjeta);

            if (tarjetaEncontrada != null)
            {
                tarjetaEncontrada.Estado = Estado;
                Db_context.SaveChanges();
            }
        }

        public void PagarTarjetaCredito(double Monto, int IdTarjeta)
        {
            var tarjetaEncontrada = Db_context.TarjetasDeCredito.Find(IdTarjeta);

            if (tarjetaEncontrada != null)
            {
                if (tarjetaEncontrada.Estado == EstadosTarjetaCredito.Activo)
                {
                    tarjetaEncontrada.MontoDeuda += Monto;
                    Db_context.SaveChanges();
                }
            }
        }

        public string GenerarResumenTarjeta(int idTarjeta)
        {
            TarjetadeCredito tarjeta = Db_context.TarjetasDeCredito.Find(idTarjeta);
            if (tarjeta != null)
            {
                StringBuilder ret = new StringBuilder();

                ret.AppendLine("Resumen de su tarjeta:");
                ret.AppendLine("Numero de tarjeta: " + tarjeta.NumeroTarjeta);
                ret.AppendLine("Titular: " + tarjeta.Titular.NombreCompleto);
                ret.AppendLine("Limite credito: " + tarjeta.LimiteCredito);
                ret.AppendLine("Saldo: " + tarjeta.Saldo);
                ret.AppendLine("Deuda: " + tarjeta.MontoDeuda);
                ret.AppendLine("Estado: " + tarjeta.Estado);

                return ret.ToString();
            }
            return "Error";
        }
        public List<TarjetadeCredito> ListaRetornarTarjetas()
        {
            return Db_context.TarjetasDeCredito.ToList();
        }
    }
}