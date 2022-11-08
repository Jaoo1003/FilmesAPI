using AutoMapper;
using FilmesAPI.Data.Dtos.Gerentes;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles {
    public class GerenteProfile : Profile{

        public GerenteProfile() {
            CreateMap<CreateGerenteDto, Gerente>();
            CreateMap<Gerente, ReadGerenteDto>()
                .ForMember(gerente => gerente.Cinemas, opt => opt
                .MapFrom(gerente => gerente.Cinemas.Select(c => new { c.Id, c.Nome, c.Endereco, c.EnderecoId })));
        }
    }
}
