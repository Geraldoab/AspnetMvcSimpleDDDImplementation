using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RevisaoApp.Startup))]
namespace RevisaoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
