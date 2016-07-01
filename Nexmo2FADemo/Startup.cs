using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nexmo2FADemo.Startup))]
namespace Nexmo2FADemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
