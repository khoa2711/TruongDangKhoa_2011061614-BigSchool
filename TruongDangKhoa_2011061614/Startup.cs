using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TruongDangKhoa_2011061614.Startup))]
namespace TruongDangKhoa_2011061614
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
