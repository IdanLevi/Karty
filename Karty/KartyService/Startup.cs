using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(KartyService.Startup))]

namespace KartyService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}