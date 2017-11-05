using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Forks1.Startup))]
namespace Forks1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
