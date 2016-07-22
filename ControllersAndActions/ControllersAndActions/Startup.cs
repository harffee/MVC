using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControllersAndActions.Startup))]
namespace ControllersAndActions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
