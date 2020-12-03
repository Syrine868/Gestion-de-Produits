using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GP.Web.Startup))]
namespace GP.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
