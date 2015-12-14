using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WheelsPrime.Startup))]
namespace WheelsPrime
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
