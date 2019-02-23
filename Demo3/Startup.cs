using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo3.Startup))]
namespace Demo3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
