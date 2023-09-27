using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Health_Clinic.Domains
{
    [Table(nameof(Clinica))]
    [Index(nameof(CNPJ), IsUnique = true)]
    public class Clinica
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required (ErrorMessage = "Nome da Clinica Obrigatorio")]
        public string? Nome { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Endereco da Clinica Obrigatorio")]
        public string? Endereco { get; set; }



        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Horario de Abertura da Clinica Obrigatorio")]
        public DateTime Abertura { get; set; }



        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Horario de fechamento da Clinica Obrigatorio")]
        public DateTime Fechamento { get; set; }


        [Column(TypeName = "CHAR(14)")]
        [Required(ErrorMessage = "CNPJ da Clinica Obrigatorio")]
        public string? CNPJ { get; set; }



        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Razao Social da Clinica Obrigatorio")]
        public string? RazaoSocial { get; set; }




    }
}
