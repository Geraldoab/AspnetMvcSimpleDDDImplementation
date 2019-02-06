using RevisaoApp.Application.Interfaces;
using RevisaoApp.Application.ViewModels;
using RevisaoApp.Domain.Entities;
using RevisaoApp.Domain.Interfaces.Services;
using AutoMapper;
namespace RevisaoApp.Application.Services
{
    public sealed class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService)
        {
            this._usuarioService = usuarioService;
        }

        public UsuarioViewModel Add(UsuarioViewModel usuarioViewModel)
        {
            Usuario novoUsuario = Mapper.Map<UsuarioViewModel, Usuario>(usuarioViewModel);
            _usuarioService.Add(novoUsuario);
            usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(novoUsuario);

            return usuarioViewModel;
        }

        public int Count()
        {
            return _usuarioService.Count();
        }
    }
}
