using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuyetTien1.Startup))]
namespace QuyetTien1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
