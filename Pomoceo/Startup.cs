using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pomoceo.Startup))]
namespace Pomoceo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
