using CascaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CascaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogadorController : ControllerBase
    {
        private static List<Jogador> jogadores = new List<Jogador>();

        [HttpGet]
        [Route("Listar Jogadores")]
        public IActionResult ListarJogadores()
        {
            return Ok(jogadores);
        }

        [HttpPost]
        public IActionResult CadastrarJogador(Jogador jogador)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }

            var voto = jogadores.FirstOrDefault(j => j.Nome == jogador.Nome);
            
            if ( jogador is null)
            {
                jogadores.Add(jogador);
                return Ok("Cadastrado com sucesso");
            }
            return BadRequest("Jogador já cadastrado");
        }

        [HttpGet]
        [Route("ConsultarJogador")]
        public IActionResult ConsultarPorNome(string nome)
        {
            var resultado = jogadores.FirstOrDefault(j => j.Nome == nome);
            if (resultado == null);
            {
                return NotFound("Jogador não encontrado");
            }
            return Ok(resultado);
        }

    }
}
