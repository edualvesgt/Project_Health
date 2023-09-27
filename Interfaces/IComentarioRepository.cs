using webapi.Health_Clinic.Domains;

namespace webapi.Health_Clinic.Interfaces
{
    public interface IComentarioRepository
    {
        List<Comentario> List();

        Comentario SearchById(Guid id);

        void Create(Comentario comentario);

        void Update(Guid id, Comentario comentario);

        void Delete(Guid Id);
        Comentario ListByConsulta(Guid id);

    }
}
