using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>().ForMember(sessaoDto => sessaoDto.Filme, option => option.MapFrom(sessao => sessao.FilmeId));
            CreateMap<Sessao, ReadSessaoDto>();
        }
    }
}
