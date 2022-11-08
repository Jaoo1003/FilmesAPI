using AutoMapper;
using FilmesAPI.Data.Dtos.Cinemas;
using FilmesAPI.Data.Dtos.Enderecos;
using FilmesAPI.Models;
using System.Runtime.CompilerServices;

namespace FilmesAPI.Profiles {
    public class CinemaProfile : Profile{
        public CinemaProfile() {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>();
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
