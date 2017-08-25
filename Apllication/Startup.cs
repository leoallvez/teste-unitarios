using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Apllication.Startup))]
namespace Apllication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
