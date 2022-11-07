using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Data.Dtos.Cinemas;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class FilmeProfile : Profile{

        public FilmeProfile() {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, Filme>();
        }
    }
}
