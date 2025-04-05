using Microsoft.AspNetCore.Mvc;

namespace RegistroUsuarios.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Set(T entity);
        void Update(T entity);
        void Delete(int id);
        IActionResult Login(string correo, string clave);

    }
}
