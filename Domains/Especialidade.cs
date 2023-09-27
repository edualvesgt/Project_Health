using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Health_Clinic.Domains
{
    [Table(nameof(Especialidade))]
    public class Especialidade
    {
        [Key]
        public Guid Id { get; set; } 


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Especialidade Obrigatoria ")]
        public string? Especializacao { get; set; }
    }
}
