using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSocialHerb.Startup))]
namespace WebSocialHerb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
