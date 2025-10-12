using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewAfrica.Startup))]
namespace NewAfrica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
