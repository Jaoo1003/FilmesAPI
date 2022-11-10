using AutoMapper;
using FilmesAPI.Data.Dtos.Cinemas;
using FilmesAPI.Data.Dtos.Enderecos;
using FilmesAPI.Models;
using System.Runtime.CompilerServices;

namespace FilmesAPI.Profiles {
    public class CinemaProfile : Profile{
        public CinemaProfile() {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>()
                .ForMember(cinema => cinema.Sessoes, opt => opt
                .MapFrom(cinema => cinema.Sessoes.Select(s => new { s.Filme.Id, s.Filme.Titulo, s.Filme.Diretor, s.Filme.Genero, s.Filme.Duracao, s.Filme.ClassificacaoEtaria })));
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
