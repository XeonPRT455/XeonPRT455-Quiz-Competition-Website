using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuizCompetition.Startup))]
namespace QuizCompetition
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
