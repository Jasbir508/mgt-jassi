using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_Mgt_Jassi.Startup))]
namespace Project_Mgt_Jassi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
