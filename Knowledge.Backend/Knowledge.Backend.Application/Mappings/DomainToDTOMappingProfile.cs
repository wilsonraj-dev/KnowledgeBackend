using AutoMapper;
using Knowledge.Backend.Application.DTOs;
using Knowledge.Backend.Domain.Entidades;

namespace Knowledge.Backend.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<ArticleDTO, ArticleDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
