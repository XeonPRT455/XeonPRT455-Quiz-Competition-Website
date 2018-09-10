using System.Reflection;
using Autofac;
using Autofac.Integration.WebApi;
using QuizCompetition.AutoFac.Modules;

namespace QuizCompetition.AutoFac
{
    public class ContainerBuilerCommon
    {
        public static IContainer GetWebApiContainer()
        {
            var builder = new ContainerBuilder();　　　　　　　
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
           
            builder.RegisterModule<LoggingModule>();
            // builder.RegisterType<Example>().As<IExample>();

            // builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
            // .Where(t => t.Namespace.Contains("Utilities"))
            // .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}