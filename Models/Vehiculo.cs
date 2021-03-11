using System;
namespace ElParqueito.Models
{
    public class Vehiculo
    {
        public int Id{get; set;}

        public string Placa{get; set;}

        public string Tipo{get; set;}

        public Vehiculo(int nuevoId, string nuevaPlaca, string nuevoTipo){
            Id = nuevoId;
            Placa = nuevaPlaca;
            Tipo = nuevoTipo;
        }
        
        public Vehiculo()
        {
            
        } 


    }
}