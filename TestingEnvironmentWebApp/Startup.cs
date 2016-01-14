using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingEnvironmentWebApp.Startup))]
namespace TestingEnvironmentWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
