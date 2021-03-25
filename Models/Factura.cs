using System;
namespace ElParqueito.Models
{
    public class Factura 
    {
        public int Id{get; set;}

        public string Telefono{get; set;}

        public Estacionamiento estacionamiento{get; set;}

        
        public Factura(int nuevoId, string nuevoTelefono,Estacionamiento nuevoEstacinaminto ){
            Id = nuevoId;
            Telefono = nuevoTelefono;
           
            estacionamiento = nuevoEstacinaminto;
        }
        
        public Factura()
        {
            
        } 


    }
}