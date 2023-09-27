using webapi.Health_Clinic.Domains;

namespace webapi.Health_Clinic.Interfaces
{
    public interface IMedicoRepository
    {
        List<Medico> List();

        Medico SearchById(Guid id);

        void Create(Medico medico);

        void Update(Guid id, Medico medico);

        void Delete(Guid Id);
    }
}
