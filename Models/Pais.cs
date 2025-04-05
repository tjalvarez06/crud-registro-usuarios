using System.ComponentModel.DataAnnotations;

namespace RegistroUsuarios.Models
{
    public class Pais
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Gentilicio { get; set; }
        public string Capital { get; set; }
        public bool Estatus { get; set; }
    }
}
