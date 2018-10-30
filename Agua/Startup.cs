using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Agua.Startup))]
namespace Agua
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
