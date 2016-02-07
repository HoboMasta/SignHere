using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignHere.Startup))]
namespace SignHere
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
