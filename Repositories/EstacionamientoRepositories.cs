using System.Collections.Generic;
using ElParqueito.Models;
using System.Linq;

namespace ElParqueito.Repositories
{
    public class EstacionamientoRepositories 
    {
        private CadenaDeParqueosContext db;
        public EstacionamientoRepositories()
        {
            db = new CadenaDeParqueosContext();
        }
         public List<Estacionamiento> ObtenerEstacionamiento()
        {
        var estacionamiento = db.Estacionamientos.ToList();
        db.SaveChanges();
        return estacionamiento;
        }
         public int AgregarEstacionamiento(Estacionamiento nuevoEstacionamiento)
         {
             var resultado =db.Estacionamientos.Add(nuevoEstacionamiento);
             db.SaveChanges();
             return resultado.Entity.Id;
         }
          public Estacionamiento ObtenerEstacionamiento(int id)
         {
            var resultado= db.Estacionamiento.Find(id);
            db.SaveChanges();
            return resultado;
         }
          public Estacionamiento ActualizarEstacionamiento (Estacionamiento nuevoEstacionamiento)
         {
           var EstacionamientoActual =db.Estacionamiento.Find(nuevoEstacionamiento.Id);
           db.Estacionamiento.Remove(EstacionamientoActual);
           db.Estacionamiento.Add(nuevoEstacionamiento);
           db.SaveChanges();
           return nuevoEstacionamiento;

         }
         public Estacionamiento DeleteEstacionamiento (int id)
         {
          var EstacionamientoActual =db.Estacionamiento.Find(id);
          var resultado = db.Estacionamiento.Remove(EstacionamientoActual);
          db.SaveChanges();
          return resultado.Entity;
         }
    }   
}