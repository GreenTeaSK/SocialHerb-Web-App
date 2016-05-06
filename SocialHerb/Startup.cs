using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialHerb.Startup))]
namespace SocialHerb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
