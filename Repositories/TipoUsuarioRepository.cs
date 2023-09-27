using webapi.Health_Clinic.Context;
using webapi.Health_Clinic.Domains;
using webapi.Health_Clinic.Interfaces;

namespace webapi.Health_Clinic.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private readonly HealthContext _context;

        public TipoUsuarioRepository()
        {
            _context = new HealthContext();
        }
        public void Create(TipoUsuario tipo)
        {
            try
            {
                tipo.Id = Guid.NewGuid();
                _context.TipoUsuario.Add(tipo);

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(Guid id)
        {
            TipoUsuario del = _context.TipoUsuario.Find(id)!;

            _context.TipoUsuario.Remove(del);

            _context.SaveChanges();
        }

        public List<TipoUsuario> list()
        {
            List<TipoUsuario> list = _context.TipoUsuario.ToList();
            return list;
        }

        public TipoUsuario SearchById(Guid id)
        {
            try
            {
                TipoUsuario search = _context.TipoUsuario
                    .Select(x => new TipoUsuario
                    {
                        Id = x.Id,
                        Tipo = x.Tipo
                    })
                    .FirstOrDefault(x => x.Id == id)!;

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

        public void Update(TipoUsuario tipo, Guid id)
        {
            TipoUsuario bus = _context.TipoUsuario.FirstOrDefault(x => x.Id == id)!;

            bus.Tipo = tipo.Tipo;

            _context.Update(bus);
            _context.SaveChanges();

        }
    }
}
