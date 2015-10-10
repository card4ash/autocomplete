using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(autocomplete.Startup))]
namespace autocomplete
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
