using webapi.Health_Clinic.Domains;

namespace webapi.Health_Clinic.Interfaces
{
    public interface IConsultaRepository
    {
        List<Consulta> List();

        Consulta SearchById(Guid id);

        void Create(Consulta consulta);

        void Update(Guid id, Consulta consulta);

        void Delete(Guid Id);

        List<Consulta> ListByMedico(Guid id );

        List<Consulta> ListByPaciente(Guid id);
    }
}
