using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamADVTManagementSystemUI.Startup))]
namespace TeamADVTManagementSystemUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
