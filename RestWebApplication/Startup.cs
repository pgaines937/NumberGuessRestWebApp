using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestWebApplication.Startup))]
namespace RestWebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
