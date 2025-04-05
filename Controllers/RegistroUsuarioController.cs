using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc;
using RegistroUsuarios.Interfaces;
using RegistroUsuarios.Models;

namespace RegistroUsuarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroUsuarioController : ControllerBase
    {
        private readonly IRepository<Usuario> service;

        public RegistroUsuarioController(IRepository<Usuario> service)
        {
            this.service = service;
        }

        [HttpGet("GetUsuario")]
        public IActionResult GetUsuarios()
        {
            return Ok(service.GetAll());
        }
        [HttpGet("GetUsuarioById")]
        public Usuario GetUsuariosById(int id)
        {
            return service.GetById(id);
        }

        [HttpPost("CreateUsuario")]
        public void CreateUsuario(Usuario model)
        {
            service.Set(model);
        }

        [HttpPut("ActualizarUsuario")]
        public void UpdateUsuario(Usuario model)
        {  
            service.Update(model);
        }

        [HttpDelete("EliminarUsuario")]
        public void DeleteUsuario(int id)
        { 
            service.Delete(id);
        }

        [HttpPost("Login")]
        public IActionResult Login(string correo, string clave)
        {
            return service.Login(correo, clave);
        }




    }
}
