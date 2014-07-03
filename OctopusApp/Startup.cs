using Microsoft.Owin;
using OctopusApp;
using Owin;

[assembly: OwinStartup(typeof (Startup))]

namespace OctopusApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}