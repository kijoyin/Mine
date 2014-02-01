using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mine.Web.Startup))]
namespace Mine.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
