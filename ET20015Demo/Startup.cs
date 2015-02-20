using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ET20015Demo.Startup))]
namespace ET20015Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
