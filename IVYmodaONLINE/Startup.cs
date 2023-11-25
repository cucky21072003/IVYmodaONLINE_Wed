using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IVYmodaONLINE.Startup))]
namespace IVYmodaONLINE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
