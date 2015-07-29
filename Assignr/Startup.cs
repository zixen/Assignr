using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignr.Startup))]
namespace Assignr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
