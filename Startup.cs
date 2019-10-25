using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HeroMaker.Startup))]
namespace HeroMaker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
