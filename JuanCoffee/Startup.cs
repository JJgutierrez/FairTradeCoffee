using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JuanCoffee.Startup))]
namespace JuanCoffee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
