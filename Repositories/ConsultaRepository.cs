using webapi.Health_Clinic.Domains;
using webapi.Health_Clinic.Interfaces;

namespace webapi.Health_Clinic.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        public void Create(Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<Consulta> List()
        {
            throw new NotImplementedException();
        }

        public List<Consulta> ListByMedico(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Consulta> ListByPaciente(Guid id)
        {
            throw new NotImplementedException();
        }

        public Consulta SearchById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id, Consulta consulta)
        {
            throw new NotImplementedException();
        }
    }
}
