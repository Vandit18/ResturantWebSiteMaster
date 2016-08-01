using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResturantWebApp.Startup))]
namespace ResturantWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
