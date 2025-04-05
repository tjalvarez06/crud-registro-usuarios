using RegistroUsuarios.Models;

namespace RegistroUsuarios.Interfaces
{
    public interface IUsuarios
    {
        string CreateUsuario(Usuario model);
        string UpdateUsuario(Usuario model);
        string DeleteUsuario(int id);
        List<Usuario> GetUsuarios();
        Usuario GetUsuariosById(int id);
        string Login(string correo, string password);

    }
}
