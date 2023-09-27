using Microsoft.EntityFrameworkCore;
using webapi.Health_Clinic.Domains;

namespace webapi.Health_Clinic.Context
{
    public class HealthContext : DbContext
    {
        public DbSet<Clinica> Clinica { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        //Define as Opcoes de construcao do banco (string de conexao )

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = NOTE15-S15; Database = Health_Bd; User Id = sa ; pwd = Senai@134; TrustServerCertificate = True");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
