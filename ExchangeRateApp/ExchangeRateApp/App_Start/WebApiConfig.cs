using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ExchangeRateApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
               name: "ExchangeCurrency",
               routeTemplate: "api/{controller}/{action}/{source}/{target}/{amount}"              
           );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new
                {
                    id = RouteParameter.Optional
                }
            );
        }
    }
}
