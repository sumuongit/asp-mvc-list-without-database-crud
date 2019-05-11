using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_CRUD_LIST.Startup))]
namespace MVC_CRUD_LIST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
