using System;
namespace ElParqueito.Models
{
    public class Factura 
    {
        public int Id{get; set;}

        public string Telefono{get; set;}

        public Estacionamiento informacionParqueo{get; set;}


        public Factura(int nuevoId, string nuevoTelefono){
            Id = nuevoId;
            Telefono = nuevoTelefono;
        }
        
        public Factura()
        {
            
        } 


    }
}