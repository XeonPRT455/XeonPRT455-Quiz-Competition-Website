﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Container
    {
        public static IContainer container = null;

      
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
                throw new System.Exception("IOCerror!" + ex.Message);
            }

            return container.Resolve<T>();
        }

      
        public static void Initialise()
        {
            var builder = new ContainerBuilder();
            //builder.RegisterType<xxxx>().As<Ixxxx>().InstancePerLifetimeScope();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            builder.RegisterType<QuestionService>().As<IQuestionService>().InstancePerLifetimeScope();
            builder.RegisterType<QuestionQuizService>().As<IQuestionQuizService>().InstancePerLifetimeScope();
            builder.RegisterType<QuizService>().As<IQuizService>().InstancePerLifetimeScope();
            builder.RegisterType<QuizInfoService>().As<IQuizInfoService>().InstancePerLifetimeScope();
            builder.RegisterType<ScoreInfoService>().As<IScoreInfoService>().InstancePerLifetimeScope();
            builder.RegisterType<OptionsService>().As<IOptionsService>().InstancePerLifetimeScope();

            container = builder.Build();
        }
    }
}

