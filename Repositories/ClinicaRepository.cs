using webapi.Health_Clinic.Context;
using webapi.Health_Clinic.Domains;
using webapi.Health_Clinic.Interfaces;

namespace webapi.Health_Clinic.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly HealthContext _healthContext;

        public ClinicaRepository()
        {
            _healthContext = new HealthContext();
        }

        public void Create(Clinica clinica)
        {
            try
            {
                clinica.Id = Guid.NewGuid();
                _healthContext.Add(clinica);

                _healthContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

       

        public void Delete(Guid id)
        {
            Clinica del = _healthContext.Clinica.Find(id)!;

            _healthContext.Remove(del);

            _healthContext.SaveChanges();
        }

        public List<Clinica> List()
        {
            List<Clinica> list = _healthContext.Clinica.ToList();
            return list;
        }

        public Clinica SearchById(Guid id)
        {
            try
            {
                Clinica search = _healthContext.Clinica
               .Select(x => new Clinica
               {
                   Id = x.Id,
                   Nome = x.Nome,
                   Endereco = x.Endereco,
                   Abertura = x.Abertura,
                   Fechamento = x.Fechamento,
                   CNPJ = x.CNPJ,
                   RazaoSocial = x.RazaoSocial,

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

        public void Update(Guid id, Clinica clinica)
        {
            Clinica bus = _healthContext.Clinica.FirstOrDefault(x => x.Id == id)!;

            if (bus != null)
            {
                bus.Nome = clinica.Nome;
                bus.Endereco = clinica.Endereco;
                bus.Abertura = clinica.Abertura;
                bus.Fechamento = clinica.Fechamento;
                bus.CNPJ = clinica.CNPJ;
                bus.RazaoSocial = clinica.RazaoSocial;

                _healthContext.Update(bus);
                _healthContext.SaveChanges();
            }
        }
    }
}
