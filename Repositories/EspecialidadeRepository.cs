using Microsoft.EntityFrameworkCore;
using webapi.Health_Clinic.Context;
using webapi.Health_Clinic.Domains;
using webapi.Health_Clinic.Interfaces;

namespace webapi.Health_Clinic.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private readonly HealthContext _context;

        public EspecialidadeRepository()
        {
            _context = new HealthContext();

        }
        public void Create(Especialidade especialidade)
        {
            try
            {
                especialidade.Id = Guid.NewGuid();
                _context.Add(especialidade);

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(Guid id)
        {
            Especialidade del = _context.Especialidade.Find(id)!;
            _context.Remove(del);
            _context.SaveChanges();

        }

        public List<Especialidade> List()
        {
            List<Especialidade> list = _context.Especialidade.ToList();
            return list;
        }

        public Especialidade SearchById(Guid id)
        {
            Especialidade search = _context.Especialidade
                .Select(x => new Especialidade
                {
                    Id = x.Id,
                    Especializacao = x.Especializacao,
                }).FirstOrDefault(x => x.Id == id)!;

            if (search != null)
            {
                return search;
            }
            return null!;
        }

        public void Update(Guid id, Especialidade especialidade)
        {
            Especialidade bus = _context.Especialidade.FirstOrDefault(x => x.Id == id)!;
            bus.Especializacao = especialidade.Especializacao;

            _context.Update(bus);
            _context.SaveChanges();
        }
    }
}
