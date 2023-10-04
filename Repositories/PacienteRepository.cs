using webapi.Health_Clinic.Context;
using webapi.Health_Clinic.Domains;
using webapi.Health_Clinic.Interfaces;

namespace webapi.Health_Clinic.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly HealthContext _context;

        public PacienteRepository()
        {
            _context = new HealthContext();
        }
        public void Create(Paciente paciente)
        {
            paciente.Id= Guid.NewGuid();
            _context.Add(paciente); 

            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Paciente del = _context.Paciente.Find(id)!;
            _context.Remove(del);
            _context.SaveChanges();

        }

        public List<Paciente> List()
        {
            List<Paciente> list = _context.Paciente.ToList();
            return list;

        }

        public Paciente SearchById(Guid id)
        {
            try
            {
                Paciente search = _context.Paciente
             .Select(x => new Paciente
             {
                 Id = x.Id,
                 RG = x.RG,
                 CPF = x.CPF,
                 DataNascimento = x.DataNascimento,
                 Telefone = x.Telefone,
                 Endereco = x.Endereco,

             }).FirstOrDefault(x => x.Id == id)!;

                if (search != null)
                {
                    return search;
                }
                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Guid id, Paciente paciente)
        {
            Paciente bus = _context.Paciente.FirstOrDefault(x => x.Id == id)!;

            bus.RG = paciente.RG;
            bus.CPF = paciente.CPF;
            bus.DataNascimento = paciente.DataNascimento;
            bus.Telefone = paciente.Telefone;
            bus.Endereco = paciente.Endereco;

            _context.Update(bus);
            _context.SaveChanges();
        }
    }
}
