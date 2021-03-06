using System.Collections.Generic;
using ElParqueito.Models;
using Microsoft.EntityFrameworkCore;

namespace ElParqueito
{
    public class CadenaDeParqueosContext : DbContext
    {
        public DbSet<Vehiculo> Vehiculos { get; set; }

        public DbSet<Estacionamiento> Estacionamientos { get; set; }

        public DbSet<Factura> facturas { get; set; }

        public DbSet<Administrador> Administradores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=cadenaDeParqueos.db");

    }
}