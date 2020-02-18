using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Student_Attendence_Management.Startup))]
namespace Student_Attendence_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
