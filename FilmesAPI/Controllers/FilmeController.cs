using FilmesAPI.Data;
using System.Globalization;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using AutoMapper;
using FilmesAPI.Data.Dtos.Cinemas;
using FilmesAPI.Services;
using Microsoft.EntityFrameworkCore.Metadata;
using FluentResults;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase{

        private FilmeService _filmeService;

        public FilmeController(FilmeService filmeService) {
           _filmeService = filmeService;
        }

        [HttpPost]

        public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto) {
            ReadFilmeDto readDto = _filmeService.AdicionaFilme(filmeDto);            
            return CreatedAtAction(nameof(RecuperaFilmesPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperaFilmes([FromQuery] int? classificacaoEtaria = null) {
            List<ReadFilmeDto> readDto = _filmeService.RecuperaFilmes(classificacaoEtaria);
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFilmesPorId(int id) {
            ReadFilmeDto readDto = _filmeService.RecuperaFilmesPorId(id);
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto) {
            Result resultado = _filmeService.AtualizaFilme(id, filmeDto);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaFilme(int id) {
            Result resultado = _filmeService.DeletaFilme(id);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }
    }
}
