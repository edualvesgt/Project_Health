using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.Health_Clinic.Domains;
using webapi.Health_Clinic.Interfaces;
using webapi.Health_Clinic.Repositories;

namespace webapi.Health_Clinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpGet("{id}")]
        public IActionResult GetById (Guid id)
        {
            try
            {
                return Ok(_usuarioRepository!.SearchById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post (Usuario usuario)
        {
            try
            {
                _usuarioRepository.Create(usuario);
                return Ok();
            }
            catch (Exception e )
            {
                return BadRequest(e.Message);
            }
        }
    }
}
