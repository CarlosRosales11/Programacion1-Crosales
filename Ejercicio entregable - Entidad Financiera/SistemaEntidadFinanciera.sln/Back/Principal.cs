using Back.Clases;
using Microsoft.EntityFrameworkCore;
using System.Text;
using static Back.ConexionBD.ConexionBD;

namespace Back
{
    public class Principal
    {
        BancoDbContext db_Context = new BancoDbContext();

        public void AgregarCliente(Cliente cliente)
        {
            db_Context.Clientes.Add(cliente);
            db_Context.SaveChanges();
        }

        public void CrearCuentaBancaria(int clienteId, string numeroCuenta, decimal saldo, string tipo)
        {
            var cliente = db_Context.Clientes.Find(clienteId);
            if (cliente == null)
            {
                throw new Exception("Cliente no encontrado");
            }

            var cuenta = new CuentaBancaria
            {
                NumeroCuenta = numeroCuenta,
                Saldo = saldo,
                Tipo = tipo,
                ClienteId = clienteId
            };

            db_Context.CuentasBancarias.Add(cuenta);
            db_Context.SaveChanges();
        }

        public void EmitirTarjetaCredito(int clienteId, string numeroTarjeta, decimal limiteCredito, string estado)
        {
            var cliente = db_Context.Clientes.Find(clienteId);
            if (cliente == null)
            {
                throw new Exception("Cliente no encontrado");
            }

            var tarjeta = new TarjetaCredito
            {
                NumeroTarjeta = numeroTarjeta,
                LimiteCredito = limiteCredito,
                SaldoDisponible = limiteCredito,
                Estado = estado,
                ClienteId = clienteId
            };

            db_Context.TarjetasCredito.Add(tarjeta);
            db_Context.SaveChanges();
        }

        public void PausarTarjetaCredito(int clienteId, string numeroTarjeta, string estado)
        {
            var tarjeta = db_Context.TarjetasCredito
                .Where(t => t.ClienteId == clienteId && t.NumeroTarjeta == numeroTarjeta)
                .FirstOrDefault();

            if (tarjeta != null)
            {
                tarjeta.Estado = estado;
                db_Context.SaveChanges();
            }
        }

        public void RealizarDeposito(int cuentaId, decimal monto)
        {
            var cuenta = db_Context.CuentasBancarias.Find(cuentaId);
            if (cuenta != null)
            {
                cuenta.Saldo += monto;
                db_Context.SaveChanges();
            }
        }

        public void RealizarExtraccion(int cuentaId, decimal monto)
        {
            var cuenta = db_Context.CuentasBancarias.Find(cuentaId);
            if (cuenta != null)
            {
                if (cuenta.Saldo >= monto)
                {
                    cuenta.Saldo -= monto;
                    db_Context.SaveChanges();
                }
                else
                {
                    throw new Exception("Saldo insuficiente");
                }
            }
        }

        public void RealizarTransferencia(int cuentaOrigenId, int cuentaDestinoId, decimal montoTarjeta)
        {
            var cuentaOrigen = db_Context.CuentasBancarias.Find(cuentaOrigenId);
            var cuentaDestino = db_Context.CuentasBancarias.Find(cuentaDestinoId);

            if (cuentaOrigen != null && cuentaDestino != null)
            {
                if (cuentaOrigen.Saldo >= montoTarjeta)
                {
                    cuentaOrigen.Saldo -= montoTarjeta;
                    cuentaDestino.Saldo += montoTarjeta;
                    db_Context.SaveChanges();
                }
                else
                {
                    throw new Exception("Saldo insuficiente en la cuenta de origen");
                }
            }
        }

        public void PagarTarjetaCredito(int clienteId, string numeroTarjeta, decimal montoTarjeta)
        {
            var tarjeta = db_Context.TarjetasCredito
                .Where(t => t.ClienteId == clienteId && t.NumeroTarjeta == numeroTarjeta)
                .FirstOrDefault();

            if (tarjeta != null)
            {
                if (tarjeta.SaldoDisponible >= montoTarjeta)
                {
                    tarjeta.SaldoDisponible -= montoTarjeta;
                    db_Context.SaveChanges();
                }
                else
                {
                    throw new Exception("Saldo insuficiente en la tarjeta de crédito");
                }
            }
        }

        public void GenerarResumenTarjeta(int clienteId, string numeroTarjeta)
        {
           
        }  

    }
}