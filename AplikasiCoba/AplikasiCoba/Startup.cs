using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AplikasiCoba.Startup))]
namespace AplikasiCoba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
