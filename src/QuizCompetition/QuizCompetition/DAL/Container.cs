using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Container
    {
        public static IContainer container = null;

        /// <summary>
       
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Resolve<T>()
        {
            try
            {
                if (container == null)
                {
                    Initialise();
                }
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("IOC error!" + ex.Message);
            }

            return container.Resolve<T>();
        }

        
        public static void Initialise()
        {
            var builder = new ContainerBuilder();
            //builder.RegisterType<xxxx>().As<Ixxxx>().InstancePerLifetimeScope();
            builder.RegisterType<UserDAL>().As<IUserDAL>().InstancePerLifetimeScope();
            container = builder.Build();
        }
    }
}

