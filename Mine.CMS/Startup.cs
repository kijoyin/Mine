using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mine.CMS.Startup))]
namespace Mine.CMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
