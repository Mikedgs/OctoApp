using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OctopusApp.Startup))]
namespace OctopusApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
