using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhClub.Startup))]
namespace PhClub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
