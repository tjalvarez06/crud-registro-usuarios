using System.ComponentModel.DataAnnotations;

namespace RegistroUsuarios.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public bool Estatus { get; set; }
    }
}
