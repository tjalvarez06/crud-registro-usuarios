using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistroUsuarios.Interfaces;
using RegistroUsuarios.Models;

namespace RegistroUsuarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroPaisController : ControllerBase
    {
        private readonly IRepository<Pais> service;

        public RegistroPaisController(IRepository<Pais> service)
        {
            this.service = service;
        }

        [HttpGet("GetPaises")]
        public IActionResult GetPaises()
        {
            return Ok(service.GetAll());
        }

        [HttpGet("GetPaisById")]
        public Pais GetPaisById(int id)
        {
            return service.GetById(id);
        }

        [HttpPost("CreatePais")]
        public void CreatePais(Pais model)
        {
            service.Set(model);
        }

        [HttpPut("ActualizarPais")]
        public void UpdatePais(Pais model)
        {
            service.Update(model);
        }

        [HttpDelete("EliminarPais")]
        public void DeletePais(int id)
        {
            service.Delete(id);
        }


    }
}
