using RevisaoApp.Domain.Entities;
using RevisaoApp.Domain.Interfaces.Repositories;

namespace RevisaoApp.Repository.Repositories
{
    public sealed class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(Context context) : base(context)
        {
        }
    }
}