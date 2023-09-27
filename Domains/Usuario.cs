using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Health_Clinic.Domains
{
    [Table(nameof(Usuario))]
    [Index(nameof(Email), IsUnique = true)]

    
    public class Usuario
    {
        [Key]
        public Guid Id { get; set; } 


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome USuario Obrigatorio")]
        public string? Nome { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Email do Usuario Obrigatorio")]
        public string? Email { get; set; }


        [Column(TypeName = "CHAR(60)")]
        [Required(ErrorMessage = "Senha do Usuario Obrigatorio")]
        [StringLength(60, MinimumLength = 3 , ErrorMessage = "Senha deve conter no minimo 3 caracteres")]
        public string? Senha { get; set; }




        [Required(ErrorMessage = "Informe o Tipo do Usuario")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey(nameof(IdTipoUsuario))]
        public TipoUsuario? TipoUsuario { get; set; }

    }
}
