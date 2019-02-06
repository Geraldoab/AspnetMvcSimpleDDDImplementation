using RevisaoApp.Domain.Entities;
using RevisaoApp.Domain.Interfaces.Repositories;
using RevisaoApp.Domain.Interfaces.Services;

namespace RevisaoApp.Domain.Services
{
    public sealed class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
            this._usuarioRepository = usuarioRepository;
        }
    }
}