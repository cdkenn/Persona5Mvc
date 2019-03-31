using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Persona5Mvc.Startup))]
namespace Persona5Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
