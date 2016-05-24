using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PalestraCEFET.Startup))]
namespace PalestraCEFET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
