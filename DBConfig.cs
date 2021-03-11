using System.Collections.Generic;
using ElParqueito.Models;
using Microsoft.EntityFrameworkCore;

namespace ElParqueito
{
    public class CadenaDeParqueosContext : DbContext
    {
        public DbSet<Vehiculo> Vehiculos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=cadenaDeParqueos.db");
    }
}