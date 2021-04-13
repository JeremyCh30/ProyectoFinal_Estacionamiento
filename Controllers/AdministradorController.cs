using System.Collections.Generic;
using ElParqueito.Models;
using ElParqueito.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ElParqueito.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AdministradoresController : ControllerBase
    {
        private AdministradorRepositories AdministradoresRepository;
        
        public AdministradoresController()
        {
            AdministradoresRepository = new AdministradorRepositories();
        }

        [HttpGet]
        public List<Administrador> GetAdministradores(){
            var administradores = AdministradoresRepository.ObtenerAdministradores();
            return administradores;
        }

        [HttpGet] 
        [Route("{id}")]
        public Administrador GetAdministrador([FromRoute ]int id)
        {
            var administrador =AdministradoresRepository.ObtenerAdministrador(id);
            return administrador;
        }

        [HttpPost]
        public string AgregarAdministrador ([FromBody] Administrador nuevoAdministrador)
        {
            var resultado = AdministradoresRepository.AgregarAdministrador(nuevoAdministrador);
            return "Administrador agregado con ID: " +resultado;
        }

        [HttpPut]
        public Administrador ActualizarAdministrador([FromBody] Administrador nuevoAdministrador)
        {
            var administrador =AdministradoresRepository.ActualizarAdministrador(nuevoAdministrador);
            return administrador;
        }

        [HttpDelete]
        public string DeleteAdministrador ([FromQuery] int id)
        {
            var administrador = AdministradoresRepository.DeleteAdministrador(id);
            return "Se eliminó el administrador con nombre de usuario: " + administrador.Usuario;
        }
        

        

    }


}