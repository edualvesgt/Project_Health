using webapi.Health_Clinic.Domains;
using webapi.Health_Clinic.Interfaces;

namespace webapi.Health_Clinic.Repositories
{
    public class EspecialidadeRepository : IEspecializadadeRepository
    {
        public void Create(Especialidade especialidade)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<Especialidade> List()
        {
            throw new NotImplementedException();
        }

        public Especialidade SearchById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id, Especialidade especialidade)
        {
            throw new NotImplementedException();
        }
    }
}
