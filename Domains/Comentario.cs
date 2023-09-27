using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Health_Clinic.Domains
{
    [Table(nameof(Comentario))]
    public class Comentario
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Comentario Obrigatorio")]
        public string? Texto { get; set; }


        //Ref.Paciente

        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? Paciente { get; set; }
    }
}
