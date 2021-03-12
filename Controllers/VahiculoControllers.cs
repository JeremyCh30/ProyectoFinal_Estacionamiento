using System.Collections.Generic;
using ElParqueito.Models;
using ElParqueito.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ElParqueito.Controllers
{

[ApiController]

[Route("[controller]")]

 public class VehiculosController : ControllerBase 
 {


    private VehiculosRepository vehiculosRepository;

    public VehiculosController()
    {
      vehiculosRepository = new VehiculosRepository();
    }   
     private List<Vehiculo> Vehiculos = new List<Vehiculo>(){

      new Vehiculo()
    };

     [HttpGet]
     public List<Vehiculo> GetVehiculos(){

     return vehiculosRepository.obtenerVehiculos();
   }
 
   [HttpGet] 
   [Route("{id}")]
   
     public Vehiculo GetVehiculo([FromRoute ]int id)
  {

    var Vehiculo =vehiculosRepository.ObtenerVehiculo(id);

    return Vehiculo;
  }

 [HttpPost]

  public string Agregarvehiculo ([FromBody] Vehiculo nuevoVehiculo)
  {
    var resultado = vehiculosRepository.AgregarVehiculos(nuevoVehiculo);
    return "Producto agregado ID:" + " "+ resultado ;

  }
  

  [HttpPut]

 public Vehiculo ActualizarVehiculo([FromBody] Vehiculo nuevoVehiculo)
  {
    var Vehiculo =vehiculosRepository.ActualizarVehiculo(nuevoVehiculo);
    return Vehiculo;
  }

  [HttpDelete]

  public string DeleteVehiculo ([FromQuery] int id)
  {
    var Vehiculo = vehiculosRepository.DeleteVehiculo(id);
    return "Se eliminó el vehiculo" +"  "+ Vehiculo.Placa;
  }

}
}