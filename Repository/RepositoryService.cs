using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistroUsuarios.Context;
using RegistroUsuarios.Interfaces;

namespace RegistroUsuarios.Repository
{
    public class RepositoryService<T> : IRepository<T> where T : class
    {   
        //Pasamos el contexto y DbSet<T> a repository
        private readonly RegistrosContext _contexto;
        DbSet<T> _dbSet;
        public RepositoryService(RegistrosContext contexto)
        {
            this._contexto = contexto;
            _dbSet = contexto.Set<T>();
        }
        public void Delete(int id)
        {
            var entidad = GetById(id);
            _dbSet.Remove(entidad);
            _contexto.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);    
        }

        public IActionResult Login(string correo, string clave)
        {
            var usuario = _contexto.Usuario.FirstOrDefault(u => u.Correo == correo);

            if (usuario == null || usuario.Clave != clave)
            {
                return new UnauthorizedResult();
            }

            return new OkObjectResult($"Datos verificados, Bienvenido {usuario.Nombre} INICIANDO SESION!...."); // 200 si es válido
        
        }

        public void Set(T entity)
        {
            _dbSet.Add(entity);
            _contexto.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _contexto.Entry(entity).State = EntityState.Modified;
            _contexto.SaveChanges();
        }
    }
}
