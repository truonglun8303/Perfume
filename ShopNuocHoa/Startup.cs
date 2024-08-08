using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopNuocHoa.Startup))]
namespace ShopNuocHoa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
