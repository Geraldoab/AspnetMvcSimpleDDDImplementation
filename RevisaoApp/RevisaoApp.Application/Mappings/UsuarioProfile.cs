using AutoMapper;
using RevisaoApp.Application.ViewModels;
using RevisaoApp.Domain.Entities;

namespace RevisaoApp.Application.Mappings
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioViewModel, Usuario>()
                .ForMember(to => to.Codigo, option => option.MapFrom(from => from.CodigoUsuario))
                .ForMember(to => to.Nome, option => option.MapFrom(from => from.NomeUsuario));

            CreateMap<Usuario, UsuarioViewModel>()
                .ForMember(to => to.CodigoUsuario, option => option.MapFrom(from => from.Codigo))
                .ForMember(to => to.NomeUsuario, option => option.MapFrom(from => from.Nome));
        }
    }
}