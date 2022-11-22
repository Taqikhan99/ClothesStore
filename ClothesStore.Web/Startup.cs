using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClothesStore.Web.Startup))]
namespace ClothesStore.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
