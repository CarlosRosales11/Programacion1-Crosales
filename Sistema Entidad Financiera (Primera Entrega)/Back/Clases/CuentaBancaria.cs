using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class CuentaBancaria
    {
        [Key] public int NumeroCuenta { get; set; }
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }
        public string NombreTitular { get; set; }
        public TipodeCuentaBancaria Tipo { get; set; }
    }
}
