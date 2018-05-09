using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DependencyApplication.Startup))]
namespace DependencyApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
