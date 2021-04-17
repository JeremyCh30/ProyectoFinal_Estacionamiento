using System.Collections.Generic;
using ElParqueito.Models;
using ElParqueito.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ElParqueito.Controllers
{

[ApiController]

[Route("[controller]")]

 public class FacturasController : ControllerBase 
 {


    private FacturasRepositories FacturasRepository;

    public FacturasController()
    {
      FacturasRepository = new FacturasRepositories();
    }   
     private List<Factura> Facturas = new List<Factura>(){

      new Factura()
    };

     [HttpGet]
     public List<Factura> GetFacturas(){

     return FacturasRepository.ObtenerFacturas();
   }
 
   [HttpGet] 
   [Route("{id}")]
   
     public Factura GetFactura([FromRoute ]int id)
  {
    var estacionamiento =FacturasRepository.ObtenerFactura(id);
    return estacionamiento;
  }

 [HttpPost]
  public string AgregarFactura ([FromBody] Factura nuevaFactura)
  {
    var resultado = FacturasRepository.AgregarFactura(nuevaFactura);
    return "Factura agregado con:" + " "+ resultado ;
  }

 }
}