using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class TarjetadeCredito
    {
        public TarjetadeCredito(double limiteCredito, double saldo)
        {
            LimiteCredito = limiteCredito;
            Estado = EstadosTarjetaCredito.Activo;
            Saldo = saldo;
            MontoDeuda = 0;
        }
        [Key] public int NumeroTarjeta { get; set; }
        public double LimiteCredito { get; set; }
        public double Saldo { get; set; }
        public double MontoDeuda { get; set; }
        public Cliente Titular { get; set; }
        public string NombreTitular { get; set; }
        public EstadosTarjetaCredito Estado { get; set; }
    }
}
