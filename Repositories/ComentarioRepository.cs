using webapi.Health_Clinic.Context;
using webapi.Health_Clinic.Domains;
using webapi.Health_Clinic.Interfaces;

namespace webapi.Health_Clinic.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {

        private readonly HealthContext _context;
        public ComentarioRepository()
        {
            _context = new HealthContext();
        }
        public void Create(Comentario comentario)
        {
            comentario.Id = Guid.NewGuid();
            _context.Add(comentario);

            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Comentario del = _context.Comentario.Find(id)!;
            _context.Remove(del);
            _context.SaveChanges();
        }

        public List<Comentario> List()
        {
            List<Comentario> list = _context.Comentario.ToList();
            return list;
        }

        public Comentario ListByConsulta(Guid id)
        {
            throw new NotImplementedException();
        }

        public Comentario SearchById(Guid id)
        {
            try
            {
                Comentario search = _context.Comentario
             .Select(x => new Comentario
             {
                 Texto = x.Texto,

                 Paciente = new Paciente
                 {
                     CPF = x.Paciente!.CPF,

                     Usuario = new Usuario
                     {
                         Nome = x.Paciente!.Usuario!.Nome
                     }
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
            };
        }

        public void Update(Guid id, Comentario comentario)
        {
            Comentario bus = _context.Comentario.FirstOrDefault(x => x.Id == id)!;

            bus.Texto = comentario.Texto;
            bus.Paciente!.CPF = comentario.Paciente!.CPF;
            bus.Paciente!.Usuario!.Nome = comentario.Paciente!.Usuario!.Nome;

        }
    }
}
