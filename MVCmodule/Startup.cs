using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCmodule.Startup))]
namespace MVCmodule
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
