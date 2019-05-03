using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Notes_ToDoList.Startup))]
namespace Notes_ToDoList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
