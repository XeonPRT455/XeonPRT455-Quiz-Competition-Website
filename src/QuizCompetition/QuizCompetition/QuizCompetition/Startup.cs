using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.Owin;
using Owin;
using Autofac;
using Autofac.Integration.WebApi;

[assembly: OwinStartup(typeof(QuizCompetition.Startup))]

namespace QuizCompetition
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            var config = WebApiConfig.OwinWebApiConfiguration(new HttpConfiguration());
            
            var container = ContainerConfig.Configure();
       
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);


            
            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(config);
            app.UseWebApi(config);
        

            // more information:https://go.microsoft.com/fwlink/?LinkID=316888
            
        }
    }
}
