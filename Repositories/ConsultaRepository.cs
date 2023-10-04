using webapi.Health_Clinic.Context;
using webapi.Health_Clinic.Domains;
using webapi.Health_Clinic.Interfaces;

namespace webapi.Health_Clinic.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HealthContext _context;

        public ConsultaRepository()
        {
            _context = new HealthContext();
        }
        public void Create(Consulta consulta)
        {
            consulta.Id = Guid.NewGuid();
            _context.Add(consulta);

            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Consulta del = _context.Consulta.Find(id)!;
            _context.Remove(del);
            _context.SaveChanges();
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
