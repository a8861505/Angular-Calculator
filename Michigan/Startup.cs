using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Michigan.Startup))]
namespace Michigan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
