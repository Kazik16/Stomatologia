using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stomatologia.Startup))]
namespace Stomatologia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
