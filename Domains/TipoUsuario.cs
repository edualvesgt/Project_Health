using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Health_Clinic.Domains
{
    [Table(nameof(TipoUsuario))]
    public class TipoUsuario
    {
        [Key]
        public Guid Id { get; set; } 

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage ="Tipo do Usuario Obrigatorio")]
        public string? Tipo { get; set; }

    }
}
