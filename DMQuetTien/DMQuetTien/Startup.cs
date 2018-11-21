using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DMQuetTien.Startup))]
namespace DMQuetTien
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
