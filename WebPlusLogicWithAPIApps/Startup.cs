using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPlusLogicWithAPIApps.Startup))]
namespace WebPlusLogicWithAPIApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
