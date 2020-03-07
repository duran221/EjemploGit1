using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjemploSubidaGit.Startup))]
namespace EjemploSubidaGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
