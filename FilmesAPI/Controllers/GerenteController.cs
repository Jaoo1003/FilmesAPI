using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos.Enderecos;
using FilmesAPI.Data.Dtos.Gerentes;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class GerenteController : ControllerBase{

        private AppDbContext _context;
        private IMapper _mapper;

        public GerenteController(AppDbContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaGerente(CreateGerenteDto gerenteDto) {
            Gerente gerente = _mapper.Map<Gerente>(gerenteDto);
            _context.Gerentes.Add(gerente);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaGerentesPorId), new { Id = gerente.Id }, gerente);
        }

        [HttpGet]
        public IEnumerable<Gerente> RecuperaGerente() {
            return _context.Gerentes;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaGerentesPorId(int id) {
            Gerente gerente = _context.Gerentes.FirstOrDefault(gerente => gerente.Id == id);
            if (gerente != null) {
                ReadGerenteDto gerenteDto = _mapper.Map<ReadGerenteDto>(gerente);
                return Ok(gerenteDto);
            }
            return NotFound();
        }
    }
}
