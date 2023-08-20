using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FIT5032MyModelFirst.Startup))]
namespace FIT5032MyModelFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
