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
    public class EspecialidadeController : ControllerBase
    {
        private IEspecialidadeRepository _especialidadeRepository;
        public EspecialidadeController()
        {
            _especialidadeRepository = new EspecialidadeRepository();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_especialidadeRepository.SearchById(id));
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
                List<Especialidade> list = _especialidadeRepository.List();
                return Ok(list);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Especialidade especialidade)
        {
            try
            {
                _especialidadeRepository.Create(especialidade);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Especialidade especialidade)
        {
            try
            {
                _especialidadeRepository.Update(id, especialidade);
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
                _especialidadeRepository.Delete(id);
                return Ok();
            }
            catch (Exception e )
            {
                return BadRequest(e.Message);
            }
        }
    }
}
