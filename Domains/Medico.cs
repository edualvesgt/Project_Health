using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Health_Clinic.Domains
{
    [Table(nameof(Medico))]
    [Index(nameof(CRM), IsUnique = true)]
    public class Medico
    {
        [Key]
        public Guid Id { get; set; } 


        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "CRM Obrigatorio")]
        public string? CRM { get; set; }

        //Ref. Usuario
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }

        //Ref. Clinica

        public Guid IdClinica { get; set; }

        [ForeignKey(nameof(IdClinica))]
        public Clinica? Clinica { get; set; }

        //Ref. especialista
        public Guid IdEspecialista { get; set; }

        [ForeignKey(nameof(IdEspecialista))]
        public Especialidade? Especialidade { get; set; }


    }

}
