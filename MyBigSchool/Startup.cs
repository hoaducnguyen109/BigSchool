using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyBigSchool.Startup))]
namespace MyBigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
