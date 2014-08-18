using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestManager.Startup))]
namespace RestManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
