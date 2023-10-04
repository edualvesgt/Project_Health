using webapi.Health_Clinic.Domains;

namespace webapi.Health_Clinic.Interfaces
{
    public interface IPacienteRepository
    {
        List<Paciente> List();

        Paciente SearchById(Guid id);

        void Create(Paciente paciente);

        void Update(Guid id, Paciente paciente);

        void Delete(Guid id);
    }
}
