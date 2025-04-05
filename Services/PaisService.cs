using RegistroUsuarios.Context;
using RegistroUsuarios.Interfaces;
using RegistroUsuarios.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace RegistroUsuarios.Services
{
    public class PaisService
    {
        IRepository<Pais> repository;

        public PaisService(IRepository<Pais> repository)
        {
            this.repository = repository;
        }
        public void CreatePais(Pais pais)
        {
            repository.Set(pais);
        }

        public void DeletePais(int id)
        {
            repository.Delete(id);
        }

        public List<Pais> GetPaises()
        {
            return repository.GetAll();
        }

        public Pais GetPaisById(int id)
        {
           return repository.GetById(id);
        }

        public void UpdatePais(Pais pais)
        {
            repository.Update(pais);
        }
    }
}
