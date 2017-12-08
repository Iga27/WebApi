using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;
using WebApi.Models;

namespace WebApi
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

            //new code
            System.Web.Http.OData.Builder.ODataConventionModelBuilder builder = new System.Web.Http.OData.Builder.ODataConventionModelBuilder();
            builder.EntitySet<Person>("People");
            config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
        }
    }
}
