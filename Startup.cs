using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NVC.Startup))]
namespace NVC
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
