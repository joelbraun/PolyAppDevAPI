using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(polyappService.Startup))]

namespace polyappService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}