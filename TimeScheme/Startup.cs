using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeScheme.Startup))]
namespace TimeScheme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
