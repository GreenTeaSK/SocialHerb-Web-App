using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppHerb.Startup))]
namespace WebAppHerb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
