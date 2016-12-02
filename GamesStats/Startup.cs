using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GamesStats.Startup))]
namespace GamesStats
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
