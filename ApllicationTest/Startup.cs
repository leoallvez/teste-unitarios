using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApllicationTest.Startup))]
namespace ApllicationTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
