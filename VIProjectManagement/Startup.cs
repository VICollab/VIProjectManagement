using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VIProjectManagement.Startup))]
namespace VIProjectManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
