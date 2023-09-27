using webapi.Health_Clinic.Domains;

namespace webapi.Health_Clinic.Interfaces
{
    public interface ITipoUsuarioRepository
    {
        List<TipoUsuario> list();

        TipoUsuario SearchById (Guid id);

        void Create(TipoUsuario tipo);

        void Update(TipoUsuario tipo, Guid id);

        void Delete(Guid id);


    }
}
