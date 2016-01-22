using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcSitemap3.Startup))]
namespace MvcSitemap3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
