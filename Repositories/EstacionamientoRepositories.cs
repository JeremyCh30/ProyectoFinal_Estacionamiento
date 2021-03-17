using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
using ElParqueito.Models;
using System.Linq;

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
        var estacionamiento = db.Estacionamientos.ToList();
        db.SaveChanges();
        return estacionamiento;
        }

        public Estacionamiento ObtenerEstacionamiento(int id)
        {
            var resultado= db.Estacionamientos.Find(id);
            System.Console.WriteLine(resultado);
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