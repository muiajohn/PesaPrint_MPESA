using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PesaPrint.MPESA.Startup))]
namespace PesaPrint.MPESA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
