using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuctioneerDemo.Startup))]
namespace AuctioneerDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
