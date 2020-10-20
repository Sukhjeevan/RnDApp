using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RnDApp.Startup))]
namespace RnDApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //This is Branch1 branch
            ConfigureAuth(app);
            //Test update remote
            //Branch
            //Adding comments only
        }
    }
}
