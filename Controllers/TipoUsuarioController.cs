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
    public class TipoUsuarioController : ControllerBase
    {
        private ITipoUsuarioRepository _tipoUsuarioRepository;

        public TipoUsuarioController()
        {
            _tipoUsuarioRepository = new TipoUsuarioRepository();
        }


        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_tipoUsuarioRepository.SearchById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult Getall()
        {
            try
            {
                List<TipoUsuario> list = _tipoUsuarioRepository.list();
                return Ok(list);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(TipoUsuario tipo)
        {
            try
            {
                _tipoUsuarioRepository.Create(tipo);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(TipoUsuario tipo, Guid id)
        {
            try
            {
                _tipoUsuarioRepository.Update(tipo, id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _tipoUsuarioRepository.Delete(id);
                return Ok();
            }
            catch (Exception e )
            {
                return BadRequest(e.Message);
            }
        }
    }
}
