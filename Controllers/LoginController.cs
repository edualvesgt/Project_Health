using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using webapi.Health_Clinic.Domains;
using webapi.Health_Clinic.Interfaces;
using webapi.Health_Clinic.Repositories;
using webapi.Health_Clinic.ViewModels;

namespace webapi.Health_Clinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]

        public IActionResult Login(LoginViewModel login)
        {
            try
            {
                Usuario Login = _usuarioRepository.Login(login.Email!, login.Senha!);

                if (login == null)
                {
                    return StatusCode(401, "Senha ou Email Invalidos");
                }

                //Tokem: 

                //1º Definir as informacoes(Claims) que serao fornecidos no token (PAYLOAD)
                var claims = new[]
                {

                    new Claim(JwtRegisteredClaimNames.Jti,Login.Id.ToString()),
                    new Claim(JwtRegisteredClaimNames.Name,Login.Nome!),
                    new Claim(JwtRegisteredClaimNames.Email,Login.Email!),
                    new Claim(ClaimTypes.Role,Login.TipoUsuario!.Tipo!)


             };

                //2º - Definir a chave de acesso do token
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("projeto-webapi-health-clinic-dev-autenticacao"));


                //3º - Definir as credenciais do token(HEADER)
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                //4º - Gerar token
                var token = new JwtSecurityToken
                    (
                        //Emissor do token
                        issuer: "weapi.Health_Clinic",

                        //Destinatario
                        audience: "weapi.Health_Clinic",

                        //dados definidos nas claims(informacoes)
                        claims: claims,

                        //Tempo de expiracao do token
                        expires: DateTime.Now.AddMinutes(5),

                        //credenciais do token
                        signingCredentials: creds
                    );

                //5º - Retirnar o token criado
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            catch (Exception e )
            {
                return BadRequest(e.Message);
            }
        }
    }
}
