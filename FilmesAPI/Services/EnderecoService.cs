using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos.Enderecos;
using FilmesAPI.Models;
using FluentResults;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FilmesAPI.Services {
    public class EnderecoService {
        private AppDbContext _context;
        private IMapper _mapper;

        public EnderecoService(AppDbContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        public ReadEnderecoDto AdicionaEndereco(CreateEnderecoDto enderecoDto) {
            Endereco endereco = _mapper.Map<Endereco>(enderecoDto);
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
            return _mapper.Map<ReadEnderecoDto>(endereco);
        }

        public List<ReadEnderecoDto> RecuperaEnderecos() {
            List<Endereco> endereco = _context.Enderecos.ToList();
            if (endereco == null) {
                return null;
            }
            return _mapper.Map<List<ReadEnderecoDto>>(endereco);
        }

        public Result AtualizaEndereco(int id, UpdateEnderecoDto enderecoDto) {
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco == null) {
                return Result.Fail("Endereco não encontrado");
            }
            _mapper.Map(enderecoDto, endereco);
            _context.SaveChanges();
            return Result.Ok();
        }

        public ReadEnderecoDto RecuperaEnderecosPorId(int id) {
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco != null) {
                ReadEnderecoDto enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);
                return enderecoDto;
            }
            return null;
        }

        public Result DeletaEndereco(int id) {
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco == null) {
                return Result.Fail("Endereco não encontrado");
            }
            _context.Remove(endereco);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
