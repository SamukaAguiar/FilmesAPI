using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] Filme filme)
        {
            filme.Id = id++;  
            filmes.Add(filme);
            return CreatedAtAction(nameof(RecurperarFilmePorId), new { Id = filme.Id}, filme);

        }

        [HttpGet]
        public IActionResult RecurperarFilmes()
        {
            return Ok(filmes);
        }

        [HttpGet("{id}")]
        public IActionResult RecurperarFilmePorId(int id) 
        {
            Filme filme = filmes.First(filme => filme.Id == id);
            if (filme != null)
                return Ok(filme);
            else
                return NotFound();
        }
    }

    
}
