using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Data_Pro_Test.Startup))]
namespace Data_Pro_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
