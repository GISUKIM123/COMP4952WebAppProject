using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TechproMiniMart.Startup))]
namespace TechproMiniMart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
