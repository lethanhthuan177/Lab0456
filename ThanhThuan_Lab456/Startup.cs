using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThanhThuan_Lab456.Startup))]
namespace ThanhThuan_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
