using RevisaoApp.Application.ViewModels;
using RevisaoApp.Domain.Entities;

namespace RevisaoApp.Application.Interfaces
{
    public interface IUsuarioAppService
    {
        UsuarioViewModel Add(UsuarioViewModel usuarioViewModel);
        int Count();
    }
}
