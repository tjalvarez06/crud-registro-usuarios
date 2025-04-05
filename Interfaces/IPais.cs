using RegistroUsuarios.Models;

namespace RegistroUsuarios.Interfaces
{
    public interface IPais
    {
        string CreatePais(Pais model);
        string UpdatePais(Pais model);
        string DeletePais(int id);
        List<Pais> GetPaises();
        Pais GetPaisById(int id);
    }
}
