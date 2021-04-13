using System;
namespace ElParqueito.Models
{
    public class Administrador
    {
        public int Id{get;set;}
        public string Usuario{get;set;}
        public string Contrasenna{get;set;}
    
        public Administrador(int nuevoId, string nuevoUsuario, string nuevaContrasenna)
        {
            Id = nuevoId;
            Usuario = nuevoUsuario;
            Contrasenna = nuevaContrasenna;
        }

        public Administrador(){

        }

    }
}