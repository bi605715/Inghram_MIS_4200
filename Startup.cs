using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Inghram_MIS_4200.Startup))]
namespace Inghram_MIS_4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
