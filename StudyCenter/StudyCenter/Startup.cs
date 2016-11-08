using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudyCenter.Startup))]
namespace StudyCenter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
