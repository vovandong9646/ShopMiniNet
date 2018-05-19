using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopMini.Web.Startup))]
namespace ShopMini.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
