using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using QuizCompetition.Exceptions;

namespace QuizCompetition
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
            


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var jsonFormatter = new JsonMediaTypeFormatter();
            config.Services.Replace(typeof(IContentNegotiator), new JsonContentNegotiator(jsonFormatter));
        }

        public static HttpConfiguration OwinWebApiConfiguration(HttpConfiguration config)
        {
           // var json = config.Formatters.JsonFormatter;
           // json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            //config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Filters.Add(new WebApiExceptionFilterAttribute());
            var jsonFormatter = new JsonMediaTypeFormatter();
            config.Services.Replace(typeof(IContentNegotiator), new JsonContentNegotiator(jsonFormatter));
            return config;
        }
    
}
}
