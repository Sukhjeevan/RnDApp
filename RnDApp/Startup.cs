using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RnDApp.Startup))]
namespace RnDApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //Test update remote
        }
    }
}
