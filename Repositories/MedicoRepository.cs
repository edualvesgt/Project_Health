using System.ComponentModel;
using webapi.Health_Clinic.Context;
using webapi.Health_Clinic.Domains;
using webapi.Health_Clinic.Interfaces;

namespace webapi.Health_Clinic.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly HealthContext _context;

        public MedicoRepository()
        {
            _context = new HealthContext();
        }
        public void Create(Medico medico)
        {
            medico.Id = Guid.NewGuid();
            _context.Add(medico);

            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Medico find = _context.Medico.Find(id)!;
            _context.Medico.Remove(find);
            _context.SaveChanges();
        }

        public List<Medico> List()
        {
            List<Medico> list = _context.Medico.ToList();
            return list;
        }

        public Medico SearchById(Guid id)
        {
            try
            {
                Medico search = _context.Medico
               .Select(x => new Medico
               {
                   Id = x.Id,
                   CRM = x.CRM,

                   Usuario = new Usuario
                   {
                       Nome = x.Usuario!.Nome

                   },

                   Clinica = new Clinica
                   {
                       Nome = x.Clinica!.Nome,
                       Endereco = x.Clinica!.Endereco
                   },

                   Especialidade = new Especialidade
                   {
                       Especializacao = x.Especialidade!.Especializacao
                   }



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

        public void Update(Guid id, Medico medico)
        {
            Medico bus = _context.Medico.FirstOrDefault(x => x.Id == id)!;

            bus.CRM = medico.CRM;
            bus.Usuario!.Nome = medico.Usuario!.Nome;
            bus.Clinica!.Nome = medico.Clinica!.Nome;
            bus.Clinica!.Endereco = medico.Clinica!.Endereco;
            bus.Especialidade!.Especializacao = medico.Especialidade!.Especializacao;


            _context.Update(bus);
            _context.SaveChanges();
        }
    }
}
