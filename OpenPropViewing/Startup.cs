using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenPropViewing.Startup))]
namespace OpenPropViewing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
