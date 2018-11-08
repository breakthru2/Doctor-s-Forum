using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Doctor_Forum.Startup))]
namespace Doctor_Forum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
