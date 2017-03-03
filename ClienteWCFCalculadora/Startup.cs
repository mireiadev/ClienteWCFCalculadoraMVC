using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClienteWCFCalculadora.Startup))]
namespace ClienteWCFCalculadora
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
