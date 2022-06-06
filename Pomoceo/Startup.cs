using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using Pomoceo.Models;

[assembly: OwinStartupAttribute(typeof(Pomoceo.Startup))]
namespace Pomoceo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //CreateUserAndRoles();
        }

       
    }
}
