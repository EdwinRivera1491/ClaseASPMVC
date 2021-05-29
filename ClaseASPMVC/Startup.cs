using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClaseASPMVC.Startup))]
namespace ClaseASPMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
