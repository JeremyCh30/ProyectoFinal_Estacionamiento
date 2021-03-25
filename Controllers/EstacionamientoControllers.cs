using System.Collections.Generic;
using ElParqueito.Models;
using ElParqueito.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ElParqueito.Controllers
{

[ApiController]

[Route("[controller]")]

 public class EstacionamientosController : ControllerBase 
 {


    private EstacionamientosRepositories EstacionamientoRepository;

    public EstacionamientosController()
    {
      EstacionamientoRepository = new EstacionamientosRepositories();
    }   
     private List<Estacionamiento> Estacionamientos = new List<Estacionamiento>(){

      new Estacionamiento()
    };

     [HttpGet]
     public List<Estacionamiento> GetEstacionamiento(){

     return EstacionamientoRepository.ObtenerEstacionamientos();
   }
 
   [HttpGet] 
   [Route("{id}")]
   
     public Estacionamiento GetEstacionamiento([FromRoute ]int id)
  {
    var estacionamiento =EstacionamientoRepository.ObtenerEstacionamiento(id);
    return estacionamiento;
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
    return "Se eliminó el Lugar de Estacionamento" +"  "+ estacionamiento.numeroPosicion;
  }
 }
}