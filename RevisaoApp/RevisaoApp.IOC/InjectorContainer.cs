using RevisaoApp.Domain.Interfaces.Repositories;
using RevisaoApp.Domain.Interfaces.Services;
using RevisaoApp.Domain.Services;
using RevisaoApp.Repository.Repositories;
using SimpleInjector;
using SimpleInjector.Integration.Web;

namespace RevisaoApp.IOC
{
    public static class InjectorContainer
    {
        public static Container Register()
        {
            var container = new Container();

            container.Options.DefaultLifestyle = Lifestyle.Scoped;

            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));

            container.Register(typeof(IUsuarioService), typeof(UsuarioService));

            container.Register(typeof(IUsuarioRepository), typeof(UsuarioRepository));

            return container;
        }
    }
}