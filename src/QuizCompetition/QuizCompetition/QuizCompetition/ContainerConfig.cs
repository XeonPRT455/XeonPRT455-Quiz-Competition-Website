using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizCompetition
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // builder.RegisterType<Example>().As<IExample>();

           // builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
            // .Where(t => t.Namespace.Contains("Utilities"))
            // .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }

    }
}