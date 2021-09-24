using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Folluk.Startup))]
namespace Folluk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
