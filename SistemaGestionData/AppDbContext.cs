using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductoVendido> ProductosVendidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=MXS-CDF43E03;Database=dbSistemaGestion;Trusted_Connection=True; encrypt=false";
            
            optionsBuilder.UseSqlServer(connectionString);

        }
    }
}

