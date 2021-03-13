using System.Collections.Generic;
using ElParqueito.Models;
using ElParqueito.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ElParqueito.Controllers
{

[ApiController]

[Route("[controller]")]

 public class EstacionamientoController : ControllerBase 
 {


    private EstacionamientoRepositories EstacionamientoRepository;

    public EstacionamientoController()
    {
      EstacionamientoRepository = new EstacionamientoRepository();
    }   
     private List<Estacionamiento> Estacionamientos = new List<Estacionamiento>(){

      new Estacionamiento()
    };

     [HttpGet]
     public List<Estacionamiento> GetEstacionamiento(){

     return vehiculosRepository.ObtenerEstacionamiento();
   }
 
   [HttpGet] 
   [Route("{id}")]
   
     public Vehiculo GetEstacionamiento([FromRoute ]int id)
  {
    var Estacionamiento =EstacionamientoRepository.ObtenerEstacionamiento(id);
    return Estacionamiento;
  }

 [HttpPost]
  public string AgregarEstacionamiento ([FromBody] Estacionamiento nuevoEstacionamiento)
  {
    var resultado = EstacionamientoRepository.AgregarEstacionamiento(nuevoEstacionamiento);
    return "Estacionamiento agregado con:" + " "+ resultado ;
  }
  [HttpPut]
 public Estacionamiento ActualizarEstacionamiento([FromBody] Estacionamiento nuevoEstacionamiento)
  {
    var estacionamiento =EstacionamientoRepository.ActualizarEstacionamiento(nuevoEstacionamiento);
    return estacionamiento;
  }
  [HttpDelete]
  public string DeleteEstacionamiento ([FromQuery] int id)
  {
    var estacionamiento = EstacionamientoRepository.DeleteEstacionamiento(id);
    return "Se eliminó el vehiculo" +"  "+ estacionamineto.numeroPosicion;
  }
 }
}