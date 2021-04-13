using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
using ElParqueito.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace ElParqueito.Repositories
{
   public class AdministradorRepositories
   {
      private CadenaDeParqueosContext db;

      public AdministradorRepositories()
      {
         db = new CadenaDeParqueosContext();
      }

      public List<Administrador> ObtenerAdministradores()
      {
         var administradores = db.Administradores.ToList();
         db.SaveChanges();
         return administradores;
      }

      public Administrador ObtenerAdministrador(int id)
      {
         var resultado= db.Administradores.Find(id);
         db.SaveChanges();
         return resultado;
      }

      public int AgregarAdministrador(Administrador nuevoAdministrador)
      {
         var resultado =db.Administradores.Add(nuevoAdministrador);
         db.SaveChanges();
         return resultado.Entity.Id;
      }

      public Administrador ActualizarAdministrador (Administrador nuevoAdministrador)
      {
         var AdministradorActual =db.Administradores.Find(nuevoAdministrador.Id);
         db.Administradores.Remove(AdministradorActual);
         db.Administradores.Add(nuevoAdministrador);
         db.SaveChanges();
         return nuevoAdministrador;
      }

      public Administrador DeleteAdministrador (int id)
      {
         var AdministradorActual =db.Administradores.Find(id);
         var resultado = db.Administradores.Remove(AdministradorActual);
         db.SaveChanges();
         return resultado.Entity;
      }





        
   }
}