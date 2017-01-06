using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebGridExample.Startup))]
namespace WebGridExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
