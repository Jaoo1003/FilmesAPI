using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos.Enderecos;
using FilmesAPI.Data.Dtos.Gerentes;
using FilmesAPI.Models;
using FilmesAPI.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class GerenteController : ControllerBase{

        private GerenteService _gerenteService;

        public GerenteController(GerenteService gerenteService) {
            _gerenteService = gerenteService;
        }

        [HttpPost]
        public IActionResult AdicionaGerente(CreateGerenteDto gerenteDto) {
            ReadGerenteDto readDto = _gerenteService.AdicionaGerente(gerenteDto);
            return CreatedAtAction(nameof(RecuperaGerentesPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public List<ReadGerenteDto> RecuperaGerente() {
            return _gerenteService.RecuperaGerente();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaGerentesPorId(int id) {
            ReadGerenteDto readDto = _gerenteService.RecuperaGerentesPorId(id);
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaGerente(int id) {
            Result resultado = _gerenteService.DeletaGerente(id);
            if(resultado.IsFailed) return NotFound();
            return NoContent();
        }
    }
}
