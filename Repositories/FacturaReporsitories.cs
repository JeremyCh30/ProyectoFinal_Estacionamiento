using System.Collections.Generic;
using ElParqueito.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ElParqueito.Repositories
{
    public class FacturasRepositories 
    {
        private CadenaDeParqueosContext db;
        public FacturasRepositories()
        {
            db = new CadenaDeParqueosContext();
        }
         public List<Factura> ObtenerFacturas()
        {
        var estacionamiento = db.facturas.Include(y=>y.estacionamiento).ToList();
        db.SaveChanges();
        return estacionamiento;
        }

        public Factura ObtenerFactura(int id)
        {
            var resultado= db.facturas.Find(id);
            db.SaveChanges();
            return resultado;
        }


         public int AgregarFactura(Factura nuevaFactura)
         {
             var resultado =db.facturas.Add(nuevaFactura);
             db.SaveChanges();
             return resultado.Entity.Id;
         }
        
    }   
}