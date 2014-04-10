using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevChallenge.Startup))]
namespace DevChallenge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
