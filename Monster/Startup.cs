using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Monster.Startup))]
namespace Monster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
