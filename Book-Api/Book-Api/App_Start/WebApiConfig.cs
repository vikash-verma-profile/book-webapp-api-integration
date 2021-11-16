using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Book_Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //removed xml formatter
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            //Added json formator
            config.Formatters.Add(config.Formatters.JsonFormatter);
        }
    }
}
