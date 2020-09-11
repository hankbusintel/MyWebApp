using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyWebApp.WebUI.Startup))]
namespace MyWebApp.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
