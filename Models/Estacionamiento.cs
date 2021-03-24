using System.Threading;
namespace ElParqueito.Models
{
    public class Estacionamiento
    {
        public int Id{get;set;}
        public int HoraDeEntrada{get;set;}
        public int numeroPosicion{get;set;}
        public virtual Vehiculo vehiculo{get;set;}
        public int HoraDeSalida{get;set;}
        public int Cobro{get;set;}

        public Estacionamiento(int nuevoId, int nuevaHoraDeEntra, int nuevoNumeroPosicion, Vehiculo nuevoVehiculo)
        {
            Id = nuevoId;
            HoraDeEntrada=nuevaHoraDeEntra;
            numeroPosicion=nuevoNumeroPosicion;
            vehiculo=nuevoVehiculo;
        }
        public Estacionamiento(){

        }



    }
}