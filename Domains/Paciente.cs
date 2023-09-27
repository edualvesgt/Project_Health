using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Health_Clinic.Domains
{
    [Table(nameof(Paciente))]
    [Index(nameof(RG), IsUnique = true)]
    [Index(nameof(CPF), IsUnique = true)]
    public class Paciente
    {
        [Key]
        public Guid Id { get; set; } 

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "RG Obrigatorio")]
        public string? RG { get; set; }

        [Column(TypeName = "CHAR(14)")]
        [Required(ErrorMessage = "CPF Obrigatorio")]
        public string? CPF { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Data de Nascimento Obrigatorio")]
        public DateTime DataNascimento { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Email do usuario Obrigatorio")]
        public int Telefone { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Email do usuario Obrigatorio")]
        public string? Endereco { get; set; }

        //Ref. Usuario
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }
    }
}
