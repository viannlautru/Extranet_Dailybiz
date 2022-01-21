using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Extranet_Dailybiz.Startup))]
namespace Extranet_Dailybiz
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
