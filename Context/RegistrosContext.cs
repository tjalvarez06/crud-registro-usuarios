using Microsoft.EntityFrameworkCore;
using RegistroUsuarios.Models;

namespace RegistroUsuarios.Context
{
    public class RegistrosContext : DbContext
    {
        public RegistrosContext(DbContextOptions<RegistrosContext> db) : base(db) { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Pais> Pais { get; set; }
        
    }
}
