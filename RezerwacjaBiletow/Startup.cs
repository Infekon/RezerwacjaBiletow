using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RezerwacjaBiletow.Startup))]
namespace RezerwacjaBiletow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
