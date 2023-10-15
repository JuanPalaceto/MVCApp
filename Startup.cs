using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiSitioWeb.Startup))]
namespace MiSitioWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
