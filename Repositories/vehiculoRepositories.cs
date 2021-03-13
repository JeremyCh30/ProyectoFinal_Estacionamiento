using System.Collections.Generic;
using ElParqueito.Models;
using System.Linq;

namespace ElParqueito.Repositories
{
    public class VehiculosRepository 
    {
        private CadenaDeParqueosContext db;

        public VehiculosRepository()

        {
            db = new CadenaDeParqueosContext();
        }

         public List<Vehiculo> obtenerVehiculos()
        {
        var vehiculos = db.Vehiculos.ToList();
        db.SaveChanges();
        return vehiculos;
        }

         public int AgregarVehiculos(Vehiculo nuevoVehiculo)
         {
             var resultado =db.Vehiculos.Add(nuevoVehiculo);
             db.SaveChanges();
             return resultado.Entity.Id;
         }

          public Vehiculo ObtenerVehiculo(int id)
         {
            var resultado= db.Vehiculos.Find(id);
            db.SaveChanges();
            return resultado;
         }
         
          public Vehiculo ActualizarVehiculo (Vehiculo nuevoVehiculo)
         {
           var VehiculoActual =db.Vehiculos.Find(nuevoVehiculo.Id);
           db.Vehiculos.Remove(VehiculoActual);
           db.Vehiculos.Add(nuevoVehiculo);
           db.SaveChanges();
           return nuevoVehiculo;

         }
         public Vehiculo DeleteVehiculo (int id)
         {
          var VehiculoActual =db.Vehiculos.Find(id);
          var resultado = db.Vehiculos.Remove(VehiculoActual);
          db.SaveChanges();
          return resultado.Entity;
         }
    }   
}