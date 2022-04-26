using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aplikasi_NOA.Startup))]
namespace Aplikasi_NOA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
