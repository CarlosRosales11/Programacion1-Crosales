using Back.Clases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CuentaBancaria> CuentasBancarias { get; set; }
        public DbSet<TarjetadeCredito> TarjetasDeCredito { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)           
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-DT711V1\\SQLEXPRESS;database=SistemaEntidadFinancieraDB;trusted_connection=true;Encrypt=False");
        }
    }
}
