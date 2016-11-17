using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkShopIdentity.Startup))]
namespace WorkShopIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
