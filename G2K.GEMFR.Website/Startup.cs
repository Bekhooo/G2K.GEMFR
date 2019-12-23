using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(G2K.GEMFR.Website.Startup))]
namespace G2K.GEMFR.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
