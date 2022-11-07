using AutoMapper;
using FilmesAPI.Data.Dtos.Enderecos;
using FilmesAPI.Models;
using System.Runtime.CompilerServices;

namespace FilmesAPI.Profiles {
    public class EnderecoProfile : Profile{

        public EnderecoProfile() {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}
