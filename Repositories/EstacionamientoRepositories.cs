using System.Collections.Generic;
using ElParqueito.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ElParqueito.Repositories
{
    public class EstacionamientosRepositories 
    {
        private CadenaDeParqueosContext db;
        public EstacionamientosRepositories()
        {
            db = new CadenaDeParqueosContext();
        }
         public List<Estacionamiento> ObtenerEstacionamientos()
        {
        var estacionamiento = db.Estacionamientos.Include(x => x.vehiculo).ToList();
        db.SaveChanges();
        return estacionamiento;
        }

        public Estacionamiento ObtenerEstacionamiento(int id)
        {
            var resultado= db.Estacionamientos.Find(id);
            db.SaveChanges();
            return resultado;
        }


         public int AgregarEstacionamiento(Estacionamiento nuevoEstacionamiento)
         {
             var resultado =db.Estacionamientos.Add(nuevoEstacionamiento);
             db.SaveChanges();
             return resultado.Entity.Id;
         }
         
          public Estacionamiento ActualizarEstacionamiento (Estacionamiento nuevoEstacionamiento)
         {
           var EstacionamientoActual =db.Estacionamientos.Find(nuevoEstacionamiento.Id);
           db.Estacionamientos.Remove(EstacionamientoActual);
           db.Estacionamientos.Add(nuevoEstacionamiento);
           db.SaveChanges();
           return nuevoEstacionamiento;

         }
         public Estacionamiento DeleteEstacionamiento (int id)
         {
          var EstacionamientoActual =db.Estacionamientos.Find(id);
          var resultado = db.Estacionamientos.Remove(EstacionamientoActual);
          db.SaveChanges();
          return resultado.Entity;
         }
    }   
}