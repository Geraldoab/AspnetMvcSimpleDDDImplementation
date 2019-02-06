using Microsoft.Owin;
using Owin;
using RevisaoApp.Application.Core;

[assembly: OwinStartupAttribute(typeof(RevisaoApp.Startup))]
namespace RevisaoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AutoMapperConfiguration.Configure();
            ConfigureAuth(app);
        }
    }
}
