using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos.Cinemas;
using FilmesAPI.Data.Dtos.Enderecos;
using FilmesAPI.Models;
using FilmesAPI.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase {

        private EnderecoService _enderecoService;

        public EnderecoController(EnderecoService enderecoService) {
            _enderecoService = enderecoService;            
        }

        [HttpPost]
        public IActionResult AdicionaEndereco([FromBody] CreateEnderecoDto enderecoDto) {
            ReadEnderecoDto readDto = _enderecoService.AdicionaEndereco(enderecoDto);
            return CreatedAtAction(nameof(RecuperaEnderecosPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public List<ReadEnderecoDto> RecuperaEnderecos() {
            return _enderecoService.RecuperaEnderecos();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaEnderecosPorId(int id) {
            ReadEnderecoDto readDto = _enderecoService.RecuperaEnderecosPorId(id);
            if (readDto != null) return Ok(readDto);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaEndereco(int id, [FromBody] UpdateEnderecoDto enderecoDto) {
            Result resultado = _enderecoService.AtualizaEndereco(id, enderecoDto);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaEndereco(int id) {
            Result resultado = _enderecoService.DeletaEndereco(id);
            if(resultado.IsFailed) return NotFound();
            return NoContent();
        }
    }
}
