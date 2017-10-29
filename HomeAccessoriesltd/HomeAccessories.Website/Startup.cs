using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeAccessories.Website.Startup))]
namespace HomeAccessories.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
