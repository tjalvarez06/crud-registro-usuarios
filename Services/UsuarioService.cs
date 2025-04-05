using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistroUsuarios.Context;
using RegistroUsuarios.Interfaces;
using RegistroUsuarios.Models;

namespace RegistroUsuarios.Services
{
    public class UsuarioService 
    {
        IRepository<Usuario> repository;

        public UsuarioService(IRepository<Usuario> repository)
        {
            this.repository = repository;
        }

        public void CreateUsuario(Usuario usuario)
        {
            repository.Set(usuario);
        }

        public void DeleteUsuario(int id)
        {
            repository.Delete(id);
        }

        public List<Usuario> GetUsuarios()
        {
            return repository.GetAll();
        }

        public Usuario GetUsuariosById(int id)
        {
            return repository.GetById(id);
        }

        public IActionResult Login(string correo, string clave)
        {
            return repository.Login(correo, clave);
        }

        public void UpdateUsuario(Usuario usuario)
        {
            repository.Update(usuario);
        }
    }
}
