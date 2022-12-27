using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCWebAppNETFramework48.Startup))]
namespace MVCWebAppNETFramework48
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
