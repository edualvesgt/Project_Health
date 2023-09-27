using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Health_Clinic.Domains
{
    [Table(nameof(Consulta))]
    public class Consulta
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Data Obrigatoria")]
        public DateTime Data { get; set; }

        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "Horario Obrigatorio")]
        public TimeSpan Hora { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Prontuario Obrigatorio")]
        public string? Prontuario { get; set; }

        //Ref.Medico

        public Guid IdMedico { get; set; }

        [ForeignKey(nameof(IdMedico))]

        public Medico? Medico { get; set; }

        //Ref.Paciente

        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? Paciente { get; set; }

        //Ref.Comentario

        public Guid IdComentario { get; set; }

        [ForeignKey(nameof(IdComentario))]
        public Comentario? Comentario { get; set; }
    }

}
