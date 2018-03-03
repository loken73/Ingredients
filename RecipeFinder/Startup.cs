using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecipeFinder.Startup))]
namespace RecipeFinder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
