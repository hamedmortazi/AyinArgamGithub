using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Amoozesh.Startup))]
namespace Amoozesh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
