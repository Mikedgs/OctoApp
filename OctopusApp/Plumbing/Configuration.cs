using System.Configuration;

namespace OctopusApp.Plumbing
{
    public class Configuration : IConfiguration
    {
        public string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString; }
        }
    }
}