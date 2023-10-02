using webapi.Health_Clinic.Context;
using webapi.Health_Clinic.Domains;
using webapi.Health_Clinic.Interfaces;
using webapi.Health_Clinic.Utils;

namespace webapi.Health_Clinic.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly HealthContext _context;

        public UsuarioRepository()
        {
            _context = new HealthContext();
        }
        public void Create(Usuario usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHashCode(usuario.Senha!);

                _context.Add(usuario);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario Login(string email, string senha)
        {
            try
            {
                Usuario user = _context.Usuario
                    .Select(x => new Usuario
                    {
                        Id = x.Id,
                        Nome = x.Nome,
                        Email = x.Email,
                        Senha = x.Senha,
                        TipoUsuario = new TipoUsuario
                        {
                            Tipo = x.TipoUsuario!.Tipo
                        }
                    })
                    .FirstOrDefault(y => y.Email == email)!;

                if (user != null)
                {
                    bool confere = Criptografia.CompararHashCode(senha, user.Senha!);

                    if (confere)
                    {
                        return user;
                    }
                }
                return null!;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario SearchById(Guid id)
        {
            try
            {
                Usuario user = _context.Usuario
                    .Select(x => new Usuario
                    {
                        Id = x.Id,
                        Nome = x.Nome,
                        Email = x.Email,
                        TipoUsuario = new TipoUsuario
                        {
                            Id = x.Id,
                            Tipo = x.TipoUsuario!.Tipo
                        }
                    })
                    .FirstOrDefault(y => y.Id == id)!;

                if (user != null)
                {
                    return user;
                }
                return null!;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
