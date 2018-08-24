using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sake.backend.Startup))]
namespace Sake.backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
