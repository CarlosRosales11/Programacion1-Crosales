using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class CuentaBancaria
    {
        public int Id { get; set; }
        public string NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }
        public string Tipo { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Monto { get; set; }
    }
}
