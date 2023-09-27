using webapi.Health_Clinic.Domains;

namespace webapi.Health_Clinic.Interfaces
{
    public interface IUsuarioRepository
    {
        
        Usuario SearchById(Guid id);

        void Create(Usuario usuario);

        Usuario Login(string email, string senha);



    }
}
