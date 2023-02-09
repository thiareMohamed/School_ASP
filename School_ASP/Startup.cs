using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(School_ASP.Startup))]
namespace School_ASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
