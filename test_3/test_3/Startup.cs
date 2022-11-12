using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test_3.Startup))]
namespace test_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
