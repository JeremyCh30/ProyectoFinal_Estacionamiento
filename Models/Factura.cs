using System;
namespace ElParqueito.Models
{
    public class Factura 
    {
        public int Id{get; set;}

        public string Telefono{get; set;}

        public Estacionamiento estacionamiento{get; set;}

        
        public Factura(int nuevoId, string nuevoTelefono,Estacionamiento nuevoEstacinamiento){
            Id = nuevoId;
            Telefono = nuevoTelefono;
            estacionamiento = nuevoEstacinamiento;
        }
        
        public Factura()
        {
            
        } 


    }
}