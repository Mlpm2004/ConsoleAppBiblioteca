using Biblioteca.Api.Entidades;
using Microsoft.AspNetCore.Mvc;


namespace Biblioteca.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivrosController : ControllerBase
    {
        private readonly DataContext _context;
        public LivrosController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<List<Livro>> ObterLivros()
        {
            return Ok(_context.Livros.ToList());
        }
    }
}
