using webapi.Health_Clinic.Domains;

namespace webapi.Health_Clinic.Interfaces
{
    public interface IClinicaRepository
    {
        List<Clinica> List();

        Clinica SearchById(Guid id);

        void Create(Clinica clinica);

        void Update(Guid id, Clinica clinica);

        void Delete(Guid id);
        
    }
}
