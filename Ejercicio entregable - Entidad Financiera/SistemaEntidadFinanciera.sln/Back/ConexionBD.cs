using Back.Clases;
using Microsoft.EntityFrameworkCore;

namespace Back.ConexionBD
{
    public class ConexionBD
    {
        public class BancoDbContext : DbContext
        {
            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<CuentaBancaria> CuentasBancarias { get; set; }
            public DbSet<TarjetaCredito> TarjetasCredito { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("DESKTOP-DT711V1\\SQLEXPRESS;database=SistemaEntidadFinanciera.sln;trusted_connection=true;Encrypt=False");
            }
        }
    }
}
