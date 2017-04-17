using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HumanResourcesDepartment.Startup))]
namespace HumanResourcesDepartment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
