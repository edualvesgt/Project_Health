using webapi.Health_Clinic.Domains;
using webapi.Health_Clinic.Interfaces;

namespace webapi.Health_Clinic.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Create(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario Login(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public Usuario SearchById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
