using Microsoft.AspNetCore.Mvc;

namespace WebApiConstructor.Controllers
{
[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new 
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };
            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"OLÁ {nome}, seja bem vindo!";
            return Ok(new {mensagem});
        }

        [HttpGet("Idade/{idade}")]
        public IActionResult PegandoIdade(int idade)
        {
            var mensagem = $"Sua {idade} é essa!";
            return Ok(new {mensagem});
        }
    }
}